using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Troca : MonoBehaviour
{
	public string str;
	public bool change;
	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.tag == "Player") 
		{
			SceneManager.LoadScene(str);	
		}
	}
}
