using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Diologue : MonoBehaviour
{
    public string[] diologues = null;
    public bool next;
    public int index = 0;
    public Text text;
   

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            next = true;
        }
        if (diologues != null)
        {
            TextUpdate();
        }
    }
    void TextUpdate() 
    {
        text.text = diologues[index];
        if (next)
        {
            next = false;
            if (index < diologues.Length) 
            { 
                index++;
            }
            if (index == diologues.Length)
            {
                TextControler.instance.FinishDiolog();
            }
        }
        
    }
}
