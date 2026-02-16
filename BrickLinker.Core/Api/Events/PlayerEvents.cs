using BrickLinker.Core.Api.Events.Arguments;
using BrickLinker.Core.Api.Interfaces;

namespace BrickLinker.Core.Api.Events;

public static class PlayerEvents
{
    public static event EventHandler<BrickGainArgs>? OnPlayerGainBricks;
    public static event EventHandler<StudGainArgs>? OnPlayerGainStuds;

    internal static void TriggerBrickGain(IPlayer player, int amount)
    {
        var args = new BrickGainArgs(player, amount);
        OnPlayerGainBricks?.Invoke(null, args);
        if (!args.IsCancelled)
        {
            // player.AddBricks(args.Amount);
        }
        else
        {
            // TODO: Cancel the event
        }
    }
    
    internal static void TriggerStudGain(IPlayer player, int amount)
    {
        var args = new StudGainArgs(player, amount);
        OnPlayerGainStuds?.Invoke(null, args);
        if (!args.IsCancelled)
        {
            // player.AddStuds(args.Amount);
        }
        else
        {}
    }
}