using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public void ChangeScene(int changeScene)
    {
       SceneManager.LoadScene(changeScene);
    }
}
