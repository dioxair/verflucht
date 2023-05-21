using System;
using Godot;

namespace Verflucht.Scripts
{
	public class Player : KinematicBody2D
	{
		[Export] public int Speed = 200;

		private Vector2 _velocity;

		private void MovePlayer()
		{
			_velocity = new Vector2
			{
				x = Convert.ToInt32(Input.IsActionPressed("MoveRight")) -
					Convert.ToInt32(Input.IsActionPressed("MoveLeft")),
				y = Convert.ToInt32(Input.IsActionPressed("MoveDown")) -
					Convert.ToInt32(Input.IsActionPressed("MoveUp"))
			};

			_velocity = _velocity.Normalized() * Speed;
		}

		public override void _PhysicsProcess(float delta)
		{
			MovePlayer();
			_velocity = MoveAndSlide(_velocity);
		}
	}
}
