using Godot;
using System;

public class GotoMenuButton : Button
{
	private void _on_Button_pressed()
	{
		GetTree().ChangeScene("res://Scenes/title_screen.tscn");
	}
}
