using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public GameObject enemy;
    public GameObject creeper;
    public GameObject purple;
    public GameObject healer;
    //public GameObject enemy;

    private float distance;
    private float distanceUsed;

    // Start is called before the first frame update
    void Start()
    {
        print(this.transform.localPosition);
    }

    // Update is called once per frame
    void Update()
    {
        // if (distance < transform.position.x + 20)
        // {
        //     distance = transform.position.x + 20;
        // }

        // float distToGo = Mathf.Floor(distance - distanceUsed);

        // if (distanceUsed < distance && distToGo > 0.6f)
        // {
        //     distanceUsed = distance;
        //     Spawn();
        // }
        if(UnityEngine.Random.Range(0f,1f)<0.01)
        {
            if(!Hit_the_ground.game_over_flag)
            {
                Spawn();
            }
            
        }
        
    }

    private void Spawn()
    {
        GameObject enemyToSpawn = enemyType();
        float yPos = UnityEngine.Random.Range(-4.8f,4.8f);
        float xPos = UnityEngine.Random.Range(-10f,10f);
        Vector3 posToSpawnEnemy = new Vector3(this.transform.position.x + xPos,this.transform.position.y + yPos,0f);
        Instantiate(enemyToSpawn,posToSpawnEnemy,Quaternion.identity);
    }

    private GameObject enemyType()
    {
        float rand = UnityEngine.Random.Range(0f,1f);
        if(rand>0.25f)
        {
            return enemy;
        }
        else if(rand>0.1f)
        {
            return purple;
        }
        else if(rand>0.05f)
        {
            return creeper;
        }
        else
        {
            return healer;
        }
    }
}
