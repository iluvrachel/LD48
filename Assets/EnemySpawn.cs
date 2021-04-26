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

    public float spawnTime = 3f;//生成时间间隔
    private float timer;//计时器

    // Start is called before the first frame update
    void Start()
    {
        timer = 0; //print(this.transform.localPosition);
    }

    // Update is called once per frame
    void FixedUpdate()
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
        // if(UnityEngine.Random.Range(0f,1f)<0.012f)
        // {
        //     if(!Hit_the_ground.game_over_flag)
        //     {
        //         Spawn();
        //     }
            
        // }
            if(!Hit_the_ground.game_over_flag)
            {
                OnStartSpawn();
            }
        
    }

    private void OnStartSpawn()
    {

        timer += Time.deltaTime;
        if(timer>=spawnTime)
        {//判断计时器时间是否到达
            timer = 0;

            float yPos = UnityEngine.Random.Range(-250f,250f);
            float xPos = UnityEngine.Random.Range(-500f,500f);
            Vector3 posToSpawnEnemy = new Vector3(this.transform.position.x + xPos,this.transform.position.y + yPos,0f);
            Instantiate(enemy,posToSpawnEnemy,Quaternion.identity);

            float rand = UnityEngine.Random.Range(0f,1f);

            
            if(rand<0.30f)
            {
                float yPos1 = UnityEngine.Random.Range(-250f,250f);
                float xPos1 = UnityEngine.Random.Range(-500f,500f);
                Vector3 posToSpawnEnemy1 = new Vector3(this.transform.position.x + xPos1,this.transform.position.y + yPos1,0f);
                Instantiate(creeper,posToSpawnEnemy1,Quaternion.identity);
            }
        }

    }

    // private void Spawn()
    // {
    //     GameObject enemyToSpawn = enemyType();
    //     float yPos = UnityEngine.Random.Range(-250f,250f);
    //     float xPos = UnityEngine.Random.Range(-500f,500f);
    //     Vector3 posToSpawnEnemy = new Vector3(this.transform.position.x + xPos,this.transform.position.y + yPos,0f);
    //     Instantiate(enemyToSpawn,posToSpawnEnemy,Quaternion.identity);
    // }

    // private GameObject enemyType()
    // {
    //     float rand = UnityEngine.Random.Range(0f,1f);
    //     // if(rand>0.25f)
    //     // {
    //     //     return enemy;
    //     // }
    //     // else if(rand>0.1f)
    //     // {
    //     //     return purple;
    //     // }
    //     // else if(rand>0.05f)
    //     // {
    //     //     return creeper;
    //     // }
    //     // else
    //     // {
    //     //     return healer;
    //     // }
    //     if(rand<0.10f)
    //     {
    //         return creeper;
    //     }
    // }
}
