using System;

public class Game
{
    private readonly int MAX_ROLE = 10;
    private readonly int MAX_RANDOM = 11;
    public int currentRoll = 0;

    private int[] frames = new int[10];
    private int[] rolls = new int[21];

    public void Start()
    {
        for (var i = 0; i < frames.Length; i++)
        {
            rollFrame(i);
        }
    }

    public void End()
    {
        var score = scoreGame();
        Console.WriteLine($"Gg, your score is: {score}");
    }

    internal void Start(int[] bumperBowls)
    {
        rolls = bumperBowls;
    }

    private void rollFrame(int i)
    {
        rolls[currentRoll] = getRoll(MAX_RANDOM);
        currentRoll++;
        if (rolls[currentRoll - 1] != MAX_ROLE)
        {
            rolls[currentRoll] = getRoll(MAX_RANDOM - rolls[currentRoll - 1]);
            currentRoll++;
        }
        else if (finalFrame(i) && rolls[currentRoll - 1] == MAX_ROLE)
        {
            rolls[currentRoll] = getRoll(MAX_RANDOM);
            currentRoll++;
        }
        if (finalFrame(i) && finalRoll(i))
            rolls[currentRoll] = getRoll(MAX_RANDOM);
    }

    private int scoreGame()
    {
        var score = 0;
        var roll = 0;
        for (var i = 0; i < frames.Length; i++)
        {
            if (isSpare(roll))
            {
                score += 10 + rolls[roll+2];
                roll +=2;
            }
            else if (isStrike(roll))
            {
                score += 10 + rolls[roll+1] + rolls[roll+2];
                roll++;
            }
            else 
            {
                score += rolls[roll] + rolls[roll+1];
                roll +=2;
            }
        }

        return score;
    }

    private bool isStrike(int roll)
    {
        return rolls[roll] == MAX_ROLE;
    }

    private bool isSpare(int role)
    {
        return rolls[role] + rolls[role+1] == 10;
    }

    private bool finalFrame(int i)
    {
        return i == (frames.Length-1);
    }

    private bool finalRoll(int i)
    {
        return (rolls[currentRoll - 1] == 10) || (rolls[currentRoll - 1] + rolls[currentRoll - 2] == 10);
    }

    public int getRoll(int max) 
    {
        return new Random().Next(0, max);
    }
}