namespace WindowsFormsApp1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.menubtn = new System.Windows.Forms.PictureBox();
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.chapter1container = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chapter1btn = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.BIbtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.FPbtn = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.SFbtn = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.newtonbtn = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.scantbtn = new System.Windows.Forms.Button();
            this.ch1transition = new System.Windows.Forms.Timer(this.components);
            this.sidebartransition = new System.Windows.Forms.Timer(this.components);
            this.Ch2container = new System.Windows.Forms.FlowLayoutPanel();
            this.GEbtn = new System.Windows.Forms.Button();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.LUbtn = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.CRbtn = new System.Windows.Forms.Button();
            this.ch2transition = new System.Windows.Forms.Timer(this.components);
            this.ch2btn = new System.Windows.Forms.Panel();
            this.chapter2btn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menubtn)).BeginInit();
            this.sidebar.SuspendLayout();
            this.chapter1container.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel7.SuspendLayout();
            this.Ch2container.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel9.SuspendLayout();
            this.ch2btn.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.menubtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1018, 29);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Menue";
            // 
            // menubtn
            // 
            this.menubtn.Image = ((System.Drawing.Image)(resources.GetObject("menubtn.Image")));
            this.menubtn.Location = new System.Drawing.Point(12, 3);
            this.menubtn.Name = "menubtn";
            this.menubtn.Size = new System.Drawing.Size(32, 26);
            this.menubtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.menubtn.TabIndex = 1;
            this.menubtn.TabStop = false;
            this.menubtn.Click += new System.EventHandler(this.menubtn_Click);
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.sidebar.Controls.Add(this.chapter1container);
            this.sidebar.Controls.Add(this.Ch2container);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 29);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(203, 479);
            this.sidebar.TabIndex = 1;
            this.sidebar.Paint += new System.Windows.Forms.PaintEventHandler(this.sidebar_Paint);
            // 
            // chapter1container
            // 
            this.chapter1container.BackColor = System.Drawing.Color.Maroon;
            this.chapter1container.Controls.Add(this.panel2);
            this.chapter1container.Controls.Add(this.panel4);
            this.chapter1container.Controls.Add(this.panel3);
            this.chapter1container.Controls.Add(this.panel6);
            this.chapter1container.Controls.Add(this.panel5);
            this.chapter1container.Controls.Add(this.panel7);
            this.chapter1container.Location = new System.Drawing.Point(0, 0);
            this.chapter1container.Margin = new System.Windows.Forms.Padding(0);
            this.chapter1container.Name = "chapter1container";
            this.chapter1container.Size = new System.Drawing.Size(202, 54);
            this.chapter1container.TabIndex = 6;
            this.chapter1container.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel2_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.chapter1btn);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(198, 41);
            this.panel2.TabIndex = 3;
            // 
            // chapter1btn
            // 
            this.chapter1btn.BackColor = System.Drawing.Color.Maroon;
            this.chapter1btn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chapter1btn.Location = new System.Drawing.Point(-5, -6);
            this.chapter1btn.Margin = new System.Windows.Forms.Padding(0);
            this.chapter1btn.Name = "chapter1btn";
            this.chapter1btn.Size = new System.Drawing.Size(212, 58);
            this.chapter1btn.TabIndex = 2;
            this.chapter1btn.Text = "CHAPTER1";
            this.chapter1btn.UseVisualStyleBackColor = false;
            this.chapter1btn.Click += new System.EventHandler(this.chapter1btn_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel4.Controls.Add(this.BIbtn);
            this.panel4.Location = new System.Drawing.Point(3, 50);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(198, 43);
            this.panel4.TabIndex = 5;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // BIbtn
            // 
            this.BIbtn.BackColor = System.Drawing.Color.Maroon;
            this.BIbtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BIbtn.Location = new System.Drawing.Point(-11, -11);
            this.BIbtn.Margin = new System.Windows.Forms.Padding(0);
            this.BIbtn.Name = "BIbtn";
            this.BIbtn.Size = new System.Drawing.Size(222, 64);
            this.BIbtn.TabIndex = 2;
            this.BIbtn.Text = "Bisection";
            this.BIbtn.UseVisualStyleBackColor = false;
            this.BIbtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel3.Controls.Add(this.FPbtn);
            this.panel3.Location = new System.Drawing.Point(3, 99);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(198, 43);
            this.panel3.TabIndex = 4;
            // 
            // FPbtn
            // 
            this.FPbtn.BackColor = System.Drawing.Color.Maroon;
            this.FPbtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FPbtn.Location = new System.Drawing.Point(-11, -10);
            this.FPbtn.Name = "FPbtn";
            this.FPbtn.Size = new System.Drawing.Size(229, 64);
            this.FPbtn.TabIndex = 2;
            this.FPbtn.Text = "Falseposition";
            this.FPbtn.UseVisualStyleBackColor = false;
            this.FPbtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel6.Controls.Add(this.SFbtn);
            this.panel6.Location = new System.Drawing.Point(3, 148);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(198, 43);
            this.panel6.TabIndex = 7;
            this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint);
            // 
            // SFbtn
            // 
            this.SFbtn.BackColor = System.Drawing.Color.Maroon;
            this.SFbtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SFbtn.Location = new System.Drawing.Point(-5, -11);
            this.SFbtn.Margin = new System.Windows.Forms.Padding(0);
            this.SFbtn.Name = "SFbtn";
            this.SFbtn.Size = new System.Drawing.Size(217, 64);
            this.SFbtn.TabIndex = 2;
            this.SFbtn.Text = "SimpleFixedpoint";
            this.SFbtn.UseVisualStyleBackColor = false;
            this.SFbtn.Click += new System.EventHandler(this.SFbtn_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel5.Controls.Add(this.newtonbtn);
            this.panel5.Location = new System.Drawing.Point(3, 197);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(198, 43);
            this.panel5.TabIndex = 6;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // newtonbtn
            // 
            this.newtonbtn.BackColor = System.Drawing.Color.Maroon;
            this.newtonbtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newtonbtn.Location = new System.Drawing.Point(-9, -10);
            this.newtonbtn.Margin = new System.Windows.Forms.Padding(0);
            this.newtonbtn.Name = "newtonbtn";
            this.newtonbtn.Size = new System.Drawing.Size(222, 64);
            this.newtonbtn.TabIndex = 2;
            this.newtonbtn.Text = "Newton\'s";
            this.newtonbtn.UseVisualStyleBackColor = false;
            this.newtonbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel7.Controls.Add(this.scantbtn);
            this.panel7.Location = new System.Drawing.Point(3, 246);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(197, 43);
            this.panel7.TabIndex = 7;
            // 
            // scantbtn
            // 
            this.scantbtn.BackColor = System.Drawing.Color.Maroon;
            this.scantbtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scantbtn.Location = new System.Drawing.Point(-5, -10);
            this.scantbtn.Margin = new System.Windows.Forms.Padding(0);
            this.scantbtn.Name = "scantbtn";
            this.scantbtn.Size = new System.Drawing.Size(217, 64);
            this.scantbtn.TabIndex = 2;
            this.scantbtn.Text = "Secant";
            this.scantbtn.UseVisualStyleBackColor = false;
            this.scantbtn.Click += new System.EventHandler(this.scantbtn_Click);
            // 
            // ch1transition
            // 
            this.ch1transition.Interval = 10;
            this.ch1transition.Tick += new System.EventHandler(this.ch1timer_Tick);
            // 
            // sidebartransition
            // 
            this.sidebartransition.Interval = 10;
            this.sidebartransition.Tick += new System.EventHandler(this.sidebartransition_Tick);
            // 
            // Ch2container
            // 
            this.Ch2container.BackColor = System.Drawing.Color.Maroon;
            this.Ch2container.Controls.Add(this.ch2btn);
            this.Ch2container.Controls.Add(this.panel10);
            this.Ch2container.Controls.Add(this.panel11);
            this.Ch2container.Controls.Add(this.panel9);
            this.Ch2container.Location = new System.Drawing.Point(3, 57);
            this.Ch2container.Name = "Ch2container";
            this.Ch2container.Size = new System.Drawing.Size(199, 52);
            this.Ch2container.TabIndex = 10;
            // 
            // GEbtn
            // 
            this.GEbtn.BackColor = System.Drawing.Color.Maroon;
            this.GEbtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GEbtn.Location = new System.Drawing.Point(-13, -11);
            this.GEbtn.Margin = new System.Windows.Forms.Padding(0);
            this.GEbtn.Name = "GEbtn";
            this.GEbtn.Size = new System.Drawing.Size(222, 64);
            this.GEbtn.TabIndex = 3;
            this.GEbtn.Text = "Gauss Elimination";
            this.GEbtn.UseVisualStyleBackColor = false;
            this.GEbtn.Click += new System.EventHandler(this.button8_Click);
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel10.Controls.Add(this.GEbtn);
            this.panel10.Location = new System.Drawing.Point(3, 50);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(198, 43);
            this.panel10.TabIndex = 6;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel11.Controls.Add(this.LUbtn);
            this.panel11.Location = new System.Drawing.Point(3, 99);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(198, 43);
            this.panel11.TabIndex = 7;
            // 
            // LUbtn
            // 
            this.LUbtn.BackColor = System.Drawing.Color.Maroon;
            this.LUbtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LUbtn.Location = new System.Drawing.Point(-13, -13);
            this.LUbtn.Margin = new System.Windows.Forms.Padding(0);
            this.LUbtn.Name = "LUbtn";
            this.LUbtn.Size = new System.Drawing.Size(222, 64);
            this.LUbtn.TabIndex = 3;
            this.LUbtn.Text = "LU Decomposition";
            this.LUbtn.UseVisualStyleBackColor = false;
            this.LUbtn.Click += new System.EventHandler(this.LUbtn_Click);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel9.Controls.Add(this.CRbtn);
            this.panel9.Location = new System.Drawing.Point(3, 148);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(198, 43);
            this.panel9.TabIndex = 8;
            // 
            // CRbtn
            // 
            this.CRbtn.BackColor = System.Drawing.Color.Maroon;
            this.CRbtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CRbtn.Location = new System.Drawing.Point(-13, -13);
            this.CRbtn.Margin = new System.Windows.Forms.Padding(0);
            this.CRbtn.Name = "CRbtn";
            this.CRbtn.Size = new System.Drawing.Size(222, 64);
            this.CRbtn.TabIndex = 3;
            this.CRbtn.Text = "Cramer Rule";
            this.CRbtn.UseVisualStyleBackColor = false;
            this.CRbtn.Click += new System.EventHandler(this.CRbtn_Click);
            // 
            // ch2transition
            // 
            this.ch2transition.Interval = 10;
            this.ch2transition.Tick += new System.EventHandler(this.ch2tranition_Tick);
            // 
            // ch2btn
            // 
            this.ch2btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ch2btn.Controls.Add(this.chapter2btn);
            this.ch2btn.Location = new System.Drawing.Point(3, 3);
            this.ch2btn.Name = "ch2btn";
            this.ch2btn.Size = new System.Drawing.Size(198, 41);
            this.ch2btn.TabIndex = 7;
            // 
            // chapter2btn
            // 
            this.chapter2btn.BackColor = System.Drawing.Color.Maroon;
            this.chapter2btn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chapter2btn.Location = new System.Drawing.Point(-15, -8);
            this.chapter2btn.Margin = new System.Windows.Forms.Padding(0);
            this.chapter2btn.Name = "chapter2btn";
            this.chapter2btn.Size = new System.Drawing.Size(222, 60);
            this.chapter2btn.TabIndex = 3;
            this.chapter2btn.Text = "CHAPTER2";
            this.chapter2btn.UseVisualStyleBackColor = false;
            this.chapter2btn.Click += new System.EventHandler(this.button6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 508);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menubtn)).EndInit();
            this.sidebar.ResumeLayout(false);
            this.chapter1container.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.Ch2container.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.ch2btn.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox menubtn;
        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private System.Windows.Forms.Button chapter1btn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button FPbtn;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button BIbtn;
        private System.Windows.Forms.FlowLayoutPanel chapter1container;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button newtonbtn;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button SFbtn;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button scantbtn;
        private System.Windows.Forms.Timer ch1transition;
        private System.Windows.Forms.Timer sidebartransition;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel Ch2container;
        private System.Windows.Forms.Button GEbtn;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Button LUbtn;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button CRbtn;
        private System.Windows.Forms.Timer ch2transition;
        private System.Windows.Forms.Panel ch2btn;
        private System.Windows.Forms.Button chapter2btn;
    }
}

