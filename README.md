# EditorButton
Add Button from method to Inspector Unity3D

[![Discord](https://img.shields.io/discord/608666714653065217.svg?label=Discord)](https://discord.gg/UWkHKB)

![Button in Inspecor](./Doc/Inspector.JPG)

![Debug Screen](./Doc/Debug.JPG)

## Installation
Download the UnityPackage from the [latest releases](https://github.com/Kilosoft/EditorButton/releases) and import it into Unity. The directory can be moved after being imported.

## Usage
Add
```C#
using Kilosoft.tools
```
Mark any public method(void) with the attribute [EditorButton(name = "")]

```C#
using UnityEngine;
using Kilosoft.Tools;

/// <summary>
/// Test script
/// </summary>
public class TestScriptButton : MonoBehaviour
{
    [EditorButton("Test Button [Press me]")]
    public void TestMethod()
    {
        Debug.Log("I am Fire!");
    }
}
```
`Thank you! Good luck!
Kilosoft`
