
using UnityEngine;
using System.Collections;

public class CameraMove : MonoBehaviour {
	
	public Transform Target;
	public Transform Cam;
	public float cany = 2f;
	public float canx;
	public float canz;

	
	
		// Update is called once per frame
	void Update () 
	{
		Cam.position = Target.position + new Vector3 (canx, cany, canz);
	}
}