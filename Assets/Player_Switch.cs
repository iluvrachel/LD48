using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player_Switch : MonoBehaviour
{
    GameObject P0;
    GameObject P1;
    GameObject P2;

    // GameObject P;

    // Start is called before the first frame update
    void Start()
    {
        P0 = GameObject.Find("P0");
        P1 = GameObject.Find("P1");
        P2 = GameObject.Find("P2");
        // P = GameObject.Find("P");

        P1.GetComponent<PlayerController>().enabled = false;
        P1.GetComponent<Rigidbody2D>().gravityScale = 0f;
        P2.GetComponent<PlayerController>().enabled = false;
        P2.GetComponent<Rigidbody2D>().gravityScale = 0f;
        // P.GetComponent<PlayerController>().enabled = false;
        // P.GetComponent<Rigidbody2D>().gravityScale = 0f;

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.I))
        {
            // l0 jump to l1
            if(P1.GetComponent<PlayerController>().enabled==false && P2.GetComponent<PlayerController>().enabled==false && !Hit_the_ground.game_over_flag)
            {
                //print(Hit_the_ground.game_over_flag);
                if(Hit_the_ground.game_over_flag) // game over, press i to restart
                {
                    SceneManager.LoadScene("SampleScene");
                }
                P1.GetComponent<PlayerController>().enabled = true;
                P1.GetComponent<Rigidbody2D>().gravityScale = 50f; 
                P1.GetComponent<Rigidbody2D>().drag = 0f; 
                P1.transform.position = new Vector2(-678f,300f);


                P0.GetComponent<Rigidbody2D>().gravityScale = 1f; 
                P0.GetComponent<Rigidbody2D>().drag = 50f; 
                P0.GetComponent<PlayerController>().enabled = false;
            }
            // l1 jump to l2
            else if(P0.GetComponent<PlayerController>().enabled==false && P2.GetComponent<PlayerController>().enabled==false && !Hit_the_ground.game_over_flag)
            {
                //print(Hit_the_ground.game_over_flag);
                P2.GetComponent<PlayerController>().enabled = true;
                P2.GetComponent<Rigidbody2D>().gravityScale = 50f; 
                P2.GetComponent<Rigidbody2D>().drag = 0f; 
                P2.transform.position = new Vector2(-1886f,372f);


                P1.GetComponent<Rigidbody2D>().gravityScale = 1f; 
                P1.GetComponent<Rigidbody2D>().drag = 50f; 
                P1.GetComponent<PlayerController>().enabled = false;
            }

            // l2 to hidden place
            else if(P2.GetComponent<PlayerController>().enabled==true)
            {
                print("!!!");
                SceneManager.LoadScene("TrueEnd");
            }

        }
    }
}
