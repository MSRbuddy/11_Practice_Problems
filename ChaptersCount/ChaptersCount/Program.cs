using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("*****Count of Remaining Chapters!*****");
        Console.WriteLine("------------------------------------------");

        Console.WriteLine("\nTotal No.of Chapters : ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("\nCurrent Reading Page is :");
        int totalPagesRead = int.Parse(Console.ReadLine()) - 1;

        Console.WriteLine("\nStart and End Pages in the chapter : ");
        List<Tuple<int, int>> chapters = new List<Tuple<int, int>>();
        for (int i = 0; i < n; i++)
        {
            string[] inputs = Console.ReadLine().Split();
            int chapterStart = int.Parse(inputs[0]) - 1;
            int chapterEnd = int.Parse(inputs[1]) - 1;
            chapters.Add(new Tuple<int, int>(chapterStart, chapterEnd));
        }
        int chaptersLeft = n;
        foreach (var chapter in chapters)
        {
            if (totalPagesRead >= chapter.Item1 && totalPagesRead <= chapter.Item2)
            {
                chaptersLeft = chapters.IndexOf(chapter, chaptersLeft - n + 1);
                break;
            }
        }
        Console.WriteLine("\nThe count of Remaining Chapters : {0}", n - chaptersLeft);
    }
}