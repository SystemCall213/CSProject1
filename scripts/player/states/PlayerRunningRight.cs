using Godot;
using System;

public partial class PlayerRunningRight : State
{
	private AnimationPlayer Anim;

	public override void Enter()
	{
		GD.Print("Entered");
		Anim = GetNode("../../PlayerAnimations") as AnimationPlayer;
	}

    public override void Update(float delta)
    {
        Anim.Play("move_right");
    }

    public override void HandleInput(InputEvent @event)
    {
        if (Input.IsKeyPressed(Key.D) && (Input.IsKeyPressed(Key.W) || Input.IsKeyPressed(Key.S))) {}
        else if (Input.IsKeyPressed(Key.A))
            fsm.TransitionTo("PlayerRunningLeft");
        else if (Input.IsKeyPressed(Key.W))
            fsm.TransitionTo("PlayerRunningUp");
        else if (Input.IsKeyPressed(Key.S))
            fsm.TransitionTo("PlayerRunningDown");
        else if (!Input.IsKeyPressed(Key.D))
            fsm.TransitionTo("PlayerIdleRight");
    }
}