using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSetting : MonoBehaviour
{
    public List<GameObject> Characters;
    private void Start()
    {
        Debug.Log("chara int " + PlayerPrefs.GetInt("chara"));
        if(SceneManager.GetActiveScene().buildIndex != 0)
        {
            Instantiate(Characters[PlayerPrefs.GetInt("chara")]);
        }
    }
}
