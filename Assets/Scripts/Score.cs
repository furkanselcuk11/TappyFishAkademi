using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    int _score; // Skore de�i�keni
    [SerializeField] private Text scoreTxt; // Skore Texti
    void Start()
    {
        _score = 0; // Ba�lang��ta skore 0 ba�las�n
        scoreTxt.text = _score.ToString();  // Skore de�erini scoreTxt de g�ster
    }    
    void Update()
    {
        
    }
    public void Scored()
    {
        // score de�erini artt�r ve scoreTxt de g�ster
        _score++;
        scoreTxt.text = _score.ToString();
    }
}
