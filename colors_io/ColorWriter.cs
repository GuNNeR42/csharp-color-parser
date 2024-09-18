using System.Text.Json;

namespace colors_io
{
	public class ColorWriter
	{
		public static void WriteToJsonFile(string filePath, List<ColorValue> colors)
		{
			var options = new JsonSerializerOptions { WriteIndented = true };

			using StreamWriter streamWriter = new StreamWriter(filePath);
			using Utf8JsonWriter jsonWriter = new Utf8JsonWriter(streamWriter.BaseStream, new JsonWriterOptions { Indented = true });
			JsonSerializer.Serialize(jsonWriter, colors, options);
		}
	}
}

