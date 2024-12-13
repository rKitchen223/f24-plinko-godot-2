using Godot;
using System;

public partial class AreaBasket1 : Area2D
{
	[Export]
	private ScoreNumber ScoreNumber;

	[Export]
	private int Points = 1;

	

	private void OnBodyEntered(Node2D body)
	{
		ScoreNumber.AddScore(Points);
	}
}
