using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerControl : MonoBehaviour
{

    public float force = 500f;

    // Start is called before the first frame update

    private float currentTime = 0;


    Vector3 initialPosition;

    void Awake()
    {
        Screen.orientation = ScreenOrientation.Landscape;
        initialPosition = transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -30 || transform.position.x > 30
        || transform.position.y < -20 || transform.position.y > 20)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

        if (Application.platform == RuntimePlatform.Android && Input.GetKey(KeyCode.Escape))
        {
            if (currentTime != 0 && Time.time - currentTime <= 2)
            {
                Application.Quit();
            }else{
                
            }
            currentTime = Time.time;
        }

    }

    void OnMouseDown()
    {
        GetComponent<Renderer>().material.color = Color.red;

    }

    void OnMouseDrag()
    {

        Vector3 currentPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector3(currentPosition.x, currentPosition.y, 0f);
    }

    void OnMouseUp()
    {
        GetComponent<Renderer>().material.color = Color.white;

        Vector2 directionToInitialPosition = initialPosition - transform.position;
        GetComponent<Rigidbody2D>().AddForce(directionToInitialPosition * force);
        GetComponent<Rigidbody2D>().gravityScale = 1;
    }


}
