using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test : MonoBehaviour
{
    public Text title;

    public void StartGame()
    {
        title.text = "�����ڴ�...";
    }

    
    public void ExitGame()
    {
        Application.Quit();
    }
}
