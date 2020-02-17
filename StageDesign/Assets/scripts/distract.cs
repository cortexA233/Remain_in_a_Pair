using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class distract : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(glob.mag_rate);
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "p1"||col.gameObject.tag=="p2")
        {
            if (glob.mag_rate == -1f)
            {
                glob.mag_rate = 1f;
            }
            else
            {
                glob.mag_rate = -1f;
            }
        }
    }
}
