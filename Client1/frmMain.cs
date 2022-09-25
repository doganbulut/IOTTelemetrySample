
using Microsoft.Azure.Devices.Client;
using Microsoft.Azure.Devices.Shared;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client1
{
    public partial class frmMain : Form
    {

        static frmMain frmInstance = null;
        static string DeviceConnectionString = "HostName=iotc-29e52c61-f799-475b-b78d-e2611535f834.azure-devices.net;DeviceId=cda9f6ee-9c13-4b99-9f75-20b23d221035;SharedAccessKey=*******";
        static DeviceClient Client = null;
        static CancellationTokenSource cts;

        public frmMain()
        {
            InitializeComponent();
        }


        public static void InitClient()
        {
            try
            {
                AddMessage("Connecting to hub");
                Client = DeviceClient.CreateFromConnectionString(DeviceConnectionString, TransportType.Mqtt);
            }
            catch (Exception ex)
            {
                AddMessage("Error in sample: {0}", ex.Message);
            }
        }

       
        private static async void SendTelemetryAsync(CancellationToken token)
        {
            try
            {
               
                while (true)
                {

                    double PowerConsumption = double.TryParse(frmInstance.txtPowerConsumption.Text, out PowerConsumption) ? PowerConsumption : -1;
                    double ServoTemperature = double.TryParse(frmInstance.txtServoTemperature.Text, out ServoTemperature) ? ServoTemperature : -1;
                    double Vibration = double.TryParse(frmInstance.txtVibration.Text, out Vibration) ? Vibration : -1;
                    bool Error = frmInstance.chkError.Checked;
                    bool Working = frmInstance.chkWorking.Checked;
                    string OverPowerMessage = frmInstance.txtPower.Text;
                    string OverTempMessage = frmInstance.txtTemp.Text;

                    Telemetry telemertyData = new Telemetry
                    {
                        PowerConsumption = PowerConsumption,
                        servoTemperature = ServoTemperature,
                        Vibration = Vibration,
                        Error = Error,
                        Working = Working,
                        OverPower = OverPowerMessage,
                        OverTemp = OverTempMessage
                    };



                    var messageString = JsonConvert.SerializeObject(telemertyData);
                    var message = new Microsoft.Azure.Devices.Client.Message(Encoding.ASCII.GetBytes(messageString));

                    token.ThrowIfCancellationRequested();
                    await Client.SendEventAsync(message);

                    AddMessage("{0} > Sending telemetry: {1}", messageString);

                    await Task.Delay(5000);
                }
            }
            catch (Exception ex)
            {

                AddMessage("Intentional shutdown: {0}", ex.Message);
            }
        }


        private static void AddMessage(string Message)
        {
            frmInstance.lstMessage.Items.Insert(0,Message);
        }

        private static void AddMessage(string Message,string Exception)
        {
            frmInstance.lstMessage.Items.Insert(0, Message+" "+Exception);
        }


        private void frmMain_Load(object sender, EventArgs e)
        {

            frmInstance = this;
            AddMessage("Azure IoT Central");

            try
            {
                InitClient();

                cts = new CancellationTokenSource();
                SendTelemetryAsync(cts.Token);
            }
            catch (Exception ex)
            {
                AddMessage("Error in sample: " + ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            cts.Cancel();
        }
    }
}


    

