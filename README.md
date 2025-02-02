# ⚙ DOWN STAIRS, BUNKER '-_

> **by Cuban Gnocchi Games 🥟** 

> Nuclear winter is hard, let's see if getting inside that bunker will help...
**DOWN STAIRS, BUNKER** is a multiplayer game where you and your friends will 
have to explore, survive, and try to arrive at the next level in a procedurally generated bunker built like a maze full of puzzle-like challenges where teamwork is needed.

## 📑Table of Contents
- [DOWN STAIRS, BUNKER](#-down-stairs-bunker--_)
- [How to Run It](#how-to-run-it)
- [How to Play](#-how-to-play-it)
- [Actual Stage of the Project](#actual-stage-of-the-project)
- [Code Structure and How It Works](#-code-structure-and-how-it-works)
  - [General Review](#general-review)
  - [Structure](#structure)

## ⏩How to run it:
> [!Warning]
>
> *Currently in development; there is only a test of maze generation and visuals to run.* 
> *A working version available to play is **coming soon**, very soon.* 
> ###### _veeery soon..._ 

1. Clone the [repository](https://github.com/cubangnocchi/Pro001 "repository link") using **git bash**.
  
   ```bash
   git clone https://github.com/cubangnocchi/Pro001.git
   ```

2. Open the project directory in your console.
3. You will need [.NET 8.0](https://dotnet.microsoft.com/en-us/download/dotnet/8.0 "click for downloading dotnet8.0") installed for the next step.
4. Use the following commands in order to run it successfully: 

   ```bash
   dotnet add package Spectre.Console
   ```

   ```bash
   dotnet add package Spectre.Console.Cli
   ```

   ```bash
   dotnet add package Colorful
   ```
   
   ```bash
   dotnet run
   ```

5. **Enjoy the game**!

## 🎮 How to play it:
- Instructions will be given to the user in the game.
- Menu keys:
  |**key**|**what it do**|
  |--|--|
  |x|exit|
  |i|information|
  |any number|other options are assigned to numbers|

- In-game keys:
  |**key**|**what it do**|
  |---|----------------|
  | w|walk up|
  | s|walk down|
  | a|walk left|
  | d|walk right|
  | e|interact with object|
  > [⚠️] more actions will be implemented

### Actual stage of the project:
- Working on the first test version where you can explore a procedurally generated maze.

## 🛠 Code structure and how it works:

### General review:
> 

### Structure:

**[Program.cs](./Program.cs)**
> Starting point. Here is called the [GameManager](./GameManager.cs) or the temporal [tester](./MiniTest.cs).
>
> [⚠️] Here will be called the first test when ready.

**[GameManager](./GameManager.cs)**
> [⚠️] Not implemented
>
> Responsible for managing [Logic](.//Resourses/Logic/) and [Visual]() Resoruses, integrating menues, players, turns, levels and interface.

### [Resourses/](./Resourses/) 
> This is the main directory containing all game-related files and assets.

- **[Logic/](./Resourses/Logic/)**
  > This directory contains the core logic of the game, including gameplay mechanics and interactions.
  
    - **[Menue.cs](./Resourses/Logic/Menue.cs)**
      > Handles the menu system for the game by importing methods and associating them to characters. Once an instance is created you can execute a method by using [```Option()```](./Resourses/Logic/Menue.cs#L45-L54) with the associated char as a parameter. It's directly made for key inputs.
      >
      > [⚠️] Can be optimized    
      
    - **[Maze/](./Resourses/Logic/Maze/)** 
      > Contains files related to the maze generation, elements, and management.
      
      - **[Maze.cs](./Resourses/Logic/Maze/Maze.cs)**
        > Defines the class Maze structure and properties. A maze is a bidimensional array of rooms.

      - **[MazeBuilder.cs](./Resourses/Logic/Maze/MazeBuilder.cs)**
        > [⚠️] not fully implemented. 
        >
        > Partial class Maze responsible for building the maze by placing procedurally MapObjects like doors, obstacles, traps, and more in order to follow a logic established by an enumerated taxonomy of mazes. 
        >
        > Lee's algorithm will be used for intelligent location of mapObjects.

      - **[MazeGenerator.cs](./Resourses/Logic/Maze/MazeGenerator.cs)**
        > Partial class Maze that contains algorithms for generating maze logic by connecting rooms in a random and [recursive](./Resourses/Logic/Maze/MazeGenerator.cs#L32) way. 
      
      - **[Elements/](./Resourses/Logic/Maze/Elements/)**
        > Contains classes for various elements within the maze.

        - **[Cell.cs](./Resourses/Logic/Maze/Elements/Cell.cs)**
          > Represents individual cells in the maze. They can be a wall or a floor cell, and they can be walkable or not.

        - **[Item.cs](./Resourses/Logic/Maze/Elements/Item.cs)** 
          > [⚠️] not implemented. 
          >
          > Defines items that can be found in the maze, collected, and used by the player.

        - **[MapObject.cs](./Resourses/Logic/Maze/Elements/MapObject.cs)**:
          > [⚠️] not implemented. 
          >
          > Represents objects that can be placed in the maze. They can be doors, obstacles, traps, ventilation fences, terminals, boxes...
          > #
      - **[Rooms/](./Resourses/Logic/Maze/Rooms/)** 
        > Contains the Room class, divided into partial classes.

        - **[LogicRoom.cs](./Resourses/Logic/Maze/Rooms/LogicRoom.cs)**
          > Defines logic parameters and methods for the Room, aiming to the maze generation. It has properties for its position, size, and connections to other rooms.

        - **[Room.cs](./Resourses/Logic/Maze/Rooms/Room.cs)** 
          > Represents a room in the maze. Consists of a bidimensional array of cells.
          >
          > [⚠️] MapObject unimplemented.

    - **[Player/](./Resourses/Logic/Player/)** 
      > Contains player-related logic.

      - **[Player.cs](./Resourses/Logic/Player/Player.cs)** 
        > Defines the player character, abilities, inventory, and its interactions.
        >
        > [⚠️] only the movement and constructor methods are implemented.

    - **[Tools/](./Resourses/Logic/Tools/)** 
      > Contains utility classes used throughout the game.

      - **[Direction.cs](./Resourses/Logic/Tools/Direction.cs)**
        > Defines directions used for movement and relative position references.
        > Contains a [constructor](./Resourses/Logic/Tools/Direction.cs#L50) with preset values for the most used directions (up, down, left, right) associated with their corresponding vector values and the classic WSAD characters.
        >
        > [⚠️] the generalized version of the constructor is not implemented.

      - **[Excpt.cs](./Resourses/Logic/Tools/Excpt.cs)** 
        > Likely contains exception handling utilities for optimized error management. Example: [Exception](./Resourses/Logic/Tools/Excpt.cs#L14) for out of range exceptions.
        >
        >[⚠️] - Not fully implemented and messages are not clear.
      - **[MyEnum.cs](./Resourses/Logic/Tools/MyEnum.cs)** 
        > Defines custom enumerations for dynamic use.

      - **[Nest.cs](./Resourses/Logic/Tools/Nest.cs)**
        > [⚠️] not implemented. (Just thinking about automation of nested loops)

      - **[TL.cs](./Resourses/Logic/Tools/TL.cs)**
        > TL Tools, a class for general use methods. Adds more operations to the arrays, and position operations.

  - **[Sound/](./Resourses/Sound/)** 
    > This directory likely contains sound-related files.

    - **[SoundManager](./Resourses/Sound/SoundManager)**
      > [⚠️] not implemented. Manages sound effects and music within the game.

  - **[Visual/](./Resourses/Visual/)** 
    > Contains files related to the visual representation and interface of the game in the console.

    - **[Camera.cs](./Resourses/Visual/Camera.cs)**: 
      > Manages camera behavior and positioning. Generates an [image](./Resourses/Visual/Image.cs) of the map depending on the kind of camera and player position (if needed).

    - **[Image.cs](./Resourses/Visual/Image.cs)**
      > Handles image building and [printing](./Resourses/Visual/Image.cs#L47). Consists of a two-dimensional array of [pixels](./Resourses/Visual/Pixel.cs). 

    - **[Pixel.cs](./Resourses/Visual/Pixel.cs)**
      > Represents a single pixel that consists of two characters, background color, and character color. (In the console, two characters are something near to a square).

    - **[TextBox.cs](./Resourses/Visual/TextBox.cs)**
      > [⚠️] will manage text display within the game.

    - **[Textures.cs](./Resourses/Visual/Textures.cs)**: 
      > Handles texture loading and management. Consists of saved values for pixels that represent cells, objects, the player...

    - **[Interface/](./Resourses/Visual/Interface/)**
      > Contains files for the user interface.
      - **[Caption.cs](./Resourses/Visual/Interface/Caption.cs)**
        > Manages captions of keys and more user interactions with the UI.
        >
        > [⚠️] Only key caption is implemented.

      - **[Screen.cs](./Resourses/Visual/Interface/Screen.cs)**
        > Handles screen management, size, refresh, and transitions. Consists of an image made of other images of objects like the Camera, TextBox, and Menus. Contains the whole console visual.
        >
        > [⚠️] Not fully implemented.
#
Thanks for reading ;D
