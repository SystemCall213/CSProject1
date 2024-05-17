using Godot;
using System;

public partial class Player : CharacterBody2D 
{
    public float MoveSpeed = 150.0f;

    public override void _Ready()
    {
        
    }

    public override void _PhysicsProcess(double delta)
    {
        Vector2 velocity = Velocity;
        velocity.X = 0;
        velocity.Y = 0;
        if (Input.IsKeyPressed(Key.A))
            velocity.X = -MoveSpeed;
        else if (Input.IsKeyPressed(Key.D))
            velocity.X = MoveSpeed;
        if (Input.IsKeyPressed(Key.W))
            velocity.Y = -MoveSpeed;
        else if (Input.IsKeyPressed(Key.S))
            velocity.Y = MoveSpeed;

        Velocity = velocity;

        MoveAndSlide();
    }
}