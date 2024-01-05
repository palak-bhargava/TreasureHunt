# TreasureHunt
_CS 4361 (Computer Graphics) Semester Project_

**Note**: The Main Menu code can be found [here](https://github.com/77EminSarac77/CS-4361-Project.git )

---

## Contributors
**[Palak Bhargava](https://github.com/palak-bhargava)**  - Project Coordinator, 3D Environment + Map and Plot Development

**[Pranav Nair](https://github.com/pranavn21)**     - 3D Environment, Blender Assets Creation

**[Chase Hubbell](https://github.com/ChaseHub)**   - Character Movement, Camera Management, Input Control, Physics

**[Dillon Carter](https://github.com/PickleMustard)**   - Map interaction, Scene Control

**[Emin Sarac](https://github.com/77EminSarac77)**      - Main menu UI + functionality and background music

---

## Project Description
**Game Play:**
Our team designed and developed a 3D interactive treasure hunt game in Unity where the player walks around a terrain looking for clues that are scattered around in hidden places. Once a clue is found, a message box pops up and this is where the player reads the clue. The clues that are found help the player find the location of the next clues. The order in which the clues are presented is sequential. This means that the player must visit the clues for them to unlock the next clue. For example, clue #1 will guide the player to clue #2. In case the player gets to a spot where clue #3 was to be located before visiting clue #2, clue #3 will not be presented. Therefore, the player must find clues in order.

**Blender Assets Creation:**
	Our team decided to use Blender 3D for creating our custom assets due to the software being both free and a very popular choice for game development. Due to its high popularity, we found several tutorials on YouTube that were beginner-friendly. While the team member responsible for the asset creation had some prior experience with Blender, these tutorials still helped immensely due to their simplicity. We wanted a consistent theme within our game, and we decided that we would have a low-poly theme; therefore, all our assets had to be low-poly. While we did use the Unity Asset store for some assets, we still needed some custom assets to satisfy our project requirements, such as a large oak tree with a hole inside the trunk, where one of our clues would be kept. Specifically, we used Blender 3D to create various trees (conifers, oak trees, generic trees), rocks, coins, etc.

**Character Interactions:**
We wanted the user to not only experience the breathtaking 3D world we created but the character they are controlling as well. The character has a multitude of animations that give it a sense of personality that the user can attach to. To accomplish this we decided on a third-person camera system that follows the character around our world. We also wanted there to be physics and collision for the characters in the world for a realistic feel. All this together turned out to be more difficult than anticipated and resulted in a set of challenges described later.

**Main Menu:**
The game has a map of the 3D terrain which will help the player navigate their way to find the hidden clues. When the game is launched, the player is to interact with a main menu. There is an audio clip that starts to play the main menu theme in a loop as soon as the main menu is loaded. The three main menu buttons are ‘Play Game,’ ‘Options,’ and ‘Quit.’ To switch between the three main menu buttons, the up and the down arrow keys are used, and the mouse left-click button is used to click the main menu button. Once the ‘Play Game’ button is pressed, the player will be able to start to play the game. The ‘Settings’ button will open a scene that contains a slider to adjust the main menu theme volume. To reflect the changes of the player’s adjusted sound volume, the player will click the ‘Back’ button which is located at the bottom center of the settings scene and this will bring the player back to the main menu. The ‘Quit’ button will allow the player to close the game application. Since our team was faced with a limit of 100 MB when uploading our individual files to a Github repository, we were not able to integrate the main menu with the game because the ‘Library’ folder for the main menu was too large to upload to Github. 

---
## Screenshots

**Full Demo Video** - [Link](https://drive.google.com/file/d/1zor_FFHZr0mhZJtsXWO8xZENqgY5LSwY/view?usp=sharing)


**Main Menu**

![image](https://github.com/palak-bhargava/TreasureHunt/assets/72369124/0daf66c7-e575-4952-86c5-65f138a43618)


**Clue Example**

![image](https://github.com/palak-bhargava/TreasureHunt/assets/72369124/e0cd79ab-3a18-4923-8fe0-9a7010fb144b)


**3D Environment** 

![image](https://github.com/palak-bhargava/TreasureHunt/assets/72369124/8ae740a5-9195-4683-864a-ede265794f18)


**Blender Asset Example**

![image](https://github.com/palak-bhargava/TreasureHunt/assets/72369124/ea914ed1-df4c-4b11-8c94-303f26ab039a)

---

## References

- [Start menu in Unity](https://www.youtube.com/watch?v=vqZjZ6yv1lA)   

- [Background music in Unity](https://www.youtube.com/watch?v=hYLm-bSq2sY)

- [Volume Slider in Unity](https://www.youtube.com/watch?v=yWCHaTwVblk)

- [Unity Terrain Tools](https://youtu.be/ddy12WHqt-M?feature=shared) 

- [3D Terrain Tutorial](https://youtu.be/MWQv2Bagwgk?feature=shared) 

- Unity Asset Store:
  - [rpg-tiny-hero-duo-pbr-polyart](https://assetstore.unity.com/packages/3d/characters/humanoids/rpg-tiny-hero-duo-pbr-polyart-225148)
  - [low-poly-simple-nature-pack](https://assetstore.unity.com/packages/3d/environments/landscapes/low-poly-simple-nature-pack-162153)
  - [low-poly-tree-pack](https://assetstore.unity.com/packages/3d/vegetation/trees/low-poly-tree-pack-57866)https://assetstore.unity.com/packages/2d/textures-materials/floors/outdoor-ground-textures-12555 
