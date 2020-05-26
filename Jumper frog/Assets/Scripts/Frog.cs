using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Frog : MonoBehaviour
{
    [SerializeField] float speed = 8;
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = this.gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        anim.SetTrigger("Idle");
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            anim.SetTrigger("Jump");
            transform.position += (Vector3.back) * Time.deltaTime * speed;
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.position += (Vector3.right) * Time.deltaTime * speed;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.position += (Vector3.left) * Time.deltaTime * speed;
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "vehicle")
        {
            Debug.Log("You died!");
            Destroy(this.gameObject);
            var arr1 = GameObject.FindGameObjectsWithTag("spawner");
            for (int i = 0; i < arr1.Length; i++)
            {
                Destroy(arr1[i]);

            }
        }
        else if (other.gameObject.tag == "Trees")
        {
            Debug.Log("You tuch the tree. \nSpawner will destroyed!");
            var arr2 = GameObject.FindGameObjectsWithTag("spawner");
            for (int i = 0; i < arr2.Length; i++)
            {
                Destroy(arr2[i]);
            }

        }
    }
}
