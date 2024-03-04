using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button1Script : MonoBehaviour
{
    public Button button;

    public void Start(){
        button.onClick.AddListener(onButtonClick);
    }
    public void LoadScene1()
    {
        SceneManager.LoadScene("Scene1");
    }
}
