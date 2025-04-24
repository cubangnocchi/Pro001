# Class Documentation

## Overview

This document provides detailed documentation for the classes in **DOWN STAIRS, BUNKER**. It covers the purpose, properties, methods, and relationships of each class to help developers understand and extend the codebase.

## Logic Classes

### Maze System

#### `Maze` Class

**Purpose**: Represents the entire maze structure and manages interactions within it.

**Properties**:
- `Room[,] mazeRooms`: 2D array of Room objects
- `int width`: Number of rooms horizontally
- `int height`: Number of rooms vertically
- `int roomSize`: Size of each room (in cells)

**Methods**:
- `Create(Maze.Type type)`: Generates a new maze based on the specified type
- `GetRoom(int x, int y)`: Returns the room at the specified coordinates
- `MoveObject(Player player, int direction)`: Moves a player in the specified direction
- `DoorPlacing(int[] roomPos, int direction, Door.TypeOfDoor doorType)`: Places a door between rooms
- `GetMapObjects()`: Returns all objects placed in the maze

**Relationships**:
- Contains multiple `Room` objects
- Interacts with `Player` objects for movement
- Creates and manages `MapObject` objects like doors

#### `Room` Class

**Purpose**: Represents a single room within the maze.

**Properties**:
- `Cell[,] cells`: 2D array of cells that make up the room
- `int[] position`: Room's position in the maze
- `int size`: Size of the room (in cells)
- `bool[] connections`: Array indicating which directions have connections to other rooms

**Methods**:
- `ConnectedDirections()`: Returns an array of directions that have connections
- `IsConnected()`: Checks if the room is connected to any other room
- `Connect(int direction)`: Creates a connection in the specified direction

**Relationships**:
- Contained within the `Maze` class
- Contains multiple `Cell` objects

#### `Cell` Class

**Purpose**: Represents the smallest unit in the maze structure.

**Properties**:
- `bool isWall`: Indicates if the cell is a wall
- `bool isWalkable`: Indicates if the cell can be walked on

**Methods**:
- `SetWall(bool value)`: Sets the cell as a wall or floor
- `SetWalkable(bool value)`: Sets whether the cell can be walked on

**Relationships**:
- Contained within `Room` objects

#### `MapObject` Class

**Purpose**: Base class for all objects that can be placed in the maze.

**Properties**:
- `int[] roomPosition`: Position of the room containing the object
- `int[] cellPosition`: Position of the cell containing the object
- `Action[] actions`: Array of actions that can be performed on this object

**Methods**:
- `GetAction(int index)`: Returns the action at the specified index
- `GetRoomPos()`: Returns the room position
- `GetCellPos()`: Returns the cell position

**Relationships**:
- Placed within the `Maze`
- Parent class for specific object types like `Door`

#### `Door` Class (extends `MapObject`)

**Purpose**: Represents doors that connect rooms in the maze.

**Properties**:
- `TypeOfDoor doorType`: Type of the door (CanOpen, Locked, etc.)
- `bool isOpen`: Indicates if the door is open

**Methods**:
- `Open()`: Opens the door
- `Close()`: Closes the door
- `Toggle()`: Toggles between open and closed states

**Enumerations**:
- `TypeOfDoor`: Defines different door types (CanOpen, Locked, CanOpenOneSide, etc.)

**Relationships**:
- Extends the `MapObject` class
- Interacts with `Player` through actions

### Player System

#### `Player` Class

**Purpose**: Represents a player character in the game.

**Properties**:
- `string name`: Player's name
- `int[] position`: Array containing [roomX, roomY, cellX, cellY] coordinates

**Methods**:
- `GetRoomPos()`: Returns the room position [x, y]
- `GetCellPos()`: Returns the cell position [x, y]
- `SetPosition(int[] newPosition)`: Sets the player's position

**Relationships**:
- Interacts with the `Maze` for movement
- Interacts with `MapObject` instances through actions

### Tools

#### `Direction` Class

**Purpose**: Handles directional vectors and conversions.

**Properties**:
- `int[][] directions`: Array of direction vectors
- `char[] chars`: Characters associated with directions (WSAD)

