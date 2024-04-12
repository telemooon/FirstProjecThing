using Godot;
using System;

public partial class UserInput : LineEdit
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		GrabFocus();
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		
	}

	public void _on_text_submitted(string p_text)
	{
		Clear();
	}

}
