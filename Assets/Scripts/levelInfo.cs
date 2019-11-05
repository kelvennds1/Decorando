using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelInfo : MonoBehaviour
{
    public int idLevel;

    public GameObject estrela1;
    public GameObject estrela2;
    public GameObject estrela3;

    private int       notaFinal;
    // Start is called before the first frame update
    void Start()
    {
        estrela1.SetActive(false);
        estrela2.SetActive(false);
        estrela3.SetActive(false);

        int notaFinal = PlayerPrefs.GetInt("notaFinal" + idLevel.ToString());


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

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
