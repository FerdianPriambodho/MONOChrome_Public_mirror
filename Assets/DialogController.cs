using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text.RegularExpressions;

public class DialogController : MonoBehaviour
{
    string[] lineWord;
    int lineWordIndex = 0;

    //Get data from dialog files
    public void setDialogFile(TextAsset DialogText)
    {
        lineWord = Regex.Split(DialogText.ToString(), "\n");
    }

    //Set text function
    public string setSpeaker()
    {
        if (lineWord[lineWordIndex] == "Player") return GameSetting.Player.name;
        else return lineWord[lineWordIndex];
    }

    public string setTextDialog()
    {
        return lineWord[lineWordIndex + 1];
    }

    public bool indexCheck()
    {
        Debug.Log(lineWordIndex);
        Debug.Log(lineWord.Length);
        if (lineWordIndex < lineWord.Length-1) return false;
        else return true;
    }

    public void nextDialog()
    {
        lineWordIndex += 2;
    }

    //Set image function
    
}
