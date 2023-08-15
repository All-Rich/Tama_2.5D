using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Temporizador : MonoBehaviour
{
    public float cuentaInicial = 60f;
    public float cuentaFinal = -20f;

    public TextMeshProUGUI tempo;

    private float tiempoRestante;

    private bool esMuerto = false;

    private Animator personajeAnimator;

    // Variables para las animaciones
    private bool EsFeliz = false;
    private bool EsEnojada = false;
    private bool EsComida = false;
    private bool EsRound = true;

    void Start()
    {
        tiempoRestante = cuentaInicial;
        StartCoroutine(Inador());

        personajeAnimator = GetComponent<Animator>();

        tempo = GameObject.Find("Temporizador").GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {
        if (tiempoRestante <= cuentaFinal && !esMuerto)
        {
            esMuerto = true;
            SceneManager.LoadScene("GameOver");
        }

        personajeAnimator.SetBool("EsFeliz", EsFeliz);
        personajeAnimator.SetBool("EsEnojada", EsEnojada);
        personajeAnimator.SetBool("EsComida", EsComida);

        if (EsRound)
        {
            personajeAnimator.SetBool("EsRound", true);
        }

        tempo.text = "Tiempo: " + tiempoRestante.ToString("F0");
    }

    IEnumerator Inador()
    {
        while (tiempoRestante > cuentaFinal)
        {
            yield return new WaitForSeconds(1f);

            tiempoRestante--;

            if (EsFeliz)
            {
                tiempoRestante += 5;
                EsFeliz = false;
            }
            if (EsEnojada)
            {
                tiempoRestante -= 5;
                EsEnojada = false;
            }
            if (EsComida)
            {
                tiempoRestante += 10;
                EsComida = false;
            }

            if (tiempoRestante > 120)
            {
                tiempoRestante = 120;
            }
        }
    }
    public void Funcion1()
    {
        EsFeliz = true;
        StartCoroutine(ResetearAnimacion(180f)); 
    }

    public void Funcion2()
    {
        EsEnojada = true;
        StartCoroutine(ResetearAnimacion(180f)); 
    }

    public void Funcion3()
    {
        EsComida = true;
        StartCoroutine(ResetearAnimacion(180f)); 
    }

    IEnumerator ResetearAnimacion(float tiempo)
    {
        Debug.Log("Eeeeeeeooooo");
        yield return new WaitForSeconds(tiempo);
        EsFeliz = false;
        EsEnojada = false;
        EsComida = false;
        EsRound = true;
    }
}
