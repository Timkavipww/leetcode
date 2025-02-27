namespace tests;

public static partial class Solution
{
    public static void GetValue(LinkedList<string> node)
    {
        LinkedList<string> myList = new();

        myList.AddLast("a");
        myList.AddLast("b");
        myList.AddLast("c");
        myList.AddLast("d");
        myList.AddLast("e");
        myList.Last.Value = "f";



        Console.WriteLine(string.Join(",", myList));


    }
    
}
