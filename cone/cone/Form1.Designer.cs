namespace cone
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.start = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.radius = new System.Windows.Forms.TextBox();
            this.heigth = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pointy = new System.Windows.Forms.TextBox();
            this.pointx = new System.Windows.Forms.TextBox();
            this.ConeDrawing = new System.Windows.Forms.PictureBox();
            this.checker = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConeDrawing)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.checker);
            this.splitContainer1.Panel1.Controls.Add(this.start);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.radius);
            this.splitContainer1.Panel1.Controls.Add(this.heigth);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.pointy);
            this.splitContainer1.Panel1.Controls.Add(this.pointx);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.ConeDrawing);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 181;
            this.splitContainer1.TabIndex = 0;
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(12, 274);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(75, 23);
            this.start.TabIndex = 8;
            this.start.Text = "Start";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            this.start.KeyDown += new System.Windows.Forms.KeyEventHandler(this.start_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Heigth";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Radius";
            // 
            // radius
            // 
            this.radius.Location = new System.Drawing.Point(12, 171);
            this.radius.Name = "radius";
            this.radius.Size = new System.Drawing.Size(100, 20);
            this.radius.TabIndex = 5;
            this.radius.Text = "0";
            // 
            // heigth
            // 
            this.heigth.Location = new System.Drawing.Point(12, 225);
            this.heigth.Name = "heigth";
            this.heigth.Size = new System.Drawing.Size(100, 20);
            this.heigth.TabIndex = 4;
            this.heigth.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Point y";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Point x";
            // 
            // pointy
            // 
            this.pointy.Location = new System.Drawing.Point(12, 118);
            this.pointy.Name = "pointy";
            this.pointy.Size = new System.Drawing.Size(100, 20);
            this.pointy.TabIndex = 1;
            this.pointy.Text = "0";
            // 
            // pointx
            // 
            this.pointx.Location = new System.Drawing.Point(12, 63);
            this.pointx.Name = "pointx";
            this.pointx.Size = new System.Drawing.Size(100, 20);
            this.pointx.TabIndex = 0;
            this.pointx.Text = "0";
            // 
            // ConeDrawing
            // 
            this.ConeDrawing.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ConeDrawing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConeDrawing.Location = new System.Drawing.Point(0, 0);
            this.ConeDrawing.Name = "ConeDrawing";
            this.ConeDrawing.Size = new System.Drawing.Size(615, 450);
            this.ConeDrawing.TabIndex = 0;
            this.ConeDrawing.TabStop = false;
            // 
            // checker
            // 
            this.checker.AutoSize = true;
            this.checker.Location = new System.Drawing.Point(12, 329);
            this.checker.Name = "checker";
            this.checker.Size = new System.Drawing.Size(133, 17);
            this.checker.TabIndex = 9;
            this.checker.Text = "Cone/Truncated Cone";
            this.checker.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ConeDrawing)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox pointy;
        private System.Windows.Forms.TextBox pointx;
        private System.Windows.Forms.PictureBox ConeDrawing;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox radius;
        private System.Windows.Forms.TextBox heigth;
        private System.Windows.Forms.CheckBox checker;
    }
}

