using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KopfleisteEinblenden : MonoBehaviour
{
    public GameObject kopfleiste;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(){
        kopfleiste.SetActive(true);
    }
}
