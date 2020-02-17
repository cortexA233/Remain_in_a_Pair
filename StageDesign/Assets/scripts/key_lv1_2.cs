using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class key_lv1_2 : MonoBehaviour
{
    public Sprite s1, s2;
    SpriteRenderer spr;
    // Start is called before the first frame update
    void Start()
    {
        spr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit2D ray_switch = Physics2D.Raycast(new Vector2(transform.position.x, transform.position.y + 1f), new Vector2(transform.position.x, transform.position.y + 150f), 1.5f);
        if (ray_switch.collider != null && (ray_switch.collider.tag == "p1" || ray_switch.collider.tag == "p2"))
        {
            spr.sprite = s2;
            glob.gate_2 = 1;
        }
        else
        {
            spr.sprite = s1;
            glob.gate_2 = 0;
        }
    }
}
