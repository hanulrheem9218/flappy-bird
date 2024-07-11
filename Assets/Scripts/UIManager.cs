using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class UIManager : MonoBehaviour
{
    [SerializeField]
    private int _scoreCount = 0;
    private TextMeshProUGUI _scoreText;
    private GameObject _displayDeath;
    void Start()
    {
        _scoreText = gameObject.transform.Find("ScoreDisplayer").GetComponent<TextMeshProUGUI>();
        _displayDeath = gameObject.transform.Find("DeathScreen").gameObject;
        _displayDeath.SetActive(false); 
    }

    public void IncreaseScore()
    {
        _scoreCount += 1;
        _scoreText.text = $"{_scoreCount}";
    }
    public void DisplayGameOverMessage()
    {
        _displayDeath.SetActive(true);
        Time.timeScale = 0f;
    }
    
}
