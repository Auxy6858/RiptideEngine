namespace RiptideEngine;

using Microsoft.Xna.Framework;

public struct HitBox : IEquatable<HitBox>, IComparable<HitBox>
{
    public Rectangle HitBoxRectangle { get; set; }


    // COMPARATIVE OPERATOR OVERLOADS

    public bool Equals(HitBox other)
    {
        return HitBoxRectangle == other.HitBoxRectangle;
    }

    public int CompareTo(HitBox other)
    {
        return (other.HitBoxRectangle.Height * other.HitBoxRectangle.Width).CompareTo(HitBoxRectangle.Height * HitBoxRectangle.Width);
    }
}

public struct CircleHitBox : IEquatable<CircleHitBox>, IComparable<CircleHitBox>
{
    private Vector2 Origin { get; set; }
    private float Radius { get; set; }

    public bool CollidesWith(Vector2 point)
    {
        return ( Math.Pow(point.X - Origin.X, 2) + Math.Pow(point.Y - Origin.Y, 2) <= Math.Pow(Radius, 2) );
    }

    // COMPARATIVE OPERATOR OVERLOADS

    public bool Equals(CircleHitBox other)
    {
        return (other.Origin == Origin) && (Math.Abs(other.Radius - Radius) < 1e-3f);
    }

    public int CompareTo(CircleHitBox other)
    {
        return Radius.CompareTo(other.Radius);
    }
}
