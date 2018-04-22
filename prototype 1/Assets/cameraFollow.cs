using UnityEngine;
using System.Collections;

public class cameraFollow : MonoBehaviour {
	public GameObject Barbarian;

	private Vector3 offset;

	// Use this for initialization
	void Start () {
		offset = transform.position - Barbarian.transform.position;
	}
	
	// Update is called once per frame
	void LateUpdate () {
		transform.position = Barbarian.transform.position + offset;
	}
}
