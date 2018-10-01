using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using UnityEngine;
using UnityEngine.UI;

public class ChickenMove : MonoBehaviour {

	public Rigidbody2D Chicken;
	public GameObject ChickenSpriteStatic;
	public GameObject ChickenSpriteMoving;
	public float speed;
	public float OrgPos;
	private int score;
	public Text DisplayScore;

	// Use this for initialization
	void Start ()
	{
		score = 0;
		ChickenSpriteStatic.SetActive(true);
		ChickenSpriteMoving.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey("w"))
		{
			print("W pressed");
			Chicken.AddRelativeForce(Vector2.up * speed);
			ChickenSpriteStatic.SetActive(false);
			ChickenSpriteMoving.SetActive(true);
		}
		
		else if (Input.GetKey("s"))
		{
			print("S pressed");
			Chicken.AddRelativeForce(Vector2.down * speed);
			ChickenSpriteStatic.SetActive(false);
			ChickenSpriteMoving.SetActive(true);
		}
		else
		{
			ChickenSpriteStatic.SetActive(true);
			ChickenSpriteMoving.SetActive(false);
		}
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.CompareTag("Car"))
		{
			transform.position = new Vector3(transform.position.x, OrgPos, transform.position.z);
		}

		if (other.CompareTag("Finish"))
		{
			transform.position = new Vector3(transform.position.x, OrgPos, transform.position.z);
			score = score + 1;
			print("Score: " + score);
			
		}
	}

	
}

