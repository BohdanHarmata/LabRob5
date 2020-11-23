namespace Lab_Rob5._1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.LowLeft = new System.Windows.Forms.TextBox();
            this.LowRight = new System.Windows.Forms.TextBox();
            this.TopRight = new System.Windows.Forms.TextBox();
            this.TopLeft = new System.Windows.Forms.TextBox();
            this.Switch = new System.Windows.Forms.CheckBox();
            this.pointy = new System.Windows.Forms.TextBox();
            this.lable_3 = new System.Windows.Forms.Label();
            this.pointx = new System.Windows.Forms.TextBox();
            this.Width1 = new System.Windows.Forms.TextBox();
            this.lable_2 = new System.Windows.Forms.Label();
            this.lable_1 = new System.Windows.Forms.Label();
            this.start = new System.Windows.Forms.Button();
            this.SquareDraw = new System.Windows.Forms.PictureBox();
            this.CooordTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SquareDraw)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.LowLeft);
            this.splitContainer1.Panel1.Controls.Add(this.LowRight);
            this.splitContainer1.Panel1.Controls.Add(this.TopRight);
            this.splitContainer1.Panel1.Controls.Add(this.TopLeft);
            this.splitContainer1.Panel1.Controls.Add(this.Switch);
            this.splitContainer1.Panel1.Controls.Add(this.pointy);
            this.splitContainer1.Panel1.Controls.Add(this.lable_3);
            this.splitContainer1.Panel1.Controls.Add(this.pointx);
            this.splitContainer1.Panel1.Controls.Add(this.Width1);
            this.splitContainer1.Panel1.Controls.Add(this.lable_2);
            this.splitContainer1.Panel1.Controls.Add(this.lable_1);
            this.splitContainer1.Panel1.Controls.Add(this.start);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.splitContainer1.Panel2.Controls.Add(this.SquareDraw);
            this.splitContainer1.Size = new System.Drawing.Size(936, 490);
            this.splitContainer1.SplitterDistance = 164;
            this.splitContainer1.TabIndex = 0;
            // 
            // LowLeft
            // 
            this.LowLeft.Location = new System.Drawing.Point(12, 422);
            this.LowLeft.Multiline = true;
            this.LowLeft.Name = "LowLeft";
            this.LowLeft.Size = new System.Drawing.Size(139, 25);
            this.LowLeft.TabIndex = 11;
            // 
            // LowRight
            // 
            this.LowRight.Location = new System.Drawing.Point(12, 453);
            this.LowRight.Multiline = true;
            this.LowRight.Name = "LowRight";
            this.LowRight.Size = new System.Drawing.Size(139, 25);
            this.LowRight.TabIndex = 10;
            // 
            // TopRight
            // 
            this.TopRight.Location = new System.Drawing.Point(12, 391);
            this.TopRight.Multiline = true;
            this.TopRight.Name = "TopRight";
            this.TopRight.Size = new System.Drawing.Size(139, 25);
            this.TopRight.TabIndex = 9;
            // 
            // TopLeft
            // 
            this.TopLeft.Location = new System.Drawing.Point(12, 360);
            this.TopLeft.Multiline = true;
            this.TopLeft.Name = "TopLeft";
            this.TopLeft.Size = new System.Drawing.Size(139, 25);
            this.TopLeft.TabIndex = 8;
            // 
            // Switch
            // 
            this.Switch.AutoSize = true;
            this.Switch.Location = new System.Drawing.Point(30, 232);
            this.Switch.Name = "Switch";
            this.Switch.Size = new System.Drawing.Size(80, 17);
            this.Switch.TabIndex = 7;
            this.Switch.Text = "Turn\\Move";
            this.Switch.UseVisualStyleBackColor = true;
            // 
            // pointy
            // 
            this.pointy.Location = new System.Drawing.Point(30, 134);
            this.pointy.Name = "pointy";
            this.pointy.Size = new System.Drawing.Size(100, 20);
            this.pointy.TabIndex = 6;
            this.pointy.Text = "0";
            // 
            // lable_3
            // 
            this.lable_3.AutoSize = true;
            this.lable_3.Location = new System.Drawing.Point(27, 118);
            this.lable_3.Name = "lable_3";
            this.lable_3.Size = new System.Drawing.Size(39, 13);
            this.lable_3.TabIndex = 5;
            this.lable_3.Text = "Point y";
            // 
            // pointx
            // 
            this.pointx.Location = new System.Drawing.Point(30, 80);
            this.pointx.Name = "pointx";
            this.pointx.Size = new System.Drawing.Size(100, 20);
            this.pointx.TabIndex = 4;
            this.pointx.Text = "0";
            // 
            // Width1
            // 
            this.Width1.Location = new System.Drawing.Point(30, 30);
            this.Width1.Name = "Width1";
            this.Width1.Size = new System.Drawing.Size(100, 20);
            this.Width1.TabIndex = 3;
            this.Width1.Text = "0";
            // 
            // lable_2
            // 
            this.lable_2.AutoSize = true;
            this.lable_2.Location = new System.Drawing.Point(27, 64);
            this.lable_2.Name = "lable_2";
            this.lable_2.Size = new System.Drawing.Size(39, 13);
            this.lable_2.TabIndex = 2;
            this.lable_2.Text = "Point x";
            // 
            // lable_1
            // 
            this.lable_1.AutoSize = true;
            this.lable_1.Location = new System.Drawing.Point(27, 13);
            this.lable_1.Name = "lable_1";
            this.lable_1.Size = new System.Drawing.Size(35, 13);
            this.lable_1.TabIndex = 1;
            this.lable_1.Text = "Width";
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(30, 177);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(75, 23);
            this.start.TabIndex = 0;
            this.start.Text = "Start";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // SquareDraw
            // 
            this.SquareDraw.BackColor = System.Drawing.SystemColors.Control;
            this.SquareDraw.Location = new System.Drawing.Point(0, 0);
            this.SquareDraw.Name = "SquareDraw";
            this.SquareDraw.Size = new System.Drawing.Size(768, 490);
            this.SquareDraw.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.SquareDraw.TabIndex = 0;
            this.SquareDraw.TabStop = false;
            // 
            // CooordTimer
            // 
            this.CooordTimer.Enabled = true;
            this.CooordTimer.Tick += new System.EventHandler(this.CooordTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 490);
            this.Controls.Add(this.splitContainer1);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SquareDraw)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox pointy;
        private System.Windows.Forms.Label lable_3;
        private System.Windows.Forms.TextBox pointx;
        private System.Windows.Forms.TextBox Width1;
        private System.Windows.Forms.Label lable_2;
        private System.Windows.Forms.Label lable_1;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.PictureBox SquareDraw;
        private System.Windows.Forms.CheckBox Switch;
        private System.Windows.Forms.TextBox TopLeft;
        private System.Windows.Forms.TextBox LowRight;
        private System.Windows.Forms.TextBox TopRight;
        private System.Windows.Forms.TextBox LowLeft;
        private System.Windows.Forms.Timer CooordTimer;
    }
}

