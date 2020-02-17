using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class staff : MonoBehaviour
{
    public Sprite[] ppt=new Sprite[3];
    int bis = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.gameObject.GetComponent<SpriteRenderer>().sprite = ppt[bis];
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (bis < 2)
            {
                ++bis;
            }
            else
            {
                bis = 0;
            }
        }
    }
}
