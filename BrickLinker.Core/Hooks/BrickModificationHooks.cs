using BrickLinker.Core.Api.Events;
using HarmonyLib;
using Koala.Board;

namespace BrickLinker.Core.Hooks;

[HarmonyPatch(typeof(BoardPlayerInfo), nameof(BoardPlayerInfo.AddBricks))]
public class BrickModificationHooks
{
    [HarmonyPrefix]
    public static bool Prefix(BoardPlayerInfo __instance,
        int value,
        BoardPlayerInfo.CurrencyAnimationType animationType,
        bool isInitialBrick)
    {
        Plugin.Log?.LogInfo($"adding {value} studs to {__instance}");
        var player = new Player(__instance._player);
        var args = PlayerEvents.TriggerBrickGain(player, value, animationType, isInitialBrick);

        value = args.Amount;
        isInitialBrick = args.IsInitialBrick;
        animationType = args.AnimationType;
        
        return !args.IsCancelled;
    }
    
}