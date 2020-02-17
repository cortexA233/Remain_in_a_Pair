using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class super_jump : MonoBehaviour
{
    int is_jump = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit2D ray_mag_jump = Physics2D.Raycast(new Vector2(transform.position.x, transform.position.y + 0.8f), new Vector2(transform.position.x, transform.position.y + 150f), 3f);
        if (ray_mag_jump.collider != null)
        {
            Debug.Log(ray_mag_jump.collider.tag);
        }
        if (ray_mag_jump.collider != null && (ray_mag_jump.collider.tag == "p1" || ray_mag_jump.collider.tag == "p2")) 
        {
            if (is_jump == 1)
            {
                Rigidbody2D rig = ray_mag_jump.collider.GetComponent<Rigidbody2D>();
                Debug.Log("!!!!");
                rig.velocity = new Vector2(rig.velocity.x, 0);
                rig.AddForce(new Vector2(0, 500f));
                is_jump = 0;
                Invoke("recov", 2f);
            }
            
        }
    }
    void recov()
    {
        is_jump = 1;
    }
}
