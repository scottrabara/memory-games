using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnEscKey : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void Update()
    {
         if (Input.GetKeyUp(KeyCode.Escape))
        {
           SceneManager.LoadScene("LandingScene");
        }
    }
}
