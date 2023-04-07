namespace AvanceradDotNetLabb1;

public class BoxSameDimensions : EqualityComparer<Box>
{
    public override bool Equals(Box? x, Box? y)
    {
        if (x.Height == y.Height && x.Width == y.Width && x.Length == y.Length || x.Height * x.Width * x.Length == y.Height * y.Width * y.Length)
        {
            return true;
        }
        
        return false;
    }

    public override int GetHashCode(Box obj)
    {
        var hash = obj.Height ^ obj.Width ^ obj.Length;
        return hash.GetHashCode();
    }
}