using PixelCrushers.DialogueSystem;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DialogueSystemSimulate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var buttons = GetComponentsInChildren<DialogueSimulatorButton>();
        int i = 0;
        for (;i< DialogueManager.masterDatabase.conversations.Count; i++)
        {
            var conversation = DialogueManager.masterDatabase.conversations[i];
            var button = buttons[i];
            button.init(conversation.Title);
        }
        for (; i < buttons.Length; i++)
        {
            var button = buttons[i];
            button.gameObject.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
