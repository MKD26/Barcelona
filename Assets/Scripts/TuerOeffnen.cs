using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TuerOeffnen : MonoBehaviour
{
    public bool zuOeffnen = false;
    public bool oeffnungsRichtungUmkehren; 
    private Quaternion startWinkel;
    private Quaternion drehung = Quaternion.Euler(0,90,0);

    void Start(){
        startWinkel = transform.rotation;
        if(oeffnungsRichtungUmkehren){
            drehung = Quaternion.Euler(0,-90,0);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(zuOeffnen){
            transform.rotation = Quaternion.Lerp(transform.rotation, startWinkel*drehung, Time.deltaTime);
        }

        if (transform.rotation == startWinkel*drehung ){
            zuOeffnen = false;
        }
        
    }
}
