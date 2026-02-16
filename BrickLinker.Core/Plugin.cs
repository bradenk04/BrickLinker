using BepInEx;
using BepInEx.Logging;
using BepInEx.Unity.IL2CPP;
using BrickLinker.Core.Api.Events;
using BrickLinker.Core.Api.Events.Arguments;
using HarmonyLib;
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
        
        var harmony = new Harmony("io.github.bradenk04.bricklinker");
        harmony.PatchAll();

        PlayerEvents.OnPlayerGainStuds += OnPlayerGainedStuds;
    }
    
    public void OnPlayerGainedStuds(object? sender, StudGainArgs e)
    {
        Plugin.Log?.LogInfo($"Player gained studs: P{e.Player.Slot} {e.Player.Username} +{e.Amount}");
    }
}