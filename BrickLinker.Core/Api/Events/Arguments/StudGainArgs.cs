using BrickLinker.Core.Api.Interfaces;

namespace BrickLinker.Core.Api.Events.Arguments;

public class StudGainArgs : EventArgs
{
    public IPlayer Player { get; init; }
    public int Amount { get; set; }
    public string? Reason { get; set; }
    public bool IsCancelled { get; set; } = false;
    
    public StudGainArgs(IPlayer p, int amt) { Player = p; Amount = amt; }
}