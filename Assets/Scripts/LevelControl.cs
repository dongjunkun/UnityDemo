using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class LevelControl : MonoBehaviour
{
    private static int _level_index = 1;

    private Enemy[] enemies;
    // Start is called before the first frame update
    void Start()
    {
        enemies = FindObjectsOfType<Enemy>();
    }

    // Update is called once per frame
    void Update()
    {
        foreach (Enemy enemy in enemies)
        {
            if (enemy != null)
            {
                return;
            }
        }

        _level_index++;
        string name = "Level" + _level_index;
        SceneManager.LoadScene(name);
    }
}