**Methods**:
- `GetInt(char c)`: Converts a character (WSAD) to a direction index
- `GetVector(int dir)`: Returns the vector for a direction index

#### `TL` (Tools) Class

**Purpose**: Provides utility methods for array operations and position calculations.

**Methods**:
- `ArrEqual(int[] arr1, int[] arr2)`: Checks if two arrays are equal
- `IsCloseDir(int[] pos1, int[] pos2)`: Checks if two positions are adjacent and returns the direction

#### `Menue` Class

**Purpose**: Manages menu systems and user input.

**Properties**:
- `string title`: Menu title
- `char[] keys`: Array of keys for options
- `string[] options`: Array of option descriptions
- `Action[] methods`: Array of methods to execute for each option

**Methods**:
- `Print()`: Displays the menu
- `Option(char key)`: Executes the method associated with the key
- `OptionLoop()`: Continuously waits for input and executes options

## Visual Classes

#### `Camera` Class

**Purpose**: Manages the view of the game world.

**Methods**:
- `Room(Room room, Player player, MapObject[] objects)`: Creates an image of a room with player and objects
- `AllMapFixed(Maze maze)`: Creates an image of the entire maze

**Relationships**:
- Uses `Image` to create visual representations
- Interacts with `Maze`, `Room`, and `Player` to determine what to display

#### `Image` Class

**Purpose**: Represents a visual image composed of pixels.

**Properties**:
- `Pixel[,] pixels`: 2D array of pixels
- `int width`: Width of the image
- `int height`: Height of the image

**Methods**:
- `SetPixel(int x, int y, Pixel pixel)`: Sets a pixel at the specified coordinates
- `Print()`: Displays the image in the console

**Relationships**:
- Contains `Pixel` objects
- Used by `Camera` to create visual representations

#### `Pixel` Class

**Purpose**: Represents a single display unit in the console.

**Properties**:
- `char[] chars`: Two characters that make up the pixel
- `Color background`: Background color
- `Color foreground`: Foreground color

#### `Textures` Class

**Purpose**: Provides predefined textures for game elements.

**Methods**:
- `GetTxtr(Txtr texture)`: Returns a pixel with the specified texture

**Enumerations**:
- `Txtr`: Defines different texture types (wall, floor, player1, player2, etc.)

## Interface Classes

#### `Caption` Class

**Purpose**: Manages user input and display captions.

**Methods**:
- `GetKey_asChar()`: Gets a key press and returns it as a character

#### `Screen` Class

**Purpose**: Manages the entire console display.

**Methods**:
- `Testing()`: Test method for screen functionality
- `ResolutionTest(int width, int height)`: Tests different console resolutions

## Testing

#### `MiniTest` Class

**Purpose**: Contains test methods for various game features.

**Methods**:
- `Run()`: Main entry point for tests
- `TestMenue()`: Displays a menu of test options
- `GeneratedMaze001()`: Tests maze generation
- `MovementTest002()`: Tests player movement
- `TurnTest001()`: Tests turn-based gameplay
- `DoorTest()`: Tests door functionality

## Relationships Between Classes

### Core Game Flow

1. `Program` initializes the game
2. `MiniTest` provides test scenarios
3. `Maze` generates the game world
4. `Player` moves within the maze
5. `Camera` creates visual representations
6. `Image` renders to the console

### Object Hierarchy

- `Maze` contains multiple `Room` objects
- `Room` contains multiple `Cell` objects
- `Maze` also contains `MapObject` objects (like `Door`)
- `Player` exists within the `Maze`

### Interaction Flow

1. User input is captured via `Caption.GetKey_asChar()`
2. Input is processed (e.g., movement via WSAD keys)
3. `Maze.MoveObject()` updates player position
4. `Camera` creates a new view based on updated state
5. `Image.Print()` displays the updated view

## Implementation Status

Many classes are partially implemented or have planned features not yet developed. The README.md file contains [⚠️] markers indicating components that are not fully implemented.

## Extension Points

The modular design allows for easy extension:

1. New `MapObject` types can be created by extending the base class
2. Additional maze generation algorithms can be added to `MazeGenerator`
3. New visual representations can be added to `Textures`
4. Player abilities can be expanded in the `Player` class