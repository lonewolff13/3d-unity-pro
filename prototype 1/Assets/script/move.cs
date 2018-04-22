using UnityEngine;
using System.Collections;

public class move : MonoBehaviour {
	Animator anim;
	public float speed;
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		var x = Input.GetAxis("Horizontal") * Time.deltaTime * 150.0f;
		var z = Input.GetAxis("Vertical") * Time.deltaTime * speed ;
		bool isMoving = Input.GetKey ("up"); //= x != 0f || z != 0f;
		anim.SetBool("IsWalking",isMoving);
		transform.Rotate(0, x, 0);
		transform.Translate(0, 0, z);
		bool isAttack = Input.GetKeyDown ("c");
		anim.SetBool ("Attack1", isAttack);
		bool isAttacking = Input.GetKeyDown ("x");
		anim.SetBool ("AttackS", isAttacking);
		bool isKicking = Input.GetKeyDown ("v");
		anim.SetBool ("KickInTheNuts", isKicking);
		bool isJumpin = Input.GetKeyDown ("space");
		anim.SetBool ("Jump", isJumpin);
		bool walkBack = Input.GetKey ("down"); // still can t figure this part out !! done !!^^
		anim.SetBool ("walkB", walkBack);
		bool isTurnL = Input.GetKey ("left");
		anim.SetBool ("TurnL", isTurnL);
		bool isTurnR = Input.GetKey ("right");
		anim.SetBool ("TurnR", isTurnR);

	}

}
