using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using cakeslice;

public class LernraumLogik : MonoBehaviour
{
    public string begruessungsText = "Herzlich Willkommen im Lernraum 1. Erkunden Sie die verschiedene Lernelemente und sammeln Sie Punkte um die Ausgangstür zu öffnen";
    public string lernraumName;
    public int startPunkte = 0;
    public int maxPunkte;
    public string abschlussText = "Herzlichen Glückwunsch! Sie haben den Lernraum erfolgreich abgeschlossen";
    public OutlineEffect effectOfOutline;
    
    public TuerOeffnen eingangstuer_links;
    public TuerOeffnen eingangstuer_rechts;
    public TuerOeffnen ausgangstuer_links;
    public TuerOeffnen ausgangstuer_rechts;
    
    public DialogZeilenWriter dialogZeile;
    public KopfleisteController kopfZeile;

    private float alphaOutline;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame sadiasdhg
    void Update()
    {

        alphaOutline = Mathf.Lerp(0,1.5f,Mathf.PingPong(Time.time, 1));
        effectOfOutline.lineColor0.a = alphaOutline;

        kopfZeile.AenderePunktestand(startPunkte,maxPunkte);

        switch(Mathf.Round(Time.fixedTime)) 
        {
            case 3: 
                eingangstuer_links.zuOeffnen = true;
                eingangstuer_rechts.zuOeffnen = true;
                dialogZeile.AndereDialogZeile(begruessungsText);
                kopfZeile.AendereLernraumname(lernraumName);

            break;

            case 10:
                eingangstuer_links.zuOeffnen = false;
                eingangstuer_rechts.zuOeffnen = false;
                dialogZeile.AndereDialogZeile(null);
            break;
        }

        if (maxPunkte == startPunkte){
                ausgangstuer_links.zuOeffnen = true;
                ausgangstuer_rechts.zuOeffnen = true;
                dialogZeile.AndereDialogZeile(abschlussText);

        }

    }

    public void PunkteErhoehen(int neuePunkte){
        startPunkte += neuePunkte;
    }
}
