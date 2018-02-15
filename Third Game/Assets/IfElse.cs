using UnityEngine;
using System.Collections;

public class IfElse : MonoBehaviour {

	public bool Key;
	public int Health = 100;
	public string Password = "IOU12";

	void Start () {

		if (Key){
			print ("I have the key.");
		} else {
			print("You shall not pass!");
		}

		if (Health > 0){
			print ("You can play the game.");
		} else {
			print ("You're dead. Dead, dead, dead!");
		}

		if (Password == "IOU12"){
			print ("Correct!");
		} else {
			print ("Try again!");
		}
		
	
	}
	
	
}
