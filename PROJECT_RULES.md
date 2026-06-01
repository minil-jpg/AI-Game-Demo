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
* Prefer explicit references over globals
* Keep systems beginner-friendly and readable

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
* Use tags, layers, or explicit references for gameplay classification; avoid checking GameObject names in gameplay logic

---

# Unity Best Practices

## Collider Consistency

* Collider bounds must closely match the visible sprite or intended gameplay shape.
* After creating or modifying prefabs, verify collider size, offset, and scale.
* Avoid manually oversized colliders unless explicitly required by gameplay.
* When using placeholder sprites, ensure BoxCollider2D or CircleCollider2D dimensions are reviewed after scaling.
* Verify collider visualization in the Scene view before considering a prefab complete.

## Physics Prefab Validation

Whenever creating a new physics-based prefab:

* Verify collider size matches visuals.
* Verify Rigidbody2D settings are appropriate for the object's role.
* Verify mass, damping, and material values.
* Verify the object behaves correctly when placed in a simple test scene.
* Explain any non-default physics settings that are applied.

---

# Unity MCP + AI Tool Usage Rules

## Script Creation

For creating or editing C# scripts:

* prefer direct filesystem editing
* avoid Unity MCP unless Unity-specific operations are required
* do not use Unity MCP for simple script generation
* generate .cs files directly in workspace when possible

Unity MCP should NOT be the default tool for:

* gameplay script generation
* architecture implementation
* refactors
* utility classes
* enum/data classes

---

## Unity MCP Usage

Use Unity MCP ONLY for:

* scene creation
* hierarchy setup
* component attachment
* inspector reference assignment
* prefab operations
* physics/component configuration
* Play Mode operations
* asset refresh operations

---

## Prompt Interpretation Rules

When a request includes both code generation and Unity scene setup:

1. create/edit scripts directly in filesystem first
2. use Unity MCP afterward only for Unity Editor interactions

Minimize unnecessary MCP operations.

Avoid:

* repeated hierarchy queries
* unnecessary asset refreshes
* re-reading unchanged scene data
* excessive verification operations

---

# Verification Rules

Allowed verification:

* scripts compile
* no console errors
* references assigned
* scene enters Play Mode
* required methods connected

Do NOT claim gameplay behavior was tested unless runtime interaction was actually simulated.

Disallowed claims unless actually tested:

* gameplay feels good
* controls are responsive
* launch behavior visually confirmed
* physics feels correct

---

# AI Workflow Rules

* Modify only requested scripts
* Preserve existing architecture
* Do not rename files unless requested
* Explain major architectural changes briefly
* Return full scripts instead of partial snippets
* Keep code beginner-friendly and readable
* Avoid overengineering
* Prefer small incremental implementations
* Placeholder-first workflow preferred

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
* Gameplay

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
