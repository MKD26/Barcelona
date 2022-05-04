using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogZeilenWriter : MonoBehaviour
{
    private Text dialogZeilenText;
    private string textFuerDialogZeile;

    // Start is called before the first frame update
    void Start()
    {
        dialogZeilenText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        dialogZeilenText.text = textFuerDialogZeile;
    }

    public void AndereDialogZeile(string textDialog){
        textFuerDialogZeile = textDialog;
    }
}
