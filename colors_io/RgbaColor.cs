using System;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace colors_io
{
	public class RgbaColor : ColorValue
	{
        public override string Type => "rgba";

        public RgbaColor(string name, string value) : base(name, value)
        {

        }

        protected override void ValidateOrThrow(string value)
        {
	        var rgbaRegex = new Regex(@"^rgba\((25[0-5]|2[0-4][0-9]|1?[0-9]{1,2}),(25[0-5]|2[0-4][0-9]|1?[0-9]{1,2}),(25[0-5]|2[0-4][0-9]|1?[0-9]{1,2}),(1|0?\.[0-9]+|0)\)$");

	        if (!rgbaRegex.IsMatch(value))
	        {
		        throw new ValidationException($"Invalid RGBA color format: {value}");
	        }
        }
    }
}

