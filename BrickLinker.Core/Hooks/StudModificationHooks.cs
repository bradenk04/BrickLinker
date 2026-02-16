using BrickLinker.Core.Api.Events;
using HarmonyLib;
using Koala.Board;

namespace BrickLinker.Core.Hooks;

[HarmonyPatch(typeof(BoardPlayerInfo), nameof(BoardPlayerInfo.AddStuds))]
public class StudModificationHooks
{
    [HarmonyPrefix]
    public static bool Prefix(BoardPlayerInfo __instance,
        int value,
        BoardPlayerInfo.CurrencyAnimationType animationType,
        bool extendAnimation)
    {
        Plugin.Log?.LogInfo($"adding {value} studs to {__instance}");
        var player = new Player(__instance._player);
        PlayerEvents.TriggerStudGain(player, value);
        return true;
    }

}