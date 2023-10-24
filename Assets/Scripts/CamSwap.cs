using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamSwap : MonoBehaviour
{
    GameObject cam;
    public bool animate =  true;
    void Start()
    {
        cam = GameObject.FindGameObjectWithTag("MainCamera");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player") 
        {
            cam.transform.position = transform.position;
            if(animate)
            collision.GetComponent<PlayerMovement>().follow.SetTrigger("Start");
        }
    }
}
