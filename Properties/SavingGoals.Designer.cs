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
            this.RegisterSavingGoals = new System.Windows.Forms.Button();
            this.txtGoalName = new System.Windows.Forms.TextBox();
            this.lbGoal = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbGoalAmount = new System.Windows.Forms.Label();
            this.txtGoalAmount = new System.Windows.Forms.TextBox();
            this.lbTarget = new System.Windows.Forms.Label();
            this.txtTargetDate = new System.Windows.Forms.TextBox();
            this.lbContributionAmount = new System.Windows.Forms.Label();
            this.txtContributionAmount = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // RegisterSavingGoals
            // 
            this.RegisterSavingGoals.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.RegisterSavingGoals.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RegisterSavingGoals.FlatAppearance.BorderSize = 0;
            this.RegisterSavingGoals.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegisterSavingGoals.ForeColor = System.Drawing.Color.White;
            this.RegisterSavingGoals.Location = new System.Drawing.Point(268, 430);
            this.RegisterSavingGoals.Margin = new System.Windows.Forms.Padding(4);
            this.RegisterSavingGoals.Name = "RegisterSavingGoals";
            this.RegisterSavingGoals.Size = new System.Drawing.Size(246, 38);
            this.RegisterSavingGoals.TabIndex = 3;
            this.RegisterSavingGoals.Text = "Save";
            this.RegisterSavingGoals.UseVisualStyleBackColor = false;
            this.RegisterSavingGoals.Click += new System.EventHandler(this.RegisterSavingGoals_Click);
            // 
            // txtGoalName
            // 
            this.txtGoalName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtGoalName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGoalName.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGoalName.Location = new System.Drawing.Point(229, 111);
            this.txtGoalName.Margin = new System.Windows.Forms.Padding(4);
            this.txtGoalName.Multiline = true;
            this.txtGoalName.Name = "txtGoalName";
            this.txtGoalName.Size = new System.Drawing.Size(345, 38);
            this.txtGoalName.TabIndex = 0;
            // 
            // lbGoal
            // 
            this.lbGoal.AutoSize = true;
            this.lbGoal.Font = new System.Drawing.Font("Marlett", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGoal.Location = new System.Drawing.Point(268, 84);
            this.lbGoal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbGoal.Name = "lbGoal";
            this.lbGoal.Size = new System.Drawing.Size(109, 23);
            this.lbGoal.TabIndex = 9;
            this.lbGoal.Text = "Goal Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(299, 30);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Save Your Goal";
            // 
            // lbGoalAmount
            // 
            this.lbGoalAmount.AutoSize = true;
            this.lbGoalAmount.Font = new System.Drawing.Font("Marlett", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGoalAmount.Location = new System.Drawing.Point(268, 167);
            this.lbGoalAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbGoalAmount.Name = "lbGoalAmount";
            this.lbGoalAmount.Size = new System.Drawing.Size(123, 23);
            this.lbGoalAmount.TabIndex = 10;
            this.lbGoalAmount.Text = "Goal Amount";
            // 
            // txtGoalAmount
            // 
            this.txtGoalAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtGoalAmount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGoalAmount.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGoalAmount.Location = new System.Drawing.Point(229, 194);
            this.txtGoalAmount.Margin = new System.Windows.Forms.Padding(4);
            this.txtGoalAmount.Multiline = true;
            this.txtGoalAmount.Name = "txtGoalAmount";
            this.txtGoalAmount.Size = new System.Drawing.Size(345, 38);
            this.txtGoalAmount.TabIndex = 11;
            // 
            // lbTarget
            // 
            this.lbTarget.AutoSize = true;
            this.lbTarget.Font = new System.Drawing.Font("Marlett", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTarget.Location = new System.Drawing.Point(268, 246);
            this.lbTarget.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTarget.Name = "lbTarget";
            this.lbTarget.Size = new System.Drawing.Size(114, 23);
            this.lbTarget.TabIndex = 12;
            this.lbTarget.Text = "Target Date";
            // 
            // txtTargetDate
            // 
            this.txtTargetDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtTargetDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTargetDate.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTargetDate.Location = new System.Drawing.Point(229, 283);
            this.txtTargetDate.Margin = new System.Windows.Forms.Padding(4);
            this.txtTargetDate.Multiline = true;
            this.txtTargetDate.Name = "txtTargetDate";
            this.txtTargetDate.Size = new System.Drawing.Size(345, 38);
            this.txtTargetDate.TabIndex = 13;
            // 
            // lbContributionAmount
            // 
            this.lbContributionAmount.AutoSize = true;
            this.lbContributionAmount.Font = new System.Drawing.Font("Marlett", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbContributionAmount.Location = new System.Drawing.Point(268, 337);
            this.lbContributionAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbContributionAmount.Name = "lbContributionAmount";
            this.lbContributionAmount.Size = new System.Drawing.Size(185, 23);
            this.lbContributionAmount.TabIndex = 14;
            this.lbContributionAmount.Text = "Contribution Amount";
            // 
            // txtContributionAmount
            // 
            this.txtContributionAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtContributionAmount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContributionAmount.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContributionAmount.Location = new System.Drawing.Point(229, 373);
            this.txtContributionAmount.Margin = new System.Windows.Forms.Padding(4);
            this.txtContributionAmount.Multiline = true;
            this.txtContributionAmount.Name = "txtContributionAmount";
            this.txtContributionAmount.Size = new System.Drawing.Size(345, 38);
            this.txtContributionAmount.TabIndex = 15;
            // 
            // SavingGoals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(765, 577);
            this.ControlBox = false;
            this.Controls.Add(this.txtContributionAmount);
            this.Controls.Add(this.lbContributionAmount);
            this.Controls.Add(this.txtTargetDate);
            this.Controls.Add(this.lbTarget);
            this.Controls.Add(this.txtGoalAmount);
            this.Controls.Add(this.lbGoalAmount);
            this.Controls.Add(this.RegisterSavingGoals);
            this.Controls.Add(this.txtGoalName);
            this.Controls.Add(this.lbGoal);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Nirmala UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "SavingGoals";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lbContributionAmount;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtContributionAmount;

        private System.Windows.Forms.Label lbTarget;
        private System.Windows.Forms.TextBox txtTargetDate;

        private System.Windows.Forms.Label lbGoalAmount;
        private System.Windows.Forms.TextBox txtGoalAmount;

        #endregion

    
        
      
        private System.Windows.Forms.Button RegisterSavingGoals;
        private System.Windows.Forms.TextBox txtGoalName;
        private System.Windows.Forms.Label lbGoal;
        private System.Windows.Forms.Label label3;
       
        
       
       
    }
}