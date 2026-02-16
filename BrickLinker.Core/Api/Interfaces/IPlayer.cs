namespace BrickLinker.Core.Api.Interfaces;

public interface IPlayer
{
    public string Username { get; }
    public bool IsAI { get; }
    public int Slot { get; }
    
    public int Bricks { get; }
    
    void AddBricks(int amount);
    void RemoveBricks(int amount);
    void SetBricks(int amount);
    
    public int Studs { get; }
    
    void AddStuds(int amount);
    void RemoveStuds(int amount);
    void SetStuds(int amount);
}