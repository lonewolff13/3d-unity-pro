using UnityEngine;
using System.Collections;

public class cameraFollow : MonoBehaviour {
	public GameObject Barbarian;

	private Vector3 offset;
	[Range(0.01f , 1.0f)]
	public float smoothC = 0.5f;
	// Use this for initialization
	void Start () {
		offset = transform.position - Barbarian.transform.position;
	}
	
	// Update is called once per frame
	void LateUpdate () {
		Vector3 newPos = Barbarian.transform.position + offset;

		transform.position = Vector3.Slerp (transform.position, newPos, smoothC);
	}
}
