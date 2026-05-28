# PROMPT_PATTERNS.md

# New System Prompt

Create a modular Unity system.

## Context

* Unity 6000.4.8f1
* 2D Built-in Render Pipeline
* Old Input System
* Angry Birds style physics gameplay

## Requirements

* Keep beginner-friendly
* Separate responsibilities clearly
* Avoid singletons
* Keep architecture modular
* Use clear naming conventions
* Follow PROJECT_RULES.md

## Output

* Return complete scripts only
* Explain inspector setup
* Explain scene setup briefly
* Include important comments only

---

# Refactor Prompt

Refactor this code for readability and modularity.

## Constraints

* Preserve behavior
* Do not change public API unless necessary
* Keep beginner readability
* Avoid overengineering
* Keep compatibility with existing systems

## Goals

* Improve readability
* Reduce coupling
* Improve inspector usability
* Improve naming consistency

---

# Bug Fix Prompt

Bug:
[describe issue]

Expected Behavior:
[expected behavior]

Current Behavior:
[current behavior]

Relevant Scripts:
[list scripts]

## Constraints

* Minimal changes only
* Preserve architecture
* Explain root cause briefly
* Do not modify unrelated systems

---

# Feature Extension Prompt

Extend the existing system.

## Existing System

[describe current system]

## New Feature

[describe requested feature]

## Constraints

* Preserve current behavior
* Maintain modularity
* Keep beginner-friendly
* Avoid duplicate logic
* Follow PROJECT_RULES.md

---

# Optimization Prompt

Optimize this Unity system.

## Goals

* Reduce allocations
* Improve readability
* Improve physics performance
* Reduce unnecessary Update usage

## Constraints

* Preserve gameplay behavior
* Do not overcomplicate
* Keep beginner-friendly

---

# Scene Setup Prompt (For MCP)

Create the following scene setup:

## Objects

[list objects]

## Requirements

* Use clear hierarchy naming
* Organize objects into parent groups
* Assign references where possible
* Keep hierarchy clean

---

# AI Debugging Philosophy

When debugging:

1. Identify exact symptom
2. Reproduce consistently
3. Isolate smallest failing system
4. Modify minimally
5. Test immediately

Avoid rewriting entire systems during debugging.
