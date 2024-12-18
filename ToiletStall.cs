namespace One_night_at_Triangelen;

public class ToiletStall:Location
{
    
    public override void HandleResponse(string response)          
    {                                                    
        switch (response)                                
        {                                                
            case("open door"):                           
                Console.WriteLine("opening door");       
                new LadiesRoom(_player);                        
                break;                   
            case("check pockets"):
                _player.Inventory.Print();
               // new ToiletStall(_player);
                Console.WriteLine("What do you want to do next?");
                var newResponse = Console.ReadLine();
                if (newResponse is not null)
                {
                    HandleResponse(newResponse);
                }
                break;
        }                                                
    }                                                    
    
    public ToiletStall(Player player):base(player) // constructor
    {
        Description = "You wake up in a toilet stall, but you have no memory of how you got here or where you are. There is a door and theres something in your pocket.";
        _menu = new Menu(this);
    }
    
}