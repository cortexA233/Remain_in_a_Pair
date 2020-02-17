using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class key : MonoBehaviour
{
    float door_speed = 4f;
    public GameObject door;
    Rigidbody2D rig_door;
    public int dir;//开门方向，1表示门向上打开，2表示向下打开，3表示向左打开，4表示向右打开
    public Sprite key_normal, key_pass;
    SpriteRenderer spr;
    // Start is called before the first frame update
    void Start()
    {
        rig_door = door.GetComponent<Rigidbody2D>();
        spr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit2D ray_switch = Physics2D.Raycast(new Vector2(transform.position.x, transform.position.y + 1f), new Vector2(transform.position.x, transform.position.y + 150f), 1.5f);
        if (ray_switch.collider != null)
        {
            Debug.Log(ray_switch.collider.tag);
        }
        if (ray_switch.collider != null && (ray_switch.collider.tag == "p1" || ray_switch.collider.tag == "p2")) 
        {
            spr.sprite = key_pass;
            if (dir == 1)
            {
                rig_door.velocity = new Vector2(0, door_speed);
            }
            if (dir == 2)
            {
                rig_door.velocity = new Vector2(0, -door_speed);
            }
            if (dir == 3)
            {
                rig_door.velocity = new Vector2(-door_speed, 0);
            }
            if (dir == 4)
            {
                rig_door.velocity = new Vector2(door_speed, 0);
            }
        }
        else
        {
            spr.sprite = key_normal;
            if (dir == 1)
            {
                rig_door.velocity = new Vector2(0, -door_speed);
            }
            if (dir == 2)
            {
                rig_door.velocity = new Vector2(0, door_speed);
            }
            if (dir == 3)
            {
                rig_door.velocity = new Vector2(door_speed, 0);
            }
            if (dir == 4)
            {
                rig_door.velocity = new Vector2(-door_speed, 0);
            }
        }
    }
}
