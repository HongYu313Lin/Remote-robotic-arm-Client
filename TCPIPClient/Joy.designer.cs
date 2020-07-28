namespace TCPIPClient
{
    partial class Joy
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
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
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btn_up = new System.Windows.Forms.Button();
            this.btn_down = new System.Windows.Forms.Button();
            this.btn_left = new System.Windows.Forms.Button();
            this.btn_right = new System.Windows.Forms.Button();
            this.btn_tri = new System.Windows.Forms.Button();
            this.btn_cross = new System.Windows.Forms.Button();
            this.btn_square = new System.Windows.Forms.Button();
            this.btn_circle = new System.Windows.Forms.Button();
            this.btn_sh = new System.Windows.Forms.Button();
            this.btn_op = new System.Windows.Forms.Button();
            this.btn_sp = new System.Windows.Forms.Button();
            this.btn_ps = new System.Windows.Forms.Button();
            this.pbl = new System.Windows.Forms.PictureBox();
            this.pbr = new System.Windows.Forms.PictureBox();
            this.btn_l2 = new System.Windows.Forms.Button();
            this.btn_l1 = new System.Windows.Forms.Button();
            this.btn_r2 = new System.Windows.Forms.Button();
            this.btn_r1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbr)).BeginInit();
            this.SuspendLayout();
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // btn_up
            // 
            this.btn_up.Location = new System.Drawing.Point(183, 220);
            this.btn_up.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_up.Name = "btn_up";
            this.btn_up.Size = new System.Drawing.Size(97, 46);
            this.btn_up.TabIndex = 0;
            this.btn_up.Text = "↑";
            this.btn_up.UseVisualStyleBackColor = true;
            // 
            // btn_down
            // 
            this.btn_down.Location = new System.Drawing.Point(183, 304);
            this.btn_down.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_down.Name = "btn_down";
            this.btn_down.Size = new System.Drawing.Size(97, 46);
            this.btn_down.TabIndex = 1;
            this.btn_down.Text = "↓";
            this.btn_down.UseVisualStyleBackColor = true;
            // 
            // btn_left
            // 
            this.btn_left.Location = new System.Drawing.Point(61, 266);
            this.btn_left.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_left.Name = "btn_left";
            this.btn_left.Size = new System.Drawing.Size(97, 46);
            this.btn_left.TabIndex = 2;
            this.btn_left.Text = "←";
            this.btn_left.UseVisualStyleBackColor = true;
            // 
            // btn_right
            // 
            this.btn_right.Location = new System.Drawing.Point(307, 266);
            this.btn_right.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_right.Name = "btn_right";
            this.btn_right.Size = new System.Drawing.Size(97, 46);
            this.btn_right.TabIndex = 3;
            this.btn_right.Text = "→";
            this.btn_right.UseVisualStyleBackColor = true;
            // 
            // btn_tri
            // 
            this.btn_tri.Location = new System.Drawing.Point(765, 220);
            this.btn_tri.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_tri.Name = "btn_tri";
            this.btn_tri.Size = new System.Drawing.Size(97, 46);
            this.btn_tri.TabIndex = 4;
            this.btn_tri.Text = "△";
            this.btn_tri.UseVisualStyleBackColor = true;
            // 
            // btn_cross
            // 
            this.btn_cross.Location = new System.Drawing.Point(765, 304);
            this.btn_cross.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_cross.Name = "btn_cross";
            this.btn_cross.Size = new System.Drawing.Size(97, 46);
            this.btn_cross.TabIndex = 5;
            this.btn_cross.Text = "×";
            this.btn_cross.UseVisualStyleBackColor = true;
            // 
            // btn_square
            // 
            this.btn_square.Location = new System.Drawing.Point(660, 266);
            this.btn_square.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_square.Name = "btn_square";
            this.btn_square.Size = new System.Drawing.Size(97, 46);
            this.btn_square.TabIndex = 6;
            this.btn_square.Text = "□";
            this.btn_square.UseVisualStyleBackColor = true;
            // 
            // btn_circle
            // 
            this.btn_circle.Location = new System.Drawing.Point(871, 266);
            this.btn_circle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_circle.Name = "btn_circle";
            this.btn_circle.Size = new System.Drawing.Size(97, 46);
            this.btn_circle.TabIndex = 7;
            this.btn_circle.Text = "○";
            this.btn_circle.UseVisualStyleBackColor = true;
            // 
            // btn_sh
            // 
            this.btn_sh.Location = new System.Drawing.Point(345, 176);
            this.btn_sh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_sh.Name = "btn_sh";
            this.btn_sh.Size = new System.Drawing.Size(85, 44);
            this.btn_sh.TabIndex = 8;
            this.btn_sh.Text = "SH";
            this.btn_sh.UseVisualStyleBackColor = true;
            // 
            // btn_op
            // 
            this.btn_op.Location = new System.Drawing.Point(637, 176);
            this.btn_op.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_op.Name = "btn_op";
            this.btn_op.Size = new System.Drawing.Size(85, 44);
            this.btn_op.TabIndex = 9;
            this.btn_op.Text = "OP";
            this.btn_op.UseVisualStyleBackColor = true;
            // 
            // btn_sp
            // 
            this.btn_sp.Location = new System.Drawing.Point(492, 222);
            this.btn_sp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_sp.Name = "btn_sp";
            this.btn_sp.Size = new System.Drawing.Size(85, 44);
            this.btn_sp.TabIndex = 10;
            this.btn_sp.Text = "SP";
            this.btn_sp.UseVisualStyleBackColor = true;
            // 
            // btn_ps
            // 
            this.btn_ps.Location = new System.Drawing.Point(492, 306);
            this.btn_ps.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_ps.Name = "btn_ps";
            this.btn_ps.Size = new System.Drawing.Size(85, 44);
            this.btn_ps.TabIndex = 11;
            this.btn_ps.Text = "PS";
            this.btn_ps.UseVisualStyleBackColor = true;
            // 
            // pbl
            // 
            this.pbl.Location = new System.Drawing.Point(279, 409);
            this.pbl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbl.Name = "pbl";
            this.pbl.Size = new System.Drawing.Size(152, 119);
            this.pbl.TabIndex = 12;
            this.pbl.TabStop = false;
            this.pbl.Paint += new System.Windows.Forms.PaintEventHandler(this.pbl_Paint);
            // 
            // pbr
            // 
            this.pbr.Location = new System.Drawing.Point(605, 409);
            this.pbr.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbr.Name = "pbr";
            this.pbr.Size = new System.Drawing.Size(152, 119);
            this.pbr.TabIndex = 13;
            this.pbr.TabStop = false;
            this.pbr.Paint += new System.Windows.Forms.PaintEventHandler(this.pbr_Paint);
            // 
            // btn_l2
            // 
            this.btn_l2.Location = new System.Drawing.Point(345, 46);
            this.btn_l2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_l2.Name = "btn_l2";
            this.btn_l2.Size = new System.Drawing.Size(85, 44);
            this.btn_l2.TabIndex = 14;
            this.btn_l2.Text = "L2";
            this.btn_l2.UseVisualStyleBackColor = true;
            // 
            // btn_l1
            // 
            this.btn_l1.Location = new System.Drawing.Point(345, 98);
            this.btn_l1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_l1.Name = "btn_l1";
            this.btn_l1.Size = new System.Drawing.Size(85, 44);
            this.btn_l1.TabIndex = 15;
            this.btn_l1.Text = "L1";
            this.btn_l1.UseVisualStyleBackColor = true;
            // 
            // btn_r2
            // 
            this.btn_r2.Location = new System.Drawing.Point(637, 46);
            this.btn_r2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_r2.Name = "btn_r2";
            this.btn_r2.Size = new System.Drawing.Size(85, 44);
            this.btn_r2.TabIndex = 16;
            this.btn_r2.Text = "R2";
            this.btn_r2.UseVisualStyleBackColor = true;
            // 
            // btn_r1
            // 
            this.btn_r1.Location = new System.Drawing.Point(637, 98);
            this.btn_r1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_r1.Name = "btn_r1";
            this.btn_r1.Size = new System.Drawing.Size(85, 44);
            this.btn_r1.TabIndex = 17;
            this.btn_r1.Text = "R1";
            this.btn_r1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1048, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 18;
            this.label1.Text = "label1";
            // 
            // Joy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1387, 562);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_r1);
            this.Controls.Add(this.btn_r2);
            this.Controls.Add(this.btn_l1);
            this.Controls.Add(this.btn_l2);
            this.Controls.Add(this.pbr);
            this.Controls.Add(this.pbl);
            this.Controls.Add(this.btn_ps);
            this.Controls.Add(this.btn_sp);
            this.Controls.Add(this.btn_op);
            this.Controls.Add(this.btn_sh);
            this.Controls.Add(this.btn_circle);
            this.Controls.Add(this.btn_square);
            this.Controls.Add(this.btn_cross);
            this.Controls.Add(this.btn_tri);
            this.Controls.Add(this.btn_right);
            this.Controls.Add(this.btn_left);
            this.Controls.Add(this.btn_down);
            this.Controls.Add(this.btn_up);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Joy";
            this.Text = "Joy";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btn_up;
        private System.Windows.Forms.Button btn_down;
        private System.Windows.Forms.Button btn_left;
        private System.Windows.Forms.Button btn_right;
        private System.Windows.Forms.Button btn_tri;
        private System.Windows.Forms.Button btn_cross;
        private System.Windows.Forms.Button btn_square;
        private System.Windows.Forms.Button btn_circle;
        private System.Windows.Forms.Button btn_sh;
        private System.Windows.Forms.Button btn_op;
        private System.Windows.Forms.Button btn_sp;
        private System.Windows.Forms.Button btn_ps;
        private System.Windows.Forms.PictureBox pbl;
        private System.Windows.Forms.PictureBox pbr;
        private System.Windows.Forms.Button btn_l2;
        private System.Windows.Forms.Button btn_l1;
        private System.Windows.Forms.Button btn_r2;
        private System.Windows.Forms.Button btn_r1;
        private System.Windows.Forms.Label label1;
    }
}

