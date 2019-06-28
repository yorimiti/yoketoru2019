using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class titlemanager : MonoBehaviour
{

    bool sceneChanged = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (sceneChanged == true) return;

        if(Input.GetMouseButtonDown(0)||Input.GetButtonDown("Jump"))
        {
            sceneChanged = true;
            UnityEngine.SceneManagement.SceneManager.LoadSceneAsync("Game");
        }
    }
}
