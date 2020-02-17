using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//砖块厚度需要调整！

public class fire_spark : MonoBehaviour
{
    float fire_rate;
    int fire_status;
    SpriteRenderer spr;
    Animator ani;
    // Start is called before the first frame update
    void Start()
    {
        ani = GetComponent<Animator>();
        spr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        fire_rate += Time.deltaTime;
        if (fire_rate >= 2f)
        {
            if (fire_status == 1)
            {
                spr.enabled = false;
                ani.enabled = false;
                fire_status = 0;
                fire_rate = 0;
            }
            else
            {
                spr.enabled = true;
                ani.enabled = true;
                fire_status = 1;
                fire_rate = 0;
            }
        }
        if (fire_status == 1)
        {
            RaycastHit2D ray_fire = Physics2D.Raycast(new Vector2(transform.position.x, transform.position.y + 0.5f), new Vector2(transform.position.x, transform.position.y + 2f), 1.5f);
            if (ray_fire.collider != null)
            {
                Debug.Log(ray_fire.collider.tag);
            }
            if (ray_fire.collider != null && (ray_fire.collider.tag == "p1" || ray_fire.collider.tag == "p2")) 
            {
                glob.is_die = 1;
                Debug.Log("die!!!!");
            }
        }
    }/*
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.collider.tag == "p1" || col.collider.tag == "p2")
        {
          //  if (fire_status == 1)
            {
                glob.is_die = 1;
                Debug.Log("die!!!");
            }
            
        }   
    }*/
}
