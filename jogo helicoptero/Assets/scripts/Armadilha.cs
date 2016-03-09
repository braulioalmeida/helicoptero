using UnityEngine;
using System.Collections;

public class Armadilha : MonoBehaviour {

	public GameObject [] Prefab; //objeto que queremos instanciar na cena
	private bool ativo;
	public Transform SpawnPoint;

	public int indice; // definir quais dos objetos deverao ser instanciado
	public bool atirar;


	// Use this for initialization
	void Start () {
	
		if (indice >= Prefab.Length) 
		{
			indice = Prefab.Length -1;
			Debug.Log("Ajustado");
		}
	}



	// Update is called once per frame
	void Update () {
	
	}
		

	void OnTriggerEnter2D (Collider2D col)
	{
		if (col.tag == "Player")
		if (!ativo) //if (!ativo) e a mesma coisa que if (ativo == false)

		if (col.gameObject.tag == "Player")
			indice = Random.Range (0, Prefab.Length - 1); 
			
		{
			GameObject tempPrefab = Instantiate (Prefab[indice]) as GameObject; 
			tempPrefab.transform.position = SpawnPoint.position;


			if (atirar) { // mesma coisa que == true
				tempPrefab.GetComponent<Rigidbody2D> ().gravityScale = 0;
				tempPrefab.GetComponent<Rigidbody2D> ().AddForce (new Vector2 (-250, 0));
			} 

			else 
			{
				tempPrefab.GetComponent<Rigidbody2D> ().gravityScale = 1;
			}

			ativo = true;

			}
		}
		

	void OnTriggerExit2D (Collider2D col)
	{
		if (col.tag == "Player") {
			ativo = false;
		}
	
	}
}



