using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace colors_io;

public class HexColor : ColorValue
{
    public HexColor(string name, string value) : base(name, value)
    {
        ValidateOrThrow(value);
    }

    public override string Type => "hex";

    protected sealed override void ValidateOrThrow(string value)
    {
        var hexRegex = new Regex(@"^#([0-9a-fA-F]{6}|[0-9a-fA-F]{3})$");

        if (!hexRegex.IsMatch(value)) throw new ValidationException($"Invalid HEX color format: {value}");
    }
}