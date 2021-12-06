using System;

string room = "mainroad";

while (room != "end")
{
    if (room == "mainroad")
    {
        Console.WriteLine("You are now on the mainroad. In front of you is a small sideroad, leading to the Low Road.");

        Console.WriteLine("Where do you want to go?");
        string where = Console.ReadLine();

        if (where == "down")
        {
            room = "lowroad";
        }
        if (where == "right")
        {
            room = "forest"; // den nya rummet
        }
        else
        {
            Console.WriteLine("I'm sorry, what?");
        }
    }
    else if (room == "lowroad")
    {
        Console.WriteLine("You are now on the Low Road. In front of you is a small stairway, leading up to the mainroad.");

        Console.WriteLine("Where do you want to go?");
        string where = Console.ReadLine();

        if (where == "up")
        {
            room = "mainroad";
        }
        else if (where == "out")
        {
            room = "end";
        }
        else
        {
            Console.WriteLine("I'm sorry, what?");
        }
    }
    else if (room == "forest") // den nya rummet
    {

        Console.WriteLine("you are in the forest you can go to the side road and the mainroad from here where you are ");

        Console.WriteLine("where do you want to go down for the lowrode and left for the main road");
        string where = Console.ReadLine();

        if (where == "down") // vägen till lowroad
        {
            room = "lowroad";
        }
        if (where == "left")
        {
            room = "mainroad";
        }
        else
        {
            Console.WriteLine("im sorry what?"); 
        }
    }
}





