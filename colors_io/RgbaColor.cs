using System;
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
            throw new NotImplementedException();
        }
    }
}

