# Code Structure Documentation

## Overview

This document provides a detailed explanation of the code structure for **DOWN STAIRS, BUNKER**, a multiplayer game where players explore procedurally generated bunkers built like mazes full of puzzle-like challenges requiring teamwork.

## Project Architecture

The project follows a modular architecture with clear separation of concerns:

```
Pro001/
├── Program.cs             # Entry point
├── GameManager/           # Game orchestration (not fully implemented)
├── Resourses/             # Main game resources
│   ├── Logic/             # Game mechanics and rules
│   │   ├── Maze/          # Maze generation and management
│   │   ├── Player/        # Player mechanics
│   │   └── Tools/         # Utility classes
│   ├── Visual/            # Visual representation
│   └── Sound/             # Audio management (not implemented)
└── Testing/               # Test implementations
```

## Core Components

### Program.cs

The entry point of the application. Currently calls `MiniTest.Run()` to execute test scenarios instead of the main game loop.

### Maze System

The maze system is the central component of the game, consisting of several interconnected classes:

#### Maze Class

The `Maze` class is implemented as a partial class split across multiple files:

- **Maze.cs**: Core maze properties and methods
  - Represents a 2D array of rooms
  - Handles object movement within the maze
  - Manages connections between rooms

- **MazeGenerator.cs**: Handles procedural generation
  - Implements recursive algorithms for connecting rooms
  - Creates the logical structure of the maze

- **MazeBuilder.cs**: Handles object placement (partially implemented)
  - Will use Lee's algorithm for intelligent object placement
  - Responsible for placing doors, obstacles, traps, etc.

#### Room System

Rooms are the building blocks of the maze:

- **Room.cs**: Represents a room as a 2D array of cells
  - Manages the physical structure of each room
  - Handles rendering and interaction within rooms

- **LogicRoom.cs**: Handles the logical aspects of rooms
  - Manages connections to other rooms
  - Used during maze generation

#### Cell System

`Cell` is the most basic unit of the maze:

- Represents individual positions within a room
- Can be walls or floor cells
- Has properties for walkability

### MapObject System

The `MapObject` class represents interactive objects within the maze:

- **Door**: Connects rooms, can be opened/closed, locked/unlocked
- **Obstacles**: Block player movement
- **Traps**: Apply penalties to players
- **Items**: Can be collected and used (not implemented)

### Player System

The `Player` class represents the player character:

- Handles movement within the maze
- Manages player position (room and cell coordinates)
- Will handle inventory and abilities (partially implemented)

### Visual System

The visual system handles rendering the game in the console:

- **Camera.cs**: Determines what part of the maze to display
  - Different camera modes (room view, map view)
  - Follows player movement

- **Image.cs**: Builds and renders images
  - Composed of a 2D array of pixels
  - Handles printing to console

- **Pixel.cs**: Represents a single display unit
  - Contains character, foreground, and background color
  - Two characters represent a square in the console

- **Textures.cs**: Manages visual representations
  - Predefined textures for game elements
  - Consistent visual styling

### Tools

Utility classes that provide common functionality:

- **Direction.cs**: Handles directional movement and vectors
- **TL.cs**: General utility methods for arrays and positions
- **Menue.cs**: Menu system for user interaction
- **Excpt.cs**: Custom exception handling

## Game Flow

1. The game starts in `Program.cs`
2. Currently runs test scenarios via `MiniTest.Run()`
3. Test menu allows selection of different test scenarios:
   - Maze generation
   - Player movement
   - Multiplayer testing
   - Door interaction testing

## Implementation Status

The project is in active development with several components partially implemented:

- **Fully Implemented**:
  - Basic maze generation
  - Room and cell structure
  - Simple player movement
  - Basic rendering system
  - Menu system

- **Partially Implemented**:
  - Door mechanics
  - Player interaction with objects
  - Camera system

- **Not Yet Implemented**:
  - Complete game loop
  - Sound system
  - Advanced object placement
  - Full inventory system
  - Multiplayer synchronization

## Future Development

Planned features and improvements:

- Complete implementation of the `GameManager` class
- Intelligent object placement using Lee's algorithm
- Enhanced player abilities and interactions
- Full multiplayer support
- Sound effects and music
- More interactive objects and puzzles

## Testing

The `Testing` directory contains test implementations:

- **MiniTest.cs**: Main test runner with various test scenarios
- **Tests001.cs** and **Tests002.cs**: Specific test cases

Tests can be run through the test menu by executing the application.