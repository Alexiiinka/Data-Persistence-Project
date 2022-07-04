using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
# if UNITY_EDITOR
using UnityEditor;
# endif

public class UIMenu : MonoBehaviour
{
    public void StartButt()
    {
        SceneManager.LoadScene(1);
    } 

    public void ExitButt()
    {
        MenuManager.Instance.DataSaveFunkcion();
    # if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
    # else
        Application.Quit();
    # endif
    }

    public void MenuButt()
    {
        SceneManager.LoadScene(0);
    }
}
