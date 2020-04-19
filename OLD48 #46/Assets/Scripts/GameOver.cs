using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public static int collapsed;

    private void Start()
    {
        collapsed = 0;
    }

    private void Update()
    {
        if (collapsed >= 2)
            SceneManager.LoadScene(0);
    }

}
