using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class start : MonoBehaviour
{
    public Sprite s1, s2;
    int sta = 1;
    SpriteRenderer spr;
    // Start is called before the first frame update
    void Start()
    {
        spr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (sta == 1)
        {
            spr.sprite = s1;
        }
        else
        {
            spr.sprite = s2;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (sta == 1)
            {
                sta = 2;
            }
            else
            {
                sta = 1;
            }
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene("stage1");
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("start");
        }
    }
}
