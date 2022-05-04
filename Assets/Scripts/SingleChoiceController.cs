using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SingleChoiceController : MonoBehaviour
{
    public int punkteStand = 0;
    public int maxPunkte;
    public Text punkteZaehlerText;
    public SingleChoiceElement[] sqe;

    public struct SingleChoiceElement{
        public string frage;
        public string antwortRichtig;
        public string antwortFalsch1;
        public string antwortFalsch2;
        public string antwortFalsch3;
    } 



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(punkteStand >= maxPunkte){
            gameObject.SetActive(false);
        }
    }

    public void ErhaltePunkte(){
        punkteStand += 1;
        punkteZaehlerText.text = punkteStand + " von " + maxPunkte + " erreicht";
    } 

}
