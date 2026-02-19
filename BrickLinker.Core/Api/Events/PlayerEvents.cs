using BrickLinker.Core.Api.Events.Arguments;
using BrickLinker.Core.Api.Interfaces;
using Koala.Board;

namespace BrickLinker.Core.Api.Events;

public static class PlayerEvents
{
    public static event EventHandler<BrickGainArgs>? OnPlayerGainBricks;
    public static event EventHandler<StudGainArgs>? OnPlayerGainStuds;

    internal static BrickGainArgs TriggerBrickGain(IPlayer player, int amount, BoardPlayerInfo.CurrencyAnimationType animationType, bool isInitialBrick)
    {
        var args = new BrickGainArgs(player, amount);
        OnPlayerGainBricks?.Invoke(null, args);
        return args;
    }
    
    internal static StudGainArgs TriggerStudGain(IPlayer player, int amount, BoardPlayerInfo.CurrencyAnimationType animationType, bool extendAnimation)
    {
        var args = new StudGainArgs(player, amount);
        OnPlayerGainStuds?.Invoke(null, args);
        return args;
    }
}