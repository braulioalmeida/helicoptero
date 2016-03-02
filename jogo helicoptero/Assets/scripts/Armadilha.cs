using UnityEngine;
using System.Collections;

public class Armadilha : MonoBehaviour {

	public GameObject Prefab;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D (Collider2D col){
		if (col.gameObject.tag == "Player") {
			GameObject tempPrefab = Instantiate (Prefab) as GameObject;	
		}
	}
}
