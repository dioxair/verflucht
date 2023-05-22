using System;
using Godot;

namespace Verflucht.Scripts.Game
{
	public class Player : KinematicBody2D
	{
		private bool _hasPlayedAnim;
		private Vector2 _velocity;
		[Export] public int Speed = 500;

		private void HitBoxButton()
		{
			if (Input.IsActionPressed("HitBox"))
			{
				GetNode<Sprite>("HitBoxMode").Visible = true;
				if (!_hasPlayedAnim)
					GetNode<AnimationPlayer>("AnimationPlayer").Play("HitBox Animation");
				_hasPlayedAnim = true;
				Speed = 300;
			}
			else if (!Input.IsActionPressed("HitBox"))
			{
				GetNode<Sprite>("HitBoxMode").Visible = false;
				_hasPlayedAnim = false;
				Speed = 500;
			}
			// Kind of like the slow button from Touhou
		}

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
			HitBoxButton();
			_velocity = MoveAndSlide(_velocity);
		}
	}
}
