namespace colors_io
{
	public class ColorReader
	{
		public List<ColorValue> ReadCsvColors(string filePath)
		{
			var colors = new List<ColorValue>();
			using (StreamReader rdr = new StreamReader("path"))
			{
				while (!rdr.EndOfStream)
				{
					colors.Add(
						this.ParseCsvColor(rdr.ReadLine()!)
						);
				}
			}
			return colors;
		}

		private ColorValue ParseCsvColor(string line)
		{
			var columns = line.Split(',');
			string name = columns[0];
			string type = columns[1];
			string value = columns[2];
		
			switch (type.ToLower())
			{
				case "rgba":
					return new RgbaColor(name, value);
				case "hex":
					return new HexColor(name, value);
				default:
					throw new ArgumentException(message: $"Type {type} is not rgba nor hex");
			}
		}
	}
}

