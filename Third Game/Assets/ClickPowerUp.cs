using UnityEngine;
using System.Collections;

public class ClickPowerUp : MonoBehaviour {

	public PowerUp MyPowerUp;

	private void OnMouseDown()
	{
		//do work
		MyPowerUp.RunPowerUp();
	}
	
}
