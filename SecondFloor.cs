namespace One_night_at_Triangelen;

public class SecondFloor:Location
{
    public SecondFloor(Player player):base(player)
    {
        Description =
            "You are on the second floor in what you recognize as Triangelen. There is an escallator and an entrance to the Ladies room. There is also an bag left by someone.";
        _menu = new Menu(this);
    }
    
    public override void HandleResponse(string response)
    {
        switch (response)
        {
            case("enter escallator"):
                new Escallator(_player);
                break;
            case("enter ladies room"):
                new LadiesRoom(_player);
                break;
            case("look in bag"):
                // enter bag? have logic here?
                break;
        }
    }
}