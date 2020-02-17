using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gate_lv1_first : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (glob.gate_1==1 || glob.gate_2==1)
        {
            GetComponent<Rigidbody2D>().velocity= new Vector2(0, 4f);
        }
        else
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, -4f);
        }
    }
}
