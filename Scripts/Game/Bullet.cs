using Godot;

namespace Verflucht.Scripts.Game
{
	public class Bullet : Sprite
	{
		public float Angle;
		public int Speed;
		public int AccelerationSpeed;
		
		public override void _Ready()
		{
		}

		public override void _Process(float delta)
		{
			Speed += AccelerationSpeed;
			Position += new Vector2(Mathf.Cos(Mathf.Deg2Rad(Angle)), Mathf.Sin(Mathf.Deg2Rad(Angle))) * Speed * delta;
		}

		private void ExitedScreen() => QueueFree();
	}
}
