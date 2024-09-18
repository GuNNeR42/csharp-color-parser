using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace colors_io;

public class RgbaColor : ColorValue
{
    public RgbaColor(string name, string value) : base(name, value)
    {
        ValidateOrThrow(value);
    }

    public override string Type => "rgba";

    protected sealed override void ValidateOrThrow(string value)
    {
        var rgbaRegex =
            new Regex(
                @"^rgba\((([01]?\d\d?|2[0-4]\d|25[0-5]),){3}(1|0?\.\d+|0)\)$");

        if (!rgbaRegex.IsMatch(value)) throw new ValidationException($"Invalid RGBA color format: {value}");
    }
}