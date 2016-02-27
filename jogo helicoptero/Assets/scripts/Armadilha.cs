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

	void OnTriggrerEnter2D (Collider2D col)
	{
	GameObject tempPrefab = Instantiate (Prefab) as GameObject;
	
	}
}
