using Godot;

namespace Verflucht.Scripts.Game
{
	public abstract class Bullet : Sprite
	{
		public int AccelerationSpeed;
		public float Angle;
		public int MaxSpeed;
		public int Speed;

		public override void _Ready()
		{
		}

		public override void _Process(float delta)
		{
			Speed += AccelerationSpeed;
			if (Speed >= MaxSpeed)
				Speed = MaxSpeed;
			Position += new Vector2(Mathf.Cos(Mathf.Deg2Rad(Angle)), Mathf.Sin(Mathf.Deg2Rad(Angle))) * Speed * delta;
		}

		private void ExitedScreen() => QueueFree();
	}
}
