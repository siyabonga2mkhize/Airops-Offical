namespace AirOps_Login
{
    partial class FrmSearchFlights
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSearchFlights));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDAirport = new System.Windows.Forms.Label();
            this.lblArrivalA = new System.Windows.Forms.Label();
            this.radRound = new System.Windows.Forms.RadioButton();
            this.radOneWay = new System.Windows.Forms.RadioButton();
            this.lblDeparture = new System.Windows.Forms.Label();
            this.lblReturn = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmbDeparture = new System.Windows.Forms.ComboBox();
            this.cmbArrival = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(96, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(61, 54);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(163, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search Flights";
            // 
            // lblDAirport
            // 
            this.lblDAirport.AutoSize = true;
            this.lblDAirport.BackColor = System.Drawing.Color.Transparent;
            this.lblDAirport.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDAirport.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblDAirport.Location = new System.Drawing.Point(92, 125);
            this.lblDAirport.Name = "lblDAirport";
            this.lblDAirport.Size = new System.Drawing.Size(152, 24);
            this.lblDAirport.TabIndex = 2;
            this.lblDAirport.Text = "Depature Airport:";
            // 
            // lblArrivalA
            // 
            this.lblArrivalA.AutoSize = true;
            this.lblArrivalA.BackColor = System.Drawing.Color.Transparent;
            this.lblArrivalA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArrivalA.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblArrivalA.Location = new System.Drawing.Point(92, 160);
            this.lblArrivalA.Name = "lblArrivalA";
            this.lblArrivalA.Size = new System.Drawing.Size(127, 24);
            this.lblArrivalA.TabIndex = 3;
            this.lblArrivalA.Text = "Arrival Airport:";
            // 
            // radRound
            // 
            this.radRound.AutoSize = true;
            this.radRound.BackColor = System.Drawing.Color.Transparent;
            this.radRound.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radRound.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.radRound.Location = new System.Drawing.Point(100, 202);
            this.radRound.Name = "radRound";
            this.radRound.Size = new System.Drawing.Size(124, 28);
            this.radRound.TabIndex = 6;
            this.radRound.TabStop = true;
            this.radRound.Text = "Round-Trip";
            this.radRound.UseVisualStyleBackColor = false;
            // 
            // radOneWay
            // 
            this.radOneWay.AutoSize = true;
            this.radOneWay.BackColor = System.Drawing.Color.Transparent;
            this.radOneWay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radOneWay.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.radOneWay.Location = new System.Drawing.Point(273, 202);
            this.radOneWay.Name = "radOneWay";
            this.radOneWay.Size = new System.Drawing.Size(104, 28);
            this.radOneWay.TabIndex = 7;
            this.radOneWay.TabStop = true;
            this.radOneWay.Text = "One-way";
            this.radOneWay.UseVisualStyleBackColor = false;
            // 
            // lblDeparture
            // 
            this.lblDeparture.AutoSize = true;
            this.lblDeparture.BackColor = System.Drawing.Color.Transparent;
            this.lblDeparture.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeparture.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblDeparture.Location = new System.Drawing.Point(96, 244);
            this.lblDeparture.Name = "lblDeparture";
            this.lblDeparture.Size = new System.Drawing.Size(98, 24);
            this.lblDeparture.TabIndex = 8;
            this.lblDeparture.Text = "Departure:";
            // 
            // lblReturn
            // 
            this.lblReturn.AutoSize = true;
            this.lblReturn.BackColor = System.Drawing.Color.Transparent;
            this.lblReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReturn.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblReturn.Location = new System.Drawing.Point(92, 283);
            this.lblReturn.Name = "lblReturn";
            this.lblReturn.Size = new System.Drawing.Size(71, 24);
            this.lblReturn.TabIndex = 9;
            this.lblReturn.Text = "Return:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label6.Location = new System.Drawing.Point(95, 330);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(207, 24);
            this.label6.TabIndex = 12;
            this.label6.Text = "Number of passengers:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label7.Location = new System.Drawing.Point(95, 375);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 24);
            this.label7.TabIndex = 13;
            this.label7.Text = "Class:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Economy",
            "First Class",
            "Business Class"});
            this.comboBox1.Location = new System.Drawing.Point(198, 379);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 14;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(323, 332);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(144, 20);
            this.numericUpDown1.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Location = new System.Drawing.Point(660, 376);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 36);
            this.button1.TabIndex = 17;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(267, 245);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 18;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(267, 285);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 19;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // cmbDeparture
            // 
            this.cmbDeparture.FormattingEnabled = true;
            this.cmbDeparture.Location = new System.Drawing.Point(288, 125);
            this.cmbDeparture.Name = "cmbDeparture";
            this.cmbDeparture.Size = new System.Drawing.Size(179, 21);
            this.cmbDeparture.TabIndex = 21;
            // 
            // cmbArrival
            // 
            this.cmbArrival.FormattingEnabled = true;
            this.cmbArrival.Location = new System.Drawing.Point(288, 163);
            this.cmbArrival.Name = "cmbArrival";
            this.cmbArrival.Size = new System.Drawing.Size(179, 21);
            this.cmbArrival.TabIndex = 22;
            // 
            // FrmSearchFlights
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(877, 504);
            this.Controls.Add(this.cmbArrival);
            this.Controls.Add(this.cmbDeparture);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblReturn);
            this.Controls.Add(this.lblDeparture);
            this.Controls.Add(this.radOneWay);
            this.Controls.Add(this.radRound);
            this.Controls.Add(this.lblArrivalA);
            this.Controls.Add(this.lblDAirport);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FrmSearchFlights";
            this.Text = "Search Flights";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDAirport;
        private System.Windows.Forms.Label lblArrivalA;
        private System.Windows.Forms.RadioButton radRound;
        private System.Windows.Forms.RadioButton radOneWay;
        private System.Windows.Forms.Label lblDeparture;
        private System.Windows.Forms.Label lblReturn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ComboBox cmbDeparture;
        private System.Windows.Forms.ComboBox cmbArrival;
    }
}