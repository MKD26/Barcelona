using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MultipleChoice : MonoBehaviour
{
    public int points;
    public Text punkteStand;

    public Dropdown dropItDownYo;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PunkteZaehlen(int punkteNeu){
        
        
        points += punkteNeu;
        punkteStand.text = "Punkte: " + points.ToString() ;


    }

        public void PunkteZaehlenDropDown(int punkteNeu){
        
        if (dropItDownYo.value == 1){
            points += punkteNeu;
            punkteStand.text = "Punkte: " + points.ToString() ;
        }
        



    }
}
