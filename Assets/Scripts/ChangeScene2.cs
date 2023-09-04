using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene2 : MonoBehaviour
{
    public void ChangeSceneBts()
    {
        SceneManager.LoadScene("GameScene"); // 게임씬을 로드한다.
    }
    public void ChangeSceneBts2()
    {
        SceneManager.LoadScene("ShopScene"); // 게임씬을 로드한다.
    }
}
