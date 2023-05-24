using Godot;

namespace Verflucht.Scripts.Game
{
	public class Boss : Sprite
	{
		private int _acceleration = 30;
		private int _speed = 50;
		private int _maxSpeed = 200; 
		private readonly PackedScene _bullet = (PackedScene)ResourceLoader.Load("res://Scenes/NodeScenes/Bullet.tscn");

		private void OnFireTimerTimeout() => Fire();

		private void Fire()
		{
			_speed += _acceleration;
			if (_speed >= _maxSpeed)
				_speed = _maxSpeed;
			foreach (float i in BulletPatterns.AllDirections)
			{
				if (!(_bullet.Instance() is Bullet bullet)) continue;
				bullet.Angle = i + Mathf.Rad2Deg(Rotation);
				bullet.Speed = _speed;
				bullet.Position = Position + new Vector2(0 * Mathf.Cos(Rotation), 50 * Mathf.Sin(Rotation));
				GetParent().AddChild(bullet);
			}
		}
	}
}



