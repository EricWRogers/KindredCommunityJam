using Godot;
using System;

public class MenuButton : Button
{
	[Export] private string scenePath = "";
	
	private void _on_Button_pressed()
	{
		GetTree().ChangeScene(scenePath);
	}
}
