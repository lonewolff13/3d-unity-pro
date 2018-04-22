using UnityEngine;
using System.Collections;

public class move : MonoBehaviour {
	Animator anim;
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		var x = Input.GetAxis("Horizontal") * Time.deltaTime * 150.0f;
		var z = Input.GetAxis("Vertical") * Time.deltaTime * 3.0f;
		bool isMoving = x != 0f || z != 0f;
		anim.SetBool("IsWalking",isMoving);
		transform.Rotate(0, x, 0);
		transform.Translate(0, 0, z);
		bool isAttacking = Input.GetKeyDown ("x");
		anim.SetBool ("Attack1", isAttacking);
		bool isJumpin = Input.GetKeyDown ("space");
		anim.SetBool ("Jump", isJumpin);
		bool walkBack = Input.GetKeyDown ("Down_Arrow"); // still can t figure this part out !!
		anim.SetBool ("walkB", walkBack);

	}

}
