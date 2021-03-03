using Grpc.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Protos.Enums;
using Newtonsoft.Json;

namespace Protos.Services
{
    /// <summary>
    /// ColorService
    /// </summary>
    public class ColorGrpcService : Protos.ColorService.ColorServiceBase
    {

        #region Properties

        /// <summary>
        /// Green
        /// </summary>
        public int Green
        {
            get => m_green;
            set => m_green = value;
        }

        /// <summary>
        /// Yellow
        /// </summary>
        public int Yellow
        {
            get => m_yellow;
            set => m_yellow = value;
        }

        /// <summary>
        /// Red
        /// </summary>
        public int Red
        {
            get => m_red;
            set => m_red = value;
        }

        /// <summary>
        /// Orange
        /// </summary>
        public int Orange
        {
            get => m_orange;
            set => m_orange = value;
        }

        #endregion

        #region Server Calls

        /// <summary>
        /// SendColor
        /// </summary>
        /// <param name="request"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public override async Task<SendColorResponse> SendColor(SendColorRequest request, ServerCallContext context)
        {
            // Update colors
            switch (request.RequestCase)
            {
                case SendColorRequest.RequestOneofCase.GreenMessage:
                    m_green++;
                    break;

                case SendColorRequest.RequestOneofCase.OrangeMessage:
                    m_orange++;
                    break;

                case SendColorRequest.RequestOneofCase.RedMessage:
                    m_red++;
                    break;

                case SendColorRequest.RequestOneofCase.YellowMessage:
                    m_yellow++;
                    break;
            }

            // Send response.
            return new SendColorResponse { Successs = true };
        }

        /// <summary>
        /// CommunicationStream
        /// </summary>
        /// <param name="requestStream"></param>
        /// <param name="responseStream"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public override async Task CommunicationStream(IAsyncStreamReader<StartStream> requestStream, IServerStreamWriter<CommunicationResponse> responseStream, ServerCallContext context)
        {
            m_responseStream = responseStream;

            while (await requestStream.MoveNext())
            {
                var current = requestStream.Current;

            }
        }

        /// <summary>
        /// SendColorReceived
        /// </summary>
        /// <param name="color"></param>
        /// <returns></returns>
        public async Task SendColorReceived(Colors color)
        {
            // Build message.
            var message = new CommunicationResponse
            {
                ColorReceived = new ColorReceived()
            };

            switch (color)
            {
                case Colors.Green:
                    message.ColorReceived.GreenMessage = new GreenMessage();
                    break;

                case Colors.Yellow:
                    message.ColorReceived.YellowMessage = new YellowMessage();
                    break;

                case Colors.Red:
                    message.ColorReceived.RedMessage = new RedMessage();
                    break;

                case Colors.Orange:
                    message.ColorReceived.OrangeMessage = new OrangeMessage();
                    break;
            }

            // Send response to stream.
            await m_responseStream.WriteAsync(message);
        }

        /// <summary>
        /// SendGameCompleted
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public async Task SendGameCompleted(string gameCompletedMessage)
        {
            // Build message.
            var message = new CommunicationResponse
            { 
                GameCompleted = new GameCompleted 
                { 
                    Message = gameCompletedMessage
                }
            };

            // Send response to stream.
            await m_responseStream.WriteAsync(message);
        }

        #endregion

        #region Private Variables

        private int m_green;
        private int m_yellow;
        private int m_red;
        private int m_orange;

        private IServerStreamWriter<CommunicationResponse> m_responseStream;

        #endregion

    }
}
