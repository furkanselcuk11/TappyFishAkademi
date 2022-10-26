using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static Vector2 bottomLeft;  // Di�er scriptlerden eri�im sa�lar
    public static bool gameOver;
    public GameObject gameOverPanel;
    private void Awake()
    {
        bottomLeft = Camera.main.ScreenToWorldPoint(new Vector2(0, 0)); // Cameran�n sol alt konumunu ayarlar
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
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);   // Yeniden ba�lat
    }
    public void GameOver()
    {
        // gameOverPanel paneli aktif hale getir ve gameEver true d�nerek oyun biter
        gameOver = true;
        gameOverPanel.SetActive(true);
    }
}
