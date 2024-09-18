namespace colors_io;

internal class Program
{
    private static void Main(string[] args)
    {
        var colors = new ColorReader().ReadCsvColors("./colors.csv");

        ColorWriter.WriteToJsonFile("./file.json", colors);
        Console.WriteLine("JSON file has been written successfully.");
    }
}