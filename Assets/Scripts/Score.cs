using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    [SerializeField] private Player player;
    [SerializeField] private TMP_Text scoreText;
 
    private void OnEnable()
    {
        player.scoreChanged += OnScoreChanged;
    }

    private void OnDisable()
    {
        player.scoreChanged -= OnScoreChanged;
    }

    private void OnScoreChanged(int score)
    {
        scoreText.text = score.ToString();
    }

    public void OnScoreReset(int score)
    {
        player.count = 0;
        scoreText.text = score.ToString("0");
    }
}
