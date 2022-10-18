using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDie : MonoBehaviour
{
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(player.transform.position.y < 0) {
            SceneManager.LoadScene("TestSceneJulian");
        }
        if (Input.GetKeyDown("r")) { 
            SceneManager.LoadScene("TestSceneJulian"); 
        } 
      
    }
}
