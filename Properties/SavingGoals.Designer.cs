using System.ComponentModel;

namespace PersonalFinanceManager.Properties
{
    partial class SavingGoals
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
            this.txtGoalAmount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTargetDate = new System.Windows.Forms.TextBox();
            this.saveGoal = new System.Windows.Forms.Button();
            this.txtContributionAmount = new System.Windows.Forms.TextBox();
            this.lbContribution = new System.Windows.Forms.Label();
            this.lbGoalAmount = new System.Windows.Forms.Label();
            this.txtGoalName = new System.Windows.Forms.TextBox();
            this.lbGoal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtGoalAmount
            // 
            this.txtGoalAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtGoalAmount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGoalAmount.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGoalAmount.Location = new System.Drawing.Point(177, 186);
            this.txtGoalAmount.Multiline = true;
            this.txtGoalAmount.Name = "txtGoalAmount";
            this.txtGoalAmount.PasswordChar = '*';
            this.txtGoalAmount.Size = new System.Drawing.Size(315, 28);
            this.txtGoalAmount.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(231, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 21);
            this.label4.TabIndex = 1;
            this.label4.Text = "Target Date";
            // 
            // txtTargetDate
            // 
            this.txtTargetDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtTargetDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTargetDate.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTargetDate.Location = new System.Drawing.Point(177, 269);
            this.txtTargetDate.Multiline = true;
            this.txtTargetDate.Name = "txtTargetDate";
            this.txtTargetDate.PasswordChar = '*';
            this.txtTargetDate.Size = new System.Drawing.Size(315, 28);
            this.txtTargetDate.TabIndex = 2;
            // 
            // saveGoal
            // 
            this.saveGoal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.saveGoal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveGoal.FlatAppearance.BorderSize = 0;
            this.saveGoal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveGoal.ForeColor = System.Drawing.Color.White;
            this.saveGoal.Location = new System.Drawing.Point(231, 400);
            this.saveGoal.Name = "saveGoal";
            this.saveGoal.Size = new System.Drawing.Size(218, 28);
            this.saveGoal.TabIndex = 4;
            this.saveGoal.Text = "Save";
            this.saveGoal.UseVisualStyleBackColor = false;
            this.saveGoal.Click += new System.EventHandler(this.saveGoal_Click);
            // 
            // txtContributionAmount
            // 
            this.txtContributionAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtContributionAmount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContributionAmount.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContributionAmount.Location = new System.Drawing.Point(177, 347);
            this.txtContributionAmount.Multiline = true;
            this.txtContributionAmount.Name = "txtContributionAmount";
            this.txtContributionAmount.PasswordChar = '*';
            this.txtContributionAmount.Size = new System.Drawing.Size(315, 28);
            this.txtContributionAmount.TabIndex = 5;
            // 
            // lbContribution
            // 
            this.lbContribution.AutoSize = true;
            this.lbContribution.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbContribution.Location = new System.Drawing.Point(229, 312);
            this.lbContribution.Name = "lbContribution";
            this.lbContribution.Size = new System.Drawing.Size(174, 21);
            this.lbContribution.TabIndex = 6;
            this.lbContribution.Text = "Contribution Amount";
            // 
            // lbGoalAmount
            // 
            this.lbGoalAmount.AutoSize = true;
            this.lbGoalAmount.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGoalAmount.Location = new System.Drawing.Point(229, 153);
            this.lbGoalAmount.Name = "lbGoalAmount";
            this.lbGoalAmount.Size = new System.Drawing.Size(111, 21);
            this.lbGoalAmount.TabIndex = 7;
            this.lbGoalAmount.Text = "Goal Amount";
            // 
            // txtGoalName
            // 
            this.txtGoalName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtGoalName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGoalName.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGoalName.Location = new System.Drawing.Point(177, 111);
            this.txtGoalName.Multiline = true;
            this.txtGoalName.Name = "txtGoalName";
            this.txtGoalName.Size = new System.Drawing.Size(315, 28);
            this.txtGoalName.TabIndex = 8;
            // 
            // lbGoal
            // 
            this.lbGoal.AutoSize = true;
            this.lbGoal.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGoal.Location = new System.Drawing.Point(229, 72);
            this.lbGoal.Name = "lbGoal";
            this.lbGoal.Size = new System.Drawing.Size(95, 21);
            this.lbGoal.TabIndex = 9;
            this.lbGoal.Text = "Goal Name";
            // 
            // SavingGoals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 557);
            this.ControlBox = false;
            this.Controls.Add(this.lbGoal);
            this.Controls.Add(this.txtGoalName);
            this.Controls.Add(this.lbGoalAmount);
            this.Controls.Add(this.lbContribution);
            this.Controls.Add(this.txtContributionAmount);
            this.Controls.Add(this.saveGoal);
            this.Controls.Add(this.txtTargetDate);
            this.Controls.Add(this.txtGoalAmount);
            this.Controls.Add(this.label4);
            this.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SavingGoals";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lbGoal;

        private System.Windows.Forms.Label lbGoalAmount;
        private System.Windows.Forms.TextBox txtGoalName;

        private System.Windows.Forms.TextBox txtContributionAmount;

        #endregion

        
        private System.Windows.Forms.Label lbContribution;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label2;
       
        private System.Windows.Forms.TextBox txtGoalAmount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTargetDate;
        
        private System.Windows.Forms.Button saveGoal;
        
       
       
    }
}