# Contributing

Thank you for contributing to this repository. This document describes the project's workflow, coding standards and expectations.

## Guidelines

- Follow the coding conventions specified in `.editorconfig`.
- Target frameworks: .NET Core 3.1 and .NET Standard 2.1. Ensure compatibility before introducing new APIs.
- Keep changes small and focused. Open a separate PR per logical change.

## Branching

- `master` is the main branch. Create feature branches named `feature/<short-description>` or `fix/<short-description>`.
- Rebase or merge regularly to keep branches up to date.

## PR Process

- Create a PR from your feature branch into `master`.
- Include a short description of the change and link any related issues.
- Ensure the solution builds cleanly and automated checks pass.
- At least one approving review is required before merging.

## Commit Messages

- Use imperative, present tense. Example: `Fix order delete confirmation`.
- Include reference to issue when relevant.

## Coding Standards

- Use the `.editorconfig` settings included in the repo. It enforces 4-space indentation, naming conventions and other C# style rules.
- Prefer explicit types over `var` unless the type is obvious.
- Private readonly fields should be prefixed with `_` and use camelCase.
- Keep methods small and single-responsibility.

## Testing

- Add unit tests for business logic and critical paths. Keep tests deterministic and fast.
- Run `dotnet test` locally before pushing changes.

## Security

- Do not commit secrets, credentials or private keys.
- Use configuration and environment variables for secrets.

## Formatting

- Run the IDE's format (or `dotnet format`) before committing.

If you need help or clarification, open an issue or contact the maintainers.