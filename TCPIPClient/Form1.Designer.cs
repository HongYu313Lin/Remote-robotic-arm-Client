namespace TCPIPClient
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.textport = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textIP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textmes = new System.Windows.Forms.TextBox();
            this.buttonconnect = new System.Windows.Forms.Button();
            this.buttonenter = new System.Windows.Forms.Button();
            this.textenter = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // textport
            // 
            this.textport.Location = new System.Drawing.Point(180, 12);
            this.textport.Margin = new System.Windows.Forms.Padding(4);
            this.textport.Name = "textport";
            this.textport.Size = new System.Drawing.Size(92, 31);
            this.textport.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "IP";
            // 
            // textIP
            // 
            this.textIP.Location = new System.Drawing.Point(32, 12);
            this.textIP.Margin = new System.Windows.Forms.Padding(4);
            this.textIP.Name = "textIP";
            this.textIP.Size = new System.Drawing.Size(87, 31);
            this.textIP.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(139, 16);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Port";
            // 
            // textmes
            // 
            this.textmes.Location = new System.Drawing.Point(28, 127);
            this.textmes.Multiline = true;
            this.textmes.Name = "textmes";
            this.textmes.Size = new System.Drawing.Size(239, 143);
            this.textmes.TabIndex = 2;
            // 
            // buttonconnect
            // 
            this.buttonconnect.Location = new System.Drawing.Point(63, 46);
            this.buttonconnect.Name = "buttonconnect";
            this.buttonconnect.Size = new System.Drawing.Size(70, 29);
            this.buttonconnect.TabIndex = 3;
            this.buttonconnect.Text = "Connect";
            this.buttonconnect.UseVisualStyleBackColor = true;
            this.buttonconnect.Click += new System.EventHandler(this.buttonconnect_Click);
            // 
            // buttonenter
            // 
            this.buttonenter.Location = new System.Drawing.Point(198, 81);
            this.buttonenter.Name = "buttonenter";
            this.buttonenter.Size = new System.Drawing.Size(69, 26);
            this.buttonenter.TabIndex = 7;
            this.buttonenter.Text = "Enter";
            this.buttonenter.UseVisualStyleBackColor = true;
            this.buttonenter.Click += new System.EventHandler(this.buttonenter_Click);
            // 
            // textenter
            // 
            this.textenter.Location = new System.Drawing.Point(27, 81);
            this.textenter.Name = "textenter";
            this.textenter.Size = new System.Drawing.Size(160, 31);
            this.textenter.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(142, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 29);
            this.button1.TabIndex = 8;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(273, 81);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(93, 24);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "AutoJoy";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 340);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonenter);
            this.Controls.Add(this.textenter);
            this.Controls.Add(this.buttonconnect);
            this.Controls.Add(this.textmes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textport);
            this.Controls.Add(this.textIP);
            this.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textIP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textmes;
        private System.Windows.Forms.Button buttonconnect;
        private System.Windows.Forms.Button buttonenter;
        private System.Windows.Forms.TextBox textenter;
        private System.Windows.Forms.Button button1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

