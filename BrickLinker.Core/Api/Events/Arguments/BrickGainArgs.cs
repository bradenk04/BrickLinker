using BrickLinker.Core.Api.Interfaces;
using Koala.Board;

namespace BrickLinker.Core.Api.Events.Arguments;

public class BrickGainArgs : EventArgs
{
    public IPlayer Player { get; init; }
    public int Amount { get; set; }
    public string? Reason { get; set; }
    public bool IsCancelled { get; set; } = false;
    
    public bool IsInitialBrick { get; set; } = false;
    public BoardPlayerInfo.CurrencyAnimationType AnimationType { get; set; } = BoardPlayerInfo.CurrencyAnimationType.All;
    
    public BrickGainArgs(IPlayer p, int amt) { Player = p; Amount = amt; }

    public BrickGainArgs(IPlayer p, int amt, BoardPlayerInfo.CurrencyAnimationType animationType,
        bool initialBrick = false)
    {
        Player = p; 
        Amount = amt;
        AnimationType = animationType;
        IsInitialBrick = initialBrick;
    }
}