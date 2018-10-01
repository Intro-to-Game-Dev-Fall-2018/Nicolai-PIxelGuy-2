using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P1Score : MonoBehaviour
{

	public GameObject Score0;
	public GameObject Score1;
	public GameObject Score2;
	public GameObject Score3;
	public GameObject Score4;
	public GameObject Score5;
	int Num = 0;

	// Use this for initialization
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
		if (Num == 0)
		{
			Score0.SetActive(true);
			Score1.SetActive(false);
			Score2.SetActive(false);
			Score3.SetActive(false);
			Score4.SetActive(false);
			Score5.SetActive(false);
		}

		if (Num == 1)
		{
			Score0.SetActive(false);
			Score1.SetActive(true);
			Score2.SetActive(false);
			Score3.SetActive(false);
			Score4.SetActive(false);
			Score5.SetActive(false);
		}
		
		if (Num == 2)
		{
			Score0.SetActive(false);
			Score1.SetActive(false);
			Score2.SetActive(true);
			Score3.SetActive(false);
			Score4.SetActive(false);
			Score5.SetActive(false);
		}
		
		if (Num == 3)
		{
			Score0.SetActive(false);
			Score1.SetActive(false);
			Score2.SetActive(false);
			Score3.SetActive(true);
			Score4.SetActive(false);
			Score5.SetActive(false);
		}
		
		if (Num == 4)
		{
			Score0.SetActive(false);
			Score1.SetActive(false);
			Score2.SetActive(false);
			Score3.SetActive(false);
			Score4.SetActive(true);
			Score5.SetActive(false);
		}
		
		if (Num == 5)
		{
			Score0.SetActive(false);
			Score1.SetActive(false);
			Score2.SetActive(false);
			Score3.SetActive(false);
			Score4.SetActive(false);
			Score5.SetActive(true);
		}
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		Num = Num + 1;
		//print(Num);
	}
}