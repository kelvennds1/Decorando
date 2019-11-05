using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CountdownScript : MonoBehaviour
{
    public Text displayContagem;

    public float contagem = 10.0f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (contagem > 0f)
        {
            contagem -= Time.deltaTime;
            displayContagem.text = contagem.ToString("F0");
        }
        else
        {
            Application.LoadLevel("notaFinal");
        }
    }
}
