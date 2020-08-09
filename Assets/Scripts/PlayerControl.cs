using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{

    public float force = 10f;

    // Start is called before the first frame update

    Rigidbody2D rb;

    Vector3 initialPosition;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        GetComponent<Renderer>().material.color = Color.red;
        initialPosition = transform.position;

    }

    void OnMouseDrag()
    {
        
        Vector3 currentPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector3(currentPosition.x,currentPosition.y, 0f);
    }

    void OnMouseUp()
    {
        GetComponent<Renderer>().material.color = Color.white;

        Vector3 directToForward = transform.position - initialPosition;
        rb.AddForce(directToForward * force);
        rb.gravityScale = 1;
    }
}
