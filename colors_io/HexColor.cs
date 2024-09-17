using System;
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
            throw new NotImplementedException();
        }

    }
}

