# Jumper frog

You need to help the frog get from the city to the forest through a road where vehicles are being driven. You must avoid the vehicles and prevent them from damaging the frog.

Link to itch.io: [ Jumper frog Game](https://odeliamos0.itch.io/jumper-frog-game)

## Start
![GitHub Logo](https://github.com/OdeliaHochman/Computer-Games-Development-Course-task2/blob/master/Jumper%20frog/images/%E2%80%8F%E2%80%8FGame%20-start.PNG)

### Game - main objects and components
#### Spawners
* We created 3 spawns object, we placed 2 of them on the right side of the game screen and one on the left side of the game. We created 2 types of spawning components:
  * [CarSpawner.cs](https://github.com/OdeliaHochman/Computer-Games-Development-Course-task2/blob/master/Jumper%20frog/Assets/Scripts/CarSpawner.cs)
  Spawning prefabs that give him left to right screen.
  * [CarSpawnerLeft2Right.cs](https://github.com/OdeliaHochman/Computer-Games-Development-Course-task2/blob/master/Jumper%20frog/Assets/Scripts/CarSpawnerLeft2Right.cs)
  Spawning prefabs that give him right to left screen.
* The objects that the spawners spawn are destroyed as they reach the screen boundaries.

![GitHub Logo](https://github.com/OdeliaHochman/Computer-Games-Development-Course-task2/blob/master/Jumper%20frog/images/Game-playing.PNG)

#### Frog
* We created two types of triggers for objects with coliders [Frog.cs](https://github.com/OdeliaHochman/Computer-Games-Development-Course-task2/blob/master/Jumper%20frog/Assets/Scripts/Frog.cs):
  * If the frog collides with a vehicle it is dead (destroyed) - a loss.
  
  ![GitHub Logo](https://github.com/OdeliaHochman/Computer-Games-Development-Course-task2/blob/master/Jumper%20frog/images/Game-died.PNG)
  
  ![image](https://user-images.githubusercontent.com/45036697/80921469-42d77180-8d7f-11ea-9dad-2cb1cb1a54a9.png)
  
  
  * If the frog did not crash into any vehicles and managed to reach the forest (crash into the trees) the spiders are destroyed - a victory.
  
  ![GitHub Logo](https://github.com/OdeliaHochman/Computer-Games-Development-Course-task2/blob/master/Jumper%20frog/images/Game-win.PNG)
  
  ![image](https://user-images.githubusercontent.com/45036697/80921498-73b7a680-8d7f-11ea-95e7-1e4a59769425.png)


