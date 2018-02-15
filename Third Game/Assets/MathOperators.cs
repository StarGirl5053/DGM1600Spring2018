using UnityEngine;
using System.Collections;

public class MathOperators : MonoBehaviour {

	public int Score = 0;
	public int PowerUp = 10;
	//public int C = 10;


	
	void OnTriggerEnter () 
	{
		Score += PowerUp; 		

	}
	
	
	
}
