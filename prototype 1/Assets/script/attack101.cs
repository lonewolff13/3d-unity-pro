using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class attack101 : MonoBehaviour {
	public GameObject enemy;
	Animator anim1 , animp;
	public string opp; 
	[Header("enemies")]
	public Slider ehealth;

	void OnTriggerEnter (Collider enemy){
		if (enemy.gameObject.tag == opp) {
			if (ehealth.value - 150 <= 0) {
				ehealth.value -= 150;
				//death animation
				anim1.SetBool ("Death", true);
			} else {
				anim1.SetTrigger ("damaged");
				ehealth.value -= 150;
			}
		}


	}
	// Use this for initialization
	void Start () {
		animp = GetComponent<Animator> ();
		anim1 = enemy.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		bool isAttack = Input.GetKeyDown ("c");
		animp.SetBool ("Attack1", isAttack);
		bool isAttacking = Input.GetKeyDown ("x");
		animp.SetBool ("AttackS", isAttacking);
		bool isKicking = Input.GetKey ("v"); 		// it s actually guard now !!!and it works ^^
		animp.SetBool ("KickInTheNuts", isKicking); // it s actually guard now !!!and it works ^^
	}
}
