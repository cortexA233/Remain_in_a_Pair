using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class winning_flag : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (glob.win_flag >= 2)
        {
            glob.win_flag = 0;
            SceneManager.LoadScene("stage2");
        }
    }
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.collider.tag == "p1" || col.collider.tag == "p2") 
        {
            if (col.collider.tag == "p1")
            {
                col.collider.GetComponent<player_control_1>().enabled = false;
            }
            if (col.collider.tag == "p2")
            {
                col.collider.GetComponent<player_control_2>().enabled = false;
            }
            ++glob.win_flag;
        }
    }
}
