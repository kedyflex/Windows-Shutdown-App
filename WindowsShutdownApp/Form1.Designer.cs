namespace WindowsShutdownApp
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.txtTimerMinute = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnTimerStart = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnTimerStop = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuProgressBar1 = new Bunifu.Framework.UI.BunifuProgressBar();
            this.btnAppClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnAppClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // txtTimerMinute
            // 
            this.txtTimerMinute.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimerMinute.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTimerMinute.ForeColor = System.Drawing.Color.Black;
            this.txtTimerMinute.HintForeColor = System.Drawing.Color.Black;
            this.txtTimerMinute.HintText = "Enter the Closing Time in Minute";
            this.txtTimerMinute.isPassword = false;
            this.txtTimerMinute.LineFocusedColor = System.Drawing.Color.White;
            this.txtTimerMinute.LineIdleColor = System.Drawing.Color.Black;
            this.txtTimerMinute.LineMouseHoverColor = System.Drawing.Color.White;
            this.txtTimerMinute.LineThickness = 5;
            this.txtTimerMinute.Location = new System.Drawing.Point(188, 120);
            this.txtTimerMinute.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.txtTimerMinute.Name = "txtTimerMinute";
            this.txtTimerMinute.Size = new System.Drawing.Size(425, 67);
            this.txtTimerMinute.TabIndex = 1;
            this.txtTimerMinute.TabStop = false;
            this.txtTimerMinute.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTimerMinute.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTimerMinute_KeyPress);
            // 
            // btnTimerStart
            // 
            this.btnTimerStart.ActiveBorderThickness = 2;
            this.btnTimerStart.ActiveCornerRadius = 20;
            this.btnTimerStart.ActiveFillColor = System.Drawing.Color.Black;
            this.btnTimerStart.ActiveForecolor = System.Drawing.Color.White;
            this.btnTimerStart.ActiveLineColor = System.Drawing.Color.White;
            this.btnTimerStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(204)))), ((int)(((byte)(253)))));
            this.btnTimerStart.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTimerStart.BackgroundImage")));
            this.btnTimerStart.ButtonText = "Start Timer";
            this.btnTimerStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimerStart.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTimerStart.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnTimerStart.IdleBorderThickness = 2;
            this.btnTimerStart.IdleCornerRadius = 20;
            this.btnTimerStart.IdleFillColor = System.Drawing.Color.White;
            this.btnTimerStart.IdleForecolor = System.Drawing.Color.Black;
            this.btnTimerStart.IdleLineColor = System.Drawing.Color.Black;
            this.btnTimerStart.Location = new System.Drawing.Point(188, 203);
            this.btnTimerStart.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.btnTimerStart.Name = "btnTimerStart";
            this.btnTimerStart.Size = new System.Drawing.Size(425, 56);
            this.btnTimerStart.TabIndex = 2;
            this.btnTimerStart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnTimerStart.Click += new System.EventHandler(this.btnTimerStart_Click);
            // 
            // btnTimerStop
            // 
            this.btnTimerStop.ActiveBorderThickness = 2;
            this.btnTimerStop.ActiveCornerRadius = 20;
            this.btnTimerStop.ActiveFillColor = System.Drawing.Color.Black;
            this.btnTimerStop.ActiveForecolor = System.Drawing.Color.White;
            this.btnTimerStop.ActiveLineColor = System.Drawing.Color.White;
            this.btnTimerStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(204)))), ((int)(((byte)(253)))));
            this.btnTimerStop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTimerStop.BackgroundImage")));
            this.btnTimerStop.ButtonText = "Stop Timer";
            this.btnTimerStop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimerStop.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTimerStop.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnTimerStop.IdleBorderThickness = 2;
            this.btnTimerStop.IdleCornerRadius = 20;
            this.btnTimerStop.IdleFillColor = System.Drawing.Color.White;
            this.btnTimerStop.IdleForecolor = System.Drawing.Color.Black;
            this.btnTimerStop.IdleLineColor = System.Drawing.Color.Black;
            this.btnTimerStop.Location = new System.Drawing.Point(188, 275);
            this.btnTimerStop.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.btnTimerStop.Name = "btnTimerStop";
            this.btnTimerStop.Size = new System.Drawing.Size(425, 56);
            this.btnTimerStop.TabIndex = 2;
            this.btnTimerStop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnTimerStop.Click += new System.EventHandler(this.btnTimerStop_Click);
            // 
            // bunifuProgressBar1
            // 
            this.bunifuProgressBar1.BackColor = System.Drawing.Color.Black;
            this.bunifuProgressBar1.BorderRadius = 0;
            this.bunifuProgressBar1.Location = new System.Drawing.Point(0, 0);
            this.bunifuProgressBar1.MaximumValue = 100;
            this.bunifuProgressBar1.Name = "bunifuProgressBar1";
            this.bunifuProgressBar1.ProgressColor = System.Drawing.Color.Transparent;
            this.bunifuProgressBar1.Size = new System.Drawing.Size(800, 46);
            this.bunifuProgressBar1.TabIndex = 3;
            this.bunifuProgressBar1.Value = 0;
            // 
            // btnAppClose
            // 
            this.btnAppClose.BackColor = System.Drawing.Color.Black;
            this.btnAppClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAppClose.Image = ((System.Drawing.Image)(resources.GetObject("btnAppClose.Image")));
            this.btnAppClose.ImageActive = null;
            this.btnAppClose.Location = new System.Drawing.Point(750, 0);
            this.btnAppClose.Name = "btnAppClose";
            this.btnAppClose.Size = new System.Drawing.Size(50, 45);
            this.btnAppClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAppClose.TabIndex = 7;
            this.btnAppClose.TabStop = false;
            this.btnAppClose.Zoom = 0;
            this.btnAppClose.Click += new System.EventHandler(this.btnAppClose_Click);
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.Black;
            this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(0, 5);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(50, 35);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 8;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Arial", 15F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(52, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = "Windows Shutdown";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(204)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bunifuImageButton2);
            this.Controls.Add(this.btnAppClose);
            this.Controls.Add(this.bunifuProgressBar1);
            this.Controls.Add(this.btnTimerStop);
            this.Controls.Add(this.btnTimerStart);
            this.Controls.Add(this.txtTimerMinute);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Windows Shutdown";
            this.Click += new System.EventHandler(this.Form1_Click);
            ((System.ComponentModel.ISupportInitialize)(this.btnAppClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtTimerMinute;
        private Bunifu.Framework.UI.BunifuThinButton2 btnTimerStart;
        private Bunifu.Framework.UI.BunifuThinButton2 btnTimerStop;
        private Bunifu.Framework.UI.BunifuProgressBar bunifuProgressBar1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private Bunifu.Framework.UI.BunifuImageButton btnAppClose;
    }
}

