using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class move : MonoBehaviour {
	Animator anim;
	public float speed;
	public Slider phealth;
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		if (phealth.value <= 0)
			return;
		//move
		var x = Input.GetAxis("Horizontal") * Time.deltaTime * 150.0f;
		var z = Input.GetAxis("Vertical") * Time.deltaTime * speed ;
		transform.Rotate(0, x, 0);
		transform.Translate(0, 0, z);
		//anime move
		bool isMoving = Input.GetKey ("up") || Input.GetKey("z"); 
		anim.SetBool("IsWalking",isMoving);
		bool walkBack = Input.GetKey ("down") || Input.GetKey("s"); // still can t figure this part out !! done !!^^
		anim.SetBool ("walkB", walkBack);
		bool isTurnL = Input.GetKey ("left") || Input.GetKey("q");
		anim.SetBool ("TurnL", isTurnL);
		bool isTurnR = Input.GetKey ("right") || Input.GetKey("d");
		anim.SetBool ("TurnR", isTurnR);
		//jump
		bool isJumpin = Input.GetKeyDown ("space");
		anim.SetBool ("Jump", isJumpin);

	}

}
