using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Audio管理のシングルトンクラス
/// </summary>
public class AudioManager : SingletonMonoBehaviour<AudioManager>
{
    AudioSource audioSource;

    private void Awake()
    {
        audioSource = this.GetComponent<AudioSource>();
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
