using Grpc.Core;
using Protos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace grpcPresentation
{
    public partial class Server : Form
    {

        #region Properties

        /// <summary>
        /// PlayerGrpcService
        /// </summary>
        public PlayerGrpcService PlayerGrpcService = new PlayerGrpcService();

        /// <summary>
        /// ColorGrpcService
        /// </summary>
        public Protos.Services.ColorGrpcService ColorGrpcService = new Protos.Services.ColorGrpcService();

        #endregion

        #region Constructor

        /// <summary>
        /// Server
        /// </summary>
        public Server()
        {
            InitializeComponent();

            StartServer();

            StartUITimer();
        }

        #endregion

        #region Methods

        /// <summary>
        /// StartUITimer
        /// </summary>
        private void StartUITimer()
        {
            m_timer = new System.Timers.Timer();
            m_timer.Interval = 1000;
            m_timer.Elapsed += M_timer_Elapsed;
            m_timer.AutoReset = true;
            m_timer.Start();
        }

        /// <summary>
        /// M_timer_Elapsed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void M_timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            var greenDifference = ColorGrpcService.Green - m_green;
            var redDifference = ColorGrpcService.Red - m_red;
            var yellowDifference = ColorGrpcService.Yellow - m_yellow;
            var orangeDifference = ColorGrpcService.Orange - m_orange;

            // Update color bars.
            if (greenDifference > 0)
            {
                for (int y = 0; y < greenDifference; y++)
                {
                    this.Invoke(new MethodInvoker(delegate ()
                    {
                        greenBar.PerformStep();
                    }));
                    
                    m_green++;
                }

                await ColorGrpcService.SendColorReceived(Protos.Enums.Colors.Green);
            }

            else if (redDifference > 0)
            {
                for (int y = 0; y < redDifference; y++)
                {
                    this.Invoke(new MethodInvoker(delegate ()
                    {
                        redBar.PerformStep();
                    }));
                    
                    m_red++;
                }

                await ColorGrpcService.SendColorReceived(Protos.Enums.Colors.Red);
            }

            else if (orangeDifference > 0)
            {
                for (int y = 0; y < orangeDifference; y++)
                {
                    this.Invoke(new MethodInvoker(delegate ()
                    {
                        orangeBar.PerformStep();
                    }));
                    
                    m_orange++;
                }

                await ColorGrpcService.SendColorReceived(Protos.Enums.Colors.Orange);
            }

            else if (yellowDifference > 0)
            {
                for (int y = 0; y < yellowDifference; y++)
                {
                    this.Invoke(new MethodInvoker(delegate ()
                    {
                        yellowBar.PerformStep();
                    }));
                    
                    m_yellow++;
                }

                await ColorGrpcService.SendColorReceived(Protos.Enums.Colors.Yellow);
            }

            if (m_green >= 10)
            {
                await ColorGrpcService.SendGameCompleted("Green wins!!");
                ResetGame();
            }
            else if (m_red >= 10)
            {
                await ColorGrpcService.SendGameCompleted("Red wins!!");
                ResetGame();
            }
            else if (m_orange >= 10)
            {
                await ColorGrpcService.SendGameCompleted("Orange wins!!");
                ResetGame();
            }
            else if (m_yellow >= 10)
            {
                await ColorGrpcService.SendGameCompleted("Yellow wins!!");
                ResetGame();
            }

            m_timer.Start();
        }

        private void ResetGame()
        {
            m_green = 0;
            m_red = 0;
            m_orange = 0;
            m_yellow = 0;

            ColorGrpcService.Green = 0;
            ColorGrpcService.Red = 0;
            ColorGrpcService.Orange = 0;
            ColorGrpcService.Yellow = 0;

            this.Invoke(new MethodInvoker(delegate ()
            {
                greenBar.Value = 0;
                redBar.Value = 0;
                yellowBar.Value = 0;
                orangeBar.Value = 0;
            }));

        }

        /// <summary>
        /// StartServer
        /// </summary>
        public void StartServer()
        {
            try
            {
                m_server = new Grpc.Core.Server
                {
                    Services =
                    {
                        PlayerService.BindService(PlayerGrpcService),
                        ColorService.BindService(ColorGrpcService)

                    },
                    Ports =
                    {
                        new ServerPort(m_host, m_port, ServerCredentials.Insecure)
                    }
                };

                m_server.Start();

            }
            catch (Exception e)
            {
                throw;
            }
        }


        #endregion


        #region Private Variables

        private Grpc.Core.Server m_server;
        private Channel m_channel;
        private const int m_port = 50051;
        private const string m_host = "localhost";        
        protected System.Timers.Timer m_timer = null;

        private int m_green = 0;
        private int m_red = 0;
        private int m_yellow = 0;
        private int m_orange = 0;

        #endregion
    }
}
