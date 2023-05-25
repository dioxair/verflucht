using Godot;

namespace Verflucht.Scripts.Game
{
	public class Boss : Sprite
	{
		private readonly PackedScene _bullet = (PackedScene)ResourceLoader.Load("res://Scenes/NodeScenes/Bullet.tscn");

		private void OnFireTimerTimeout() => AllDirections();

		private void AllDirections()
		{
			foreach (float i in BulletPatterns.AllDirections)
			{
				if (!(_bullet.Instance() is Bullet bullet)) continue;
				bullet.Angle = i + Mathf.Rad2Deg(Rotation);
				bullet.MaxSpeed = 200;
				bullet.AccelerationSpeed = 30;
				bullet.Speed = 50;
				bullet.Position = Position + new Vector2(0 * Mathf.Cos(Rotation), 50 * Mathf.Sin(Rotation));
				GetParent().AddChild(bullet);
			}
		}
	}
}



