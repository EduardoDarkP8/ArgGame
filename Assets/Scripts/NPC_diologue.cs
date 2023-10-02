using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC_diologue : MonoBehaviour
{
    Transform player;
    public string[] text;
    bool entry;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
		if (Vector3.Distance(transform.position, player.position) < 2f) 
        {
            entry = true;
            player.Find("PressButton").gameObject.SetActive(true);
            if (Input.GetButtonDown("Jump")) 
            {
                player.Find("PressButton").gameObject.SetActive(false);
                TextControler.instance.StartDiolog(text);
                Destroy(this);
            }
        }
        else if(entry)
        {
            player.Find("PressButton").gameObject.SetActive(false);
            entry = false;
        }
    }
}
