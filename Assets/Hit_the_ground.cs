using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit_the_ground : MonoBehaviour
{

    public static bool game_over_flag = false;

    public GameObject C0;
    public GameObject C1;
    public GameObject C2;
    public GameObject P0;
    public GameObject P1;
    public GameObject P2;

    // Start is called before the first frame update
    void Start()
    {
        // C0 = GameObject.Find("C0");
        // C1 = GameObject.Find("C1");
        // C2 = GameObject.Find("C2");
        // P0 = GameObject.Find("P0");
        // P1 = GameObject.Find("P1");
        // P2 = GameObject.Find("P2");
        Time.timeScale = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D other) 
    {
        if(other.gameObject.tag=="Player")
        {
            // l2 to l1
            if(this.tag == "L2")
            {
                //print(C1.activeInHierarchy);
                if(C2.activeInHierarchy==true)
                {
                    C1.SetActive(true);
                    C2.SetActive(false);

                    P1.GetComponent<PlayerController>().enabled = true;
                    P1.GetComponent<Rigidbody2D>().gravityScale = 1f; 
                    P1.GetComponent<Rigidbody2D>().drag = 0f; 

                    P2.GetComponent<Rigidbody2D>().gravityScale = 0.01f; 
                    P2.GetComponent<Rigidbody2D>().drag = 1f; 
                    P2.GetComponent<PlayerController>().enabled = false;

                    P0.GetComponent<Rigidbody2D>().gravityScale = 0.01f; 
                    P0.GetComponent<Rigidbody2D>().drag = 1f; 
                    P0.GetComponent<PlayerController>().enabled = false;  
                }

            }

            // l1 to l0
            else if(this.tag == "L1")
            {
                if(C1.activeInHierarchy==true)
                {
                    C0.SetActive(true);
                    C1.SetActive(false);

                    P0.GetComponent<PlayerController>().enabled = true;
                    P0.GetComponent<Rigidbody2D>().gravityScale = 1f; 
                    P0.GetComponent<Rigidbody2D>().drag = 0f; 

                    P1.GetComponent<Rigidbody2D>().gravityScale = 0.01f; 
                    P1.GetComponent<Rigidbody2D>().drag = 1f; 
                    P1.GetComponent<PlayerController>().enabled = false;

                    P2.GetComponent<Rigidbody2D>().gravityScale = 0.01f; 
                    P2.GetComponent<Rigidbody2D>().drag = 1f; 
                    P2.GetComponent<PlayerController>().enabled = false;
                }
                else if(C2.activeInHierarchy==true)
                {
                    C0.SetActive(true);
                    C2.SetActive(false);

                    P0.GetComponent<PlayerController>().enabled = true;
                    P0.GetComponent<Rigidbody2D>().gravityScale = 1f; 
                    P0.GetComponent<Rigidbody2D>().drag = 0f; 

                    P1.GetComponent<Rigidbody2D>().gravityScale = 0.01f; 
                    P1.GetComponent<Rigidbody2D>().drag = 1f; 
                    P1.GetComponent<PlayerController>().enabled = false;

                    P2.GetComponent<Rigidbody2D>().gravityScale = 0.01f; 
                    P2.GetComponent<Rigidbody2D>().drag = 1f; 
                    P2.GetComponent<PlayerController>().enabled = false;                    
                }

            }
            // l0 to over
            else if(this.tag == "L0")
                {
                    // game over
                    C0.SetActive(true);
                    C1.SetActive(false);
                    C2.SetActive(false);


                    Time.timeScale = 0.05f; //slow motion
                    Time.fixedDeltaTime = 0.02F*Time.timeScale; // frame smooth
                    game_over_flag =true;
                }
        }
    }
}
