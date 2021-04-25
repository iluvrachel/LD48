using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game_Over : MonoBehaviour
{
    
    private GameObject gm;

    // Start is called before the first frame update
    void Start()
    {
        Hit_the_ground.game_over_flag = false;
        gm = transform.Find("GameOver").gameObject;
        gm.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Hit_the_ground.game_over_flag)
        {
            print("over");
            gm.SetActive(true);
        }
    }
}
