# Psycho-Surgeon

Psycho Surgeon is a fast-paced 2D action game developed in Unity, challenging players with dynamic bullet combat, strategic enemy encounters and engaging battles. With dynamic gameplay battles outsmart the race against time with the immersive countdown timer 
![image](https://github.com/apekkshaa/psycho-surgeon/blob/main/images/psychosurgeon.png)<br>

## Features
- Engage in fast-paced shooting action with responsive controls and challenging enemies
- Face off against various enemies, each with unique behaviors and attack patterns
- Add urgency to your gameplay with a countdown timer that forces you to think and act quickly
- Experience intense battles with a variety of enemies


## Controls
- Movement: Use the arrow keys or WASD to move your character.
- Shoot: Press Space to shoot bullets.


## Gameplay
- Objective: Survive and defeat enemies as you race against the countdown timer.
- Enemies: Encounter different types of enemies with unique attack patterns.


## Functionalities
1. Movement and collision detection of bullets fired by the player. Includes methods to set bullet speed and handle collisions with enemies
2. Controls enemy behavior, including movement towards the player, attacking, and handling death animations
3. Damage area around enemies during their attack phase, enabling and disabling damage zones based on attack timings
4. Health of enemies, handles taking damage, and triggers death sequences when health reaches zero
5. Controls the spawning of enemies at predefined positions with a limit on the number of active enemies at any given time
6. Implements smooth camera following logic to keep the player in view, with constraints to limit camera movement within predefined bounds
7. Destroys objects (e.g., bullets) that collide with it to prevent clutter and manage game resources efficiently
8. Manages key gameplay elements such as enemy kill count, displaying the count on the UI, and restarting the game
9. Controls player animations and handles changing the player's facing direction based on movement
10. Manages player health, handles taking damage, and triggers game over sequences when health reaches zero
11. Manages player shooting actions, instantiates bullets, and plays shooting sound effects
12. Manages the countdown timer displayed during gameplay, updates the UI, and handles game events when the timer reaches zero
13. Handles sound effects such as the player shooting


## Installation
To play Psycho Surgeon, follow these steps:

1. Clone the repository:<br>
   git clone https://github.com/your-username/psycho-surgeon.git
2. Open the project in Unity:<br>
   - Ensure you have Unity installed. The recommended version for this project is Unity 2021.3.15f1
   - Open Unity Hub and click on "Add" to add the cloned project.
3. Install dependencies: This project uses Unity's built-in features, so there are no additional dependencies to install.


## Acknowledgements
Developed using **Unity**
