
namespace Puerto_Serial_Proyecto
{
    partial class Puerto_Serial
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnBuscar = new MetroFramework.Controls.MetroButton();
            this.btnConectar = new MetroFramework.Controls.MetroButton();
            this.btnEnviarDatos = new MetroFramework.Controls.MetroButton();
            this.CboPuertos = new MetroFramework.Controls.MetroComboBox();
            this.CboBaudRate = new MetroFramework.Controls.MetroComboBox();
            this.LblBaudrate = new MetroFramework.Controls.MetroLabel();
            this.LblDatosIngreso = new MetroFramework.Controls.MetroLabel();
            this.TxtDatos_a_Enviar = new MetroFramework.Controls.MetroTextBox();
            this.TxtDatosRecibidos = new MetroFramework.Controls.MetroTextBox();
            this.SpPuertos = new System.IO.Ports.SerialPort(this.components);
            this.btnCerrar = new MetroFramework.Controls.MetroButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnBuscar.Location = new System.Drawing.Point(23, 88);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(130, 32);
            this.btnBuscar.TabIndex = 0;
            this.btnBuscar.Text = "Buscar Puertos";
            this.btnBuscar.UseCustomBackColor = true;
            this.btnBuscar.UseSelectable = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnConectar
            // 
            this.btnConectar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnConectar.Location = new System.Drawing.Point(23, 126);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(130, 32);
            this.btnConectar.TabIndex = 1;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseCustomBackColor = true;
            this.btnConectar.UseSelectable = true;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // btnEnviarDatos
            // 
            this.btnEnviarDatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnEnviarDatos.Location = new System.Drawing.Point(313, 268);
            this.btnEnviarDatos.Name = "btnEnviarDatos";
            this.btnEnviarDatos.Size = new System.Drawing.Size(130, 32);
            this.btnEnviarDatos.TabIndex = 2;
            this.btnEnviarDatos.Text = "Enviar Datos";
            this.btnEnviarDatos.UseCustomBackColor = true;
            this.btnEnviarDatos.UseSelectable = true;
            this.btnEnviarDatos.Click += new System.EventHandler(this.btnEnviarDatos_Click);
            // 
            // CboPuertos
            // 
            this.CboPuertos.BackColor = System.Drawing.SystemColors.Info;
            this.CboPuertos.FormattingEnabled = true;
            this.CboPuertos.ItemHeight = 23;
            this.CboPuertos.Location = new System.Drawing.Point(166, 107);
            this.CboPuertos.Name = "CboPuertos";
            this.CboPuertos.Size = new System.Drawing.Size(121, 29);
            this.CboPuertos.TabIndex = 3;
            this.CboPuertos.UseCustomBackColor = true;
            this.CboPuertos.UseSelectable = true;
            // 
            // CboBaudRate
            // 
            this.CboBaudRate.BackColor = System.Drawing.SystemColors.Info;
            this.CboBaudRate.FormattingEnabled = true;
            this.CboBaudRate.ItemHeight = 23;
            this.CboBaudRate.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "28800",
            "38400",
            "56000",
            "115200"});
            this.CboBaudRate.Location = new System.Drawing.Point(516, 92);
            this.CboBaudRate.Name = "CboBaudRate";
            this.CboBaudRate.Size = new System.Drawing.Size(196, 29);
            this.CboBaudRate.TabIndex = 4;
            this.CboBaudRate.UseCustomBackColor = true;
            this.CboBaudRate.UseSelectable = true;
            // 
            // LblBaudrate
            // 
            this.LblBaudrate.AutoSize = true;
            this.LblBaudrate.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.LblBaudrate.Location = new System.Drawing.Point(568, 70);
            this.LblBaudrate.Name = "LblBaudrate";
            this.LblBaudrate.Size = new System.Drawing.Size(84, 19);
            this.LblBaudrate.TabIndex = 5;
            this.LblBaudrate.Text = "Frecuencia:";
            // 
            // LblDatosIngreso
            // 
            this.LblDatosIngreso.AutoSize = true;
            this.LblDatosIngreso.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.LblDatosIngreso.Location = new System.Drawing.Point(33, 352);
            this.LblDatosIngreso.Name = "LblDatosIngreso";
            this.LblDatosIngreso.Size = new System.Drawing.Size(120, 19);
            this.LblDatosIngreso.TabIndex = 6;
            this.LblDatosIngreso.Text = "Datos Recibidos:";
            // 
            // TxtDatos_a_Enviar
            // 
            // 
            // 
            // 
            this.TxtDatos_a_Enviar.CustomButton.Image = null;
            this.TxtDatos_a_Enviar.CustomButton.Location = new System.Drawing.Point(684, 1);
            this.TxtDatos_a_Enviar.CustomButton.Name = "";
            this.TxtDatos_a_Enviar.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtDatos_a_Enviar.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtDatos_a_Enviar.CustomButton.TabIndex = 1;
            this.TxtDatos_a_Enviar.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtDatos_a_Enviar.CustomButton.UseSelectable = true;
            this.TxtDatos_a_Enviar.CustomButton.Visible = false;
            this.TxtDatos_a_Enviar.Lines = new string[] {
        "Escriba datos"};
            this.TxtDatos_a_Enviar.Location = new System.Drawing.Point(33, 239);
            this.TxtDatos_a_Enviar.MaxLength = 32767;
            this.TxtDatos_a_Enviar.Name = "TxtDatos_a_Enviar";
            this.TxtDatos_a_Enviar.PasswordChar = '\0';
            this.TxtDatos_a_Enviar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtDatos_a_Enviar.SelectedText = "";
            this.TxtDatos_a_Enviar.SelectionLength = 0;
            this.TxtDatos_a_Enviar.SelectionStart = 0;
            this.TxtDatos_a_Enviar.ShortcutsEnabled = true;
            this.TxtDatos_a_Enviar.Size = new System.Drawing.Size(706, 23);
            this.TxtDatos_a_Enviar.TabIndex = 7;
            this.TxtDatos_a_Enviar.Text = "Escriba datos";
            this.TxtDatos_a_Enviar.UseSelectable = true;
            this.TxtDatos_a_Enviar.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtDatos_a_Enviar.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TxtDatosRecibidos
            // 
            // 
            // 
            // 
            this.TxtDatosRecibidos.CustomButton.Image = null;
            this.TxtDatosRecibidos.CustomButton.Location = new System.Drawing.Point(467, 1);
            this.TxtDatosRecibidos.CustomButton.Name = "";
            this.TxtDatosRecibidos.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtDatosRecibidos.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtDatosRecibidos.CustomButton.TabIndex = 1;
            this.TxtDatosRecibidos.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtDatosRecibidos.CustomButton.UseSelectable = true;
            this.TxtDatosRecibidos.CustomButton.Visible = false;
            this.TxtDatosRecibidos.Lines = new string[0];
            this.TxtDatosRecibidos.Location = new System.Drawing.Point(159, 352);
            this.TxtDatosRecibidos.MaxLength = 32767;
            this.TxtDatosRecibidos.Name = "TxtDatosRecibidos";
            this.TxtDatosRecibidos.PasswordChar = '\0';
            this.TxtDatosRecibidos.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtDatosRecibidos.SelectedText = "";
            this.TxtDatosRecibidos.SelectionLength = 0;
            this.TxtDatosRecibidos.SelectionStart = 0;
            this.TxtDatosRecibidos.ShortcutsEnabled = true;
            this.TxtDatosRecibidos.Size = new System.Drawing.Size(489, 23);
            this.TxtDatosRecibidos.TabIndex = 8;
            this.TxtDatosRecibidos.UseSelectable = true;
            this.TxtDatosRecibidos.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtDatosRecibidos.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // SpPuertos
            // 
            this.SpPuertos.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.DatoRecibido);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Red;
            this.btnCerrar.Location = new System.Drawing.Point(657, 450);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(130, 65);
            this.btnCerrar.TabIndex = 9;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseCustomBackColor = true;
            this.btnCerrar.UseSelectable = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Puerto_Serial_Proyecto.Properties.Resources.red04;
            this.pictureBox2.Location = new System.Drawing.Point(289, 389);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(182, 149);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Puerto_Serial_Proyecto.Properties.Resources.images;
            this.pictureBox1.Location = new System.Drawing.Point(166, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(92, 49);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // Puerto_Serial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 561);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.TxtDatosRecibidos);
            this.Controls.Add(this.TxtDatos_a_Enviar);
            this.Controls.Add(this.LblDatosIngreso);
            this.Controls.Add(this.LblBaudrate);
            this.Controls.Add(this.CboBaudRate);
            this.Controls.Add(this.CboPuertos);
            this.Controls.Add(this.btnEnviarDatos);
            this.Controls.Add(this.btnConectar);
            this.Controls.Add(this.btnBuscar);
            this.Name = "Puerto_Serial";
            this.Text = "Puerto Serial";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnBuscar;
        private MetroFramework.Controls.MetroButton btnConectar;
        private MetroFramework.Controls.MetroButton btnEnviarDatos;
        private MetroFramework.Controls.MetroComboBox CboPuertos;
        private MetroFramework.Controls.MetroComboBox CboBaudRate;
        private MetroFramework.Controls.MetroLabel LblBaudrate;
        private MetroFramework.Controls.MetroLabel LblDatosIngreso;
        private MetroFramework.Controls.MetroTextBox TxtDatos_a_Enviar;
        private MetroFramework.Controls.MetroTextBox TxtDatosRecibidos;
        private System.IO.Ports.SerialPort SpPuertos;
        private MetroFramework.Controls.MetroButton btnCerrar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

