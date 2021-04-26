using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Load_scene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        LoadGame();
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

    public void LoadGame()
    {
        if(Hit_the_ground.game_over_flag && Input.GetKeyDown(KeyCode.I))
        {
            Time.timeScale = 1f;
            SceneManager.LoadScene("SampleScene");
        }
        
    }
}
