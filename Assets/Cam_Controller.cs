using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam_Controller : MonoBehaviour
{
    GameObject C0;
    GameObject C1;
    GameObject C2;
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
    }
}
