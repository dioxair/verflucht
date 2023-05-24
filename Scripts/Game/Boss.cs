using Godot;

namespace Verflucht.Scripts.Game
{
	public class Boss : Sprite
	{
		private const int Accel = 30;
		private int _currspeed = 50;
		private readonly PackedScene _bullet = (PackedScene)ResourceLoader.Load("res://Scenes/NodeScenes/Bullet.tscn");
		private static readonly float[] Pattern = {0, 15, 30, 45, 60, 75, 90, 105, 120, 135, 150, 165, 180, 195, 210, 225, 240, 255, 270, 285, 300, 315, 330, 345, 360};

		private void OnFireTimerTimeout() => Fire();

		private void Fire()
		{
			_currspeed += Accel;
			if (_currspeed > 200)
				_currspeed = 200;
			foreach (float i in Pattern)
			{
				Bullet bullet = _bullet.Instance() as Bullet;
				bullet.Angle = i + Mathf.Rad2Deg(Rotation);
				bullet.Speed = _currspeed;
				bullet.Position = Position + new Vector2(0 * Mathf.Cos(Rotation), 50 * Mathf.Sin(Rotation));
				GetParent().AddChild(bullet);
			}
		}
	}
}



