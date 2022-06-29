using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Endszene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void OnTriggerEnter() {
        SceneManager.LoadScene(3);
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
