using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public Player player;

    public void StartGame()
    {
        player.StartGame();
        gameObject.SetActive(false);
    }
}
