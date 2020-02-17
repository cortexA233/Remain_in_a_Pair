using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//砖块厚度需要调整！！！！！！！！！
public class swap_player : MonoBehaviour
{
    public GameObject new_player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.collider.tag == "p1")
        {
            new_player.tag = "p1";
            col.collider.tag = "used_player";
            col.collider.GetComponent<player_control_1>().enabled = false;
            new_player.GetComponent<player_control_1>().enabled = true;
        }
        if (col.collider.tag == "p2")
        {
            new_player.tag = "p2";
            col.collider.tag = "used_player";
            col.collider.GetComponent<player_control_2>().enabled = false;
            new_player.GetComponent<player_control_2>().enabled = true;
        }
    }
}
