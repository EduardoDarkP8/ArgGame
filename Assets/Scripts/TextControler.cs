using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextControler : MonoBehaviour
{

    public static TextControler instance;
    GameObject textBox;
    GameObject player;
    Diologue diologue;
    void Awake()
    {
        instance = this;
        player = GameObject.FindGameObjectWithTag("Player");
        textBox = GameObject.FindGameObjectWithTag("textBox");
        diologue = textBox.GetComponent<Diologue>();
        FinishDiolog();
    }

    public void StartDiolog(string[] text) 
    {
        diologue.index = 0;
        player.GetComponent<PlayerMovement>().enabled = false;
        textBox.SetActive(true);
        diologue.diologues = text;
    }
    public void FinishDiolog() 
    {
        player.GetComponent<PlayerMovement>().enabled = true;
        diologue.diologues = null;
        diologue.text.text = "";
        textBox.SetActive(false);
    }

}
