using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class NewBehaviourScript : MonoBehaviour {

	// Use this for initialization
	void Start () {


	}

    // Update is called once per frame
    void FixedUpdate()
    {

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(0);

        }
    }
		
		public void StartGame (){
		SceneManager.LoadScene (1);
	}
	     
		public void Quit () {
		Application.Quit ();
	}

    public void Options()
    {
        SceneManager.LoadScene(2);
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(0);
        }
    }

    public void Credits () { 
        SceneManager.LoadScene(3);
    }

	
}
