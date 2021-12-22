using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


// Sets the script to be executed later than all default scripts
// This is helpful for UI, since other things may need to be initialized before setting the UI
[DefaultExecutionOrder(1000)]
public class InputHandler : MonoBehaviour
{
     
    // Start is called before the first frame update
    void Start()
    {
        var input = gameObject.GetComponent<TMP_InputField>();
        input.onEndEdit.AddListener(SubmitName);
    }
    private void SubmitName(string text_arg)
    {
        //Debug.Log(text_arg);
        DataManager.Instance.SetPlayerName(text_arg);
    } 

}
