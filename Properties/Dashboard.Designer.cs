using System.ComponentModel;

namespace PersonalFinanceManager.Properties
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.panel1 = new System.Windows.Forms.Panel();
            this.financialGoal = new System.Windows.Forms.Button();
            this.incomeOverview = new System.Windows.Forms.Button();
            this.expenseTrack = new System.Windows.Forms.Button();
            this.SavingGoal = new System.Windows.Forms.Button();
            this.returntoDash = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.usernameDash = new System.Windows.Forms.Label();
            this.mainpanel = new System.Windows.Forms.Panel();
            this.setTotalBalence = new System.Windows.Forms.Label();
            this.lbAcntBadg = new System.Windows.Forms.Label();
        
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.mainpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.label1.Location = new System.Drawing.Point(67, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.panel1.Controls.Add(this.financialGoal);
            this.panel1.Controls.Add(this.incomeOverview);
            this.panel1.Controls.Add(this.expenseTrack);
            this.panel1.Controls.Add(this.SavingGoal);
            this.panel1.Controls.Add(this.returntoDash);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(186, 577);
            this.panel1.TabIndex = 1;
            // 
            // financialGoal
            // 
            this.financialGoal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.financialGoal.Font = new System.Drawing.Font("Microsoft Uighur", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.financialGoal.Location = new System.Drawing.Point(12, 388);
            this.financialGoal.Name = "financialGoal";
            this.financialGoal.Size = new System.Drawing.Size(145, 39);
            this.financialGoal.TabIndex = 8;
            this.financialGoal.Text = "Financial Goals";
            this.financialGoal.UseVisualStyleBackColor = false;
            // 
            // incomeOverview
            // 
            this.incomeOverview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.incomeOverview.Font = new System.Drawing.Font("Microsoft Uighur", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incomeOverview.Location = new System.Drawing.Point(14, 323);
            this.incomeOverview.Name = "incomeOverview";
            this.incomeOverview.Size = new System.Drawing.Size(145, 39);
            this.incomeOverview.TabIndex = 6;
            this.incomeOverview.Text = "Income Overview";
            this.incomeOverview.UseVisualStyleBackColor = false;
            // 
            // expenseTrack
            // 
            this.expenseTrack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.expenseTrack.Font = new System.Drawing.Font("Microsoft Uighur", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expenseTrack.Location = new System.Drawing.Point(14, 261);
            this.expenseTrack.Name = "expenseTrack";
            this.expenseTrack.Size = new System.Drawing.Size(145, 39);
            this.expenseTrack.TabIndex = 5;
            this.expenseTrack.Text = "Expense Tracking";
            this.expenseTrack.UseVisualStyleBackColor = false;
            this.expenseTrack.Click += new System.EventHandler(this.expenseTrack_Click);
            // 
            // SavingGoal
            // 
            this.SavingGoal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.SavingGoal.Font = new System.Drawing.Font("Microsoft Uighur", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SavingGoal.Location = new System.Drawing.Point(14, 204);
            this.SavingGoal.Name = "SavingGoal";
            this.SavingGoal.Size = new System.Drawing.Size(145, 39);
            this.SavingGoal.TabIndex = 4;
            this.SavingGoal.Text = "Saving Goals";
            this.SavingGoal.UseVisualStyleBackColor = false;
            this.SavingGoal.Click += new System.EventHandler(this.SavingGoal_Click);
            // 
            // returntoDash
            // 
            this.returntoDash.FlatAppearance.BorderSize = 0;
            this.returntoDash.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returntoDash.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.returntoDash.Location = new System.Drawing.Point(0, 146);
            this.returntoDash.Name = "returntoDash";
            this.returntoDash.Size = new System.Drawing.Size(186, 52);
            this.returntoDash.TabIndex = 3;
            this.returntoDash.Text = "Dashboard";
            this.returntoDash.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.returntoDash.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.usernameDash);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(186, 144);
            this.panel2.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(61, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // usernameDash
            // 
            this.usernameDash.AutoSize = true;
            this.usernameDash.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameDash.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.usernameDash.Location = new System.Drawing.Point(14, 118);
            this.usernameDash.Name = "usernameDash";
            this.usernameDash.Size = new System.Drawing.Size(157, 13);
            this.usernameDash.TabIndex = 0;
            this.usernameDash.Text = "Some user information";
            // 
            // mainpanel
            // 
            this.mainpanel.BackColor = System.Drawing.Color.RosyBrown;
            this.mainpanel.Controls.Add(this.setTotalBalence);
           
            this.mainpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainpanel.Font = new System.Drawing.Font("Shonar Bangla", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainpanel.Location = new System.Drawing.Point(186, 0);
            this.mainpanel.Name = "mainpanel";
            this.mainpanel.Size = new System.Drawing.Size(765, 577);
            this.mainpanel.TabIndex = 3;
            // 
            // setTotalBalence
            // 
            this.setTotalBalence.Font = new System.Drawing.Font("Shonar Bangla", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.setTotalBalence.Location = new System.Drawing.Point(104, 114);
            this.setTotalBalence.Name = "setTotalBalence";
            this.setTotalBalence.Size = new System.Drawing.Size(185, 39);
            this.setTotalBalence.TabIndex = 1;
            this.setTotalBalence.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
           
            // 
            this.lbAcntBadg.Location = new System.Drawing.Point(0, 0);
            this.lbAcntBadg.Name = "lbAcntBadg";
            this.lbAcntBadg.Size = new System.Drawing.Size(100, 23);
            this.lbAcntBadg.TabIndex = 0;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(951, 577);
            this.ControlBox = false;
            this.Controls.Add(this.mainpanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.mainpanel.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label setTotalBalence;

        private System.Windows.Forms.Label lbAcntBadg;

        

        private System.Windows.Forms.Panel panel3;

        

       

        private System.Windows.Forms.Button financialGoal;

        private System.Windows.Forms.Button expenseTrack;
        private System.Windows.Forms.Button incomeOverview;
        

        private System.Windows.Forms.Button SavingGoal;

        public System.Windows.Forms.Panel mainpanel;

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label usernameDash;
        private System.Windows.Forms.Button returntoDash;
    }
}