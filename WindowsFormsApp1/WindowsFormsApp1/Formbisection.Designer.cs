namespace WindowsFormsApp1
{
    partial class Formbisection
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
            this.label1 = new System.Windows.Forms.Label();
            this.functionTextBox = new System.Windows.Forms.TextBox();
            this.xuTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.xlTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.epsilonTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.calculatebutton = new System.Windows.Forms.Button();
            this.resultsDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.resultsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(199, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "F(x)";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // functionTextBox
            // 
            this.functionTextBox.Location = new System.Drawing.Point(250, 56);
            this.functionTextBox.Name = "functionTextBox";
            this.functionTextBox.Size = new System.Drawing.Size(270, 22);
            this.functionTextBox.TabIndex = 1;
            this.functionTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // xuTextBox
            // 
            this.xuTextBox.Location = new System.Drawing.Point(250, 123);
            this.xuTextBox.Name = "xuTextBox";
            this.xuTextBox.Size = new System.Drawing.Size(100, 22);
            this.xuTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(586, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "XL";
            // 
            // xlTextBox
            // 
            this.xlTextBox.Location = new System.Drawing.Point(668, 119);
            this.xlTextBox.Name = "xlTextBox";
            this.xlTextBox.Size = new System.Drawing.Size(100, 22);
            this.xlTextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(199, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "XU";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // epsilonTextBox
            // 
            this.epsilonTextBox.Location = new System.Drawing.Point(668, 53);
            this.epsilonTextBox.Name = "epsilonTextBox";
            this.epsilonTextBox.Size = new System.Drawing.Size(100, 22);
            this.epsilonTextBox.TabIndex = 7;
            this.epsilonTextBox.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(577, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Epson";
            // 
            // calculatebutton
            // 
            this.calculatebutton.Location = new System.Drawing.Point(476, 374);
            this.calculatebutton.Name = "calculatebutton";
            this.calculatebutton.Size = new System.Drawing.Size(158, 23);
            this.calculatebutton.TabIndex = 8;
            this.calculatebutton.Text = "Detremine Root";
            this.calculatebutton.UseVisualStyleBackColor = true;
            this.calculatebutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // resultsDataGridView
            // 
            this.resultsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultsDataGridView.Location = new System.Drawing.Point(111, 197);
            this.resultsDataGridView.Name = "resultsDataGridView";
            this.resultsDataGridView.RowHeadersWidth = 51;
            this.resultsDataGridView.RowTemplate.Height = 24;
            this.resultsDataGridView.Size = new System.Drawing.Size(825, 150);
            this.resultsDataGridView.TabIndex = 9;
            // 
            // Formbisection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1039, 450);
            this.Controls.Add(this.resultsDataGridView);
            this.Controls.Add(this.calculatebutton);
            this.Controls.Add(this.epsilonTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.xlTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.xuTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.functionTextBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Formbisection";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Formbisection_Load);
            ((System.ComponentModel.ISupportInitialize)(this.resultsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox functionTextBox;
        private System.Windows.Forms.TextBox xuTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox xlTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox epsilonTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button calculatebutton;
        private System.Windows.Forms.DataGridView resultsDataGridView;
    }
}