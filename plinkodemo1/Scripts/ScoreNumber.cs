using Godot;
using System;

public partial class ScoreNumber : Label
{
	private int score;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		UpdateDisplay();
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}

	private void UpdateDisplay()
	{
		Text = $"Score: {score}";
	}

	public void AddScore(int points)
	{
		score += points;
		UpdateDisplay();
	}
}
