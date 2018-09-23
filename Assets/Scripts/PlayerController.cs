using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class PlayerController : MonoBehaviour
{

    public float speed;
    public Text countText;
    public Text winText;
	public float jump;
    public Transform cameraTransform;

    private Rigidbody rb;
    private int count;
    private AudioSource myAudio;
	private AudioSource Loopy; 
	private bool isFalling;
    private Vector3 forward;


    // Start will happen at the very beginning of your game level loading. Here we can see setting the count to 0 as we start the game and calling the Rigidbody to be a private class.
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        myAudio = GetComponent<AudioSource>();
		Loopy = GetComponent<AudioSource>();
		Loopy.Play();
        count = 0;
        SetCountText();
        winText.text = "";
    }
    // FixedUpdate happens at the start of every frame.
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement * speed);

        if (Input.GetKeyDown (KeyCode.Space) && !isFalling) {
			rb.AddForce (Vector3.up * jump, ForceMode.Impulse);
		}

		if (Input.GetKeyDown (KeyCode.Escape)){
			SceneManager.LoadScene (0);
               
            }
	}
       

    

    public void OnCollisionStay(Collision col) {
		isFalling = false;
	}

		public void OnCollisionExit(){
		isFalling = true; 
	}




    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);
            myAudio.Play();
            count = count + 1;
            SetCountText();
        }
    }

    void SetCountText()
    {
        countText.text = "Count: " + count.ToString();
        if (count >= 100)
        {
            SceneManager.LoadScene(4);
        }
    }
}

