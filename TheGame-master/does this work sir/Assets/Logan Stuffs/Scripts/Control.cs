using UnityEngine;
using System.Collections;


public class Control : MonoBehaviour {
	//GameObject go = GameObject.Find("RandRoom");
	//RandRoom rr = (RandRoom) go.GetComponent(typeof(RandRoom));
	//rr.CloseDoors();
	public GameObject RandRoom;
	private RandRoom RR;
	//public GameObject Astar;
	//private AstarPath A_star;




	// Use this for initialization
	void Start () 
	{
		RandRoom = GameObject.Find("RandRoom");
		RR = RandRoom.GetComponent<RandRoom>();

		//Astar = GameObject.Find("A*");
		//A_star = Astar.GetComponent<AstarPath>();

		if (RR.enabled == false)
			RR.enabled = true;

		//if (A_star.enabled == false)
			//A_star.enabled = true;
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
