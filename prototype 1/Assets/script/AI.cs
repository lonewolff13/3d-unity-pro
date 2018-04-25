using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class AI : MonoBehaviour {
	public Transform player;
	public Transform head;
	Animator anim;
	Animator animp;
	public string opp;
	public Slider phealth;
	public Slider ehealth;
	void OnTriggerEnter (Collider player){
		if (player.gameObject.tag == opp && Input.GetKey("v")) {
			animp.SetTrigger ("TakeDamage");

		} else if (player.gameObject.tag == opp)
			phealth.value -= 50;


	}
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
		animp = player.GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (ehealth.value <= 0)
			return;
		Vector3 direction = player.position - this.transform.position; //direction feha el position mta3 el player % lel enemy 
		direction.y = 0; // mahachtich bih bech ybadalha 
		float angle = Vector3.Angle(direction,head.up);
		if (Vector3.Distance (player.position, this.transform.position) <= 15 && angle < 60 ) { // idha ychoufou ....
			

			this.transform.rotation = Quaternion.Slerp (this.transform.rotation, Quaternion.LookRotation (direction), 0.1f); // rotate the basterd

			if (direction.magnitude > 5) {
				this.transform.Translate (0, 0, 0.07f);
				anim.SetBool ("atttack", false);
				anim.SetBool ("walk", true);

			} else {
				anim.SetBool ("walk", false);
				anim.SetBool ("atttack", true);
			}

		} else {
			anim.SetBool ("walk", false);
			anim.SetBool ("atttack", false);

		}
	}
}
