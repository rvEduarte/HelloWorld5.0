using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingObjectScript : MonoBehaviour
{

    public Transform posA, posB;
    public int Speed;
    Vector2 targerPos;
    // Start is called before the first frame update
    void Start()
    {
        targerPos = posB.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector2.Distance(transform.position, posA.position) < .1f) targerPos = posB.position;

        if (Vector2.Distance(transform.position, posB.position) < .1f) targerPos = posA.position;

        transform.position = Vector2.MoveTowards(transform.position, targerPos, Speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player2.0"))
        {
            collision.transform.SetParent(this.transform);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player2.0"))
        {
            collision.transform.SetParent(null);
        }
    }
}
