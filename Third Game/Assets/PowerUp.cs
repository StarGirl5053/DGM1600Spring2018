using UnityEngine;
using System.Collections;

[CreateAssetMenu]

public class PowerUp : ScriptableObject {

	public int PowerLevel = 10;
	public Player CurrentPlayer;

	public void RunPowerUp ()
	{
		CurrentPlayer.Score += PowerLevel;
	}
	
}
