# Angry Birds AI Demo - Project Instructions

This project is a 2D physics-based game inspired by Angry Birds, developed using an AI-assisted workflow in Unity 6000.

## Project Overview

- **Engine:** Unity 6000.4.8f1
- **Render Pipeline:** 2D Built-in Render Pipeline
- **Physics:** 2D Physics (Rigidbody2D, BoxCollider2D, etc.)
- **Input System:** Legacy Input System (per `PROJECT_RULES.md`), though the Input System package is present.
- **Target Platform:** Desktop / Web

## Project Structure

All custom assets and code must reside within `Assets/_Project/`.

- `Assets/_Project/Art/`: Sprites, Materials, UI assets.
- `Assets/_Project/Audio/`: Sound effects and music.
- `Assets/_Project/Prefabs/`: Reusable GameObjects (Birds, Enemies, Blocks).
- `Assets/_Project/Scenes/`: Game levels and sandbox scenes.
- `Assets/_Project/Scripts/`: C# scripts organized by responsibility.
    - `Core/`: Core engine-like systems.
    - `Gameplay/`: Game-specific logic (Launching, Scoring).
    - `Input/`: Input handling (Drag, Click).
    - `Physics/`: Custom physics interactions.
    - `UI/`: Menu and HUD logic.
    - `Utilities/`: Helper classes and extensions.
- `Assets/_Project/ScriptableObjects/`: Data-driven configurations.

## Development Conventions

### Coding Style
- **Naming:** PascalCase for classes and public members; camelCase for private fields.
- **Encapsulation:** Use `[SerializeField]` for private fields that need inspector access; avoid public fields.
- **Organization:** Use `[Header("...")]` for inspector categorization.
- **Constraints:** Keep scripts under 250 lines. Avoid magic numbers.
- **Architecture:** 
    - Prefer **composition over inheritance**.
    - Separate input handling from gameplay logic.
    - Avoid singletons and static managers where possible.
    - One responsibility per script.

### Unity Best Practices
- Cache component references (e.g., in `Awake` or `Start`).
- Avoid `FindObjectOfType` or `GameObject.Find` in `Update`.
- Use Prefabs for all reusable game elements.
- Maintain a clean hierarchy with parent "folder" GameObjects.

## AI-Assisted Workflow

- **Planning:** Always plan the system/feature before implementation.
- **Surgical Edits:** Modify only the scripts requested.
- **Modularity:** Build small, testable, and modular systems.
- **Verification:** Test after every feature implementation. 
- **Documentation:** Refer to `PROJECT_RULES.md` and `PROMPT_PATTERNS.md` for specific guidance on how to prompt for new features or fixes.
- Do not modify unrelated systems or files unless explicitly requested.
- Preserve existing gameplay behavior during refactors unless otherwise requested.
- Prioritize clarity and iteration speed over premature optimization.
- Recommend logical Git commits after stable feature completion.

## Key Commands (Reference)

- **Test Run:** Use `mcp_unityMCP_run_tests` if tests are implemented.
- **Compilation Check:** Use `mcp_unityMCP_read_console` to monitor for errors.
- **Scene Setup:** Use `mcp_unityMCP_manage_gameobject` and `mcp_unityMCP_manage_components` for procedural setup via MCP.

---
*Note: This file is a foundational mandate for Gemini CLI. Adhere to these instructions for all development tasks.*
