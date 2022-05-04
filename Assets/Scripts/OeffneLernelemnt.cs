using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class OeffneLernelemnt : MonoBehaviour
{
    public GameObject werner;
    public GameObject lernelement;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other) {
        werner.SetActive(true);
    }

        void OnTriggerExit(Collider other) {
        werner.SetActive(false);
    }

    void OnTriggerStay(Collider other) {
        if(Keyboard.current.iKey.isPressed){
            lernelement.SetActive(true);
        }
    }

}
