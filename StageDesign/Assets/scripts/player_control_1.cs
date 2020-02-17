using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_control_1 : MonoBehaviour
{
    GameObject p1, p2;
    public float character_thick;
    public float jump_height;
    public float running_speed;
    int is_ground = 1;
    Rigidbody2D rig;
    Animator anime;
    public AudioClip jumpAudio;
    // Start is called before the first frame update
    void Start()
    {
        p1 = this.gameObject;
        p2 = GameObject.FindGameObjectWithTag("p2");
        if (character_thick == 0)
        {
            character_thick = 0.5f;
        }
        if (jump_height == 0)
        {
            jump_height = 7f;
        }
        if (running_speed == 0)
        {
            running_speed = 5f;
        }
        is_ground = 1;
        rig = GetComponent<Rigidbody2D>();
        anime = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        character_move();
        attract();
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
      //  is_ground = 1; //ZGY:记得改回来

        if (col.collider.tag == "floor")
        {
            is_ground = 1;
        }
        if (col.collider.tag == "p2")
        {
            
            glob.is_die = 1;
        }
    }


    void character_move()
    {
        float h = Input.GetAxis("Horizontal");
        float lookat = 1;
        rig.velocity = new Vector2(0 + h * running_speed, rig.velocity.y);
        if (h < 0)
        {
            lookat = 0f;
        }
        else if (h == 0)
        {
        }
        else
        {
            lookat = 1f;
        }
        anime.SetFloat("LookX", lookat);
        anime.SetFloat("speed", Mathf.Abs(rig.velocity.x));
        if (Input.GetKeyDown(KeyCode.Space) && is_ground == 1)
        {
            Invoke("is_grond_recover", 8f);
            is_ground = 0;
            AudioManager.instance.AudioPlay(jumpAudio);
            rig.AddForce(new Vector2(0, jump_height * 50f));
        }
    }

    void attract()
    {
        RaycastHit2D r1 = Physics2D.Raycast(new Vector2(p1.transform.position.x + character_thick, p1.transform.position.y + 0.5f), new Vector2(p1.transform.position.x + 150f, p1.transform.position.y));
        RaycastHit2D r2 = Physics2D.Raycast(new Vector2(p1.transform.position.x - character_thick, p1.transform.position.y + 0.5f), new Vector2(p1.transform.position.x - 150f, p1.transform.position.y));
        if (r1.collider != null && (r1.collider.tag == "p2"))
        {
            rig.velocity = new Vector2(rig.velocity.x + 3f * glob.mag_rate, rig.velocity.y);
        }
        
        if (r2.collider != null && (r2.collider.tag == "p2"))
        {
            rig.velocity = new Vector2(rig.velocity.x - 3f * glob.mag_rate, rig.velocity.y);
        }
        
    }
    void is_grond_recover()
    {
        is_ground = 1;
    }
}
