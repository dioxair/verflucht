using System.Collections.Generic;

namespace Verflucht.Scripts.Game
{
    public record BulletPatternBuilder 
    {
        public List<float> Angles { get; } = new();
        public int Speed { get; set; }
        public int MaxSpeed { get; set; }
        public int AccelerationSpeed { get; set; }
    }
}