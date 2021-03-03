using Grpc.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Protos.Enums;
using Newtonsoft.Json;

namespace Protos
{
    public class PlayerGrpcService : PlayerService.PlayerServiceBase
    {
        #region Properties

        /// <summary>
        /// Players
        /// </summary>
        public List<Player> Players
        {
            get;
            private set;
        } = new List<Player>();

        /// <summary>
        /// GrpcLog
        /// </summary>
        public List<string> GrpcLog
        {
            get;
            private set;
        } = new List<string>();

        #endregion

        #region Events

        /// <summary>
        /// Event fired for UI when GrpcLog is updated.
        /// </summary>
        public event EventHandler<EventArgs> GrpcLogUpdated;

        /// <summary>
        /// Event fired for UI when Players collection is updated.
        /// </summary>
        public event EventHandler<EventArgs> PlayersUpdated;

        #endregion


        #region Server Calls

        /// <summary>
        /// AddPlayer
        /// </summary>
        /// <param name="request"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public override async Task<AddPlayerResponse> AddPlayer(AddPlayerRequest request, ServerCallContext context)
        {            
            // Log request.
            CreateLogEntry(request, gRPCMessageType.Request, nameof(AddPlayer));

            var currentPlayerId = Players.Count;

            // Add new player into Players collection.
            // Normally this would be a database call instead.
            // The database would then set the PlayerId.
            // Implementation would usually involve a Repository that uses a mapper to map the Player data type to database table.

            Players.Add(new Player
            {
                Id = currentPlayerId + 1,
                FirstName = request.Player.FirstName,
                LastName = request.Player.LastName,
                DateOfBirth = request.Player.DateOfBirth
            });

            // Notify players subscribers that collection has been updated.
            PlayersUpdated?.Invoke(this, new EventArgs());

            var response = new AddPlayerResponse
            {
                Success = true
            };

            // Log response.
            CreateLogEntry(response, gRPCMessageType.Response, nameof(AddPlayer));

            // Return response.
            return response;
        }

        /// <summary>
        /// GetPlayers
        /// </summary>
        /// <param name="request"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public override async Task<GetPlayersResponse> GetPlayers(Empty request, ServerCallContext context)
        {
            // Log request.
            CreateLogEntry(request, gRPCMessageType.Request, nameof(GetPlayers));

            var response = new GetPlayersResponse();
            response.Players.AddRange(Players);

            // Log response.
            CreateLogEntry(response, gRPCMessageType.Response, nameof(GetPlayers));

            return response;
        }

        #endregion

        #region Private Methods

        /// <summary>
        /// Log grpc to local collection.
        /// </summary>
        /// <param name="payload"></param>
        /// <param name="messageType"></param>
        private void CreateLogEntry(object payload, gRPCMessageType messageType, string methodName)
        {
            const string logFormat = "ComponentName: '{0}' MethodName: '{1}' MessageType: '{2}' Message: '{3}'";

            // Convert object to json.
            var objectData = JsonConvert.SerializeObject(payload);

            // Log in gRPC output directory.
            GrpcLog.Add($"[{DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss")}] {string.Format(logFormat, nameof(PlayerService), methodName, messageType, objectData)}");

            // Invoke event for listeners.
            GrpcLogUpdated?.Invoke(this, new EventArgs());
        }

        #endregion
    }
}
