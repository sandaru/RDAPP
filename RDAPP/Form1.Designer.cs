namespace RDAPP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupClent = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtClientString = new System.Windows.Forms.TextBox();
            this.groupServer = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numClients = new System.Windows.Forms.NumericUpDown();
            this.rtxtServerString = new System.Windows.Forms.RichTextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.axRDPViewer = new AxRDPCOMAPILib.AxRDPViewer();
            this.radioClient = new System.Windows.Forms.RadioButton();
            this.radioServer = new System.Windows.Forms.RadioButton();
            this.lblDisplay = new System.Windows.Forms.Label();
            this.groupClent.SuspendLayout();
            this.groupServer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numClients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axRDPViewer)).BeginInit();
            this.SuspendLayout();
            // 
            // groupClent
            // 
            this.groupClent.Controls.Add(this.button2);
            this.groupClent.Controls.Add(this.btnConnect);
            this.groupClent.Controls.Add(this.label1);
            this.groupClent.Controls.Add(this.txtClientString);
            this.groupClent.Enabled = false;
            this.groupClent.Location = new System.Drawing.Point(691, 27);
            this.groupClent.Name = "groupClent";
            this.groupClent.Size = new System.Drawing.Size(200, 151);
            this.groupClent.TabIndex = 0;
            this.groupClent.TabStop = false;
            this.groupClent.Text = "Client";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 113);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(188, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Disconnect";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(6, 84);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(188, 23);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Connection String";
            // 
            // txtClientString
            // 
            this.txtClientString.Location = new System.Drawing.Point(6, 48);
            this.txtClientString.Name = "txtClientString";
            this.txtClientString.Size = new System.Drawing.Size(188, 20);
            this.txtClientString.TabIndex = 0;
            // 
            // groupServer
            // 
            this.groupServer.Controls.Add(this.label2);
            this.groupServer.Controls.Add(this.numClients);
            this.groupServer.Controls.Add(this.rtxtServerString);
            this.groupServer.Controls.Add(this.button7);
            this.groupServer.Controls.Add(this.button6);
            this.groupServer.Controls.Add(this.button5);
            this.groupServer.Controls.Add(this.button4);
            this.groupServer.Controls.Add(this.btnStart);
            this.groupServer.Enabled = false;
            this.groupServer.Location = new System.Drawing.Point(691, 256);
            this.groupServer.Name = "groupServer";
            this.groupServer.Size = new System.Drawing.Size(200, 308);
            this.groupServer.TabIndex = 1;
            this.groupServer.TabStop = false;
            this.groupServer.Text = "Server";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Client Limit";
            // 
            // numClients
            // 
            this.numClients.Location = new System.Drawing.Point(94, 127);
            this.numClients.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numClients.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numClients.Name = "numClients";
            this.numClients.Size = new System.Drawing.Size(100, 20);
            this.numClients.TabIndex = 10;
            this.numClients.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // rtxtServerString
            // 
            this.rtxtServerString.Location = new System.Drawing.Point(6, 38);
            this.rtxtServerString.Name = "rtxtServerString";
            this.rtxtServerString.ReadOnly = true;
            this.rtxtServerString.Size = new System.Drawing.Size(188, 69);
            this.rtxtServerString.TabIndex = 9;
            this.rtxtServerString.Text = "";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(6, 250);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(188, 23);
            this.button7.TabIndex = 8;
            this.button7.Text = "Resume ";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(6, 221);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(188, 23);
            this.button6.TabIndex = 7;
            this.button6.Text = "Pause";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(6, 279);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(188, 23);
            this.button5.TabIndex = 6;
            this.button5.Text = "Terminate Server";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(6, 192);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(188, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = "Connection String";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(6, 163);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(188, 23);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Start Server";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // axRDPViewer
            // 
            this.axRDPViewer.Enabled = true;
            this.axRDPViewer.Location = new System.Drawing.Point(4, 3);
            this.axRDPViewer.Name = "axRDPViewer";
            this.axRDPViewer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axRDPViewer.OcxState")));
            this.axRDPViewer.Size = new System.Drawing.Size(681, 561);
            this.axRDPViewer.TabIndex = 2;
            // 
            // radioClient
            // 
            this.radioClient.AutoSize = true;
            this.radioClient.Location = new System.Drawing.Point(877, 12);
            this.radioClient.Name = "radioClient";
            this.radioClient.Size = new System.Drawing.Size(14, 13);
            this.radioClient.TabIndex = 3;
            this.radioClient.TabStop = true;
            this.radioClient.UseVisualStyleBackColor = true;
            this.radioClient.CheckedChanged += new System.EventHandler(this.radioClient_CheckedChanged);
            // 
            // radioServer
            // 
            this.radioServer.AutoSize = true;
            this.radioServer.Location = new System.Drawing.Point(877, 237);
            this.radioServer.Name = "radioServer";
            this.radioServer.Size = new System.Drawing.Size(14, 13);
            this.radioServer.TabIndex = 4;
            this.radioServer.TabStop = true;
            this.radioServer.UseVisualStyleBackColor = true;
            this.radioServer.CheckedChanged += new System.EventHandler(this.radioServer_CheckedChanged);
            // 
            // lblDisplay
            // 
            this.lblDisplay.AutoSize = true;
            this.lblDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplay.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblDisplay.Location = new System.Drawing.Point(696, 195);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(162, 16);
            this.lblDisplay.TabIndex = 5;
            this.lblDisplay.Text = "Connect to share Desktop";
            this.lblDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(903, 576);
            this.Controls.Add(this.lblDisplay);
            this.Controls.Add(this.radioServer);
            this.Controls.Add(this.radioClient);
            this.Controls.Add(this.axRDPViewer);
            this.Controls.Add(this.groupServer);
            this.Controls.Add(this.groupClent);
            this.Name = "Form1";
            this.Text = "Dummy";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupClent.ResumeLayout(false);
            this.groupClent.PerformLayout();
            this.groupServer.ResumeLayout(false);
            this.groupServer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numClients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axRDPViewer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupClent;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtClientString;
        private System.Windows.Forms.GroupBox groupServer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numClients;
        private System.Windows.Forms.RichTextBox rtxtServerString;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnStart;
        private AxRDPCOMAPILib.AxRDPViewer axRDPViewer;
        private System.Windows.Forms.RadioButton radioClient;
        private System.Windows.Forms.RadioButton radioServer;
        private System.Windows.Forms.Label lblDisplay;
    }
}

