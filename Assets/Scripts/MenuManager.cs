using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public TMP_InputField playerNameInput;

    public void OnClickStart()
    {
        string name = playerNameInput.text;
        PlayerPrefs.SetString("PlayerName",name);
        SceneManager.LoadScene("Gameplay");
    }

    public void ClickOnQuit()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#endif
        Application.Quit();
    }
}