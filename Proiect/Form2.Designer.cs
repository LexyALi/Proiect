namespace Proiect
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btX = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btLogOut = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btRetB = new System.Windows.Forms.Button();
            this.btIssB = new System.Windows.Forms.Button();
            this.btAddB = new System.Windows.Forms.Button();
            this.btDas = new System.Windows.Forms.Button();
            this.userControl11 = new Proiect.UserControl1();
            this.returBooks1 = new Proiect.ReturBooks();
            this.issueBooks1 = new Proiect.IssueBooks();
            this.add1 = new Proiect.ADD();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(108)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.btX);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1064, 40);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btX
            // 
            this.btX.BackColor = System.Drawing.SystemColors.Control;
            this.btX.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btX.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btX.ForeColor = System.Drawing.Color.Black;
            this.btX.Location = new System.Drawing.Point(1021, 2);
            this.btX.Name = "btX";
            this.btX.Size = new System.Drawing.Size(40, 35);
            this.btX.TabIndex = 3;
            this.btX.Text = "X";
            this.btX.UseVisualStyleBackColor = false;
            this.btX.Click += new System.EventHandler(this.btX_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(108)))), ((int)(((byte)(255)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 607);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1064, 40);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(108)))), ((int)(((byte)(255)))));
            this.panel3.Controls.Add(this.btLogOut);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.btRetB);
            this.panel3.Controls.Add(this.btIssB);
            this.panel3.Controls.Add(this.btAddB);
            this.panel3.Controls.Add(this.btDas);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 40);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(190, 567);
            this.panel3.TabIndex = 2;
            // 
            // btLogOut
            // 
            this.btLogOut.BackColor = System.Drawing.SystemColors.Control;
            this.btLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btLogOut.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLogOut.ForeColor = System.Drawing.Color.Black;
            this.btLogOut.Location = new System.Drawing.Point(59, 469);
            this.btLogOut.Name = "btLogOut";
            this.btLogOut.Size = new System.Drawing.Size(90, 32);
            this.btLogOut.TabIndex = 3;
            this.btLogOut.Text = "Log Out";
            this.btLogOut.UseVisualStyleBackColor = false;
            this.btLogOut.Click += new System.EventHandler(this.btLogOut_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(51, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(98, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btRetB
            // 
            this.btRetB.BackColor = System.Drawing.SystemColors.Control;
            this.btRetB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btRetB.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRetB.ForeColor = System.Drawing.Color.Black;
            this.btRetB.Location = new System.Drawing.Point(30, 384);
            this.btRetB.Name = "btRetB";
            this.btRetB.Size = new System.Drawing.Size(143, 52);
            this.btRetB.TabIndex = 4;
            this.btRetB.Text = "RETURN BOOK";
            this.btRetB.UseVisualStyleBackColor = false;
            this.btRetB.Click += new System.EventHandler(this.btRetB_Click);
            // 
            // btIssB
            // 
            this.btIssB.BackColor = System.Drawing.SystemColors.Control;
            this.btIssB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btIssB.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btIssB.ForeColor = System.Drawing.Color.Black;
            this.btIssB.Location = new System.Drawing.Point(30, 310);
            this.btIssB.Name = "btIssB";
            this.btIssB.Size = new System.Drawing.Size(143, 52);
            this.btIssB.TabIndex = 1;
            this.btIssB.Text = "ISSUE BOOKS";
            this.btIssB.UseVisualStyleBackColor = false;
            this.btIssB.Click += new System.EventHandler(this.btIssB_Click);
            // 
            // btAddB
            // 
            this.btAddB.BackColor = System.Drawing.SystemColors.Control;
            this.btAddB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btAddB.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAddB.ForeColor = System.Drawing.Color.Black;
            this.btAddB.Location = new System.Drawing.Point(30, 238);
            this.btAddB.Name = "btAddB";
            this.btAddB.Size = new System.Drawing.Size(143, 52);
            this.btAddB.TabIndex = 3;
            this.btAddB.Text = "ADD BOOKS";
            this.btAddB.UseVisualStyleBackColor = false;
            this.btAddB.Click += new System.EventHandler(this.btAddB_Click);
            // 
            // btDas
            // 
            this.btDas.BackColor = System.Drawing.SystemColors.Control;
            this.btDas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btDas.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDas.ForeColor = System.Drawing.Color.Black;
            this.btDas.Location = new System.Drawing.Point(30, 166);
            this.btDas.Name = "btDas";
            this.btDas.Size = new System.Drawing.Size(143, 52);
            this.btDas.TabIndex = 0;
            this.btDas.Text = "DASHBOARD";
            this.btDas.UseVisualStyleBackColor = false;
            this.btDas.Click += new System.EventHandler(this.btDas_Click);
            // 
            // userControl11
            // 
            this.userControl11.Location = new System.Drawing.Point(196, 40);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(880, 565);
            this.userControl11.TabIndex = 3;
            // 
            // returBooks1
            // 
            this.returBooks1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(108)))), ((int)(((byte)(255)))));
            this.returBooks1.Location = new System.Drawing.Point(184, 40);
            this.returBooks1.Name = "returBooks1";
            this.returBooks1.Size = new System.Drawing.Size(880, 565);
            this.returBooks1.TabIndex = 4;
            // 
            // issueBooks1
            // 
            this.issueBooks1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(108)))), ((int)(((byte)(255)))));
            this.issueBooks1.Location = new System.Drawing.Point(196, 40);
            this.issueBooks1.Name = "issueBooks1";
            this.issueBooks1.Size = new System.Drawing.Size(880, 565);
            this.issueBooks1.TabIndex = 5;
            // 
            // add1
            // 
            this.add1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(108)))), ((int)(((byte)(255)))));
            this.add1.Location = new System.Drawing.Point(196, 42);
            this.add1.Name = "add1";
            this.add1.Size = new System.Drawing.Size(880, 565);
            this.add1.TabIndex = 6;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 647);
            this.Controls.Add(this.add1);
            this.Controls.Add(this.issueBooks1);
            this.Controls.Add(this.returBooks1);
            this.Controls.Add(this.userControl11);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btDas;
        private System.Windows.Forms.Button btX;
        private System.Windows.Forms.Button btRetB;
        private System.Windows.Forms.Button btIssB;
        private System.Windows.Forms.Button btAddB;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btLogOut;
        private UserControl1 userControl11;
        private ReturBooks returBooks1;
        private IssueBooks issueBooks1;
        private ADD add1;
    }
}