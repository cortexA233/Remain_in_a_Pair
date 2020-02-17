using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class start_UI : MonoBehaviour
{
    int option;
    float lx, ly;
    int fl = 1;
    // Start is called before the first frame update
    void Start()
    {
        lx = 3.755f;
        ly = 3.755f;
        option = 1;
    }

    // Update is called once per frame
    void Update()
    {

        if (fl == 1)
        {
            lx += 0.01f;
            ly += 0.01f;
        }
        if (fl == 0)
        {
            lx -= 0.01f;
            ly -= 0.01f;
        }
        if (lx >= 4f)
        {
            fl = 0;
        }
        if (lx <= 3f)
        {
            fl = 1;
        }
        transform.localScale = new Vector2(lx, ly);
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            if (option < 3)
            {
                ++option;
                transform.Translate(new Vector2(0, -3f));
            }
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (option > 1)
            {
                --option;
                transform.Translate(new Vector2(0, 3f));
            }
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (option == 1)
            {
                SceneManager.LoadScene("die_spark");
            }
            if (option == 2)
            {
                Application.Quit();
            }
            if (option == 3)
            {
                SceneManager.LoadScene("staff");
            }
        }
    }
}
