using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReloadOnEscape : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
