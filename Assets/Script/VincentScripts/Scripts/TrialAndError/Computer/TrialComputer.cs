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

    string a = null;
    string b = null;
    string c = null;

    int counter = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (counter == 1)
        {
            Debug.Log("WLHELLO_COUNTER3");
            //canvasText.text = helloWriteLine;
            //counter++;
        }
        if (counter == 2)
        {
            Debug.Log("WLHELLO_COUNTER2");
            //counter++;
        }
        if (counter == 3)
        {
            Debug.Log("WLHELLO_COUNTER1");
            //counter++;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("ENTER BULLET TITE");
        //if the game object we collided with is not equal to the current game object (so anything other than itself)
        if (collision.gameObject.tag == "WHELLO")
        {
            Debug.Log("ENTER W__HELLO");
            counter++;
            //canvasText.text = "\nPEPE ";
            //canvasText.text += helloWriteLine;
            //canvasText.text = helloWriteLine+"Helloworld";
            //counter++;
        }
        else if(collision.gameObject.tag == "WLHELLO")
        {
            Debug.Log("ENTER WL__HELLO");
            counter++;
        }
    }
}
