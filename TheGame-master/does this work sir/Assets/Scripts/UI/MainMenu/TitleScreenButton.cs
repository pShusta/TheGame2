using UnityEngine;
using System.Collections;

public class TitleScreenButton : MonoBehaviour {
public GameObject Crate;
public GameObject Words;
public GameObject[] OtherCrates;
public GameObject[] OtherWords;
public bool solo;
public bool team;
public bool quit;

private float Wait;
private bool MoveOn = false;

	// Use this for initialization
	void Start () {
		Wait = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if(Wait > 0 && MoveOn == true){
			Wait -= Time.deltaTime;
			if(Wait <= 0){
				Pick ();
			}
		}
	}
	
	public void OnClick(){
		Crate.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
		foreach(GameObject _words in OtherWords) { _words.SetActive(false); }
		foreach(GameObject _crate in OtherCrates){ _crate.GetComponent<Rigidbody>().useGravity = true; }
		Wait = 3;
		MoveOn = true;
	}
	
	
	void Pick(){
		if(quit){
			Quit();
		} else if (team) {
			Team();
		} else {
			Solo();
		}
	}
	
	void Solo(){
		Application.LoadLevel("Dungeon");
	}
	
	void Team(){
		Application.LoadLevel("Networking");
	}
	
	void Quit(){
		Application.Quit();
	}

}
