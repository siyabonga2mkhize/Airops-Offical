namespace AirOps_Login
{
    partial class FrmRetrievePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRetrievePassword));
            this.lblHeading = new System.Windows.Forms.Label();
            this.lblNoWorries = new System.Windows.Forms.Label();
            this.txtIDNumber = new System.Windows.Forms.TextBox();
            this.btnRetrieve = new System.Windows.Forms.Button();
            this.lblYouPasswordis = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.BackColor = System.Drawing.Color.Transparent;
            this.lblHeading.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblHeading.Location = new System.Drawing.Point(283, 56);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(248, 24);
            this.lblHeading.TabIndex = 0;
            this.lblHeading.Text = "Forgot Your Password?";
            // 
            // lblNoWorries
            // 
            this.lblNoWorries.AutoSize = true;
            this.lblNoWorries.BackColor = System.Drawing.Color.Transparent;
            this.lblNoWorries.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoWorries.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblNoWorries.Location = new System.Drawing.Point(219, 93);
            this.lblNoWorries.Name = "lblNoWorries";
            this.lblNoWorries.Size = new System.Drawing.Size(380, 20);
            this.lblNoWorries.TabIndex = 1;
            this.lblNoWorries.Text = "No worries, Enter your ID Number to retrieve your password";
            // 
            // txtIDNumber
            // 
            this.txtIDNumber.BackColor = System.Drawing.Color.Black;
            this.txtIDNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIDNumber.ForeColor = System.Drawing.SystemColors.Window;
            this.txtIDNumber.Location = new System.Drawing.Point(247, 153);
            this.txtIDNumber.Name = "txtIDNumber";
            this.txtIDNumber.Size = new System.Drawing.Size(330, 32);
            this.txtIDNumber.TabIndex = 2;
            // 
            // btnRetrieve
            // 
            this.btnRetrieve.BackColor = System.Drawing.Color.Transparent;
            this.btnRetrieve.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRetrieve.BackgroundImage")));
            this.btnRetrieve.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRetrieve.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRetrieve.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetrieve.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnRetrieve.Location = new System.Drawing.Point(223, 208);
            this.btnRetrieve.Name = "btnRetrieve";
            this.btnRetrieve.Size = new System.Drawing.Size(168, 38);
            this.btnRetrieve.TabIndex = 3;
            this.btnRetrieve.Text = "Retrieve Password";
            this.btnRetrieve.UseVisualStyleBackColor = false;
            this.btnRetrieve.Click += new System.EventHandler(this.btnRetrieve_Click);
            // 
            // lblYouPasswordis
            // 
            this.lblYouPasswordis.AutoSize = true;
            this.lblYouPasswordis.BackColor = System.Drawing.Color.Transparent;
            this.lblYouPasswordis.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYouPasswordis.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblYouPasswordis.Location = new System.Drawing.Point(196, 297);
            this.lblYouPasswordis.Name = "lblYouPasswordis";
            this.lblYouPasswordis.Size = new System.Drawing.Size(134, 19);
            this.lblYouPasswordis.TabIndex = 4;
            this.lblYouPasswordis.Text = "Your Password is:\r\n";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblPassword.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblPassword.Location = new System.Drawing.Point(336, 297);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(55, 24);
            this.lblPassword.TabIndex = 5;
            this.lblPassword.Text = "*****";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Location = new System.Drawing.Point(435, 208);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 38);
            this.button1.TabIndex = 6;
            this.button1.Text = "Return to Login";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmRetrievePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(805, 422);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblYouPasswordis);
            this.Controls.Add(this.btnRetrieve);
            this.Controls.Add(this.txtIDNumber);
            this.Controls.Add(this.lblNoWorries);
            this.Controls.Add(this.lblHeading);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FrmRetrievePassword";
            this.Text = "Retrieve Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Label lblNoWorries;
        private System.Windows.Forms.TextBox txtIDNumber;
        private System.Windows.Forms.Button btnRetrieve;
        private System.Windows.Forms.Label lblYouPasswordis;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button button1;
    }
}