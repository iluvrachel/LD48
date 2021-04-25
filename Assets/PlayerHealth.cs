using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{

    public Slider P1_healthbar;
    public Slider P2_healthbar;

    private GameObject foreground1;
    private GameObject foreground2;
    private GameObject background1;
    private GameObject background2;
   
    // Start is called before the first frame update
    void Start()
    {
       foreground1 = GameObject.Find("Fill1");
       foreground2 = GameObject.Find("Fill2");
       background1 = GameObject.Find("Background1");
       background2 = GameObject.Find("Background2");
       
    }

    void Awake()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(P1_healthbar.value<=0)
        {
            foreground1.SetActive(false);
        }
        else
        {
            foreground1.SetActive(true);
        }

        if(P2_healthbar.value<=0)
        {
            foreground2.SetActive(false);
        }
        else
        {
            foreground2.SetActive(true);
        }

    }

    void OnCollisionEnter2D(Collision2D other) 
    {


    }

    private void Die()
    {

    }
}