using System;

Console.WriteLine("Ready to bowl? ('y' for yes, 'n' for no; serious bowlers only.)");

// if (Console.ReadKey().KeyChar == 'y')
// {
    var game = new Game();

    while (game.CurrentFrame <= Game.MAX_INDEX)
    {
        game.RoleFrame();
    }
    var score = game.ScoreGame();
    Console.WriteLine($"Gg, your score is: {score}");
//}
// else
// {
//     Console.WriteLine("Serious bowlers only!)");
// }