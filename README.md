# GMML.Templates
Templates for creating new GMML mods

*Note: GMML is still under active early development, so these templates may change frequently
always check if anything changed in here after updating GMML and apply the changes to your code if relevant*

## Installation
### Prerequisites
[.NET 6 or newer](https://dotnet.microsoft.com/download)
### Install
1. Clone the repository (`git clone https://github.com/cgytrus/GMML.Templates`)
2. Install the templates (`dotnet new -i .`)

Included templates:

| Templates         | Short Name | Language | Tags     |
|-------------------|------------|----------|----------|
| GMML Mod Template | gmml       | [C#]     | GMML/Mod |

## Usage
To use a template, you can use `dotnet new` command
If you use Rider or Visual Studio 2022, you will be able to select the templates when creating a new solution

For example
```
dotnet new gmml -n MyModName -G "path\to\Steam\steamapps\Will You Snail" -I "com.github.me.gmml.example" -D "My Mod" -A "Me" -De "Example description" -W
```
will create a folder named MyModName with a simple mod for Will You Snail? with id `com.github.me.gmml.example` named `My Mod`
version 0.1.0 by Me with description `Example description`

Use `--help` to view available arguments:
```
> dotnet new gmml --help
Options:
  -G|--GamePath      The path to the game to test the mod in. Used for the scripts.
                     text - Optional

  -I|--ID            The unique, java-like identifier of the mod.
                     text - Required

  -D|--DisplayName   The user-friendly display name of the mod.
                     text - Required

  -V|--Version       The Semver v2 version of the mod.
                     text - Optional
                     Default: 0.1.0

  -A|--Author        The author of the mod.
                     text - Required

  -De|--Description  The description of the mod.
                     text - Optional

  -W|--WillYouSnail  Whether to add additional WYS-related dependencies or not.
                     bool - Optional
                     Default: false
```
