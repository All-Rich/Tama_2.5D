using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Icons : MonoBehaviour
{
    [SerializeField] private GameObject menuIcons;
    public void Activar()
    {
        menuIcons.SetActive(true);
    }

    public void Desactivar()
    {
        menuIcons.SetActive(false);
    }

    public void Salir()
    {
        Application.Quit();
    }

    public void Jugar()
    {
        SceneManager.LoadScene("Mini_Juego");
    }
}
