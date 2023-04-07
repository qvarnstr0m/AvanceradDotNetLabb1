namespace AvanceradDotNetLabb1;

public class Box : IEquatable<Box>
{
    public int Height { get; set; }
    public int Width { get; set; }
    public int Length { get; set; }
    
    public Box(int height, int width, int length)
    {
        Height = height;
        Width = width;
        Length = length;
    }
    
    public bool Equals(Box? other)
    {
        if (new BoxSameDimensions().Equals(this, other))
        {
            return true;
        }
        
        return false;
    }

    public override bool Equals(object? obj)
    {
        return base.Equals(obj);
    }

    public override int GetHashCode()
    {
        return base.GetHashCode();
    }
}