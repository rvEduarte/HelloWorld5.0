using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlateHintScript : MonoBehaviour
{
    public GameObject EXLA;

    public GameObject Hint;

    public GameObject HintPanel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            HintPanel.SetActive(true);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("Player2.0"))
        {
            EXLA.SetActive(false);
            Hint.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("Player2.0"))
        {
            Hint.SetActive(false);
            HintPanel.SetActive(false);
        }
    }
}
