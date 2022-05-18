using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationOnTrigger : MonoBehaviour
{
    public Animator animController;

    // Start is called before the first frame update
    void Start()
    {
        animController = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other) {
        animController.Play("TestAnimation");
    }
}
