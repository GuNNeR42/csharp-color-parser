namespace colors_io;

public class ColorReader
{
    public List<ColorValue> ReadCsvColors(string filePath)
    {
        var colors = new List<ColorValue>();
        using var rdr = new StreamReader(filePath);
        while (!rdr.EndOfStream)
            colors.Add(
                ParseCsvColor(rdr.ReadLine()!)
            );

        return colors;
    }

    private ColorValue ParseCsvColor(string line)
    {
        var columns = line.Split(';');
        var name = columns[0];
        var type = columns[1];
        var value = columns[2];

        switch (type.ToLower())
        {
            case "rgba":
                return new RgbaColor(name, value);
            case "hex":
                return new HexColor(name, value);
            default:
                throw new ArgumentException($"Type {type} is not rgba nor hex");
        }
    }
}