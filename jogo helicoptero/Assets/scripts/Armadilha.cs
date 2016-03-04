using UnityEngine;
using System.Collections;

public class Armadilha : MonoBehaviour {

	public GameObject Prefab;
	private bool ativo;
	public Transform SpawnPoint;



	// Use this for initialization
	void Start () {
	
	}




	// Update is called once per frame
	void Update () {
	
	}
		

	void OnTriggerEnter2D (Collider2D col)
	{
		if (col.tag == "player")
		if (!ativo) //if (!ativo) e a mesma coisa que if (ativo == false)

		if (col.gameObject.tag == "Player") 
			
			{
			GameObject tempPrefab = Instantiate (Prefab) as GameObject; 
			tempPrefab.transform.position = SpawnPoint.position;
				ativo = true;

			}
		}

	void OnTriggerExit2D (Collider2D col)
	{

		if (col.tag == "player") 
		{
			ativo = false;
		}
	}

}



