using UnityEditor;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    public void OnClickStart()
    {
    }

    public void ClickOnQuit()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#endif
        Application.Quit();
    }
}