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

namespace controller
{
    public partial class MainView : Form
    {
        private List<string> output = new List<string>();
        private SerialPort sp = new SerialPort();

        public MainView()
        {
            InitializeComponent();
            sp.BaudRate = 9600;
        }

        private void connect_button_Click(object sender, EventArgs e)
        {
            if (sp.IsOpen)
            {
                sp.Close();
                this.connect_button.Text = "Connect";
                log("Conection closed.");
            }
            else
            {
                log($"Connecting to COM{this.com_numericUpDown.Value}...");
                sp.PortName = $"COM{this.com_numericUpDown.Value}";
                try
                {
                    sp.Open();
                    this.connect_button.Text = "Disconnect";
                    log("Connected!");
                }
                catch
                {
                    log("Connection failed.");
                }
            }
        }

        public void log(string message)
        {
            const int length = 6;
            output.Add(message);
            if (output.Count > length)
            {
                output.RemoveAt(0);
            }
            this.output_richTextBox.Lines = output.ToArray();
        }

        private void bigleft_button_Click(object sender, EventArgs e)
        {
            log("Jumping left");
            sp.WriteLine("L");
        }

        private void littleleft_button_Click(object sender, EventArgs e)
        {
            log("Stepping left");
            sp.WriteLine("l");
        }

        private void littleright_button_Click(object sender, EventArgs e)
        {
            log("Stepping right");
            sp.WriteLine("r");
        }

        private void bigright_button_Click(object sender, EventArgs e)
        {
            log("Jumping right");
            sp.WriteLine("R");
        }
    }
}
