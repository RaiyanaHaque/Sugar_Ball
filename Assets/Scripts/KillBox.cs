using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;
using System.Collections.Generic;

public class KillBox : MonoBehaviour {

	void OnCollisionEnter(Collision collision)
	{
		if(collision.gameObject.tag == "Player" )   //Finds if an object within the game tagged "Player" has come into contact with the cube
		{
			Destroy(collision.gameObject);   //Destroys (kills) the player object

			SceneManager.LoadScene (1); //Reloads the scene, allowing the player to retry
		}
	}
}
