using PixelCrushers.DialogueSystem;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueSimulatorButton : MonoBehaviour
{
    string dialogueName;
    Button button;
    public void init(string name)
    {
        dialogueName = name;
        button = GetComponent<Button>();
        button.GetComponentInChildren<Text>().text = dialogueName;
        button.onClick.AddListener(() =>
        {
            DialogueManager.StartConversation(dialogueName);
        });
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
