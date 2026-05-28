# PROJECT_RULES.md

## Engine Rules

* Unity Version: 6000.4.8f1
* Use 2D physics only
* Use Built-in Render Pipeline
* Use Old Input System

---

# Architecture Rules

* Separate input from gameplay logic
* Prefer composition over inheritance
* Keep systems modular
* One responsibility per script
* Avoid tightly coupled systems
* Avoid static managers unless approved
* Avoid singletons unless absolutely necessary

---

# Code Style Rules

* Keep scripts under 250 lines when possible
* Use PascalCase for classes and public members
* Use camelCase for private fields
* Use [SerializeField] instead of public where appropriate
* Add Header attributes for inspector readability
* Avoid magic numbers
* Use clear descriptive variable names
* Add comments only for non-obvious logic

---

# Unity Rules

* Avoid FindObjectOfType in Update loops
* Cache references whenever possible
* Use Rigidbody2D physics
* Use prefabs for reusable objects
* Keep inspector clean and organized

---

# AI Workflow Rules

* Modify only requested scripts
* Preserve existing architecture
* Do not rename files unless requested
* Explain major architectural changes briefly
* Return full scripts instead of partial snippets
* Keep code beginner-friendly and readable
* Avoid overengineering

---

# Naming Conventions

## Scripts

* BirdLauncher
* SlingshotController
* TrajectoryRenderer
* CameraFollow
* LevelManager

## Prefabs

* Bird_Red
* Pig_Basic
* Block_Wood

## Scenes

* MainMenu
* Level_01
* Sandbox

---

# Development Workflow

1. Plan feature
2. Define constraints
3. Generate small systems
4. Test immediately
5. Debug incrementally
6. Refactor if needed
7. Commit stable version to Git

---

# Prompting Philosophy

Good prompts are:

* specific
* constrained
* architecture-aware
* small in scope

Avoid giant multi-system prompts.
