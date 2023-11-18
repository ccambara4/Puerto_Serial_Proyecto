using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Puerto_Serial_Proyecto
{
    public partial class Puerto_Serial : MetroFramework.Forms.MetroForm
    {
        private delegate void DelegadoAccceso(string accion);
        private string strBufferIn;
        private string strbufferOut;
        public Puerto_Serial()
        {
            InitializeComponent();
        }

        private void AccesoForm(string accion)
        {
            strBufferIn = accion;
            TxtDatosRecibidos.Text = strBufferIn;
        }

        private void AccesoInterrupcion(string accion)
        {
            DelegadoAccceso Var_DelegadoAcceso;
            Var_DelegadoAcceso = new DelegadoAccceso(AccesoForm);
            object[] arg = { accion };
            base.Invoke(Var_DelegadoAcceso, arg);

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            strBufferIn = "";
            strbufferOut = "";
            btnConectar.Enabled = false;
            btnEnviarDatos.Enabled = false;

        }

        private void btnBuscar_Click(object sender, EventArgs e)//Busca nuevos puertos
        {
            string[] PuertosDisponibles = SerialPort.GetPortNames();

            foreach(string puerto_simple in PuertosDisponibles)
            {
                CboPuertos.Items.Add(puerto_simple);
            }
            if(CboPuertos.Items.Count > 0)
            {
                CboPuertos.SelectedIndex = 0;
                MessageBox.Show("Seleccione el puerto a trabajar");
                btnConectar.Enabled = true;
            }
            else
            {
                MessageBox.Show("No se detectó ningún puerto");
                CboPuertos.Items.Clear();
                CboPuertos.Text = "                    ";
                strBufferIn = "";
                strbufferOut = "";
                btnConectar.Enabled = false;
                btnEnviarDatos.Enabled = false;
            }
        }

        private void btnConectar_Click(object sender, EventArgs e)//Conectar a los puertos disponibles en la pc o virtualmente
        {
            try
            {
                if(btnConectar.Text=="Conectar")
                {
                    SpPuertos.BaudRate = Int32.Parse(CboBaudRate.Text);
                    SpPuertos.DataBits = 8;
                    SpPuertos.Parity = Parity.None;
                    SpPuertos.StopBits = StopBits.One;
                    SpPuertos.Handshake = Handshake.None;
                    SpPuertos.PortName = CboPuertos.Text;

                    try
                    {
                        SpPuertos.Open();
                        btnConectar.Text = "Desconectar";
                        btnEnviarDatos.Enabled = true;
                    }
                    catch(Exception exc)
                    {
                        MessageBox.Show(exc.Message.ToString());
                    }


                }

                else if(btnConectar.Text == "Desconectar")
                {
                    SpPuertos.Close();
                    btnConectar.Text = "Conectar";
                    btnEnviarDatos.Enabled = true;

                }
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message.ToString());
            }
        }

        private void btnEnviarDatos_Click(object sender, EventArgs e)//Encia los datos al otro puerto
        {
            try
            {
                SpPuertos.DiscardOutBuffer();
                strbufferOut = TxtDatos_a_Enviar.Text;
                SpPuertos.Write(strbufferOut);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message.ToString());
            }
        }

        private void DatoRecibido(object sender, SerialDataReceivedEventArgs e)//Recibi los datos del puerto al que se enviaron los datos
        {
            AccesoInterrupcion(SpPuertos.ReadExisting());
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
