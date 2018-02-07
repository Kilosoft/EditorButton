# EditorButton
Add Button from method to Inspector Unity3D

![Button in Inspecor](./Doc/Inspector.JPG)

![Debug Screen](./Doc/Debug.JPG)

## Installation

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
