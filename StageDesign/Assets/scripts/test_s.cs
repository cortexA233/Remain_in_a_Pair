using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test_s : MonoBehaviour
{
    public GameObject p1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2(p1.transform.position.x + 0.5f, p1.transform.position.y + 0.5f);
    }
}
