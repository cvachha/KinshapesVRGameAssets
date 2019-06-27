using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GoToGame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnMouseButtonDown()
    {
        if (transform.name == "Cube")
        {
            //SceneManager.LoadScene("IdolScene", LoadSceneMode.single);
            Application.LoadLevel("IdolScene");
        }
        
    }
}
