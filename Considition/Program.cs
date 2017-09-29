using Considition.RestApi;
using Considition.RestApi.Models;
using System.Collections.Generic;

namespace Considition
{
    public class Program
    {
        // TODO: Enter your API key
        const string API_KEY = "eeb6c562-6324-4532-b36e-4d461ff000a9";

        static List<string> SolveGame(GameState game)
        {
            /*
             * --- Available commands ---
             * TRAVEL [NORTH|SOUTH|WEST|EAST]
             * [BUS|TRAIN|FLIGHT] {CityName}
             * SET_PRIMARY_TRANSPORTATION [CAR|BIKE]
             */

            // TODO: Implement your solution

            // Example solution
            var solution = new List<string>();
            var x = game.Start.X;
            var y = game.Start.Y;
            while (y < game.End.Y)
            {
                y++;
                solution.Add("TRAVEL SOUTH");
            }
            while (x < game.End.X)
            {
                x++;
                solution.Add("TRAVEL EAST");
            }

            return solution;
        }

        static void Main(string[] args)
        {
            Api.SetApiKey(API_KEY);
            Api.InitGame();
            var game = Api.GetMyLastGame();
            var solution = SolveGame(game);
            Api.SubmitSolution(solution, game.Id);
        }
    }
}
