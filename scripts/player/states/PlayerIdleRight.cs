using Godot;
using System;

public partial class PlayerIdleRight : State
{
	private AnimationPlayer Anim;

	public override void Enter()
	{
		Anim = GetNode("../../PlayerAnimations") as AnimationPlayer;
	}

    public override void Update(float delta)
    {
        Anim.Play("Idle_right");
    }

    public override void HandleInput(InputEvent @event)
    {
        if (Input.IsKeyPressed(Key.A))
            fsm.TransitionTo("PlayerRunningLeft");
        else if (Input.IsKeyPressed(Key.D))
            fsm.TransitionTo("PlayerRunningRight");
        if (Input.IsKeyPressed(Key.W))
            fsm.TransitionTo("PlayerRunningUp");
        else if (Input.IsKeyPressed(Key.S))
            fsm.TransitionTo("PlayerRunningDown");
    }
}
