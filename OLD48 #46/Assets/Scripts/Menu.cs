using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public Texture2D cursorTexture;
    private void Awake()
    {
        Cursor.SetCursor(cursorTexture, new Vector2(10, 10), CursorMode.ForceSoftware);
    }

    private void Start()
    {
        Cursor.SetCursor(cursorTexture, new Vector2(10, 10), CursorMode.ForceSoftware);
    }

    public void StartGame()
    {
        Cursor.SetCursor(cursorTexture, new Vector2(10, 10), CursorMode.ForceSoftware);
        SceneManager.LoadScene(1);
    }

}
