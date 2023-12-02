namespace CSharp;

public static class Program
{
    private static IEnumerable<char[]> ReadAndParseInput(string filePath) => 
        File.ReadAllText(filePath)
            .Split("\n\r\n")
            .Select(ToArrays);

    private static int ParseChar(char c) => c - '0';

    private static char[] ToArrays(this string s) => 
        s.Split('\n')
         .Select(char.Parse)
         .ToArray();

    private static void Part1(string inputPath)
    {
        var input = ReadAndParseInput(inputPath);

        var result = input
            .Select(p => (p.First(), p.Last()))
            .Sum(s => ParseChar(s.Item1) + ParseChar(s.Item2));

        Console.WriteLine("Part1 result: " + result);
    }

    private static void Part2(string inputPath)
    {
        var input = ReadAndParseInput(inputPath);

        // var result = input
        //     .OrderByDescending(e => e)
        //     .Take(3)
        //     .Sum();

        // Console.WriteLine("Part2 result: " + result);
    }

    public static void Main(string[] args)
    {
        Part1(args[0]);
        Part2(args[0]);
    }
}
