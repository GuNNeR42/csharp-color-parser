namespace colors_io;

class Program
{
    static void Main(string[] args)
    {
        var colors = new ColorReader().ReadCsvColors("./colors.csv");
        
        ColorWriter.WriteToJsonFile("./file.json", colors);
        Console.WriteLine("JSON file has been written successfully.");
    }
}

