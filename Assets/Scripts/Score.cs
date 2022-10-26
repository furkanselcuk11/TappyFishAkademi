using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    int _score; // Skore deðiþkeni
    [SerializeField] private Text scoreTxt; // Skore Texti
    void Start()
    {
        _score = 0; // Baþlangýçta skore 0 baþlasýn
        scoreTxt.text = _score.ToString();  // Skore deðerini scoreTxt de göster
    }    
    void Update()
    {
        
    }
    public void Scored()
    {
        // score deðerini arttýr ve scoreTxt de göster
        _score++;
        scoreTxt.text = _score.ToString();
    }
}
