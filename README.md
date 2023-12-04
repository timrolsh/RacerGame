# RacerGame

A racing game that utilizes proper design patterns for the Software Engineering class at BCA.

## Unity Version

This project was created in Unity version 2022.3.14f1 LTS. However, it is version agnostic and should work with any version of Unity.

## Contributors

Ethan Modi, Rishabh Singh, and Tim Rolshud

## Design Patterns Used

* A Singleton for the ScoreManager class that lives inside of the Canvas UI manager and keeps track of the game score, high score, and stores the high score in a long term storage format using Unity's PlayerPrefs feature
* A Coroutine inside of that ScoreManager Singleton that updates the score every half second, and then updates the high score if the score is higher than the high score. It is started and stopped when the game is started and stopped accordingly.
* enums
* scriptableobjects as delegates
