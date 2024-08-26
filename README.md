## Introduction
**Cosmic Cruiser** is an exhilarating space adventure game where players take on the role of a daring rocket pilot navigating the treacherous environment of the Lunar Outpost. Set in a visually stunning cosmos, the game challenges you to maneuver your rocket through perilous black holes and vortexes, all while collecting cosmic coins to boost your high score.

**Platforms:** Windows, WebGL
- **Play the game online:** [Cosmic Cruiser on Simmer](https://simmer.io/@MukeshKrish/cosmic-cruiser)

## Gameplay Mechanics
- **Rocket Movement:** The player controls the rocket using the arrow keys and A, D for side-to-side movement. The rocket is in constant motion, continuously spinning, which adds a layer of complexity and realism to the gameplay, simulating the challenges of space travel.
- **Increasing Speed:** As you cover more distance, the rocket's speed increases, intensifying the difficulty and requiring sharper reflexes to navigate through obstacles.
- **Obstacles:** Black holes and vortexes are the primary dangers. As the rocket approaches these cosmic phenomena, they exert a gravitational pull, drawing the rocket in. The player must skillfully avoid these pulls to survive. Additionally, the side walls of the environment are deadly, and crashing into them results in the rocket's destruction.

## UI/UX Design Features
- **Level Selection Menu:** Displays the available levels along with instructions on how to play each level.
- **Background Audio Control:** Includes an on/off button to manage background music.
- **Pause Menu:** Activated by pressing the space button. The pause menu overlays the game screen, allowing players to pause the game, restart or return to the main menu.
- **High Score Tracking:** The game features a high score display that updates in real-time based on the number of cosmic coins collected. The high score is stored using Unity’s PlayerPrefs, ensuring it persists across game sessions.
- **Restart Button:** A prominent restart button allows players to quickly start a new game session, providing an easy way to try again after a game over.
- **Three Unique Game-Over Scenes:** Custom-designed scenes for when the player crashes into walls, vortexes, or black holes.
- **Credits Page:** Acknowledges contributors and provides credit for assets and tools used in the game's development.
- **Button Design:** All in-game buttons, including those for audio controls, navigation, and gameplay actions, have been meticulously designed in Canva to ensure a cohesive and visually appealing user interface.

## Comprehensive Game Development Scripts
- **FlowManager:** Manages UI transitions between the main menu, about, theme, and credits panels. Handles scene changes, opens external URLs, and exits the game, with platform-specific behavior for Unity Editor and standalone builds. Serialized fields enable easy panel customization within the Unity Editor.
- **PlatformFinal:** Controls the spawning of obstacles and coins on platforms. Uses randomization to place obstacles and coins at specific child positions within the platform. Triggers the spawning of a new platform when the player exits the platform's trigger and destroys the current one after a delay, ensuring a continuous and dynamic gameplay environment.
  - The script uses HashSet to store unique random indices for spawning obstacles and coins. A HashSet is ideal here because it automatically handles uniqueness, ensuring that each selected index is distinct without requiring additional checks or loops.
- **PlayerMovement:** Manages the player's forward and horizontal movement in a 3D environment. Increases the player's forward speed based on the distance traveled, with a speed cap to maintain gameplay balance. Utilizes the Rigidbody component for physics-based movement and handles user input for horizontal navigation.
- **LogicScript:** Handles core gameplay logic, including score tracking, platform spawning, and game state management. Manages game over conditions by displaying specific panels based on the cause of failure. Includes pause/resume functionality controlled by a customizable key and updates the player's high score using PlayerPrefs. Allows scene transitions and controls UI elements for a smooth gameplay experience.
  - High scores are managed using Unity's PlayerPrefs, which stores the highest score achieved by the player.
- **CrashDetection:** Detects collisions between the player and various obstacles, triggering game over scenarios based on the type of object hit. Distinguishes between walls, vortexes, and black holes, displaying the corresponding game over panel and destroying the player object upon impact.

## Visual and Audio Elements
Discover the assets and audio design that bring "Cosmic Cruiser" to life, creating an immersive space adventure experience.

- **Celestial Assets:** The game features high-quality assets to create an immersive space environment:
  - **Yellow Black Hole and Blue Vortex assets** from PNGTree bring a vibrant yet menacing look to the dangers that await.
  - **The Lunar Landscape** from Unity Asset Store provides a realistic backdrop, grounding the player in a desolate yet beautiful extraterrestrial environment.
  - **The Starfield Skybox** from Unity Asset Store envelops the scene in a starry void, enhancing the feeling of deep space.
  - **The Toy Rocket model** from CGTrader adds a playful yet detailed appearance to the player's vehicle, making it stand out against the cosmic backdrop.
- **Audio :** The game features a soundtrack by **Simon Jensen** titled **"Space".**

## Getting Started

To get a local copy up and running, follow these steps:

1. Clone the repository:
    ```bash
    git clone https://github.com/mukeshkrish08/CosmicCruiser-Unity3D
    ```
2. Open the project in Unity.