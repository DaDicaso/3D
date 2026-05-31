# OpenGL Lighting

A 3D graphics application demonstrating OpenGL lighting techniques with an interactive camera system.

## Overview

This project is a C++ OpenGL application that renders a 3D cube with lighting effects. It features a custom shader system and an interactive first-person camera controlled via mouse and keyboard.

## Features

- **3D Cube Rendering**: Displays a textured 3D cube using modern OpenGL
- **Interactive Camera**: First-person camera with:
  - Mouse look (yaw and pitch)
  - Scroll wheel zoom
  - Keyboard navigation support
- **Custom Shader System**: GLSL shaders for vertex and fragment processing
- **Lighting Support**: Infrastructure for implementing lighting calculations

## Dependencies

- **GLFW**: Window creation and input handling
- **GLAD**: OpenGL function loading
- **GLM**: Mathematics library for vectors and matrices
- **STB Image**: Image loading for textures

## Project Structure

```
.
├── include/
│   ├── Camera.h         # Interactive camera class
│   ├── glad/glad.h      # OpenGL loader
│   ├── KHR/khrplatform.h
│   ├── Shader.h         # Shader compilation and management
│   └── stb_image.h      # Image loading utility
├── shaders/
│   ├── shader.fs        # Fragment shader
│   └── shader.vs        # Vertex shader
├── src/
│   ├── glad.c           # OpenGL implementation
│   └── main.cpp         # Application entry point
├── build/               # Build directory
└── app                  # Compiled executable
```

## Building

The project can be compiled using a C++ compiler with the required dependencies linked:

```bash
g++ -o app src/main.cpp src/glad.c -Iinclude -lglfw -lGL -lX11 -lpthread -lXrandr -lXi -ldl
```

Or use the provided build system if configured.

## Controls

| Input | Action |
|-------|--------|
| Mouse | Look around (yaw/pitch) |
| Scroll | Zoom in/out |
| Escape | Close application |

## Technical Details

- **OpenGL Version**: 3.3 Core Profile
- **Screen Resolution**: 1920x1080
- **Rendering**: Uses VAO/VBO for efficient vertex data management
- **Shaders**: Custom vertex and fragment shaders with transformation matrices

## Camera System

The camera implements:
- Euler angle-based rotation (yaw/pitch)
- Configurable movement speed and mouse sensitivity
- View matrix calculation using `glm::lookAt`
- Vector-based movement (forward/backward/left/right)

## Shaders

### Vertex Shader (`shader.vs`)
- Handles vertex position transformation
- Applies model, view, and projection matrices
- Passes texture coordinates to fragment shader

### Fragment Shader (`shader.fs`)
- Samples from two textures
- Mixes textures with a 0.3 blend factor
- Outputs final pixel color

## License

This project is for educational purposes.
