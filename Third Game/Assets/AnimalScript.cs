using UnityEngine;
using System.Collections;

public class AnimalScript : MonoBehaviour {

	public bool Soup = false;

	void OnMouseDown()
	{
		if (Soup == true)
		{
			print ("Time to eat!");
		}
	}

	

}
