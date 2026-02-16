using BrickLinker.Core.Api.Interfaces;
using Koala.Board;

namespace BrickLinker.Core;

internal class Player : IPlayer
{
    private BoardPlayer _boardPlayer { get; set; }
    internal Player(BoardPlayer bp)
    {
        _boardPlayer = bp;
    }
    
    public string Username => _boardPlayer.Username;
    public bool IsAI => _boardPlayer.IsAI;
    public int Slot => _boardPlayer.ID.value;
    public int Bricks => _boardPlayer.Info.Bricks;
    public void AddBricks(int amount)
    {
        _boardPlayer.Info.AddBricks(amount, BoardPlayerInfo.CurrencyAnimationType.All);
    }

    public void RemoveBricks(int amount)
    {
        _boardPlayer.Info.RemoveBricks(amount, BoardPlayerInfo.CurrencyAnimationType.All);
    }

    public void SetBricks(int amount)
    {
        if (amount < Bricks) RemoveBricks(Bricks - amount);
        else AddBricks(amount - Bricks);
    }

    public int Studs => _boardPlayer.Info.Studs;
    public void AddStuds(int amount)
    {
        _boardPlayer.Info.AddStuds(amount, BoardPlayerInfo.CurrencyAnimationType.All);
    }

    public void RemoveStuds(int amount)
    {
        _boardPlayer.Info.RemoveStuds(amount, RemoveStudType.Lost, BoardPlayerInfo.CurrencyAnimationType.All);
    }

    public void SetStuds(int amount)
    {
        if (amount < Studs) RemoveStuds(Studs - amount);
        else AddStuds(amount - Studs);
    }
}