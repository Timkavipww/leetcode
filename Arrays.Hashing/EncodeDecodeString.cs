using System.Text;

namespace tests;

public static partial class Solution {

    public static string Encode(IList<string> strs) {
        if (strs == null || strs.Count == 0) return "";
        
        // Первый проход: вычисляем общий размер итогового массива байтов
        // и сохраняем байтовые представления каждой строки для повторного использования.
        int totalBytes = 0;
        byte[][] encodedStrings = new byte[strs.Count][];
        for (int i = 0; i < strs.Count; i++) {
            byte[] sBytes = Encoding.UTF8.GetBytes(strs[i]);
            encodedStrings[i] = sBytes;
            totalBytes += 8;              // 8 байт для хранения длины
            totalBytes += sBytes.Length;  // байты самой строки
        }
        
        // Выделяем массив нужного размера
        byte[] resultBytes = new byte[totalBytes];
        int pos = 0;
        
        // Второй проход: заполняем массив байтов данными
        for (int i = 0; i < strs.Count; i++) {
            byte[] sBytes = encodedStrings[i];
            // Преобразуем длину строки в 8-байтовый массив
            byte[] lenBytes = BitConverter.GetBytes((long)sBytes.Length);
            // Копируем 8 байтов длины
            Array.Copy(lenBytes, 0, resultBytes, pos, 8);
            pos += 8;
            // Копируем байты строки
            Array.Copy(sBytes, 0, resultBytes, pos, sBytes.Length);
            pos += sBytes.Length;
        }
        
        // Перекодируем итоговый массив байтов в Base64-строку
        return Convert.ToBase64String(resultBytes);
    }

    // Декодирует строку обратно в список строк.
    public static List<string> Decode(string s) {
        var result = new List<string>();
        if (string.IsNullOrEmpty(s)) return result;
        
        // Преобразуем Base64-строку обратно в массив байтов
        byte[] allBytes = Convert.FromBase64String(s);
        int index = 0;
        
        // Пока не достигнут конец массива
        while (index < allBytes.Length) {
            // Считываем 8 байт для длины строки
            long len = BitConverter.ToInt64(allBytes, index);
            index += 8;
            
            // Выделяем байты для строки
            byte[] sBytes = new byte[len];
            Array.Copy(allBytes, index, sBytes, 0, len);
            index += (int)len;
            
            // Преобразуем байты в строку (UTF-8)
            string decodedString = Encoding.UTF8.GetString(sBytes);
            result.Add(decodedString);
        }
        return result;
    }
}