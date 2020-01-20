Pull Request
============

Please, go through these steps before you submit a PR.

1. Make sure that your PR is not a duplicate.
2. If not, then make sure that:
   a. You have done your changes in a separate branch. Branches MUST have
      descriptive names that start with either the `feature/` or `bugfix/`
      prefixes and must include the GitHub issue number at the start.
      Good examples are: `feature/1-add-github-as-authentication-provider`
      or `bugfix/2-fix-github-authentication-provider-api-base-url`.
   b. You have a descriptive commit message with a short title (first line).
   c. You have only one commit (if not, squash them into one commit).
   d. Visual Studio unit tests doesn't throw any error. If it does, fix them
      first and amend your commit (`git commit --amend`).
3. **After** these steps, you're ready to open a pull request.
   a. Your pull request MUST NOT target the `master` branch on this repository.
      You probably want to target `develop` instead.
   b. Give a descriptive title to your PR.
   c. Provide a description of your changes.
   d. Put `Closes #XXXX` or `Fixes #XXXX` in your comment to auto-close the
      issue that your PR fixes (if such).

**Important:** Please review the [CONTRIBUTING.md][1] file for detailed
contributing guidelines.

**PLEASE REMOVE THIS TEMPLATE BEFORE SUBMITTING**


Affected GitHub issues:
-----------------------

  - Fixes #
  - Fixes #
  - Fixes #


Proposed Changes
----------------

  - Change Summary
  - Change Summary
  - Change Summary


<!-- Web Links -->

[1]: https://github.com/soerenkornetzki/KornetzkiIT.Reflection.AssemblyInformation/blob/develop/CONTRIBUTING.md
