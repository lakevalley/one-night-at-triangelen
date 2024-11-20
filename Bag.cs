namespace One_night_at_Triangelen;

public class Bag:Location
{
    public Bag(Player player) : base(player)
    {
        Description = "";
        _menu = new Menu(this);
    }

    public override void HandleResponse(string response)
    {
        switch (response)
        {
            case("return"):
                new SecondFloor(_player);
                break;
        }
    }
}