using Godot;
using System;

public partial class Game : Control
{
	private PackedScene InputResponse = (PackedScene)GD.Load("res://InputResponse.tscn");
	private Node history_rows;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		history_rows = GetNode<Node>("Background/MarginContainer/Rows/GameInfo/ScrollContainer/HistoryRows"); 
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}

	public void _on_user_input_text_submitted(string p_text)
	{ 
		GD.Print(p_text);
		Node input_Response_Instance = (Node)InputResponse.Instantiate();
		history_rows.AddChild(input_Response_Instance);
	}
}
