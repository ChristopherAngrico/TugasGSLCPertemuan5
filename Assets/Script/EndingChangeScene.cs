using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndingChangeScene : MonoBehaviour
{
    private GameObject AfterEndingChangeScene;
    private ChangeScene ChangeTheScene;
    void Awake()
    {
        AfterEndingChangeScene =  GameObject.Find("ChangeScene");
        ChangeTheScene = AfterEndingChangeScene.GetComponent<ChangeScene>();
    }

    void Start(){
        Invoke(nameof(ChangeTheSceneAfterEnding),10f);
    }
    void ChangeTheSceneAfterEnding(){
        ChangeTheScene.ChangeSceneScript("MainMenuScene");
    }
}
