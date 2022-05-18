using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class UI : MonoBehaviour
{
    [SerializeField] private Text _hpText;
    [SerializeField] private Text _levelText;

    [SerializeField] private Text _scoreText;

    public void UpdateScoreAndLevel()
    {
        _levelText.text = "Level " + Stats.Level;
        _scoreText.text = "Score: " + Stats.Score.ToString("D4");
    }

    public void UpdateHp(int hp)
    {
        _hpText.text = "Hp: " + hp;
    }
}
