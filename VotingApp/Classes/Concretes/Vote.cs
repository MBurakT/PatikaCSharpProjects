using System;

namespace VotingApp;

class Vote
{
    public static int Movie = 0;
    public static int Technology = 0;
    public static int Sport = 0;
    public static int Total = 0;

    public static void Result(double scale = 100.0)
    {
        Console.WriteLine(string.Format("Movie     : {0}    %{1}\nTechnology: {2}    %{3}\nSport     : {4}    %{5}",
        Movie, Movie * scale / Total, Technology, Technology * scale / Total, Sport, Sport * scale / Total));
    }
}