using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoChasing : MonoBehaviour
{
    private float moveSpeed = 50f;
    // public GameObject gameObject;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 diff = GameObject.FindGameObjectWithTag("P2").transform.position - transform.position;
        diff.Normalize();

        float rot_z = Mathf.Atan2(diff.y, diff.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, rot_z - 90);

        if(GameObject.FindGameObjectWithTag("P2").transform.position.x < transform.position.x)
        transform.Translate(Vector2.up * moveSpeed * -1 * Time.deltaTime);
        else
        transform.Translate(Vector2.up * moveSpeed * Time.deltaTime);
    }
}
