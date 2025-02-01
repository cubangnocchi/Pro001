# DOWN STAIRS, BUNKER 

> **by Cuban Gnocchi Games 🥟** 

> Nuclear winter is hard, let's see if getting inside that bunker will help...
**DOWN STAIRS, BUNKER** is a multiplayer game where you and your friends will 
have to explore and try to survive in a procedurally generated bunker like a maze
full of puzzle-like challenges where teamwork is needed.

## How to run it:
> ⚠️ *Currently in development; there is nothing to run yet.*
>
>  *A testing version is **coming soon** very soon.*
>  #

1. Clone the [repository](https://github.com/cubangnocchi/Pro001 "repository link") using **git bach**.
  
   ```bach
   git clone https://github.com/cubangnocchi/Pro001.git
   ```

2. Open the project directory in your console.
3. You will need [.NET 8.0](https://dotnet.microsoft.com/en-us/download/dotnet/8.0 "click for downloading dotnet8.0") for the next step
4. Use the following commands in order to run it successfully: 

   ```bach
   dotnet add package Spectre.Console
   ```
  
    ```bach
   dotnet run
    ```

5. **Enjoy the game**!


## How to play it:
- Instructions will be given to the user in the game.
- Menu keys:
  |**key**|**what it do**|
  |--|--|
  |x|exit|
  |i|information|
  |any number|other options are asigned to numbers|
#

- In-game keys:
  |**key**|**what it do**|
  |---|----------------|
  | w|walk up|
  | s|walk down|
  | a|walk left|
  | d|walk right|
  | e|interact with object|
#
### Actual stage of the project:
- Working on the first test version where you can explore a procedurally generated maze.

## Code structure and how it works:

### Resourses/ 
> This is the main directory containing all game-related files and assets.

- **Logic/**
  > This directory contains the core logic of the game, including gameplay mechanics and interactions.
  
    - **Menue.cs**
      > Handles the menu system for the game by importing methods and asociating them to characters.Once an instanse is created you can execute a mehtod by using ```exampleMenue.Option(exampleChar);``` with the asociated char as a parameter. It's directly made for key inputs.    
      
    - **Maze/** 
      > Contains files related to the maze generation, elements and management.
      
      - **Maze.cs**:
        > Defines the class Maze structure and properties. A maze is a bidimentional array of rooms.

      - **MazeBuilder.cs**:
        > Responsible for building the maze by placig proceduraly MapObjects like doors, obstacules, traps and more in order to follow a logic stabliched.

      - **MazeGenerator.cs**: 
        > partial class Maze that contains algorithms for generating maze logic by connectin rooms in a random and recurcive way.
      
      - **Elements/**: Contains classes for various elements within the maze.
        - **Cell.cs**: Represents individual cells in the maze.
        - **Item.cs**: Defines items that can be found in the maze.
        - **MapObject.cs**: Represents objects that can be placed in the maze.
      - **Rooms/**: Contains classes for different rooms within the maze.
        - **LogicRoom.cs**: Defines logic for specific rooms.
        - **Room.cs**: Represents a room in the maze.
    - **Player/**: Contains player-related logic.
      - **Player.cs**: Defines the player character and its interactions.
    - **Tools/**: Contains utility classes and enums used throughout the game.
      - **Direction.cs**: Defines directions for movement.
      - **Excpt.cs**: Likely contains exception handling utilities.
      - **MyEnum.cs**: Defines custom enumerations used in the game.
      - **Nest.cs**: Possibly contains logic for nesting objects or behaviors.
      - **TL.cs**: May contain tools for handling text or logging.
      - **WSAD.cs**: Handles input for movement using the WSAD keys.
  - **Sound/**: This directory likely contains sound-related files and managers.
    - **SoundManager**: Manages sound effects and music within the game.
  - **Visual/**: Contains files related to the visual representation of the game.
    - **Camera.cs**: Manages camera behavior and positioning.
    - **Image.cs**: Handles image loading and rendering.
    - **Pixel.cs**: Likely deals with pixel-level operations or effects.
    - **TextBox.cs**: Manages text display within the game.
    - **Textures.cs**: Handles texture loading and management.
    - **Interface/**: Contains files for the user interface.
      - **Caption.cs**: Manages captions or labels in the UI.
      - **Screen.cs**: Handles screen management and transitions.

## Contributing:
- [Add guidelines for contributing to the project, if applicable.]

## License:
- [Include license information if applicable.]
