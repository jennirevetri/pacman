using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
    public GameManager gameManager;

    public void Start()
    {
        gameManager = GameObject.FindObjectOfType<GameManager>();
    }
    // Start is called before the first frame update
    public void VolverMenu()
    {
        gameManager.Awake();
        gameManager.NewGame();
        SceneManager.LoadScene("PacmanMenu");
    }
}
