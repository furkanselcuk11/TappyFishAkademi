using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static Vector2 bottomLeft;  // Diðer scriptlerden eriþim saðlar
    public static bool gameOver;
    public GameObject gameOverPanel;
    private void Awake()
    {
        bottomLeft = Camera.main.ScreenToWorldPoint(new Vector2(0, 0)); // Cameranýn sol alt konumunu ayarlar
    }
    void Start()
    {
        gameOver = false;
    }    
    void Update()
    {
        
    }
    public void RestartBtn()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);   // Yeniden baþlat
    }
    public void GameOver()
    {
        // gameOverPanel paneli aktif hale getir ve gameEver true dönerek oyun biter
        gameOver = true;
        gameOverPanel.SetActive(true);
    }
}
