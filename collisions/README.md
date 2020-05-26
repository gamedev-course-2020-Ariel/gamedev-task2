# Spaceship game

## Start
* In this game, the player must shoot laser beams at the enemies that are the flying plates and avoid being hit by them.

* Link to itch.io: [ 3d-shield Game](https://odeliamos0.itch.io/3d-shield )

### Game - components and objects
* [Life](https://github.com/OdeliaHochman/Computer-Games-Development-Course-task2/blob/master/collisions/Assets/Scripts/3-collisions/DestroyOnTrigger2D.cs) - The player's spaceship is not destroyed immediately when it hits the enemy, but at the beginning of the game it has 3 life points. Only when it reaches zero is it destroyed.

![image](https://user-images.githubusercontent.com/45036697/80924395-54297980-8d91-11ea-9305-dafdd9872485.png)

* [T-Slow down the enemy](https://github.com/OdeliaHochman/Computer-Games-Development-Course-task2/blob/master/collisions/Assets/Scripts/2-spawners/OnceTimedSpawner.cs) - The player receives a gift (T) that allows the enemies spawning time to be diluted for a few seconds (defined in the inspector).

![image](https://user-images.githubusercontent.com/45036697/80924419-728f7500-8d91-11ea-92b0-6c69f49e16bf.png)

* [Border walls](https://github.com/OdeliaHochman/Computer-Games-Development-Course-task2/blob/master/collisions/Assets/Scripts/3-collisions/WallThePlayer.cs) - Visible walls that the player cannot pass through.

![image](https://user-images.githubusercontent.com/45036697/80924451-acf91200-8d91-11ea-8ea9-8ab9714a537f.png)

![image](https://user-images.githubusercontent.com/45036697/80924468-c00be200-8d91-11ea-934a-1e3963bcba00.png)

* [Invisible boundaries](https://github.com/OdeliaHochman/Computer-Games-Development-Course-task2/blob/master/collisions/Assets/Scripts/1-movers/Mover.cs) - The enemies and lasers are destroyed as they collide within the boundaries of the game screen.

![image](https://user-images.githubusercontent.com/45036697/80924712-2cd3ac00-8d93-11ea-8ac7-b62cbd519bff.png)

* [Round World](https://github.com/OdeliaHochman/Computer-Games-Development-Course-task2/blob/master/collisions/Assets/Scripts/1-movers/KeyboardMover.cs) - When the player reaches one side of the world, he appears on the other side.

![image](https://user-images.githubusercontent.com/45036697/80924594-7d96d500-8d92-11ea-8d32-d8b4aa670512.png)

![image](https://user-images.githubusercontent.com/45036697/80924629-ad45dd00-8d92-11ea-8bf6-38478506d1e3.png)




Some material is based on the Udemy course:
[The Ultimate Guide to Game Development with Unity 2019](https://www.udemy.com/the-ultimate-guide-to-game-development-with-unity/), by Jonathan Weinberger

Some assets are from:
* [Matt Whitehead](https://ccsearch.creativecommons.org/photos/7fd4a37b-8d1a-4d4c-80a2-4ca4a3839941)
* [Kenney's space kit](https://kenney.nl/assets/space-kit)
* [Ductman's 2D Animated Spacehips](https://assetstore.unity.com/packages/2d/characters/2d-animated-spaceships-96852)
* [Franc from the Noun Project](https://commons.wikimedia.org/w/index.php?curid=64661575)
