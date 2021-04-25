using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class wakeup : MonoBehaviour
{
    private int i = 0;
    public Text text;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(i>0 && i < 25)
        {
            i++;
            this.transform.localScale = new Vector3(i,i,i);
        }
        
    }

    void OnCollisionEnter2D(Collision2D other) 
    {
        if(other.gameObject.tag=="Finish")
        {
            text.text = "Welcome back to reality.";
            Destroy(other.gameObject);
            i = 1;
        }

    }
}
