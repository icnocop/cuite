## How to contribute

First of all, thank you for wanting to contribute to CUITe! Support from the community is what makes open source such a wonderful thing.

We want to keep it as easy as possible to contribute changes that get things working in your environment. There are a few guidelines that we need contributors to follow so that we have a chance of keeping on top of things.

## Reporting issues

A great way to contribute to the project is to send a detailed report when you encounter an issue. We always appreciate a well-written, thorough bug report, and will thank you for it!

Check that your issue isn't [already submitted](https://github.com/icnocop/cuite/issues). If you find a match, please add a comment. Doing this helps prioritize the most common problems and requests.

## Making changes

All contribution is welcome. Did you find a typo? Found a bug and know how to fix it? Want to implement a new awesome feature?  Do it! We will appreciate it. Any significant improvement should be documented as a GitHub issue before anybody starts working on it. This allows us to help and guide you on your way.

For the unexperienced GitHub developer, [GitHub Collaborating](https://help.github.com/categories/collaborating/) contains information about forking and syncing while [GitHub Flow](https://guides.github.com/introduction/flow/) describes the preferred way of working with branches.

## Submitting a pull request

To help easily identify what has actually changed between commits in the main repository, we recommend squashing commits down to as few discreet changesets as possible before submitting a pull request. Fixing a bug usually only requires one commit but adding a large feature may require a few commits in order to help track the improvements with each change.

See [Squashing commits with rebase](http://gitready.com/advanced/2009/02/10/squashing-commits-with-rebase.html) for help.

Some changes may have been made in the main repository while you were working in your fork. If that's the case, rebase your changes on top of the latest source code from the main repository.

See [About Git rebase](https://help.github.com/articles/about-git-rebase/) for additional help.

Your commit should have a descriptive message like "Fixed #123: CodedUI SetFocus on TextBox".

See [Changing a commit message](https://help.github.com/articles/changing-a-commit-message/) if you need help to change your commit message.

## Development prerequisites

To successfully build and run tests, the following prerequisites are required:

- Visual Studio 2013 Premium or Ultimate
- [Selenium components for Coded UI Cross Browser Testing](https://visualstudiogallery.msdn.microsoft.com/11cfc881-f8c9-4f96-b303-a2780156628d)
- [Microsoft Visual Studio 2013 Coded UI Test Plugin for Silverlight](https://visualstudiogallery.msdn.microsoft.com/51b4a94a-1878-4dcc-81e0-7dc92131d2da)

## Code guidelines

ReSharper is configured to our code guidelines. If you need to make changes to the configuration, please select Visual Studio menu item _ReSharper > Manage Options... > Solution 'CUITe' team-shared > Edit Layer_ and make sure to save the changes. Use ReSharper and act on its error and warnings. Other than that the following guidelines are of importance:

- Indent with 4 spaces, not tabs
- Use `var` only when type is obvious
- Use the C# type aliases for types that have them, e.g. `int` instead of `Int32`, `string` instead of `String` etc
- Use meaningful names

## Compilation and NuGet creation

Run _Build.bat_ from a command prompt to build and pack the NuGet packages using the Release configuration.

## Running tests

Run _Test.bat_ from a command prompt to execute all unit and UI tests.
