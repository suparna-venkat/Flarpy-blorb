using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int playerScore = 0;
    public Text scoreText;
    public GameObject gameOverScreen;

    void Start()
    {
        scoreText.text = playerScore.ToString();
    }

    [ContextMenu("Increase Score")]
    public void addScore(int scoreToAdd)
    {
        playerScore=playerScore+scoreToAdd;
        scoreText.text = playerScore.ToString();
    }

    public void RestartGame()
{
    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
}

public void gameOver(){
    gameOverScreen.SetActive(true);

}
}