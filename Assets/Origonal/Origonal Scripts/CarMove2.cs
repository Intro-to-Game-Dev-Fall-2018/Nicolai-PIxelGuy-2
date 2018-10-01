using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMove2 : MonoBehaviour
{

	private Rigidbody2D Car;
	public float speed;
	public int OrgPos = 0;


	// Use this for initialization
	void Start()
	{
		Car = GetComponent<Rigidbody2D>();
	}

	// Update is called once per frame
	void Update()
	{
		Car.AddRelativeForce(Vector2.left * speed);
	}


	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.CompareTag("Wall"))
		{
			transform.position = new Vector3(OrgPos,transform.position.y,transform.position.z);
		}
            
	}


}