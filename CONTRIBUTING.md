# Contributing to TravelAround

Thank you for your interest in contributing! Here is how to get involved.

---

## Getting Started

1. **Fork** the repository on GitHub
2. **Clone** your fork locally:
   ```bash
   git clone https://github.com/YOUR_USERNAME/TravelAround.git
   cd TravelAround
   ```
3. Set up the database following the instructions in [README.md](README.md)
4. Open the solution in Visual Studio 2022 and make sure it builds cleanly

---

## Making Changes

- Create a **feature branch** for your work — never commit directly to `main`:
  ```bash
  git checkout -b feature/my-feature
  ```
- Keep commits focused and write clear commit messages:
  ```
  Add distance validation for custom route mode
  Fix high-contrast theme on radio buttons
  ```
- Follow the existing code style (C# naming conventions, XML comments on public members)
- Test your changes manually before submitting

---

## Submitting a Pull Request

1. Push your branch:
   ```bash
   git push origin feature/my-feature
   ```
2. Open a **Pull Request** on GitHub against the `main` branch
3. Fill in the PR description explaining what changed and why
4. Wait for review — changes may be requested before merging

---

## Reporting Bugs

Please open a **GitHub Issue** and include:
- Steps to reproduce
- Expected behaviour
- Actual behaviour
- Screenshots if applicable
- Your OS and Visual Studio version

---

## Code Style Guidelines

- Use `PascalCase` for class and method names
- Use `camelCase` for local variables and parameters
- Prefix private fields with `_` (e.g. `_baseYTransport`)
- Add XML summary comments to all public methods
- Use parameterised queries for all database operations — never string concatenation

---

## Security

- **Never commit database credentials** — update `.gitignore` to exclude `db.cs` if it contains your password
- Do not commit compiled binaries (`bin/`, `obj/`)
