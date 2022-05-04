using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SingleChoiceTester : MonoBehaviour
{
    public int punkteZumBestehen;
    public SingleChoiceElement[] frageliste;
    public Text zählerRichtig;
    public Text zumBestehen;
    public Text zählerOffen;
    public Text frage;
    public Button antwort1;
    public Button antwort2;
    public Button antwort3;
    public Button antwort4;
    public GameObject winnerScreen;
    public GameObject loserScreen;


    private int richtigeAntwort;
    private Text antwort1_text;
    private Text antwort2_text;
    private Text antwort3_text;
    private Text antwort4_text;
    private ColorBlock col_red;
    private ColorBlock col_green;
    
    private int aktiveFrage;
    private int anzahlRichtig;
    private int anzahlFalsch;
    private int anzahlOffen;


    void Start() {
        antwort1_text = antwort1.GetComponentInChildren<Text>();
        antwort2_text = antwort2.GetComponentInChildren<Text>();
        antwort3_text = antwort3.GetComponentInChildren<Text>();
        antwort4_text = antwort4.GetComponentInChildren<Text>();

        col_red = antwort1.colors; 
        col_green = antwort1.colors; 

        col_red.pressedColor = Color.red;
        col_green.pressedColor = Color.green;

        loadQuestion(aktiveFrage);

        anzahlOffen = frageliste.Length;
    }
    void Update() {
        zählerRichtig.text = "Bisher richtig: " + anzahlRichtig.ToString();
        zumBestehen.text = "Zum Bestehen erforderlich: " + punkteZumBestehen.ToString();
        zählerOffen.text = "Noch offen: " + anzahlOffen.ToString();
    }

    void loadQuestion(int questionNumber){
        if(aktiveFrage < frageliste.Length){
            frage.text = frageliste[questionNumber].frage;
            antwort1_text.text = frageliste[questionNumber].antwort1;
            antwort2_text.text = frageliste[questionNumber].antwort2;
            antwort3_text.text = frageliste[questionNumber].antwort3;
            antwort4_text.text = frageliste[questionNumber].antwort4;
            richtigeAntwort = frageliste[questionNumber].richtigeAntwort;
            RichtigeAntwortZuweisen(richtigeAntwort);
        }
        else {
            Debug.Log("Alle Fragen durchlaufen");

            if(anzahlRichtig >= punkteZumBestehen){
                winnerScreen.SetActive(true);
            }
            else {
                loserScreen.SetActive(true);
            }
        }
    }

    void RichtigeAntwortZuweisen(int rightAnswer){

        switch(rightAnswer){
            
            case 1:
                antwort1.colors = col_green;
                antwort2.colors = col_red;
                antwort3.colors = col_red;
                antwort4.colors = col_red;

                antwort1.onClick.RemoveAllListeners();
                antwort2.onClick.RemoveAllListeners();
                antwort3.onClick.RemoveAllListeners();
                antwort4.onClick.RemoveAllListeners();

                antwort1.onClick.AddListener(KorrekteAntwort);
                antwort2.onClick.AddListener(FalscheAntwort);
                antwort3.onClick.AddListener(FalscheAntwort);
                antwort4.onClick.AddListener(FalscheAntwort);
            break;

            case 2:
                antwort1.colors = col_red;
                antwort2.colors = col_green;
                antwort3.colors = col_red;
                antwort4.colors = col_red;

                antwort1.onClick.RemoveAllListeners();
                antwort2.onClick.RemoveAllListeners();
                antwort3.onClick.RemoveAllListeners();
                antwort4.onClick.RemoveAllListeners();

                antwort1.onClick.AddListener(FalscheAntwort);
                antwort2.onClick.AddListener(KorrekteAntwort);
                antwort3.onClick.AddListener(FalscheAntwort);
                antwort4.onClick.AddListener(FalscheAntwort);
            break;

            case 3:
                antwort1.colors = col_red;
                antwort2.colors = col_red;
                antwort3.colors = col_green;
                antwort4.colors = col_red;

                antwort1.onClick.RemoveAllListeners();
                antwort2.onClick.RemoveAllListeners();
                antwort3.onClick.RemoveAllListeners();
                antwort4.onClick.RemoveAllListeners();

                antwort1.onClick.AddListener(FalscheAntwort);
                antwort2.onClick.AddListener(FalscheAntwort);
                antwort3.onClick.AddListener(KorrekteAntwort);
                antwort4.onClick.AddListener(FalscheAntwort);
            break;

            case 4:
                antwort1.colors = col_red;
                antwort2.colors = col_red;
                antwort3.colors = col_red;
                antwort4.colors = col_green;

                antwort1.onClick.RemoveAllListeners();
                antwort2.onClick.RemoveAllListeners();
                antwort3.onClick.RemoveAllListeners();
                antwort4.onClick.RemoveAllListeners();

                antwort1.onClick.AddListener(FalscheAntwort);
                antwort2.onClick.AddListener(FalscheAntwort);
                antwort3.onClick.AddListener(FalscheAntwort);
                antwort4.onClick.AddListener(KorrekteAntwort);
            break;
        }
    }

    void FalscheAntwort(){
        Debug.Log("Das war falsch");
        aktiveFrage++;
        loadQuestion(aktiveFrage);
        anzahlOffen--;
    }

    void KorrekteAntwort(){
        Debug.Log("Das war korrekt");
        aktiveFrage++;
        loadQuestion(aktiveFrage);
        anzahlRichtig++;
        anzahlOffen--;
    }

    void SetRandomQuestion(){
        aktiveFrage = Random.Range(0,frageliste.Length);

        Debug.Log(aktiveFrage);
    }

}
