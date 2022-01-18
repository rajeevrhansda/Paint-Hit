using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitScript : MonoBehaviour
{
    public GameObject exitMenu;
    private void Awake()
    {
        exitMenu.gameObject.SetActive(false);

    }
    void Update()
    {
        if (Input.GetKey("escape"))
        {
            exitMenu.gameObject.SetActive(true);
        }
    }

    public void ExitGame()
    {
        Application.Quit();
    }
    public void HideExitMenu()
    {
        exitMenu.gameObject.SetActive(false);
    }
}
