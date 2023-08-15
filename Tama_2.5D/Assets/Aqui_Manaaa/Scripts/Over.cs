using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Over : MonoBehaviour
{
    // Start is called before the first frame update
    public void Salida()
    {
        Application.Quit();
    }

    // Update is called once per frame
    public void Dwight()
    {
        SceneManager.LoadScene(0);
    }
}
