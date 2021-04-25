using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cam_Controller : MonoBehaviour
{
    GameObject C0;
    GameObject C1;
    GameObject C2;

    public GameObject I0;
    public GameObject I1;
    public GameObject I2;

    // Start is called before the first frame update
    void Start()
    {
        C0 = GameObject.Find("C0");
        C1 = GameObject.Find("C1");
        C2 = GameObject.Find("C2");

        C1.SetActive(false);
        C2.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.I))
        {
            // l0 jump to l1
            if(C1.activeInHierarchy==false && C2.activeInHierarchy==false)
            {
                C1.SetActive(true);
                C0.SetActive(false);
            }
            // l1 jump to l2
            else if(C0.activeInHierarchy==false && C2.activeInHierarchy==false)
            {
                C2.SetActive(true);
                C1.SetActive(false);
            }
            // else if(C1.activeInHierarchy==false)
            // {
            //     C1.SetActive(true);
            //     C2.SetActive(false);
            // }
        }

        if(C0.activeInHierarchy==true)
        {
            I0.transform.localScale = new Vector3(1.2f,1.2f,1.2f); 
            I1.transform.localScale = new Vector3(1.0f,1.0f,1.0f);
            I2.transform.localScale = new Vector3(1.0f,1.0f,1.0f);
        }
        else if(C1.activeInHierarchy==true)
        {
            I1.transform.localScale = new Vector3(1.2f,1.2f,1.2f); 
            I0.transform.localScale = new Vector3(1.0f,1.0f,1.0f);
            I2.transform.localScale = new Vector3(1.0f,1.0f,1.0f);
        }
        else if(C2.activeInHierarchy==true)
        {
            I2.transform.localScale = new Vector3(1.2f,1.2f,1.2f); 
            I1.transform.localScale = new Vector3(1.0f,1.0f,1.0f);
            I0.transform.localScale = new Vector3(1.0f,1.0f,1.0f);
        }
    }
}
