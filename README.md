# Prop Hunt (Unity Project)

A **single-player Prop Hunt style game prototype** made in Unity. Players can change their shape into different props (cube, cylinder, cone, etc.) and spawn temporary clones of themselves.  

---

## 🎮 Features

- **Player Prop Switching:**  
  - Press **Left Shift** to cycle through available props.
  - Props are pre-made prefabs stored under the player model.

- **Clone Creation:**  
  - Press **Left Control** to spawn a temporary clone of the current prop.
  - Clones are automatically destroyed after a configurable timer (default: 3.5 seconds).

- **Movement & Jump:**  
  - WASD / Arrow Keys for movement.
  - Spacebar for jumping.
  - Rigidbody-based physics movement.

- **Prefab-based Setup:**  
  - All props are created as prefabs for easy expansion and swapping.
  - Player model hierarchy:
    ```
    Player
      └── Model
            └── CurrentProp (Cube / Cylinder / Cone etc.)
    ```
---
## 🧩 Project Structure

