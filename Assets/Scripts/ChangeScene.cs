using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public void ChangeSceneBts()
    {
        SceneManager.LoadScene("StartScene1"); // 게임씬을 로드한다.
    }

}
