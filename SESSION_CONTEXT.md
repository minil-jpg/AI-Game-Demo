# SESSION_CONTEXT.md

## Project

Angry Birds AI Demo

## Current Status

Project foundation complete.

### Environment

* Unity 6000.4.8f1
* 2D Built-in Render Pipeline
* Legacy Input System
* VS Code
* Git initialized
* GitHub connected
* Unity MCP configured
* AI-assisted workflow

---

# Implemented Systems

## Bird Launch System

Implemented:

* Bird drag mechanic
* Drag distance constraint
* Launch force calculation
* Rigidbody2D-based launch
* Bird state management

Key Scripts:

* BirdLauncher
* DragHandler

Status:

✅ Working

---

## Trajectory Prediction

Implemented:

* Predicted launch path visualization
* Trajectory shown during drag
* Trajectory hidden after launch
* Uses same launch calculations as BirdLauncher

Key Scripts:

* TrajectoryRenderer

Status:

✅ Working

---

## Camera Follow

Implemented:

* Camera stays focused on slingshot before launch
* Camera follows bird after launch
* Smooth horizontal tracking
* Camera behavior similar to Angry Birds prototype

Key Scripts:

* CameraFollow

Status:

✅ Working

---

## Bird Reset System

Implemented:

Automatic Reset:

* Detects when launched bird has settled
* Waits 2 seconds
* Resets bird to launch position

Manual Reset:

* Press R to reset bird immediately

Reset Behavior:

* Position reset
* Rotation reset
* Velocity cleared
* Physics state restored
* Camera reset

Status:

✅ Working

---

# Scene Structure

Gameplay

* Environment
* Slingshot

  * LaunchPoint
  * LeftAnchor
  * RightAnchor
* Birds

  * Bird_Red
* Camera

---

# Existing Prefabs

Birds:

* Bird_Red

Blocks:

* None yet (next task)

---

# Physics Notes

Bird uses:

* Rigidbody2D
* CircleCollider2D

BirdLauncher currently contains:

* Launch logic
* Ground detection
* Settling detection
* Sleep logic

Possible future refactor:

* Move landing/settling behavior into dedicated component

Not required currently.

---

# Architecture Rules

Must Follow:

* Separate input from gameplay logic
* Prefer composition over inheritance
* Avoid unnecessary singletons
* Avoid unnecessary static managers
* One responsibility per script
* Keep scripts beginner-friendly
* Preserve existing architecture during refactors
* Use placeholder-first workflow

---

# Current Goal

Create first reusable wooden block prefab.

Requirements:

* Placeholder visuals
* Rigidbody2D
* BoxCollider2D
* PhysicsMaterial2D
* Stable stacking behavior
* Suitable for future structures

---

# Next Planned Milestones

1. Wooden Block Prefab
2. Block Structures
3. Pig Prefab
4. Collision Damage
5. Pig Death
6. Win Condition
7. Multiple Birds
8. Level System
9. UI

---

# Known Issues

* Block_Wood collider currently appears larger than visual sprite.
* Needs investigation and correction so collider matches rendered dimensions.

---

# Last Stable Milestone

Completed:

* Drag system
* Launch system
* Trajectory prediction
* Camera follow
* Bird reset system

Project is ready to begin environment interaction and target gameplay.
