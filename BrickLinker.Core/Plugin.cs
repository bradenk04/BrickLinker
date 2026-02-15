using BepInEx;
using BepInEx.Logging;
using BepInEx.Unity.IL2CPP;
using Il2CppInterop.Runtime.Injection;

namespace BrickLinker.Core;

[BepInPlugin("io.github.bradenk04", "BrickLinker Core", "1.0.0")]
public class Plugin : BasePlugin
{
    public new static ManualLogSource? Log;
    
    public override void Load()
    {
        Log = base.Log;
        Log.LogInfo("BrinkLinker initializing.");
        
        ClassInjector.RegisterTypeInIl2Cpp<Loop>();
        AddComponent<Loop>();
    }
}