using System;
using System.Linq;

public class Game
{
    private readonly int MAX_ROLE = 10;
    private readonly int MAX_RANDOM = 11;
    private readonly int STRIKE = 10;
    private readonly int SPARE = 5;
    public static readonly int MAX_INDEX = 9;
    public int CurrentFrame { get; set; } = 0;

    private Frame[] Frames = new Frame[10];

    public void RoleFrame()
    {
        Frames[CurrentFrame] = new Frame();
        var role1 = role(MAX_RANDOM);
        Frames[CurrentFrame].Role1 = role1;

        if (CurrentFrame != 9) Frames[CurrentFrame].Role2 = role(MAX_RANDOM-role1);
        else
        {
            var role2 = (MAX_ROLE-role1) == 0 ? role(MAX_RANDOM) : role(MAX_RANDOM-role1);
            
            Frames[CurrentFrame].Role2 = role2;

            if (role2 == MAX_ROLE || ((role2 + role1) == MAX_ROLE))
                Frames[CurrentFrame].Role3 = role(MAX_RANDOM);
        }

        CurrentFrame++;
    }

    public int ScoreGame()
    {
        var score = 0;
        foreach (var (frame, index) in Frames.Select((value, i) => (value, i)))
        {
            score += getRoundScore(frame, index);

            var role3 = index == 9 ? "/" + frame.Role3 : "";
            Console.WriteLine($"Round {index+1}: {frame.Role1}/{frame.Role2}{role3} ({frame.Total})");
        }
        return score;
    }

    private int getRoundScore(Frame frame, int index)
    {
        var score = frame.Total;
        if (index > 0)
        {
            var previousFrame = Frames[index-1];
            if (index != MAX_INDEX)
            {
                if (previousFrame.Total == MAX_ROLE)
                {
                    if (previousFrame.Role2 == 0) score += STRIKE;
                    else score += SPARE;
                }
            }
            else {
                if (previousFrame.Role2 == 0) score += STRIKE;
                else score += SPARE;
                if (frame.Role1 == STRIKE) score += STRIKE;
                else if (frame.Role1+frame.Role2 == MAX_ROLE) score += SPARE;
                if (frame.Role3 == MAX_ROLE) score += STRIKE;
            }
        }
        return score;
    }

    private int role(int max)
    {
        return new Random().Next(0, max);
    }
}