using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene2 : MonoBehaviour
{
    public void ChangeSceneBts()
    {
        SceneManager.LoadScene("GameScene"); // ���Ӿ��� �ε��Ѵ�.
    }
    public void ChangeSceneBts2()
    {
        SceneManager.LoadScene("ShopScene"); // ���Ӿ��� �ε��Ѵ�.
    }
}
