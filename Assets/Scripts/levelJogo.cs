using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class levelJogo : MonoBehaviour
{
    public Button       btnPlay;
    public Text         txtNomeLevel;
    
    public GameObject   infoLevel;
    public Text         txtInfoLevel;
    public GameObject   estrela1;
    public GameObject   estrela2;
    public GameObject   estrela3;

    public string[]     nomeLevel;
    public int          numeroQuestões;
    private int         idLevel;


    // Start is called before the first frame update
    void Start()
    {
        idLevel = 0;
        txtNomeLevel.text = nomeLevel[idLevel];
        txtInfoLevel.text = "Você acertou X de X questões!";
        infoLevel.SetActive(false);
        estrela1.SetActive(false);
        estrela2.SetActive(false);
        estrela3.SetActive(false);
        btnPlay.interactable = false; 
        
    }

    public void selecioneoNivel (int i)
    {
        idLevel = i;
        PlayerPrefs.SetInt("idLevel", idLevel);
        txtNomeLevel.text = nomeLevel[idLevel];

            int notaFinal = PlayerPrefs.GetInt("notaFinal" + idLevel.ToString());
            int acertos = PlayerPrefs.GetInt("acertos" + idLevel.ToString());

        estrela1.SetActive(false);
        estrela2.SetActive(false);
        estrela3.SetActive(false);

        if (notaFinal == 10)
        {
            estrela1.SetActive(true);
            estrela2.SetActive(true);
            estrela3.SetActive(true);
        }
        else if (notaFinal >= 7)
        {
            estrela1.SetActive(true);
            estrela2.SetActive(true);
            estrela3.SetActive(false);
        }
        else if (notaFinal >= 5)
        {
            estrela1.SetActive(true);
            estrela2.SetActive(false);
            estrela3.SetActive(false);
        }

        txtInfoLevel.text = "Você acertou "+acertos.ToString()+" de " + numeroQuestões.ToString() + " questões!";
        infoLevel.SetActive(true);
        btnPlay.interactable = true;
    }

    public void Jogar()
    {
            
        Application.LoadLevel("L" + idLevel.ToString());
    }

      

}
