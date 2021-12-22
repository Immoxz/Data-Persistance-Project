using System.Collections;
using System.Collections.Generic;
#if UNITY_EDITOR
using UnityEditor;
#endif
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

//Helping to order UI handler to show on end
[DefaultExecutionOrder(1000)]

public class MenuUIHandler : MonoBehaviour
{
    public static DataManager Instance;

    /*[SerializeField] private InputField input;
    public string playerName;


    private void Start()
    {
        input = gameObject. //.GetComponentInChildren<InputField>();
        var se = new InputField.SubmitEvent();
        se.AddListener(SubmitName);
        input.onEndEdit = se;
    }

    private void SubmitName(string arg0)
    {
        Debug.Log(arg0);
        playerName = arg0;
    }*/

    public void StartBttnHandler()
    {
        SceneManager.LoadScene(1);
    }
    public void QuitBttnHandler()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    } 

}
