using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Cinemachine;

public class GameSetting : MonoBehaviour
{
    public List<GameObject> Characters;
    public static GameObject Player;
    public CinemachineVirtualCamera cM_vcam;
    private void Start()
    {
        // Start action on call
    }

    public void instantiateCharacter()
    {
        Debug.Log("chara int " + PlayerPrefs.GetInt("chara"));
        if(SceneManager.GetActiveScene().buildIndex != 0)
        {
            Player = Instantiate(Characters[PlayerPrefs.GetInt("chara")]);
            Debug.Log(Player.name);
            cM_vcam.m_Follow = Player.transform;
        }
    }
}
