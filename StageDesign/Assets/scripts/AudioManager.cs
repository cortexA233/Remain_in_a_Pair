using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 音效管理
/// </summary>
public class AudioManager : MonoBehaviour
{
    public static AudioManager instance { get; private set; } //跟UI一样使用单例模式

    private AudioSource audioSrc;
    // Start is called before the first frame update
    void Awake()
    {
        instance = this;
        audioSrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /// <summary>
    /// 播放指定音效
    /// </summary>
    /// <param name="clip"></param>
    public void AudioPlay(AudioClip clip)
    {
        audioSrc.PlayOneShot(clip);
    }
}
