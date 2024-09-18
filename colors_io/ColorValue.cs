namespace colors_io;

public abstract class ColorValue
{
    protected ColorValue(string name, string value)
    {
        Name = name;
        Value = value;
    }

    public string Name { get; private set; }

    public abstract string Type { get; }

    public string Value { get; private set; }

    protected abstract void ValidateOrThrow(string value);
}