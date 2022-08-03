# Bowling C# Code Kata Console

A simple C# console app for calculating a bowling score using random rolls.

## Prerequisites

- .NET 6

## Getting Started

1. Clone this repo: `git clone https://github.com/davidamdev/bowling-challenge`
2. Navigate into the `BowlingChallenge.Console` application
   - `cd bowling-challenge/BowlingChallenge.Console`
3. Run the application `dotnet run`

## Testing the application

1. Change lines [19](https://github.com/davidamdev/bowling-challenge/blob/741918f1d56fcf9c0cffe2d5b2da96da344b3167/BowlingChallenge.Console/Program.cs#L19) or [21](https://github.com/davidamdev/bowling-challenge/blob/741918f1d56fcf9c0cffe2d5b2da96da344b3167/BowlingChallenge.Console/Program.cs#L21) of the program.cs class
   - Keep in mind that strikes only take up 1 slot in the array

**Example**

```c#
        game.Start(new int[]{9,0,5,5,10,10,10,10,10,10,10,9,1,10});
        game.End();
```

Use https://bowlinggenius.com/ to compare the results.

![Alt text](/Artifacts/248.PNG "Bowling Score 248")

## Future Improvements

- [ ] Unit tests
- [ ] Better user interface
- [ ] Error handling
- [ ] Additional documentation