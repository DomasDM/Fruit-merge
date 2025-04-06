using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cloundcont : MonoBehaviour
{
    public Transform[] fruit;
    static public string spawnedYet = "n";
    static public Vector2 cloudxPos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        spawnFruit();
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

        cloudxPos = transform.position;
    }

    void spawnFruit()
    { 
        if (spawnedYet=="n")
        {
            StartCoroutine(spawntimer());

            spawnedYet = "y";
        }
    }
    IEnumerator spawntimer()
    {
        yield return new WaitForSeconds(.75f);
        Instantiate(fruit[Random.Range(0, 6)], transform.position, fruit[0].rotation);
    }
}
