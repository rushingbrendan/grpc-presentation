using Grpc.Core;
using Newtonsoft.Json;
using Protos;
using Protos.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace grpcClient
{
    /// <summary>
    /// Client
    /// </summary>
    public partial class Client : Form
    {

        #region Constructor

        /// <summary>
        /// Client
        /// </summary>
        public Client()
        {
            InitializeComponent();

            CreateChannel();

            InitializeMonths();

            CommunicationStream();
        }

        #endregion

        #region Methods

        /// <summary>
        /// CommunicationStream
        /// </summary>
        /// <returns></returns>
        private async Task CommunicationStream()
        {
            // Create client.
            var client = new ColorService.ColorServiceClient(m_channel);

            var call = client.CommunicationStream();

            while (await call.ResponseStream.MoveNext())
            {
                // Get current response.
                var current = call.ResponseStream.Current;

                // Log response.
                CreateColorServiceLogEntry(current, gRPCMessageType.Response, nameof(CommunicationStream));

                switch (current.ResponseCase)
                {
                    // We could do something with this response but we wont.                    
                    case CommunicationResponse.ResponseOneofCase.ColorReceived:
                        
                        switch (current.ColorReceived.ColorCase)
                        {
                            case ColorReceived.ColorOneofCase.GreenMessage:
                                break;

                            case ColorReceived.ColorOneofCase.OrangeMessage:
                                break;

                            case ColorReceived.ColorOneofCase.RedMessage:
                                break;

                            case ColorReceived.ColorOneofCase.YellowMessage:
                                break;
                        }

                        break;

                    case CommunicationResponse.ResponseOneofCase.GameCompleted:
                        var message = current.GameCompleted.Message;
                        break;
                }
            }
        }

        /// <summary>
        /// CreateChannel
        /// </summary>
        public void CreateChannel()
        {
            m_channel = new Channel($"{m_host}:{m_port}", Grpc.Core.ChannelCredentials.Insecure);
        }

        /// <summary>
        /// InitializeMonths
        /// </summary>
        private void InitializeMonths()
        {
            foreach (var month in m_months)
            {
                months.Items.Add(month);
            }
            months.SelectedIndex = 0;
        }

        /// <summary>
        /// addPlayerButton_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void addPlayerButton_Click(object sender, EventArgs e)
        {
            await AddPlayer();
        }

        /// <summary>
        /// AddPlayer
        /// </summary>
        /// <returns></returns>
        private async Task AddPlayer()
        {
            AddPlayerResponse response;

            // gRPC Client.
            var client = new PlayerService.PlayerServiceClient(m_channel);

            // Create request.
            var playerRequest = new AddPlayerRequest
            {
                Player = new Player
                {
                    Id = 0,
                    FirstName = firstName.Text,
                    LastName = lastName.Text,
                    DateOfBirth = new DateOfBirth
                    {
                        Day = Convert.ToInt32(day.Value),
                        Year = Convert.ToInt32(year.Value)
                    }
                }
            };

            // Set month.
            switch (months.SelectedItem)
            {
                case "January":
                    playerRequest.Player.DateOfBirth.Month = Month.January;
                    break;

                case "February":
                    playerRequest.Player.DateOfBirth.Month = Month.February;
                    break;

                case "March":
                    playerRequest.Player.DateOfBirth.Month = Month.March;
                    break;

                case "April":
                    playerRequest.Player.DateOfBirth.Month = Month.April;
                    break;

                case "May":
                    playerRequest.Player.DateOfBirth.Month = Month.May;
                    break;

                case "June":
                    playerRequest.Player.DateOfBirth.Month = Month.June;
                    break;

                case "July":
                    playerRequest.Player.DateOfBirth.Month = Month.July;
                    break;

                case "August":
                    playerRequest.Player.DateOfBirth.Month = Month.August;
                    break;

                case "September":
                    playerRequest.Player.DateOfBirth.Month = Month.September;
                    break;

                case "October":
                    playerRequest.Player.DateOfBirth.Month = Month.October;
                    break;

                case "November":
                    playerRequest.Player.DateOfBirth.Month = Month.November;
                    break;

                case "December":
                    playerRequest.Player.DateOfBirth.Month = Month.December;
                    break;
            }

            // Log request.
            CreatePlayerServiceLogEntry(playerRequest, gRPCMessageType.Request, nameof(AddPlayer));

            try
            {
                // Get response from service.
                response = await client.AddPlayerAsync(playerRequest);
            }
            catch (Exception e)
            {
                // Should probably log this exception somewhere if this was production.
                throw;
            }

            // Log response.
            CreatePlayerServiceLogEntry(response, gRPCMessageType.Response, nameof(AddPlayer));
        }

        /// <summary>
        /// Log grpc to local collection.
        /// </summary>
        /// <param name="payload"></param>
        /// <param name="messageType"></param>
        private void CreatePlayerServiceLogEntry(object payload, gRPCMessageType messageType, string methodName)
        {
            const string logFormat = "ComponentName: '{0}' MethodName: '{1}' MessageType: '{2}' Message: '{3}'";

            // Convert object to json.
            var objectData = JsonConvert.SerializeObject(payload);

            // Log in gRPC output directory.
            grpcPlayerServiceLogOutput.Text += $"[{DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss")}] {string.Format(logFormat, nameof(PlayerService), methodName, messageType, objectData)}{Environment.NewLine}";
        }

        /// <summary>
        /// Log grpc to local collection.
        /// </summary>
        /// <param name="payload"></param>
        /// <param name="messageType"></param>
        private void CreateColorServiceLogEntry(object payload, gRPCMessageType messageType, string methodName)
        {
            const string logFormat = "ComponentName: '{0}' MethodName: '{1}' MessageType: '{2}' Message: '{3}'";

            // Convert object to json.
            var objectData = JsonConvert.SerializeObject(payload);

            // Log in gRPC output directory.
            grpcColorServiceLogOutput.Text += $"[{DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss")}] {string.Format(logFormat, nameof(ColorService), methodName, messageType, objectData)}{Environment.NewLine}";
        }

        /// <summary>
        /// getAllPlayersButton_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void getAllPlayersButton_Click(object sender, EventArgs e)
        {
            await GetAllPlayers();
        }

        /// <summary>
        /// GetAllPlayers
        /// </summary>
        /// <returns></returns>
        private async Task GetAllPlayers()
        {
            GetPlayersResponse response;

            // gRPC Client.
            var client = new PlayerService.PlayerServiceClient(m_channel);

            // Create request.
            var request = new Empty();

            // Log request.
            CreatePlayerServiceLogEntry(request, gRPCMessageType.Request, nameof(GetAllPlayers));

            try
            {
                // Get response from service.
                response = await client.GetPlayersAsync(request);
            }
            catch (Exception e)
            {
                // Should probably log this exception somewhere if this was production.
                throw;
            }

            // Log response.
            CreatePlayerServiceLogEntry(response, gRPCMessageType.Response, nameof(GetAllPlayers));
        }

        /// <summary>
        /// redButton_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void redButton_Click(object sender, EventArgs e)
        {
            // Create client.
            var client = new ColorService.ColorServiceClient(m_channel);

            // Create request and log.
            var request = new SendColorRequest { RedMessage = new RedMessage() };
            CreateColorServiceLogEntry(request, gRPCMessageType.Request, "Red");

            // Send request and log.
            var response = await client.SendColorAsync(request);
            CreateColorServiceLogEntry(response, gRPCMessageType.Response, "Red");
        }

        /// <summary>
        /// greenButton_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void greenButton_Click(object sender, EventArgs e)
        {
            // Create client.
            var client = new ColorService.ColorServiceClient(m_channel);

            // Create request and log.
            var request = new SendColorRequest { GreenMessage = new GreenMessage() };
            CreateColorServiceLogEntry(request, gRPCMessageType.Request, "Green");

            // Send request and log.
            var response = await client.SendColorAsync(request);
            CreateColorServiceLogEntry(response, gRPCMessageType.Response, "Green");
        }

        /// <summary>
        /// yellowButton_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void yellowButton_Click(object sender, EventArgs e)
        {
            // Create client.
            var client = new ColorService.ColorServiceClient(m_channel);

            // Create request and log.
            var request = new SendColorRequest { YellowMessage = new YellowMessage() };
            CreateColorServiceLogEntry(request, gRPCMessageType.Request, "Yellow");

            // Send request and log.
            var response = await client.SendColorAsync(request);
            CreateColorServiceLogEntry(response, gRPCMessageType.Response, "Yellow");
        }

        /// <summary>
        /// orangeButton_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void orangeButton_Click(object sender, EventArgs e)
        {
            // Create client.
            var client = new ColorService.ColorServiceClient(m_channel);

            // Create request and log.
            var request = new SendColorRequest { OrangeMessage = new OrangeMessage() };
            CreateColorServiceLogEntry(request, gRPCMessageType.Request, "Orange");

            // Send request and log.
            var response = await client.SendColorAsync(request);
            CreateColorServiceLogEntry(response, gRPCMessageType.Response, "Orange");
        }

        #endregion

        #region Private Properties

        private Channel m_channel;
        private const int m_port = 50051;
        private const string m_host = "localhost";


        /// <summary>
        /// Months
        /// </summary>
        private List<string> m_months = new List<string>
        {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"
        };

        #endregion

    }
}