namespace One_night_at_Triangelen;

public class Bag:Location
{
    public Bag(Player player) : base(player)
    {
        Description = 
            "This bag looks like it belongs to a security guard. There is a note here.";
        _menu = new Menu(this);
    }

    public override void HandleResponse(string response)
    {
        switch (response)
        {
            case("return"):
                new SecondFloor(_player);
                break;
            case("take note"):
                _player.Inventory.Items.Add("alarm code");
                new SecondFloor(_player);
                break;
        }
    }
}