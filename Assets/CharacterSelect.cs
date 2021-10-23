using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterSelect : MonoBehaviour
{
    public void loadStages(int chara)
    {
        PlayerPrefs.SetInt("chara",chara);
        SceneManager.LoadScene(1);
    }
}
