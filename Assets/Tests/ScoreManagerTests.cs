// using NUnit.Framework;
// using UnityEngine.TestTools;
// using UnityEngine;
// using UnityEngine.UI;

// public class ScoreManagerTests
// {
//     private ScoreManager scoreManager;
//     private GameObject scoreManagerGameObject;

//     [SetUp]
//     public void SetUp()
//     {
//         // Set up your test environment
//         scoreManagerGameObject = new GameObject();
//         scoreManager = scoreManagerGameObject.AddComponent<ScoreManager>();
//         scoreManager.scoreText = scoreManagerGameObject.AddComponent<Text>();
//         scoreManager.highScoreText = scoreManagerGameObject.AddComponent<Text>();
//     }

//     [TearDown]
//     public void TearDown()
//     {
//         // Clean up after your tests
//         Object.DestroyImmediate(scoreManagerGameObject);
//     }

//     [Test]
//     public void ScoreManagerSingletonIsNotNull()
//     {
//         // Check if the ScoreManager instance is not null
//         Assert.IsNotNull(ScoreManager.Instance);
//     }

//     [Test]
//     public void ScoreManagerInitialScoreIsZero()
//     {
//         // Check if the initial score is zero
//         Assert.AreEqual(0, scoreManager.GetScore());
//     }

//     [Test]
//     public void ScoreManagerHighScoreUpdatesCorrectly()
//     {
//         // Simulate a score boost to check if high score updates correctly
//         scoreManager.ScoreBoost();
//         Assert.AreEqual(10, scoreManager.GetHighScore());
//     }
// }
