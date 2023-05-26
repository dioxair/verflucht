namespace Verflucht.Scripts.Game;

public abstract class BulletPatterns
{
    public static readonly BulletPatternBuilder AllDirectionsPattern = new()
    {
        Angles = { 180, 195, 210, 225, 240, 255, 270, 285, 300, 315, 330, 345, 360 },
        Speed = 50,
        MaxSpeed = 200,
        AccelerationSpeed = 30
    };

    public static readonly BulletPatternBuilder ForwardPattern = new()
    {
        Angles = { 270 },
        Speed = 50,
        MaxSpeed = 200,
        AccelerationSpeed = 30,
    };
}