public class Player
{
    public PlayerClass PClass { get; }
    public string Name { get ; }
    public Player ( PlayerClass pClass, string name )
    {
        PClass = pClass ;
        Name = name ;
    }

    public override bool Equals(object obj)
    {
        if (obj == null || GetType() != obj.GetType()) return false;
        Player other = obj as Player;

        return PClass == other.PClass && 
                   ((Name == null && other.Name == null) || 
                    (Name != null && Name.Equals(other.Name))); 
    }

    public override int GetHashCode()
    {
        return PClass.GetHashCode() ^ Name.GetHashCode();
    }
}
