using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class ScoreManagerTests
{
    private ScoreManager scoreManager;
    private GameObject scoreManagerObj;

    [SetUp]
    public void Setup()
    {
        // Create a new GameObject and add the ScoreManager component to it
        scoreManagerObj = new GameObject();
        scoreManager = scoreManagerObj.AddComponent<ScoreManager>();
        scoreManager.scoreText = new GameObject().AddComponent<Text>();
        scoreManager.highScoreText = new GameObject().AddComponent<Text>();
    }

    [TearDown]
    public void Teardown()
    {
        // Cleanup
        Object.Destroy(scoreManagerObj);
    }

    [Test]
    public void ScoreStartsAtZero()
    {
        Assert.AreEqual(0, scoreManager.GetScore());
    }

    [Test]
    public void ScoreIncreasesOverTime()
    {
        scoreManager.StartScore();
        float timeToWait = 1.0f; // Wait for 1 second
        yield return new WaitForSeconds(timeToWait);
        Assert.Greater(scoreManager.GetScore(), 0);
    }

    [Test]
    public void ScoreStopsWhenStopped()
    {
        scoreManager.StartScore();
        scoreManager.StopScore();
        int scoreAfterStopping = scoreManager.GetScore();
        yield return new WaitForSeconds(1.0f);
        Assert.AreEqual(scoreAfterStopping, scoreManager.GetScore());
    }

    [Test]
    public void HighScoreIsUpdatedCorrectly()
    {
        scoreManager.ScoreBoost(); // Increase score
        scoreManager.StopScore();
        Assert.AreEqual(scoreManager.GetScore(), scoreManager.GetHighScore());
    }
}