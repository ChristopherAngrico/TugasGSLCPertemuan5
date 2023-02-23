using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public void ChangeSceneScript(string nameScene) {
        SceneManager.LoadScene(nameScene);
    }
}
