using Godot;
using System;

public partial class PlayerRunningUp : State
{
	private AnimationPlayer Anim;

	public override void Enter()
	{
		GD.Print("Entered");
		Anim = GetNode("../../PlayerAnimations") as AnimationPlayer;
	}

    public override void Update(float delta)
    {
        Anim.Play("move_up");
    }

    public override void HandleInput(InputEvent @event)
    {
        if (Input.IsKeyPressed(Key.W) && (Input.IsKeyPressed(Key.A) || Input.IsKeyPressed(Key.D))) {}
        else if (Input.IsKeyPressed(Key.D))
            fsm.TransitionTo("PlayerRunningRight");
        else if (Input.IsKeyPressed(Key.A))
            fsm.TransitionTo("PlayerRunningLeft");
        else if (Input.IsKeyPressed(Key.S))
            fsm.TransitionTo("PlayerRunningDown");
        else if (!Input.IsKeyPressed(Key.W))
            fsm.TransitionTo("PlayerIdleUp");
    }
}