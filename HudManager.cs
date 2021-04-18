using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HudManager : MonoBehaviour
{
	public static HudManager instance = null;
	public Text scoreText;
	public Text coinText;

	public int coinBonus = 200;
	public int coins;
	public int scores;

	void Start()
	{
		if (instance == null)
		{
			instance = this;
		}
		else if (instance == this)
		{
			Destroy(gameObject);
		}
		DontDestroyOnLoad(gameObject);
		ResetHud();
	}
	public void ResetHud()
	{
		coins = 0;
		scores = 0;
	}
	public void AddCoin()
	{
		coins++;
		coinText.text = "x" + coins.ToString("D2");
		AddScore(coinBonus);
	}
	public void AddScore(int bonus)
	{
		scores += bonus;
		scoreText.text = scores.ToString("D6");
	}
}
