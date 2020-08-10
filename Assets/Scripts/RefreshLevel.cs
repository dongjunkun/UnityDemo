using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RefreshLevel : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<Button>().onClick.AddListener(RestartLevel);
    }


    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }
}
