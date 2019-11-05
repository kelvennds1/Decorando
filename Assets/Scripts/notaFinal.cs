using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class notaFinal : MonoBehaviour
{
    private int idLevel;

    public Text txtNota;
    public Text txtInfoLevel;

    public GameObject estrela1;
    public GameObject estrela2;
    public GameObject estrela3;

    private int acabouNota;
    private int acertos;

    // Start is called before the first frame update
    void Start() {
        estrela1.SetActive(false);
        estrela2.SetActive(false);
        estrela3.SetActive(false);

        idLevel = PlayerPrefs.GetInt("idLevel");
        acabouNota = PlayerPrefs.GetInt("notaFinalTemp" + idLevel.ToString());
        acertos = PlayerPrefs.GetInt("acertosTemp" + idLevel.ToString());

        txtNota.text = acabouNota.ToString();
        txtInfoLevel.text = "Você acertou "+acertos.ToString()+" de 10 perguntas";

        if(acabouNota == 10)
        {
            estrela1.SetActive(true);
            estrela2.SetActive(true);
            estrela3.SetActive(true);
        }
        else if (acabouNota >= 7)
        {
            estrela1.SetActive(true);
            estrela2.SetActive(true);
            estrela3.SetActive(false);
        }
        else if (acabouNota >= 5)
        {
            estrela1.SetActive(true);
            estrela2.SetActive(false);
            estrela3.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void jogarNovamente()
    {
        Application.LoadLevel("L" + idLevel.ToString());
    }

}
