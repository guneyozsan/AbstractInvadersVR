using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class ReloadLevel : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("Game");

        }
    }
}