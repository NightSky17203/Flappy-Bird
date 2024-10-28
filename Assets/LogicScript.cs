using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class LogicScript : MonoBehaviour
{
    // Start is called before the first frame update
    public int score;
    public Text scoreText;
    public GameObject GameOver;
    [ContextMenu("increase")]
    public void count()
    {
        score = score + 1;
        scoreText.text = score.ToString();
    }

    public void Retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void Gameover()
    {
        GameOver.SetActive(true);
    }
}
