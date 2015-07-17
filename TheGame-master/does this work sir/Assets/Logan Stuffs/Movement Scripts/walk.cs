using UnityEngine;
using System.Collections;

public class walk : MonoBehaviour {
	Animator anim;
	public float MouseSensitivity = 5f;
	float vertRot;
	public float UpDownRange = 60.0f;

	void Start () 
	{
		anim = GetComponent<Animator> ();
	
	}
	
	// Update is called once per frame
	void Update () 
	{/*
		float rotLeftRight = Input.GetAxis ("Mouse X") * MouseSensitivity;
		transform.Rotate (0, rotLeftRight, 0);

		vertRot -= Input.GetAxis ("Mouse Y") * MouseSensitivity;
		vertRot = Mathf.Clamp (vertRot, -UpDownRange, UpDownRange);
		Camera.main.transform.localRotation = Quaternion.Euler (vertRot , 0, 0);
*/
		float move = Input.GetAxis ("Vertical");
		anim.SetFloat ("Speed", move);

		float Wmove = Input.GetAxis ("Horizontal");
		anim.SetFloat ("LRSpeed", Wmove);

	
	}
}
