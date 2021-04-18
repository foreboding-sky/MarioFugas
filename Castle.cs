using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Castle : MonoBehaviour 
{
	[SerializeField] private string sceneName;

	void OnCollisionEnter2D(Collision2D other) 
	{
		SceneManager.LoadScene(sceneName);
	}
}
