# Angry Birds AI Demo

A beginner-friendly Angry Birds style physics game created in Unity 6000 using an AI-assisted workflow.

## Goals

This project is designed to learn:

* AI-assisted Unity development
* Gemini CLI workflows
* Unity MCP scene editing
* Modular game architecture
* Git and version control
* Prompt engineering for game development
* Physics-based gameplay systems

## Tech Stack

* Unity 6000.4.8f1
* 2D Built-in Render Pipeline
* Old Input System
* Visual Studio Code
* Gemini CLI
* Unity MCP Server
* Git + GitHub

## Development Philosophy

This project follows an AI-first workflow:

* Plan systems before implementation
* Build small vertical slices
* Use modular architecture
* Keep prompts constrained and precise
* Refactor incrementally
* Commit stable features frequently

## Initial Gameplay Scope

### Phase 1

* Slingshot drag mechanic
* Bird launching
* Trajectory prediction
* Camera follow

### Phase 2

* Destructible blocks
* Pig enemies
* Collision damage

### Phase 3

* Scoring system
* Win/Lose conditions
* Multiple birds
* Level reset

### Phase 4

* Juice and polish
* Sound effects
* Particles
* UI polish

## Folder Structure

Assets/_Project contains all custom project content.

Third-party assets and packages should remain separate from project code.

## Git Workflow

Commit after every stable feature.

Example commits:

* Added slingshot drag system
* Implemented trajectory prediction
* Added camera follow behavior
* Refactored launch architecture

## AI Workflow Rules

* AI should modify only requested scripts
* Keep systems modular
* Avoid unnecessary complexity
* Prefer readability over cleverness
* Test after every generated feature
