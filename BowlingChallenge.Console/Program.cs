using System;

Console.WriteLine("Ready to bowl? ('y' for yes, 'n' for no; serious bowlers only.)");
var game = new Game();

if (Console.ReadKey().KeyChar == 'y')
{
    game.Start();
    game.End();
}
else
{
    Console.WriteLine("Want to run in test mode instead? ('y' for yes, 'n' for no; frivolous bowlers only.");
    if (Console.ReadKey().KeyChar == 'y')
    {
        // Change this to anything you'd like as long as it equates to 12 rounds
        // Strikes take up 1 space in the array
        // Everything else takes up 2
        game.Start(new int[]{10,10,10,10,10,10,10,10,10,10,10,10});
        game.End();
        game.Start(new int[]{9,0,5,5,10,10,10,10,10,10,10,9,1,10});
        game.End();
    }
    else
    {
        Console.WriteLine("Serious bowlers only!)");
    }
}