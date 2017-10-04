using System;
using System.Collections.Generic;
using RestSharp;
using Newtonsoft.Json;
using Considition.RestApi.Models.Response;
using Considition.RestApi.Helpers;
using Considition.RestApi.Models;

namespace Considition.RestApi
{
    public class Api
    {
        private const string Domain = "http://theconsidition.se/";
        private static readonly RestClient Client = new RestClient(Domain);
        
        public static bool Silent { get; set; }

        private static void Log(string message)
        {
            if (!Silent)
            {
                Console.WriteLine($"API: {message}");
            }
        }

        private static void HandleApiResponse(ApiResponse response)
        {
            if (response is ErrorApiResponse apiResponse)
            {
                var error = apiResponse;
                var message = "An error occured: " + error.Message;
                Log(message);
                throw new Exception(message);
            }
            else if (response is GameErrorApiResponse)
            {
                var error = (GameErrorApiResponse)response;
                var message = $"Your solution had an error: {error.Error}";
                Log(message);
                throw new Exception(message);
            }
        }

        /// <summary>
        /// Set your API key.
        /// </summary>
        /// <param name="apiKey">Your API key.</param>
        public static void SetApiKey(string apiKey)
        {
            Client.AddDefaultParameter("apikey", apiKey, ParameterType.QueryString);
        }

        /// <summary>
        /// Create a new game.
        /// </summary>
        /// <returns>Returns the ID of the game.</returns>
        public static int InitGame()
        {
            var request = new RestRequest("considition/initgame", Method.GET);
            var result = Client.Execute(request);
            var response = JsonConvert.DeserializeObject<ApiResponse>(result.Content, new ApiResponseJsonConverter());
            HandleApiResponse(response);
            var gameResponse = (GameCreatedApiResponse)response;
            Log($"Created new game with ID {gameResponse.GameId}");
            return gameResponse.GameId;
        }

        /// <summary>
        /// Get the last game that was created by your InitGame method.
        /// </summary>
        /// <returns>Returns your latest created game.</returns>
        public static GameState GetMyLastGame()
        {
            var request = new RestRequest("considition/getgame", Method.GET);
            var result = Client.Execute(request);
            var response = JsonConvert.DeserializeObject<ApiResponse>(result.Content, new ApiResponseJsonConverter(), new GameObjectiveJsonConverter());
            HandleApiResponse(response);
            var gameResponse = (GetGameApiResponse)response;
            Log($"Retrieved game with ID {gameResponse.GameState.Id}");
            return gameResponse.GameState;
        }

        /// <summary>
        /// Get a specific game created by anyone.
        /// </summary>
        /// <param name="gameStateId">The ID of the game.</param>
        /// <returns>Returns the requested game.</returns>
        public static GameState GetGame(int gameStateId)
        {
            var request = new RestRequest("considition/getgame", Method.GET);
            request.AddQueryParameter("gameStateId", gameStateId.ToString());
            var result = Client.Execute(request);
            var response = JsonConvert.DeserializeObject<ApiResponse>(result.Content, new ApiResponseJsonConverter(), new GameObjectiveJsonConverter());
            HandleApiResponse(response);
            var gameResponse = (GetGameApiResponse)response;
            Log($"Retrieved game with ID {gameResponse.GameState.Id}");
            return gameResponse.GameState;
        }

        /// <summary>
        /// Submit a solution.
        /// </summary>
        /// <param name="solution">A list of your solution.</param>
        /// <param name="gameStateId">The ID of the game that your solution was made on.</param>
        /// <returns>Returns the amount of points you received.</returns>
        public static int SubmitSolution(List<string> solution, int gameStateId)
        {
            var request = new RestRequest("considition/submit", Method.POST);
            request.AddQueryParameter("gameStateId", gameStateId.ToString());
            request.AddJsonBody(solution);
            var result = Client.Execute(request);
            var response = JsonConvert.DeserializeObject<ApiResponse>(result.Content, new ApiResponseJsonConverter());
            HandleApiResponse(response);
            var gameResponse = (GameCompletedApiResponse)response;
            Log($"Your solution gave {gameResponse.Points} points.");
            return gameResponse.Points;
        }
    }
}
