using System;
using System.Diagnostics;
using System.Collections.Generic;

public class ForVsForeachPerformance
{
    /// <summary>
    /// Total number of elements on which we need to check performance.
    /// </summary>
    private static int totalNumberOfElements = 1000000;

    public static void Main(string[] args)
    {
        List<string> lst = new List<string>();
        for (int i = 0; i < totalNumberOfElements; i++)
        {
            lst.Add(" " + i);
        }

        Console.WriteLine("When we access element once.");
        
        WriteForPerformance_WithOneTimeElementAccess(lst);
        WriteForeachPerformance_WithOneTimeElementAccess(lst);

        Console.WriteLine("\nWhen we access element multiple times.");
        WriteForPerformance_WithMultipleTimeElementAccess(lst);
        WriteForeachPerformance_WithMultipleTimeElementAccess(lst);
    }

    /// <summary>
    /// This method is used to check performance of for loop when we access element once.
    /// </summary>
    /// <param name="lst"></param>
    public static void WriteForPerformance_WithOneTimeElementAccess(List<string> lst)
    {
        List<string> copyLst = new List<string>();
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        for (int i = 0; i < lst.Count; i++)
        {
            copyLst.Add(lst[i]);
        }
        stopwatch.Stop();
        Console.WriteLine("For loop Elapsed Time is {0} ms", stopwatch.ElapsedMilliseconds);
    }

    /// <summary>
    /// This method is used to check performance of for loop when we access element multiple times.
    /// </summary>
    /// <param name="lst"></param>
    public static void WriteForPerformance_WithMultipleTimeElementAccess(List<string> lst)
    {
        List<string> copyLst = new List<string>();
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        for (int i = 0; i < lst.Count; i++)
        {
            copyLst.Add(lst[i]);
            copyLst.Add(lst[i]);
            copyLst.Add(lst[i]);
            copyLst.Add(lst[i]);
        }
        stopwatch.Stop();
        Console.WriteLine("For loop Elapsed Time is {0} ms", stopwatch.ElapsedMilliseconds);
    }

    /// <summary>
    /// This method is used to check performance of foreach loop when we access element once.
    /// </summary>
    /// <param name="lst"></param>
    public static void WriteForeachPerformance_WithOneTimeElementAccess(List<string> lst)
    {
        List<string> copyLst = new List<string>();
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        foreach (string i in lst)
        {
            copyLst.Add(i);
        }
        stopwatch.Stop();
        Console.WriteLine("Foreach Elapsed Time is {0} ms", stopwatch.ElapsedMilliseconds);
    }

    /// <summary>
    /// This method is used to check performance of foreach loop when we access element multiple times.
    /// </summary>
    /// <param name="lst"></param>
    public static void WriteForeachPerformance_WithMultipleTimeElementAccess(List<string> lst)
    {
        List<string> copyLst = new List<string>();
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        foreach (string i in lst)
        {
            copyLst.Add(i);
            copyLst.Add(i);
            copyLst.Add(i);
            copyLst.Add(i);
        }
        stopwatch.Stop();
        Console.WriteLine("Foreach Elapsed Time is {0} ms", stopwatch.ElapsedMilliseconds);
    }
}
