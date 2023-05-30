using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public int score = 0;
    public Text scoreText;

    void Start()
    {
        Puntaje();
    }

    public void PuntosUno()
    {
        score += 1;
        Puntaje();
    }

    public void PuntosDos()
    {
        score += 2;
        Puntaje();
    }

    public void PuntosTres()
    {
        score += 3;
        Puntaje();
    }

    private void Puntaje()
    {
        scoreText.text = "Score: " + score;
    }
}