<h1 align="center">🎮 Ball Game — Unity 3D Project</h1>

<p align="center">
  <em>A clean, responsive, and extendable 3D ball-roller game built in Unity using C# and physics-based controls.</em>
</p>

<p align="center">
  <a href="https://unity.com/"><img src="https://img.shields.io/badge/Engine-Unity-000000.svg?style=flat&logo=unity"></a>
  <a href="https://github.com/Abhi12002/Ball-Game-Using-Unity/stargazers"><img src="https://img.shields.io/github/stars/Abhi12002/Ball-Game-Using-Unity?style=social"></a>
</p>

---

## 📑 Table of Contents

- [📝 Project Overview](#-project-overview)
- [🎮 Gameplay Demo](#-gameplay-demo)
- [🧠 Architecture & Design Notes](#-architecture--design-notes)
- [🧾 Key Scripts Explained](#-key-scripts-explained)
- [🕹️ Controls](#️-controls)
- [📁 Project Structure](#-project-structure)
- [🚀 Getting Started](#-getting-started)
- [🔧 Tech Stack](#-tech-stack)
- [🐞 Known Issues](#-known-issues)
- [🛠️ Future Work](#️-future-work)
- [📓 Dev Log](#-dev-log)
- [📜 License](#-license)
- [📬 Contact](#-contact)

---

## 📝 Project Overview

This is a Unity-based 3D ball movement game. You control a ball that rolls across platforms, collects pickups, avoids obstacles, and finishes levels. It's physics-driven, responsive, and minimal — designed for learning, experimentation, and extension into larger gameplay systems.

---

## 🎮 Gameplay Demo

<p align="center">
  <a href="https://github.com/Abhi12002/Ball-Game-Using-Unity/blob/main/BallGame.mp4">
    <img src="https://img.shields.io/badge/▶ Watch%20Video-BallGame.mp4-blue?style=for-the-badge">
  </a>
</p>

---

## 🧠 Architecture & Design Notes

This project follows Unity's ECS-inspired architecture with the following principles:

- **Physics-Based Movement**: Movement handled through `Rigidbody` forces in `FixedUpdate()` to align with Unity’s physics timestep.
- **Separation of Concerns**: Input, movement, scoring, and collision logic live in dedicated scripts for clarity and extensibility.
- **Trigger-Based Interactions**: Collectibles and obstacles rely on `OnTriggerEnter` for lightweight and modular interactions.

---

## 🧾 Key Scripts Explained

### 📄 `BallController.cs`
Handles player input and applies movement using Rigidbody physics:

```csharp
void FixedUpdate() {
    float moveX = Input.GetAxis("Horizontal");
    float moveZ = Input.GetAxis("Vertical");
    Vector3 movement = new Vector3(moveX, 0.0f, moveZ);
    rb.AddForce(movement * speed);
}
```

- Physics-based, frame-rate independent movement
- Easily tweakable `speed` parameter

---

### 📄 `PickupHandler.cs`
Detects collisions with collectibles and updates score:

```csharp
void OnTriggerEnter(Collider other) {
    if (other.CompareTag("Pickup")) {
        other.gameObject.SetActive(false);
        score += 1;
    }
}
```

- Uses Unity’s tag system for quick filtering
- Easily extendable to add sound, effects, UI updates

---

## 🕹️ Controls

| Action         | Key / Input         |
|----------------|---------------------|
| Move Ball      | `W`, `A`, `S`, `D` / Arrow Keys |
| Jump / Special | *(Optional)*        |
| Restart Level  | `R` *(if coded)*    |
| Quit Game      | `Esc` *(if enabled)*|

---

## 📁 Project Structure

```
Ball-Game-Using-Unity/
├── Assets/                # Game scenes, scripts, prefabs
│   ├── Scenes/            # Main scene(s)
│   └── Scripts/           # Core game logic
├── Packages/              # Unity packages
├── ProjectSettings/       # Unity config files
├── BallGame.mp4           # Gameplay demo
├── .gitignore             # Git exclusions
└── README.md              # This file
```

---

## 🚀 Getting Started

### 1. Clone the Repo

```bash
git clone https://github.com/Abhi12002/Ball-Game-Using-Unity.git
```

### 2. Open in Unity

- Launch Unity Hub
- Click "Add" and select this folder
- Open the main scene from `Assets/Scenes`
- Press ▶️ to play

---

## 🔧 Tech Stack

- 🎮 **Unity Engine** (2021.x or newer)
- 🧠 **C# Scripting**
- 📁 **Git for Version Control**
- 💡 **MonoBehaviour / Rigidbody System**
- 🔄 Unity Input Manager

---

## 🐞 Known Issues

- Ball may get stuck on edges due to mesh collider overlaps
- Jump logic stubbed but not implemented
- No UI yet for score tracking or restart prompts

---

## 🛠️ Future Work

- 🧮 Add UI for score, timer, win/lose state
- 🗺️ Level management system (multiple stages)
- 🔊 Sound FX and background music
- 📱 Mobile controls and touchscreen support
- ☁️ WebGL/Android builds
- 🧪 Add unit tests for core logic (input, collision)

---

## 📓 Dev Log

| Version | Updates                                         |
|---------|-------------------------------------------------|
| 1.0     | Initial release with player movement, pickups   |
| 1.1     | Code cleanup, added demo video, .gitignore      |
| 1.2     | Refactored input logic and separated UI stubs   |

---

## 📜 License

This project is licensed under the **MIT License** — feel free to use, modify, and distribute it. Credit is appreciated but not required.

---

## 📬 Contact

**Abhinav Mishra**  
📫 [GitHub](https://github.com/Abhi12002)  
🔗 [LinkedIn](https://www.linkedin.com/in/abhinav-mishra-4b72b120b/)

> ⭐ If you found this useful or inspiring, drop a star!
