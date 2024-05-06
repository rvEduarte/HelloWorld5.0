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

            if(a == "HELLOWORLD")
            {           
                canvasText.text = "" + a;
            }
            if(a == "7")
            {
                canvasText.text = "" + a;
            }
            
        }
        if (counter == 2)
        {
            Debug.Log("WLHELLO_COUNTER2");
            if (a == "HELLOWORLD")
            {
                b = "HELLOWORLD";
                canvasText.text = "" + a + b;
            }
        }
        if (counter == 3)
        {
            Debug.Log("WLHELLO_COUNTER1");
            canvasText.text = "" + a + b + c;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("ENTER BULLET TITE");
        //if the game object we collided with is not equal to the current game object (so anything other than itself)
        if (collision.gameObject.tag == "WHELLO")
        {
            Debug.Log("ENTER W__HELLO");
            a = "HELLOWORLD";
            
            
            
            //b = "HELLOWORLD";
            //c = "HELLOWORLD";
            counter++;
            
        }
        else if(collision.gameObject.tag == "WLHELLO")
        {
            Debug.Log("ENTER WL__HELLO");
            a = "7";
            counter++;
        }
    }

    /*private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("EXIT BULLET TITE");
        //if the game object we collided with is not equal to the current game object (so anything other than itself)
        if (collision.gameObject.tag == "WHELLO")
        {
            Debug.Log("EXIT W__HELLO");
            b = null;
            c = null;

        }
    }*/
}
