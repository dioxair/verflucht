namespace Verflucht.Scripts.Game;

public abstract class BulletPatterns
{
    public static readonly BulletPatternBuilder AllDirectionsPattern = new()
    {
        Angles =
        {
            0, 15, 30, 45, 60, 75, 90, 105, 120, 135, 150, 165, 180, 195, 210, 225, 240, 255, 270, 285, 300, 315, 330,
            345, 360
        },
        MaxSpeed = 200,
        AccelerationSpeed = 30
    };

    public static readonly BulletPatternBuilder ForwardPattern = new()
    {
        Angles = { 90 },
        Speed = 50,
        MaxSpeed = 200,
        AccelerationSpeed = 30,
    };
}