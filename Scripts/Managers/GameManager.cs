using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Enums;

/// <summary>
/// ゲーム総合管理のシングルトンクラス
/// </summary>
public class GameManager : SingletonMonoBehaviour<GameManager>
{

    SceneState m_sceneState = new SceneState();


    AudioManager m_audioManager;


    private void Awake()
    {
        m_sceneState = SceneState.Title;


    }

    private void Start()
    {
        
    }

    private void Update()
    {
        
    }
}
