using Considition.RestApi;
using Considition.RestApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Considition
{
    class Program
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
            List<string> solution = new List<string>();
            int x = game.Start.X;
            int y = game.Start.Y;
            while (x < game.End.X)
            {
                x++;
                solution.Add("TRAVEL EAST");
            }
            while (y < game.End.Y)
            {
                y++;
                solution.Add("TRAVEL SOUTH");
            }

            return solution;
        }

        static void Main(string[] args)
        {
            Api.SetApiKey(API_KEY);
            Api.InitGame();
            GameState game = Api.GetMyLastGame();
            List<string> solution = SolveGame(game);
            Api.SubmitSolution(solution, game.Id);
        }
    }
}
