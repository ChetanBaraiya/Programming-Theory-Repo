using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    
    
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

     public void ShowRechargeMessage()
    {
        msgObject.SetActive(true);
        msgText.text = "Press R to reload the gun";
    }
     
     


}
