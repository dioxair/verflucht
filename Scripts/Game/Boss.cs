using Godot;

namespace Verflucht.Scripts.Game
{
	public class Boss : Sprite
	{
		private readonly PackedScene _bullet = (PackedScene)ResourceLoader.Load("res://Scenes/NodeScenes/Bullet.tscn");

		private void OnFireTimerTimeout() => InstanceBullet(BulletPatterns.AllDirectionsPattern);
		private void InstanceBullet(BulletPatternBuilder bulletPattern)
		{
			foreach (float i in bulletPattern.Angles)
			{
				if (_bullet.Instance() is not Bullet bullet) continue;
				bullet.Angle = -i + Mathf.Rad2Deg(Rotation);
				bullet.MaxSpeed = bulletPattern.MaxSpeed;
				bullet.AccelerationSpeed = bulletPattern.AccelerationSpeed;
				bullet.Speed = bulletPattern.Speed;
				bullet.Position = Position + new Vector2(0 * Mathf.Cos(Rotation), 50 * Mathf.Sin(Rotation));
				GetParent().AddChild(bullet);
			}
		}
	}
}



