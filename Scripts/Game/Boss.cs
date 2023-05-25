using Godot;

namespace Verflucht.Scripts.Game
{
	public class Boss : Sprite
	{
		private readonly PackedScene _bullet = (PackedScene)ResourceLoader.Load("res://Scenes/NodeScenes/Bullet.tscn");

		private void OnFireTimerTimeout() => AllDirections();

		private void AllDirections()
		{
			foreach (float i in BulletPatterns.AllDirectionsPattern.Angles)
			{
				if (_bullet.Instance() is not Bullet bullet) continue;
				bullet.Angle = i + Mathf.Rad2Deg(Rotation);
				bullet.MaxSpeed = BulletPatterns.AllDirectionsPattern.MaxSpeed;
				bullet.AccelerationSpeed = BulletPatterns.AllDirectionsPattern.AccelerationSpeed;
				bullet.Speed = BulletPatterns.AllDirectionsPattern.Speed;
				bullet.Position = Position + new Vector2(0 * Mathf.Cos(Rotation), 50 * Mathf.Sin(Rotation));
				GetParent().AddChild(bullet);
			}
		}
	}
}



