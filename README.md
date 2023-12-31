# RacerGame

A racing game that utilizes proper design patterns for the Software Engineering class at BCA.

## Unity Version

This project was created in Unity version 2022.3.14f1 LTS. However, it is version agnostic and should work with any version of Unity.

## Contributors

Ethan Modi, Rishabh Singh, and Tim Rolshud

## Design Patterns Used

* A Singleton for the ScoreManager class that lives inside of the Canvas UI manager and keeps track of the game score, high score, and stores the high score in a long term storage format using Unity's PlayerPrefs feature
* A Coroutine inside of that ScoreManager Singleton that updates the score every half second, and then updates the high score if the score is higher than the high score. It is started and stopped when the game is started and stopped accordingly.
* Enums for the different Obstacle types that there can be within the game, used to conveniently handle the way different types of obstacles interact with the car and allows for easy randomized obstacle generation.
* REQUIRED: ScriptableObjects as delegates make it possible for us to pass back callback functions and customize the way different types of obstacles react with the car (Cones are good, everything else are bad)

## Cool Features

* Our game allows you to save your high score so that when you reopen it, the game still sees your high score!
* Our game also has a cool space background as well

## Tests

We have tests written to ensure that the there will always be new obstacles ahead of us, that the car moves with the same speed as the platform, and that the car never lags behind he platform.
