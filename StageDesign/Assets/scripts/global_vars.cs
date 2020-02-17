using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class global_vars : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

public class glob
{
    //  public static float mag_rate_1 = 1f, mag_rate_2 = 1f;//磁力系数，分开算，废案
    //  public static float mag_disappear_time_1 = 0, mag_disappear_time_2 = 0;//同上
    public static float mag_rate = 1f;
    public static int gate_1 = 0, gate_2 = 0;//第一关双开关门专用变量
    public static float mag_disappear_time = 0;
    public static int is_die = 0;
    public static int win_flag = 0;
}
