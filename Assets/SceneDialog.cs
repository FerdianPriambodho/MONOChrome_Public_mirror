using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class SceneDialog : DialogController
{
    public TextAsset Dialog;
    public Text SpeakerBox;
    public Text DialogBox;
    public List<GameObject> Avatar;

    public bool indexCheck=true;

    int indextTemp;

    private void Start()
    {
        this.setDialogFile(Dialog);
        SpeakerBox.text = setSpeaker();
        DialogBox.text = setTextDialog();

        //Set Avatar (Temporary)
        foreach (GameObject obj in Avatar)
        {
            obj.SetActive(false);
        }
        for (int i=0;i< Avatar.Count; i++)
        {
            if (SpeakerBox.text == GameSetting.Player.name)
            {
                indextTemp = 0;
            } else if(Avatar[i].name == SpeakerBox.text)
            {
                indextTemp = i;
            }
        }
        Avatar[indextTemp].SetActive(true);
    }

    public void FixedUpdate()
    {
        indexCheck = this.indexCheck();
        if (indexCheck())
        {
            this.gameObject.SetActive(false);
            return;
        }
        SpeakerBox.text = setSpeaker();
        DialogBox.text = setTextDialog();

        //Set Avatar (Temporary)
        foreach (GameObject obj in Avatar)
        {
            obj.SetActive(false);
        }
        for (int i = 0; i < Avatar.Count; i++)
        {
            if (SpeakerBox.text.Contains(GameSetting.Player.name))
            {
                indextTemp = 0;
                break;
            } else if (SpeakerBox.text.Contains(SpeakerBox.text))
            {
                indextTemp = 1;
            }
        }
        Avatar[indextTemp].SetActive(true);
    }
}
