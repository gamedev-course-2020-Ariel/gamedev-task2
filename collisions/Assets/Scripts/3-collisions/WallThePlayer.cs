using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallThePlayer : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        //GameObject.FindGameObjectWithTag("Player").GetComponent<KeyboardMover>().enabled = true;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            GameObject.FindGameObjectWithTag("Player").GetComponent<KeyboardMover>().enabled = false;
            if(this.gameObject.tag == "DownWall")
            {
                other.GetComponent<Transform>().position += new Vector3(0,0.3f,0);
            } else if(this.gameObject.tag == "UpWall") {
                other.GetComponent<Transform>().position += new Vector3(0,-0.3f, 0);
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        GameObject.FindGameObjectWithTag("Player").GetComponent<KeyboardMover>().enabled = true;
    }


}
