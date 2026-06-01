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

  * Ground
  * TestTower

    * Block_Wood_Long_LeftLeg
    * Block_Wood_Long_RightLeg
    * Block_Wood_Medium_TopBeam
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

* Bird_Red (scene instance, no prefab asset)

Blocks:

* Block_Wood — base plank (2.0, 0.5) scale → 0.32 × 0.08 world. Mass 1.
* Block_Wood_Small — 2× bird diameter wide, 0.5× tall → 0.60 × 0.15 world. Mass 3.52.
* Block_Wood_Medium — 4× bird diameter wide, 0.5× tall → 1.20 × 0.15 world. Mass 7.03.
* Block_Wood_Long — 8× bird diameter wide, 0.5× tall → 2.40 × 0.15 world. Mass 14.06.

---

# Physics Notes

Bird uses:

* Rigidbody2D
* CircleCollider2D
* Bird_Red world diameter: 0.30 (local bounds 0.20 × scale 1.5)

Blocks use:

* Rigidbody2D (Dynamic)
* BoxCollider2D (local size 0.16 × 0.16 matches sprite local bounds)
* Wood_PhysicsMaterial2D (shared across all block variants)
* Density ~39.1 (mass scales with area)

All block colliders verified matching sprite bounds.

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

Create reusable wooden block prefabs and test structures.

Completed:

* Block_Wood base prefab with BoxCollider2D matching sprite
* Block_Wood_Small / Medium / Long variants (sized to bird diameter)
* Wood_PhysicsMaterial2D for consistent physics
* TestTower structure (2 vertical Long legs + Medium beam on top)
* Collider-world-size matching verified on all prefabs

---

# Next Planned Milestones

1. ✅ Wooden Block Prefab (base + 3 sizes)
2. ✅ Block Structures (TestTower)
3. Pig Prefab
4. Collision Damage
5. Pig Death
6. Win Condition
7. Multiple Birds
8. Level System
9. UI

---

# Known Issues

* None currently known.

---

# Last Stable Milestone

Completed:

* Drag system
* Launch system
* Trajectory prediction
* Camera follow
* Bird reset system
* Block_Wood prefab (collider fix)
* Block_Wood_Small / Medium / Long (bird-relative sizes)
* Wood_PhysicsMaterial2D
* TestTower structure (rotated legs + top beam)
* git-autocommit skill and opencode config

Project has environment interaction (blocks, test structures) ready.
