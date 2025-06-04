using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public TMP_Text scoreText;
    private int score = 0;

    void Start()
    {
        UpdateScoreText();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("ScoreZone")) // Assurez-vous que l'objet déclencheur a ce tag
        {
            score++;
            UpdateScoreText();
        }
    }

    void UpdateScoreText()
    {
        scoreText.text = $"{score}";
    }
}