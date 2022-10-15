using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class First_Script : MonoBehaviour
{
    public string newScene;
    public Button btn;
    void Start()
    {
        btn.onClick.AddListener(Button);
    }

    private void Button()
    {
        Debug.Log(newScene);
        SceneManager.LoadScene(newScene);
    }

}
