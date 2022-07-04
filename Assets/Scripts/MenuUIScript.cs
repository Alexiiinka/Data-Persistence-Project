using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuUIScript : MonoBehaviour
{
    public Text textik;
    public Text playerNameInput;
    public InputField inputfildiek;
    // Start is called before the first frame update
    void Start()
    {
        textik.text = $"Best score has {MenuManager.BestScoreName} : {MenuManager.BestScore}"; 
        inputfildiek.text = MenuManager.Instance.newPlayer.playerName;  
    }

    public void playerNameChanged(string name)
    {
        MenuManager.Instance.newPlayer.playerName = playerNameInput.text;
        Debug.Log(MenuManager.Instance.newPlayer.playerName);
    }
}
