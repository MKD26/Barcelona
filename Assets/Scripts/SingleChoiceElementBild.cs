using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Neue SingleChoice Frage Bild", menuName = "SingleChoice Frage Bild")]
public class SingleChoiceElementBild : ScriptableObject
{
    public string frage;
    public Texture frageImage;
    public string antwort1;
    public string antwort2;
    public string antwort3;
    public string antwort4;
    public int richtigeAntwort;

}
