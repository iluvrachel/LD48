using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D m_rg;
    public float MoveSpeed = 5.0f;
    Vector2 m_scale;
    // public float Gravity = 1;
    private Rigidbody2D rb;
    private SpriteRenderer sr;
    private ParticleSystem ps;

    public Slider healthBar;
    public Slider charge_target_healthBar;
    
    // Start is called before the first frame update
    void Start()
    {
        m_rg = gameObject.GetComponent<Rigidbody2D>();
        m_scale = transform.localScale;
        rb = gameObject.GetComponent<Rigidbody2D>(); //Rigidbody of Player
        sr = gameObject.GetComponent<SpriteRenderer>(); 
        ps = gameObject.GetComponent<ParticleSystem>();
        ps.Stop();

        
    }

    void Awake()
    {
        if(healthBar!=null)
        {
            healthBar.value = healthBar.minValue;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxisRaw("Vertical") > 0)
        {
            m_rg.velocity = new Vector2(m_rg.velocity.x, MoveSpeed);
            //transform.localScale = new Vector2(m_scale.x, m_scale.y);
            if(healthBar!=null)
            {
                healthBar.value -= 0.1f;
            }
            
        }
        if (Input.GetAxisRaw("Vertical") < 0)
        {
            m_rg.velocity = new Vector2(m_rg.velocity.x, -MoveSpeed);
            //transform.localScale = new Vector2(m_scale.x, m_scale.y);
            if(healthBar!=null)
            {
                healthBar.value -= 0.1f;
            }
            
        }
        if (Input.GetAxisRaw("Horizontal") > 0)
        {
            m_rg.velocity = new Vector2(MoveSpeed, m_rg.velocity.y);
            //transform.localScale = new Vector2(m_scale.x, m_scale.y);
            if(healthBar!=null)
            {
                healthBar.value -= 0.1f;
            }
            
        }
        if (Input.GetAxisRaw("Horizontal") < 0)
        {
            m_rg.velocity = new Vector2(-MoveSpeed, m_rg.velocity.y);
            //transform.localScale = new Vector2(m_scale.x, m_scale.y);
            if(healthBar!=null)
            {
                healthBar.value -= 0.1f;
                if (healthBar.value <= 0)
                {
                    Die();
                }
            }
            
        }
    }

    void FixedUpdate() 
    {
        // rb.AddForce(new Vector3(0, -9.81f, 0));
    }

    void OnCollisionEnter2D(Collision2D other) 
    {
        if(other.gameObject.tag=="Enemy")
        {
            // healthBar.value += 15f;   
            // PlayerHealth.P1_hit = true;
            if(charge_target_healthBar!=null)
            {
                charge_target_healthBar.value += 25f;
            }

        }
        if(other.gameObject.tag=="Creeper")
        {
            ps.Play();
            sr.enabled = false;
            Hit_the_ground.game_over_flag = true;
            // TODO: destroy player

        }
        // if(other.gameObject.tag=="Purple")
        // {
        //     Vector3 direction = new Vector3(UnityEngine.Random.Range(0f,1f),UnityEngine.Random.Range(0f,1f),UnityEngine.Random.Range(0f,1f));
        //     rb.AddForce(direction*UnityEngine.Random.Range(100f,200f));
        //     CameraRig.isHit = true;

        // }
        // if(other.gameObject.tag=="Healer")
        // {

        //     healthBar.value = healthBar.maxValue;   
        //     CameraRig.isHit = true;

        // }

    }

    private void Die()
    {

        // stay still
        rb.velocity = Vector2.zero;
        gameObject.GetComponent<PlayerController>().enabled = false;

        //transform.position = finalPos;
        

        //Destroy(gameObject);
    }
}
