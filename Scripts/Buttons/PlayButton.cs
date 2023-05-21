using Godot;

namespace Verflucht.Scripts.Buttons
{
	public class PlayButton : Button
	{
		private void _on_PlayButton_pressed() => 
			GetTree().ChangeScene("res://Scenes/GameScenes/Game.tscn");
	}
}



