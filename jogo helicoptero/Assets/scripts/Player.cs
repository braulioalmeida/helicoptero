using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	//declarando variaveis

	public Animator anime; 
	public Rigidbody2D RigidBodyPlayer;
	public bool Flying;
	private float movimentoX; // recebe o valor de entrada
	public float maxSpeed; 
	public bool FacingRight; 
	public int JumpForce; 

	public bool WallCheck;


	public Transform GroundCheck;
	public bool Grounded;
	public LayerMask WhatIsGround;




	// Use this for initialization
	void Start ()
	{

		// anime = GetComponent<Animator>(); // PEGAR O COMPONENTE SE ELE ESTIVER NO MESMO OBJETO QUE O SCRIPT
		// anime = GameObject.Find("Player").GetComponent<Animator> (); // BUSCA O OBJETO E PEGA O COMPONENTE
		
	}

	// Update is called once per frame
	void Update () {

		Grounded = Physics2D.OverlapCircle (GroundCheck.position, 0.2f, WhatIsGround);

		movimentoX = Input.GetAxis ("Horizontal");
	
		if(Input.GetButtonDown("Jump"))
			
			{
			RigidBodyPlayer.velocity = new Vector2 (0, 0);
			RigidBodyPlayer.AddForce (new Vector2 (0, JumpForce));
			}

		if (movimentoX > 0 && !FacingRight) 
		{
			Flip ();
		} 

		else if (movimentoX < 0 && FacingRight) 
		
		{
			Flip ();
		}

	
			RigidBodyPlayer.velocity = new Vector2 (movimentoX * maxSpeed, RigidBodyPlayer.velocity.y);
	

		if (movimentoX != 0) // verifica se o movimento x eh é diferente de zero, entao seta flying verdadeiro 
		{
			Flying = true;
		} 
		else // se o movimento x for igual a zero, seta o flying para false
		{
			Flying = false;
		}

		anime.SetBool ("Flying", Flying);

		//GetComponent<Animator> ().SetBool ("Flying", Flying); // um dos metodos de acessar o componente

	    }

	void Flip ()
	{
		FacingRight = !FacingRight;
		Vector3 theScale = transform.localScale;
		theScale.x *= -1; 
		transform.localScale = theScale;
	}
		

	void OnTriggerEnter2D (Collider2D col) // ao entrar em colisao com um trigger

		
		{

		}
		

	void OnTriggerExit2D (Collider2D col) //ao sair da colisao com um trigger
	{
		
		WallCheck = false;
	}

	void OnTriggerStay2D (Collider2D col) // vai ficar execultando enquanto estiver colidindo
	{
		
		WallCheck = true;
	}

	void OnCollisionEnter2D (Collision2D col)
	{
		if (col.gameObject.tag == "bloco")
		{
			Debug.Log ("bateu");
		}
	}

	void OnCollisionExit2D (Collision2D col)
	{
		
	}

	void OnCollisionStay2D (Collision2D col)
	{
		

	}


}