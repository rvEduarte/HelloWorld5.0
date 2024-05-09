using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using System.Drawing;

public class TrialComputer : MonoBehaviour
{
    [SerializeField]
    private GameObject bulletHelloWrite;
    public TMP_Text canvasText;

    public GameObject resetCounter;

    public BoxCollider2D disableBox2d;

    string a = null;

    //int counter = 0;

    public CounterCount Counter1;

    string TITE = null;
    string PEPE = null;
    string TEPE = null;

    // Start is called before the first frame update
    void Start()
    {
        disableBox2d.GetComponent<BoxCollider2D>().offset = new Vector2 (-9, 0);
        disableBox2d.GetComponent<BoxCollider2D>().size = new Vector2((float)0.1, (float)16.8);
        
    }

    // Update is called once per frame
    void Update()
    {
        Person myObj = new Person();
        

        if (Counter1.counter == 1)
        {
            Debug.Log("WLHELLO_COUNTER3");
            //canvasText.text = helloWriteLine;
            //counter++;

            if(a == "HELLOWORLD")
            {
                myObj.Name = "HELLOWORLD";
                string color = "#18eded";
                canvasText.text = "" + "<color=" + color + ">" + myObj.Name + "</color>";
                TITE = myObj.Name;
            }

            else if(a == "7")
            {
                myObj.Name = "7";
                string color = "#18eded";
                canvasText.text = "" + "<color=" + color + ">" + myObj.Name + "</color>";
                TITE = myObj.Name;
            }

            else if(a == "SPACE_HELLOWORLD")
            {
                myObj.Name = "\nHELLOWORLD";
                string color = "#18eded";
                canvasText.text = "" + "<color=" + color + ">" + myObj.Name + "</color>";
                TITE = myObj.Name;
            }

            else if (a == "SPACE_7")
            {
                myObj.Name = "\n7";
                string color = "#18eded";
                canvasText.text = "" + "<color=" + color + ">" + myObj.Name + "</color>";
                TITE = myObj.Name;
            }

        }
        if (Counter1.counter == 2)
        {
            Debug.Log("WLHELLO_COUNTER2");
            if (a == "HELLOWORLD")
            {
                Debug.Log("KARL_TITE");
                myObj.Name1 = "HELLOWORLD";
                PEPE = myObj.Name1;
                //canvasText.color = Color.red;
                string color = "#18eded";
                canvasText.text = "" + TITE + "<color=" + color + ">" + PEPE + "</color>";
                //canvasText.text = "" + TITE + "<color=" + color + ">HELLOWORLD</color>";
            }

            else if(a == "7")
            {
                myObj.Name1 = "7";
                PEPE = myObj.Name1;
                //canvasText.color = Color.red;
                string color = "#18eded";
                canvasText.text = "" + TITE + "<color=" + color + ">" + PEPE + "</color>";
            }

            else if (a == "SPACE_HELLOWORLD")
            {
                myObj.Name1 = "\nHELLOWORLD";
                PEPE = myObj.Name1;
                //canvasText.color = Color.red;
                string color = "#18eded";
                canvasText.text = "" + TITE + "<color=" + color + ">" + PEPE + "</color>";
            }

            else if (a == "SPACE_7")
            {
                myObj.Name1 = "\n7";
                PEPE = myObj.Name1;
                //canvasText.color = Color.red;
                string color = "#18eded";
                canvasText.text = "" + TITE + "<color=" + color + ">" + PEPE + "</color>";
            }

        }
        if (Counter1.counter == 3)
        {
            //disableBox2d.GetComponent<BoxCollider2D>().enabled = true;

            if (a == "HELLOWORLD")
            {
                myObj.Name2 = "HELLOWORLD";
                TEPE = myObj.Name2;
                //canvasText.color = Color.red;
                string color2 = "#03960f";
                string color = "#18eded";
                canvasText.text = "" + TITE + PEPE + "<color=" + color + ">" + TEPE + "</color>" + "<color=" + color2 + ">\n\n\n...Program finished with exit code 0</color>";

                //MOVE THE COLLIDER TO BOTTOM
                disableBox2d.GetComponent<BoxCollider2D>().offset = new Vector2((float)-2.2, (float)-26.72);
                disableBox2d.GetComponent<BoxCollider2D>().size = new Vector2((float)8.63, (float)9.63);
            }

            else if (a == "7")
            {
                myObj.Name2 = "7";
                TEPE = myObj.Name2;
                //canvasText.color = Color.red;
                string color2 = "#03960f";
                string color = "#18eded";
                canvasText.text = "" + TITE + PEPE + "<color=" + color + ">" + TEPE + "</color>" + "<color=" + color2 + ">\n\n\n...Program finished with exit code 0</color>";

                //MOVE THE COLLIDER TO BOTTOM
                disableBox2d.GetComponent<BoxCollider2D>().offset = new Vector2((float)-2.2, (float)-26.72);
                disableBox2d.GetComponent<BoxCollider2D>().size = new Vector2((float)8.63, (float)9.63);

            }

            else if (a == "SPACE_HELLOWORLD")
            {
                myObj.Name2 = "\nHELLOWORLD";
                TEPE = myObj.Name2;
                //canvasText.color = Color.red;
                string color2 = "#03960f";
                string color = "#18eded";
                canvasText.text = "" + TITE + PEPE + "<color=" + color + ">" + TEPE + "</color>" + "<color=" + color2 + ">\n\n\n...Program finished with exit code 0</color>";

                //MOVE THE COLLIDER TO BOTTOM
                disableBox2d.GetComponent<BoxCollider2D>().offset = new Vector2((float)-2.2, (float)-26.72);
                disableBox2d.GetComponent<BoxCollider2D>().size = new Vector2((float)8.63, (float)9.63);
            }
            else if (a == "SPACE_7")
            {
                myObj.Name2 = "\n7";
                TEPE = myObj.Name2;
                //canvasText.color = Color.red;
                string color2 = "#03960f";
                string color = "#18eded";
                canvasText.text = "" + TITE + PEPE + "<color=" + color + ">" + TEPE + "</color>" + "<color=" + color2 + ">\n\n\n...Program finished with exit code 0</color>";

                //MOVE THE COLLIDER TO BOTTOM
                disableBox2d.GetComponent<BoxCollider2D>().offset = new Vector2((float)-2.2, (float)-26.72);
                disableBox2d.GetComponent<BoxCollider2D>().size = new Vector2((float)8.63, (float)9.63);

            }
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
            Counter1.counter++;

            if (Counter1.counter == 4)
            {
                Debug.Log("SUPER_FUCK");

                //MOVE THE COLLIDER TO TOP
                disableBox2d.GetComponent<BoxCollider2D>().offset = new Vector2(-9, 0);
                disableBox2d.GetComponent<BoxCollider2D>().size = new Vector2((float)0.1, (float)16.8);

                canvasText.text = "__";
                Counter1.counter = 0;
            }
            
        }
        else if(collision.gameObject.tag == "WLHELLO")
        {
            Debug.Log("ENTER WL__HELLO");
            a = "SPACE_HELLOWORLD";
            Counter1.counter++;
        }

        else if (collision.gameObject.tag == "W7")
        {
            Debug.Log("ENTER W__7");
            a = "7";
            Counter1.counter++;
        }

        else if (collision.gameObject.tag == "WL7")
        {
            Debug.Log("ENTER W__7");
            a = "SPACE_7";
            Counter1.counter++;
        }
    }
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
    private string name2;
    public string Name2   // property
    {
        get { return name2; }
        set { name2 = value; }
    }
}
