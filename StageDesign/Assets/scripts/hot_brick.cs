using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hot_brick : MonoBehaviour
{
    float ray_height = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*
        glob.mag_disappear_time_1 += Time.deltaTime;
        glob.mag_disappear_time_2 += Time.deltaTime;
        if (glob.mag_disappear_time_1 >= 5f)
        {
            glob.mag_rate_1 = 1f;
        }
        if (glob.mag_disappear_time_2 >= 5f)
        {
            glob.mag_rate_2 = 1f;
        }*/
        glob.mag_disappear_time += Time.deltaTime;
        if (glob.mag_disappear_time >= 5f)
        {
           
            glob.mag_rate = 1f;
        }
        RaycastHit2D r1, r2, r3;
        //ZGY：transform.position.y + 1f 待定？
        r2 = Physics2D.Raycast(new Vector2(transform.position.x, transform.position.y + 1f), new Vector2(transform.position.x, transform.position.y + 150f),ray_height);
        if (r2.collider != null)
        {
            /*
            if(r2.collider.tag == "p1")
            {
                glob.mag_rate_1 = 0;
                glob.mag_disappear_time_1 = 0f;
            }*/
            Debug.Log(r2.collider.tag);
            if (r2.collider.tag == "p1"|| r2.collider.tag == "p2")
            {             
                glob.mag_rate = 0;
                glob.mag_disappear_time = 0;
            }
        }
    }
}
