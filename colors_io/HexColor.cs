using System;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace colors_io
{
	public class HexColor : ColorValue
	{

        public override string Type => "hex";

        public HexColor(string name, string value) : base(name, value)
        {

        }

        protected override void ValidateOrThrow(string value)
        {
            Regex hexRegex = new Regex(@"^#([0-9a-fA-F]{6}|[0-9a-fA-F]{3})$");

            if (!hexRegex.IsMatch(value))
            {
                throw new ValidationException($"Invalid HEX color format: {value}");
            }
        }
        
        

    }
}

