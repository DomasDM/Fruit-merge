using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private string inthecloud = "y";
    private string timetocheck = "n";
    void Start()
    {
        if (transform.position.y < 3.5)
        {
            inthecloud = "n";
            GetComponent<Rigidbody2D>().gravityScale = 1;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (inthecloud=="y")
        {
            GetComponent<Transform>().position = cloundcont.cloudxPos;
        }
        if(Input.GetKeyDown("space"))
        {

            GetComponent<Rigidbody2D>().gravityScale = 1;

            inthecloud = "n";
            StartCoroutine(chkGameOver());



        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == gameObject.tag)
        {
            cloundcont.spawnPos = transform.position;
            cloundcont.newfruit = "y";
            cloundcont.whichFruit = int.Parse(gameObject.tag);
            Destroy(gameObject);
        }
    }
    private void OnTriggerStay2D(Collider2D other)
    {
        if ((other.gameObject.name=="LIMIT")&& (timetocheck == "y"))
        {
            Debug.Log("game over");
        }
    }


    IEnumerator chkGameOver()
    {
        yield return new WaitForSeconds(.75f);
        timetocheck = "y";
    }

}
