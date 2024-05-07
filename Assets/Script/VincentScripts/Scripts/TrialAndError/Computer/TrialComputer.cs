using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

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

    string TITE = null;
    //string TITE1 = null;
    string PEPE = null;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Person myObj = new Person();
        

        if (counter == 1)
        {
            Debug.Log("WLHELLO_COUNTER3");
            //canvasText.text = helloWriteLine;
            //counter++;

            if(a == "HELLOWORLD")
            {
                //Person myObj = new Person();
                myObj.Name = "HELLOWORLDick";
                canvasText.text = "" + myObj.Name;
                //myObj.Name = TITE;
                TITE = myObj.Name;
                //Person myObj = new Person();
                //myObj.Name = "Liam";
                //Console.WriteLine(myObj.Name);
            }
            if(a == "7")
            {
                myObj.Name = "7";
                canvasText.text = "" + myObj.Name;
                myObj.Name = TITE;
            }
            
        }
        if (counter == 2)
        {
            Debug.Log("WLHELLO_COUNTER2");
            if (a == "HELLOWORLD")
            {
                Debug.Log("KARL_TITE");
                //b = "HELLOWORLD";

                canvasText.text = "" + TITE;
            }

            if(a == "7")
            {
                myObj.Name1 = "7";
                //canvasText.text = "" + myObj.Name1;
                //myObj.Name1 = PEPE;
                PEPE = myObj.Name1;
                canvasText.text = "" + TITE + PEPE;
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

class Person
{
    private string name; // field
    public string Name   // property
    {
        get { return name; }
        set { name = value; }
    }

    private string name1; // field
    public string Name1   // property
    {
        get { return name1; }
        set { name1 = value; }
    }
}
