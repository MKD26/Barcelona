using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KopfleisteController : MonoBehaviour
{
    public Text textPunkte;
    public Text textLernraumName;

    private int punkteStand;
    private int maxPunkte;
    private string nameLernraum;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        textPunkte.text = "Lernelemente: " + punkteStand + " von " + maxPunkte;
        textLernraumName.text = nameLernraum;
    }

    public void AenderePunktestand(int aktuellePunkte, int maximalePunkte){
        punkteStand = aktuellePunkte;
        maxPunkte = maximalePunkte;
    }

    public void AendereLernraumname(string neuerLernRaumName){
        nameLernraum = neuerLernRaumName;
    }
}
