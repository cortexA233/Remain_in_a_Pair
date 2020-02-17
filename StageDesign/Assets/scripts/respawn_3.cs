using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class respawn_3 : MonoBehaviour
{
    float rx1, rx2, ry1, ry2, rx3, ry3, rx4, ry4;
    GameObject p1, p2;
    public GameObject p3, p4;
    public AudioClip deadAudio;
    // Start is called before the first frame update
    void Start()
    {
        p1 = GameObject.FindGameObjectWithTag("p1");
        p2 = GameObject.FindGameObjectWithTag("p2");
        rx1 = p1.transform.position.x;
        ry1 = p1.transform.position.y;
        rx2 = p2.transform.position.x;
        ry2 = p2.transform.position.y;
        if (p3 != null)
        {
            rx3 = p3.transform.position.x;
            ry3 = p3.transform.position.y;
        }
        if (p4 != null)
        {
            rx4 = p4.transform.position.x;
            ry4 = p4.transform.position.y;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            relive();
        }
        if (glob.is_die == 1)
        {

            AudioManager.instance.AudioPlay(deadAudio);
            glob.is_die = 0;
            relive();
        }
    }
    void relive()
    {
        glob.win_flag = 0;
        p1.tag = "p1";
        p2.tag = "p2";
        p1.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
        p2.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
        p1.transform.position = new Vector2(rx1, ry1);
        p2.transform.position = new Vector2(rx2, ry2);
        if (p3 != null)
        {
            p3.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
            p1.GetComponent<player_control_1>().enabled = true;
            p2.GetComponent<player_control_2>().enabled = true;
            p3.GetComponent<player_control_1>().enabled = false;
            p3.GetComponent<player_control_2>().enabled = false;
            p3.transform.position = new Vector2(rx3, ry3);
        }
        if (p4 != null)
        {
            p4.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
            p1.GetComponent<player_control_1>().enabled = true;
            p2.GetComponent<player_control_2>().enabled = true;
            p4.GetComponent<player_control_1>().enabled = false;
            p4.GetComponent<player_control_2>().enabled = false;
            p4.transform.position = new Vector2(rx4, ry4);
        }
    }
}
