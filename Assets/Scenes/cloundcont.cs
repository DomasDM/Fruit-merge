using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cloundcont : MonoBehaviour
{
    public Transform[] fruit;
    static public string spawnedYet = "n";
    static public Vector2 cloudxPos;
    static public Vector2 spawnPos;
    static public string newfruit = "n";
    static public int whichFruit = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        spawnFruit();
        replaceFruit();
        if (Input.GetKey("a"))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(-2, 0);
        }

        if (Input.GetKey("d"))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(2, 0);
        }
        if ((!Input.GetKey("a")) && (!Input.GetKey("d")))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
        }

        if ((Input.GetKeyDown("space")) && (spawnedYet == "y"))
        {
            spawnedYet = "n";
        }


        if ((GetComponent<Rigidbody2D>().velocity.x<0) && (transform.position.x<-3))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
        }

        if ((GetComponent<Rigidbody2D>().velocity.x > 0) && (transform.position.x >3))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
        }

        cloudxPos = transform.position;
    }

   


void spawnFruit()
    { 
        if (spawnedYet=="n")
        {
            StartCoroutine(spawntimer());

            spawnedYet = "w";
        }
    }
    void replaceFruit()
    {
        if (newfruit == "y")
        {
            newfruit = "n";
            Instantiate(fruit[whichFruit + 1], spawnPos, fruit[0].rotation);
        }
    }
    IEnumerator spawntimer()
    {
        yield return new WaitForSeconds(.75f);
        Instantiate(fruit[Random.Range(0, 6)], transform.position, fruit[0].rotation);
        spawnedYet = "y";
    }
}
