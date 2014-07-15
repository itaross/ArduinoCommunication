using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;


namespace ArduinoCommunication {

    public partial class Form1 : Form {

        private SerialPort serialPort;
        private String buffer;
        private ArduinoBoardManager arduinoMan;
        bool toggle = false;

        public Form1() {

            InitializeComponent();

            arduinoMan = new ArduinoBoardManager();

            serialPort = new SerialPort();
            serialPort.ReadTimeout = 500;
            serialPort.WriteTimeout = 500;
            serialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);

            String[] serialPortList = SerialPort.GetPortNames();

            //Initialize the list of serial ports
            cbbComPort.BeginUpdate();
            foreach (String serialPortName in serialPortList) {
                System.Console.WriteLine(serialPortName);
                cbbComPort.Items.Add(serialPortName);
            }
            cbbComPort.EndUpdate();

            //Initialize the list of baud rates
            cbbBaudRate.BeginUpdate();
            Object[] baudRateList = { "9600", "14400", "19200", "28800", "34400", "57600", "115200" };
            cbbBaudRate.Items.AddRange(baudRateList);
            cbbBaudRate.EndUpdate();
        
        }

        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e) {
            SerialPort sp = (SerialPort)sender;
            buffer = sp.ReadExisting();
            System.Console.WriteLine(buffer);

            this.Invoke(new EventHandler(DisplayText));

        }

        private void DisplayText(object sender, EventArgs e) {
            tbDisplay.AppendText(buffer + "\n");
            if (buffer.Equals("ACK")) {
                cbLedStatus.Checked = toggle;
            }
        }

        private void btnConnect_Click(object sender, EventArgs e) {

            tbDisplay.Lines = null;

            if (serialPort.IsOpen) {
                serialPort.Close();
                btnConnect.Text = "Connect";
                btnConnect.ForeColor = Color.Red;
            }
            else {

                if (cbbComPort.SelectedItem == null) {
                    serialPort.PortName = "COM42";
                    cbbComPort.SelectedItem = "COM42";
                }
                else {
                    serialPort.PortName = (String)cbbComPort.SelectedItem;
                }

                if (cbbBaudRate.SelectedItem == null) {

                    serialPort.BaudRate = 115200;
                    cbbBaudRate.SelectedItem = "115200";
                }
                else {
                    serialPort.BaudRate = int.Parse(cbbBaudRate.SelectedItem.ToString());
                }

                //try to open the serial port
                try {
                    serialPort.Open();
                }
                catch (Exception ex) {
                    MessageBox.Show("Error: " + ex.ToString(), "Error");
                }


                btnConnect.Text = "Connected";
                btnConnect.ForeColor = Color.Green;

                tbDisplay.AppendText("Serial connection initialized with parameters: \n");
                tbDisplay.AppendText("Port: " + serialPort.PortName + "\n");
                tbDisplay.AppendText("Baud Rate: " + serialPort.BaudRate + "\n");
                tbDisplay.AppendText("Data Bits: " + serialPort.DataBits + "\n");
                tbDisplay.AppendText("Rts Enable: " + serialPort.RtsEnable + "\n");
                tbDisplay.AppendText("Parity: " + serialPort.Parity + "\n\n\n");

            }

        }

        private void btnDigitalWrite_Click(object sender, EventArgs e) {
            toggle = !toggle;
            int pin_n = int.Parse(tbPin.Lines[0]);
            String cmd = arduinoMan.writeDigitalPinValue(pin_n, toggle);
            serialPort.Write(cmd);
            
        }

    }
}
