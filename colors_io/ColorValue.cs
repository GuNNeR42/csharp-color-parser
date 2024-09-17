using System;
namespace colors_io
{
	public abstract class ColorValue
	{
		public string Name { get; private set; }

		public abstract string Type { get; }

		public string Value { get; private set; }

        protected ColorValue(string name, string value)
        {
            Name = name;
            Value = value;

            ValidateOrThrow(value);
        }

        protected abstract void ValidateOrThrow(string value);

    }
}

