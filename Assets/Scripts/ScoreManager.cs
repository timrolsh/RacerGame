using System.Collections;
using UnityEngine;
using UnityEngine.UI;
/*
A Singleton used to manage the score of the player.
*/
public class ScoreManager : MonoBehaviour
{
    public Text scoreText;
    public Text highScoreText;
    private static ScoreManager _instance;
    public static ScoreManager Instance { get { return _instance; } }
    private int _score = 0;
    // Load the high score from PlayerPrefs or initialize it to 0 if it doesn't exist
    private int _highScore;
    private Coroutine coroutine;
    private void Awake()
    {
        if (_instance != null && _instance != this)
        {
            // destroy any other instances of this object that could be created by mistake
            Destroy(this.gameObject);
            Debug.Log("An instance of ScoreManager already exists, destroying this one. This is a singleton and should not be created more than once.");
        }
        else
        {
            _instance = this;
        }
        _highScore = PlayerPrefs.GetInt("HighScore", 0);
        UpdateHighScoreText();
    }

    private IEnumerator UpdateScoreRoutine()
    {
        // Run indefinitely
        while (true)
        {
            yield return new WaitForSeconds(0.5f); // Wait for half a second
            ++_score;
            UpdateScoreText();
            // Update high score if it goes over
            if (_score > _highScore)
            {
                _highScore = _score;
                UpdateHighScoreText();
            }
        }
    }

    private void UpdateScoreText()
    {
        scoreText.text = "Score: " + _score.ToString();
    }

    private void UpdateHighScoreText()
    {
        highScoreText.text = "High Score: " + _highScore.ToString();
    }

    public void StartScore()
    {
        coroutine = StartCoroutine(UpdateScoreRoutine());

    }

    public void StopScore()
    {
        StopCoroutine(coroutine);
        if (_score > _highScore)
        {
            _highScore = _score;
        }
        PlayerPrefs.SetInt("HighScore", _highScore);
        _score = 0;
        UpdateScoreText();
    }

    public void ScoreBoost()
    {
        _score += 10;
        UpdateScoreText();
        if (_score > _highScore)
        {
            _highScore = _score;
            UpdateHighScoreText();
        }
    }

}
