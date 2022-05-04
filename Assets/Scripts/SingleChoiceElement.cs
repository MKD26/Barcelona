using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Neue SingleChoice Frage", menuName = "SingleChoice Frage")]
public class SingleChoiceElement : ScriptableObject
{
    public string frage;
    public string antwort1;
    public string antwort2;
    public string antwort3;
    public string antwort4;
    public int richtigeAntwort;

}
