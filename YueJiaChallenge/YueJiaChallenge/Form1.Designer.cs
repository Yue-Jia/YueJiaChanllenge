namespace YueJiaChallenge
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CLEAR = new System.Windows.Forms.Button();
            this.Supp = new System.Windows.Forms.TextBox();
            this.Cust = new System.Windows.Forms.TextBox();
            this.OK = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.CLEAR);
            this.panel1.Controls.Add(this.Supp);
            this.panel1.Controls.Add(this.Cust);
            this.panel1.Controls.Add(this.OK);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 700);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Fuchsia;
            this.label2.Location = new System.Drawing.Point(167, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Supplier quantity";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(22, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Customer quantity";
            // 
            // CLEAR
            // 
            this.CLEAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CLEAR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CLEAR.Location = new System.Drawing.Point(170, 233);
            this.CLEAR.Name = "CLEAR";
            this.CLEAR.Size = new System.Drawing.Size(100, 50);
            this.CLEAR.TabIndex = 3;
            this.CLEAR.Text = "CLEAR";
            this.CLEAR.UseVisualStyleBackColor = true;
            this.CLEAR.Click += new System.EventHandler(this.CLEAR_Click);
            // 
            // Supp
            // 
            this.Supp.BackColor = System.Drawing.Color.DarkGray;
            this.Supp.Location = new System.Drawing.Point(170, 138);
            this.Supp.Name = "Supp";
            this.Supp.Size = new System.Drawing.Size(100, 22);
            this.Supp.TabIndex = 2;
            // 
            // Cust
            // 
            this.Cust.BackColor = System.Drawing.Color.DarkGray;
            this.Cust.Location = new System.Drawing.Point(22, 138);
            this.Cust.Name = "Cust";
            this.Cust.Size = new System.Drawing.Size(100, 22);
            this.Cust.TabIndex = 1;
            // 
            // OK
            // 
            this.OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.OK.Location = new System.Drawing.Point(22, 233);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(100, 50);
            this.OK.TabIndex = 0;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.Info;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.TextBox Cust;
        private System.Windows.Forms.TextBox Supp;
        private System.Windows.Forms.Button CLEAR;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

