namespace BrickLinker.Core;

using System;
using UnityEngine;
using UnityEngine.InputSystem;
using BepInEx.Unity.IL2CPP.Utils;

public class Loop : MonoBehaviour
{
    public Loop(IntPtr ptr) : base(ptr) { }
    private void Start()
    {
        Plugin.Log?.LogInfo("Loop initialized & attached.");
    }

    private void Update()
    {
        if (Keyboard.current != null && Keyboard.current.f12Key.wasPressedThisFrame)
        {
            Plugin.Log?.LogInfo("Dev menu hotkey pressed.");
        }
    }
}