namespace tests;

public static partial class Solution 
{
    public static bool IsValidSudoku(char[][] board) 
    {
        var rows = new HashSet<char>[9];
        var cols = new HashSet<char>[9];
        var boxes = new HashSet<char>[9];

        for (int i = 0; i < 9; i++) {
            rows[i] = new HashSet<char>();
            cols[i] = new HashSet<char>();
            boxes[i] = new HashSet<char>();
        }

        for (int i = 0; i < 9; i++) {
            for (int j = 0; j < 9; j++) {
                char c = board[i][j];

                if (c == '.') continue;

                if (!rows[i].Add(c)) return false;

                if (!cols[j].Add(c)) return false;

                int boxIndex = (i / 3) * 3 + (j / 3);

                if (!boxes[boxIndex].Add(c)) return false;
            }
        }
        return true;
    }
}