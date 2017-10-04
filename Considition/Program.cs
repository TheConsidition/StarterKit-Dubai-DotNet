using Considition.RestApi;
using Considition.RestApi.Models;
using System.Collections.Generic;

namespace Considition
{
    public class Program
    {
        // TODO: Enter your API key
        const string API_KEY = "XXXXXXXX-XXXX-XXXX-XXXX-XXXXXXXXXXXX";

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
            //Or get by gameId:
            //var game = Api.GetGame(3005);
            var solution = SolveGame(game);
            Api.SubmitSolution(solution, game.Id);
        }
    }
}
