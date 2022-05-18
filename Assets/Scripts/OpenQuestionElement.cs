using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using cakeslice;

public class OpenQuestionElement : MonoBehaviour
{
    public GameObject learningElement; 
    public LernraumLogik logikFuerLernraum;
    public DialogZeilenWriter dialogZeile;
    private GameObject kamera;
    private Outline outLinerScript;
    private string dialogzeilenText = "Oeffnen Sie das Lernelement mit der Taste R" ;
    public bool wurdeBearbeitet = false;



    void Start() {
        kamera = GameObject.Find("MainCamera");
        outLinerScript = GetComponent<Outline>();
    }

    void Update() {
        if (wurdeBearbeitet == true){
            outLinerScript.color = 1;
        }
    }
    

    void  OnTriggerEnter(Collider other) {
        dialogZeile.AndereDialogZeile(dialogzeilenText);
    }

    void  OnTriggerStay(Collider other) {
        if (Keyboard.current.rKey.wasPressedThisFrame){
            learningElement.SetActive(true);
            }
    }

    void  OnTriggerExit(Collider other) {
        dialogZeile.AndereDialogZeile(null);
    }

    public void BearbeitungLernelement (bool bearbeitet){
        wurdeBearbeitet = bearbeitet;
    }



}
