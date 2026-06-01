---
name: git-autocommit
description: "Stage all changes, check for conflicts, update SESSION_CONTEXT.md, and commit+push. Use when the user says 'commit', 'push', 'save', 'autocommit', 'git commit', or 'stage changes'."
---

# git-autocommit

Stage, commit, and push changes with automatic SESSION_CONTEXT.md updates.

## Workflow

1. **Stage everything** — `git add .`

2. **Check for conflicts** — Run `git diff --cached --name-only --diff-filter=U`. If any files have merge conflicts, report them to the user and **stop** — do not proceed.

3. **Check for changes** — Run `git diff --cached --name-only` and `git diff --cached --stat`. If no files are staged, notify the user and stop.

4. **Analyze changes** — Read `git diff --cached` to understand what was modified. List changed files and summarize the nature of the work (new prefabs, scene edits, script changes, config updates, etc.).

5. **Update SESSION_CONTEXT.md** — Before committing, read the current `SESSION_CONTEXT.md`. Based on the diff analysis:
   - Update `# Last Stable Milestone` with new additions.
   - Update `# Existing Prefabs` if prefabs were added/changed.
   - Update `# Scene Structure` if the scene hierarchy changed.
   - Update `# Known Issues` if issues were fixed or new ones introduced.
   - Update `# Next Planned Milestones` to check off completed items.
   - If `# Current Goal` exists and is completed, move it to milestones and add a new goal placeholder.
   - Stage the updated SESSION_CONTEXT.md: `git add SESSION_CONTEXT.md`

6. **Commit** — Using the analysis from step 4, write a short, descriptive commit message (imperative mood, ≤72 chars title, bullet details if needed). Run `git commit -m "..."`.

7. **Push** — Run `git push`. Report the result to the user (commit hash, branch, any errors).

## Notes

- If `git push` fails due to remote divergence, notify the user — do not force push.
- Preserve all existing content in SESSION_CONTEXT.md; only append or modify relevant sections.
- The commit message should describe the actual work done (e.g. "Add Pig_Basic prefab with collider and rigidbody" not "Update SESSION_CONTEXT.md").
