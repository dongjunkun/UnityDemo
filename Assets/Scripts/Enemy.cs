using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject boumEffect;
    // Start is called before the first frame update
    void Update()
    {
        if (transform.position.x < -30 || transform.position.x > 30
        || transform.position.y < -20 || transform.position.y > 20)
        {
            Destroy(this.gameObject);
            Instantiate(boumEffect, transform.position, Quaternion.identity);
        }

    }
    void OnCollisionEnter2D(Collision2D collisionInfo)
    {
        if (collisionInfo.collider.gameObject.CompareTag("Player"))
        {
            Destroy(this.gameObject);
            Instantiate(boumEffect, transform.position, Quaternion.identity);
        }

    }
}
