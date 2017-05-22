namespace ICS_servo_ctrl
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.portNameCB = new System.Windows.Forms.ComboBox();
            this.connBTN = new System.Windows.Forms.Button();
            this.ctrlGB = new System.Windows.Forms.GroupBox();
            this.posTRB = new System.Windows.Forms.TrackBar();
            this.posLAB = new System.Windows.Forms.Label();
            this.weakCKB = new System.Windows.Forms.CheckBox();
            this.posSetLAB = new System.Windows.Forms.Label();
            this.posActLAB = new System.Windows.Forms.Label();
            this.posSetValTXB = new System.Windows.Forms.TextBox();
            this.posActValTB = new System.Windows.Forms.TextBox();
            this.ctrlGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.posTRB)).BeginInit();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // portNameCB
            // 
            this.portNameCB.FormattingEnabled = true;
            this.portNameCB.Location = new System.Drawing.Point(13, 13);
            this.portNameCB.Name = "portNameCB";
            this.portNameCB.Size = new System.Drawing.Size(121, 20);
            this.portNameCB.TabIndex = 0;
            // 
            // connBTN
            // 
            this.connBTN.Location = new System.Drawing.Point(141, 9);
            this.connBTN.Name = "connBTN";
            this.connBTN.Size = new System.Drawing.Size(75, 23);
            this.connBTN.TabIndex = 1;
            this.connBTN.Text = "接続";
            this.connBTN.UseVisualStyleBackColor = true;
            this.connBTN.Click += new System.EventHandler(this.button1_Click);
            // 
            // ctrlGB
            // 
            this.ctrlGB.Controls.Add(this.posActValTB);
            this.ctrlGB.Controls.Add(this.posSetValTXB);
            this.ctrlGB.Controls.Add(this.posActLAB);
            this.ctrlGB.Controls.Add(this.posSetLAB);
            this.ctrlGB.Controls.Add(this.weakCKB);
            this.ctrlGB.Controls.Add(this.posLAB);
            this.ctrlGB.Controls.Add(this.posTRB);
            this.ctrlGB.Location = new System.Drawing.Point(12, 39);
            this.ctrlGB.Name = "ctrlGB";
            this.ctrlGB.Size = new System.Drawing.Size(204, 115);
            this.ctrlGB.TabIndex = 2;
            this.ctrlGB.TabStop = false;
            this.ctrlGB.Text = "制御";
            this.ctrlGB.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // posTRB
            // 
            this.posTRB.LargeChange = 100;
            this.posTRB.Location = new System.Drawing.Point(60, 18);
            this.posTRB.Maximum = 11500;
            this.posTRB.Minimum = 3500;
            this.posTRB.Name = "posTRB";
            this.posTRB.Size = new System.Drawing.Size(138, 45);
            this.posTRB.TabIndex = 0;
            this.posTRB.TickFrequency = 1000;
            this.posTRB.Value = 7500;
            this.posTRB.ValueChanged += new System.EventHandler(this.posTRB_ValueChanged);
            // 
            // posLAB
            // 
            this.posLAB.AutoSize = true;
            this.posLAB.Location = new System.Drawing.Point(4, 18);
            this.posLAB.Name = "posLAB";
            this.posLAB.Size = new System.Drawing.Size(29, 12);
            this.posLAB.TabIndex = 1;
            this.posLAB.Text = "位置";
            // 
            // weakCKB
            // 
            this.weakCKB.AutoSize = true;
            this.weakCKB.Location = new System.Drawing.Point(6, 33);
            this.weakCKB.Name = "weakCKB";
            this.weakCKB.Size = new System.Drawing.Size(48, 16);
            this.weakCKB.TabIndex = 2;
            this.weakCKB.Text = "脱力";
            this.weakCKB.UseVisualStyleBackColor = true;
            this.weakCKB.CheckedChanged += new System.EventHandler(this.weakCKB_CheckedChanged);
            // 
            // posSetLAB
            // 
            this.posSetLAB.AutoSize = true;
            this.posSetLAB.Location = new System.Drawing.Point(33, 66);
            this.posSetLAB.Name = "posSetLAB";
            this.posSetLAB.Size = new System.Drawing.Size(41, 12);
            this.posSetLAB.TabIndex = 3;
            this.posSetLAB.Text = "設定値";
            // 
            // posActLAB
            // 
            this.posActLAB.AutoSize = true;
            this.posActLAB.Location = new System.Drawing.Point(127, 66);
            this.posActLAB.Name = "posActLAB";
            this.posActLAB.Size = new System.Drawing.Size(41, 12);
            this.posActLAB.TabIndex = 4;
            this.posActLAB.Text = "現在値";
            // 
            // posSetValTXB
            // 
            this.posSetValTXB.Location = new System.Drawing.Point(6, 81);
            this.posSetValTXB.Name = "posSetValTXB";
            this.posSetValTXB.ReadOnly = true;
            this.posSetValTXB.Size = new System.Drawing.Size(91, 19);
            this.posSetValTXB.TabIndex = 5;
            // 
            // posActValTB
            // 
            this.posActValTB.Location = new System.Drawing.Point(103, 81);
            this.posActValTB.Name = "posActValTB";
            this.posActValTB.ReadOnly = true;
            this.posActValTB.Size = new System.Drawing.Size(95, 19);
            this.posActValTB.TabIndex = 6;
            this.posActValTB.TextChanged += new System.EventHandler(this.posActValTB_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 166);
            this.Controls.Add(this.ctrlGB);
            this.Controls.Add(this.connBTN);
            this.Controls.Add(this.portNameCB);
            this.Name = "Form1";
            this.Text = "Kondo ICS Servo";
            this.ctrlGB.ResumeLayout(false);
            this.ctrlGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.posTRB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ComboBox portNameCB;
        private System.Windows.Forms.Button connBTN;
        private System.Windows.Forms.GroupBox ctrlGB;
        private System.Windows.Forms.CheckBox weakCKB;
        private System.Windows.Forms.Label posLAB;
        private System.Windows.Forms.TrackBar posTRB;
        private System.Windows.Forms.Label posActLAB;
        private System.Windows.Forms.Label posSetLAB;
        public System.Windows.Forms.TextBox posActValTB;
        public System.Windows.Forms.TextBox posSetValTXB;
    }
}

