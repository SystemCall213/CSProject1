using Godot;
using System;

public partial class godotIcon : Sprite2D
{
	public override void _Ready()
	{
	}

	public override void _Process(double delta)
	{
		// var newPosition = Position;
		// newPosition.X = 100.0f;
		// Position = newPosition;
		this.Position += new Vector2(5,0);
	}
}
