# .NET Core: Library Open Source Progress

![Chart](Status.png)

For more details, see [.NET Core: Library Open Source Progress][progress]

## Overview

This repository is designed to allow you track our progress towards open source.
It's only provided as a temporary mechanism to allow you track the difference
between what we've already open sourced and what is yet to come. As a result, we
don't intend you to contribute to this repository nor to run the `update.ps1`
script.

This repo contains the following folders:

* **lib-full**. These are the reference assemblies (i.e. assemblies without IL)
  that represent the entire surface area of all .NET Core libraries.

* **src-full**. This is the C# representation of the assemblies in `lib-full`.

* **src-oss**. This is the C# representation of the assemblies that are already
  open sourced, i.e. are available on GitHub.

* **src-diff**. For each assembly, this folder has a Markdown that contains the
  unified diff between `src-full` and `src-oss`.

## How can I understand what hasn't been open sourced yet but is coming?

Take a look at the [.NET Core: Library Open Source Progress][progress].
Alternatively you can clone this repository and use your favorite tool to diff
the directories `src-full` and `src-oss`.

[progress]: https://github.com/dotnet/corefx-progress/tree/master/src-diff/README.md