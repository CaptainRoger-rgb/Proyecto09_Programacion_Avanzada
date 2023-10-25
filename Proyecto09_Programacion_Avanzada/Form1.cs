﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace Proyecto09_Programacion_Avanzada
{
    public partial class Form1 : Form
    {
        delegate void SetTextDelegate(string value);
        public SerialPort ArduinoPort
        {
            get;
        }
        public Form1()
        {
            InitializeComponent();
            ArduinoPort = new System.IO.Ports.SerialPort();
            ArduinoPort.PortName = "COM6";
            ArduinoPort.BaudRate = 9600;
            ArduinoPort.DataBits = 8;
            ArduinoPort.ReadTimeout = 500;
            ArduinoPort.WriteTimeout = 500;
            ArduinoPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);

            this.btnConectar.Click += btnConectar_Click;
        }

        private void DataReceivedHandler(object sneder, SerialDataReceivedEventArgs e)
        {
            string dato = ArduinoPort.ReadLine();
            EscribirTxt(dato);
        }

        private void EscribirTxt(string dato)
        {
            if (InvokeRequired)
                try
                {
                    Invoke(new SetTextDelegate(EscribirTxt), dato);
                }
                catch { }
            else
                lblTemperatura.Text = dato;
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            btnDesconectar.Enabled = true;
            try
            {
                if (!ArduinoPort.IsOpen)
                    ArduinoPort.Open();
                if (int.TryParse(txtLimTem.Text, out int temperatureLimit))
                {
                    //Convierte
                    string limitString = temperatureLimit.ToString();
                    ArduinoPort.Write(limitString);
                }
                else
                {
                    MessageBox.Show("Ingresa un valor númerico válido en el TextBox del limite de la Temperatura. ");
                }

                lblConetion.Text = "Conexión OK";
                lblConetion.ForeColor = System.Drawing.Color.Lime;             
            }

            catch
            {
                MessageBox.Show("Configure el puerto de comunicacion correcto o Desconecte");
            }
        }

        private void btnDesconectar_Click(object sender, EventArgs e)
        {
            btnConectar.Enabled = true;
            btnDesconectar.Enabled = false;
            if (ArduinoPort.IsOpen)
                ArduinoPort.Close();
            lblConetion.Text = "Desconectado";
            lblConetion.ForeColor = System.Drawing.Color.Red;
            lblTemperatura.Text = "0.0";

        }
    }
}
