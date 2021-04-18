using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
	HudManager hudManager;
	void Start()
	{
		hudManager = FindObjectOfType<HudManager>();
	}
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.tag == "Player")
		{
			hudManager.AddCoin();
			Destroy(gameObject);
		}
	}
}
