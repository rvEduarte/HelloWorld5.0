using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TrialComputer : MonoBehaviour
{
    [SerializeField]
    private GameObject bulletHelloWrite;
    public TMP_Text canvasText;

    string helloWriteLine = "HelloWorld";

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("ENTER BULLET TITE");
        //if the game object we collided with is not equal to the current game object (so anything other than itself)
        if (collision.gameObject.tag == "WLHELLO")
        {
            //canvasText.text = "\nPEPE ";
            canvasText.text += helloWriteLine;
            canvasText.text = helloWriteLine+"Helloworld";
        }
    }
}
