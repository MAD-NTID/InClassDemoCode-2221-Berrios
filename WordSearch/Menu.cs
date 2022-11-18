public class Menu
{
    public static string[] menu = {
        "Create",
        "Delete",
        "Edit",
        "Read",
        "Search",
        "Exit"
    };

    public bool MenuChoice(string choice, out int choiceNumber)
    {
        if(int.TryParse(choice, out choiceNumber))
            //  This block for number menu choice
            return choiceNumber >= 1 && choiceNumber <= menu.Length;
        
        //  This block for word menu choice
        // return Array.IndexOf(menu, choice) > -1;

        for(int i = 0; i < menu.Length; i++)
        {
            if(string.Equals(choice, menu[i], StringComparison.InvariantCultureIgnoreCase))
            {
                choiceNumber = i + 1;
                return true;   
            }
        }

        return false;
    }

    public override string ToString()
    {
        string menuString = "";

        for(int i = 0; i < menu.Length; i++)
        {
            menuString += $"{i + 1}. {menu[i]}\n";
        }

        return menuString;
    }
}