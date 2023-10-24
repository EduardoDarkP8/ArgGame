using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameChangeController : MonoBehaviour
{
    public bool closeGame;
	public bool startGame;
	public bool start;
	public Animator anim;
	private void Start()
	{
		anim = GetComponent<Animator>();

		if (start) 
		{
			anim.SetBool("IsTheStart", true);
		}
	}
	// Update is called once per frame
	void Update()
    {
		if (closeGame) 
		{
			Application.Quit();
		}
		if (startGame) 
		{
			
			SceneManager.LoadScene("Game");
			
		}
    }
}
