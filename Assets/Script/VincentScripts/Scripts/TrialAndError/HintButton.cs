using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HintButton : MonoBehaviour
{
    public Button ButtonHint;
    public GameObject DisablePanel;

    public bool clicked = true;

    void Start()
    {
        DisablePanel.SetActive(false);

        Button btn = ButtonHint.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    // Update is called once per frame
    void Update()
    {
        if (clicked == true)
        {
            DisablePanel.SetActive(false);
        }

        else if (clicked == false)
        {
            DisablePanel.SetActive(true);
        }
    }

    public void TaskOnClick()
    {
        if (clicked == true)
        {
            clicked = false;
            return;
        }
        else if (clicked == false)
        {
            clicked = true;
            return;
        }
    }
}
