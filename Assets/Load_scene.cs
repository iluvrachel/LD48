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
    }

    public void LoadGame()
    {
        if(Input.GetKeyDown(KeyCode.I))
        {
            Time.timeScale = 1f;
            SceneManager.LoadScene("SampleScene");
        }
        
    }
}
