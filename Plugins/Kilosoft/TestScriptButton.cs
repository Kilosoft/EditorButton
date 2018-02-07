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
