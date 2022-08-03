using System;

Console.WriteLine("Ready to bowl? ('y' for yes, 'n' for no; serious bowlers only.)");

if (Console.ReadKey().KeyChar == 'y')
{
    var game = new Game();

    game.Start();

    game.End();
}
else
{
    Console.WriteLine("Serious bowlers only!)");
}