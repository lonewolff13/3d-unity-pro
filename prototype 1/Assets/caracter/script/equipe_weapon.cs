using UnityEngine;
using System.Collections;

public class equipe_weapon : MonoBehaviour {
	public Transform axe , equiped_axe , unequiped_axe ;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		axe.position = equiped_axe.position;
		axe.rotation = equiped_axe.rotation;
	}
}
