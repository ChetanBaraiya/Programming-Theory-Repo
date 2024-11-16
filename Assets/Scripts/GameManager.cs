using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public TMP_Text playerNameText;
    public TMP_Text msgText;
    public GameObject msgObject;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        playerNameText.text = PlayerPrefs.GetString("PlayerName");;
    }

    public void ShowRechargeMessage()
    {
        msgObject.SetActive(true);
        msgText.text = "Press R to reload the gun";
    }
    public void OnClickBack()
    {
        SceneManager.LoadScene("TitleScene");
    }
}