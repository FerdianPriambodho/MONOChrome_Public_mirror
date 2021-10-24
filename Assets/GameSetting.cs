using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSetting : MonoBehaviour
{
    public List<GameObject> Characters;
    public static GameObject Player;
    private void Start()
    {
        Debug.Log("chara int " + PlayerPrefs.GetInt("chara"));
        if(SceneManager.GetActiveScene().buildIndex != 0)
        {
            Player = Instantiate(Characters[PlayerPrefs.GetInt("chara")]);
            Debug.Log(Player.name);
        }
    }
}
