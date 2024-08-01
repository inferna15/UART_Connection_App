using System.IO.Ports;

namespace UART_Connection_App
{
    public partial class Form1 : Form
    {
        private SerialPort serial;
        private string[] ports = SerialPort.GetPortNames();

        public Form1()
        {
            InitializeComponent();
            disconnectBtn.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            serial = new SerialPort();
            foreach (string port in ports)
            {
                portsBox.Items.Add(port);
            }
            if (portsBox.Items.Count > 0)
            {
                portsBox.SelectedIndex = 0;
            }

            serial.DataReceived += new SerialDataReceivedEventHandler(serial_DataReceived);
        }

        private void serial_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string data = serial.ReadLine();
            messageListBox.Items.Add(data);
        }

        private void connectBtn_Click(object sender, EventArgs e)
        {
            if (!serial.IsOpen)
            {
                serial.PortName = portsBox.Text;
                serial.BaudRate = 9600;
                serial.Parity = Parity.None;
                serial.StopBits = StopBits.One;
                serial.DataBits = 8;

                try
                {
                    serial.Open();
                }
                catch (Exception)
                {
                    Console.WriteLine("Baðlantý kurulamadý");
                    throw;
                }

                connectBtn.Enabled = false;
                disconnectBtn.Enabled = true;
            }
        }

        private void disconnectBtn_Click(object sender, EventArgs e)
        {
            if (serial.IsOpen)
            {
                serial.Close();
                connectBtn.Enabled = true;
                disconnectBtn.Enabled = false;
            }

        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            if (messageBox.Text.Length > 0 && connectBtn.Enabled == false)
            {
                serial.WriteLine(messageBox.Text);
            }
        }
    }
}
