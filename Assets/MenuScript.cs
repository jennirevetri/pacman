using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    public void StartMundoUno()
    {
        SceneManager.LoadScene("Pacman1.0");
    }
    public void StartMundoDos()
    {
        SceneManager.LoadScene("Pacman2.0");
    }
    public void StartMundoTres()
    {
        SceneManager.LoadScene("Pacman3.0");
    }
    public void StartMundoCuatro()
    {
        SceneManager.LoadScene("Pacman");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
