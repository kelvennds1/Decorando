using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class responder : MonoBehaviour
{
    private int idLevel;

    public Text pergunta;
    public Text respostaA;
    public Text respostaB;
    public Text respostaC;
    public Text respostaD;
    public Text infoRespostas;

    public string[] perguntas;
    public string[] alternativaA;
    public string[] alternativaB;
    public string[] alternativaC;
    public string[] alternativaD;
    public string[] corretas;

    private int idPergunta;

    private float acertos;
    private float questoes;
    private float media;
    private int   notaFinal;

    // Start is called before the first frame update
    void Start () {
        idLevel = PlayerPrefs.GetInt("idLevel");
        idPergunta = 0;
        questoes = perguntas.Length;
        pergunta.text = perguntas[idPergunta];
        respostaA.text = alternativaA[idPergunta];
        respostaB.text = alternativaB[idPergunta];
        respostaC.text = alternativaC[idPergunta];
        respostaD.text = alternativaD[idPergunta];

        infoRespostas.text = "Respondendo "+(idPergunta + 1).ToString()+ " de " + questoes.ToString() + " perguntas.";
    }

    public void resposta(string alternativa)
    {
        if(alternativa == "A")
        {
            if (alternativaA[idPergunta] == corretas[idPergunta])
            {
                acertos += 1;
            }
        }

        else if (alternativa == "B")
        {
            if (alternativa == "B")
            {
                if (alternativaB[idPergunta] == corretas[idPergunta])
                {
                    acertos += 1;
                }
            }

        }

        else if (alternativa == "C")
        {
            if (alternativa == "C")
            {
                if (alternativaC[idPergunta] == corretas[idPergunta])
                {
                    acertos += 1;
                }
            }
        }

        else if (alternativa == "D")
        {
            if (alternativa == "D")
            {
                if (alternativaD[idPergunta] == corretas[idPergunta])
                {
                    acertos += 1;
                }
            }
        }
        proximaPergunta();
    }


    void proximaPergunta()
    {
        idPergunta += 1;

        if (idPergunta <= (questoes - 1))
        {

            pergunta.text = perguntas[idPergunta];
            respostaA.text = alternativaA[idPergunta];
            respostaB.text = alternativaB[idPergunta];
            respostaC.text = alternativaC[idPergunta];
            respostaD.text = alternativaD[idPergunta];

            infoRespostas.text = "Respondendo " + (idPergunta + 1).ToString() + " de " + questoes.ToString() + " perguntas.";
        }
        else
        {
            media = 10 * (acertos / questoes);
            notaFinal = Mathf.RoundToInt(media);


            if(notaFinal > PlayerPrefs.GetInt("notaFinal"+idLevel.ToString())) 
            {
              
                PlayerPrefs.SetInt ("notaFinal" + idLevel.ToString(), notaFinal);
                PlayerPrefs.SetInt("acertos" + idLevel.ToString(), (int)acertos);

            }

            PlayerPrefs.SetInt("notaFinalTemp" + idLevel.ToString(), notaFinal);
            PlayerPrefs.SetInt("acertosTemp" + idLevel.ToString(), (int)acertos);



            Application.LoadLevel("notaFinal");
        }
    }








    
}
