using System.ComponentModel;

namespace PersonalFinanceManager.Properties
{
    partial class ExpenseTracking
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
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtExpenseOne = new System.Windows.Forms.TextBox();
            this.btnExpenseSaving = new System.Windows.Forms.Button();
            this.ExpenseDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txttwoexp = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.texexpensethree = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.expensefourtxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(242, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 27);
            this.label3.TabIndex = 0;
            this.label3.Text = "Save Expense";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(242, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Expense One";
            // 
            // txtExpenseOne
            // 
            this.txtExpenseOne.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtExpenseOne.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtExpenseOne.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExpenseOne.Location = new System.Drawing.Point(242, 176);
            this.txtExpenseOne.Multiline = true;
            this.txtExpenseOne.Name = "txtExpenseOne";
            this.txtExpenseOne.Size = new System.Drawing.Size(218, 28);
            this.txtExpenseOne.TabIndex = 0;
            // 
            // btnExpenseSaving
            // 
            this.btnExpenseSaving.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnExpenseSaving.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExpenseSaving.FlatAppearance.BorderSize = 0;
            this.btnExpenseSaving.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExpenseSaving.ForeColor = System.Drawing.Color.White;
            this.btnExpenseSaving.Location = new System.Drawing.Point(242, 430);
            this.btnExpenseSaving.Name = "btnExpenseSaving";
            this.btnExpenseSaving.Size = new System.Drawing.Size(218, 28);
            this.btnExpenseSaving.TabIndex = 4;
            this.btnExpenseSaving.Text = "Save";
            this.btnExpenseSaving.UseVisualStyleBackColor = false;
            this.btnExpenseSaving.Click += new System.EventHandler(this.btnExpenseSaving_Click);
            // 
            // ExpenseDatePicker
            // 
            this.ExpenseDatePicker.Location = new System.Drawing.Point(242, 116);
            this.ExpenseDatePicker.Name = "ExpenseDatePicker";
            this.ExpenseDatePicker.Size = new System.Drawing.Size(200, 25);
            this.ExpenseDatePicker.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(242, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Expense Two";
            // 
            // txttwoexp
            // 
            this.txttwoexp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txttwoexp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txttwoexp.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttwoexp.Location = new System.Drawing.Point(242, 244);
            this.txttwoexp.Multiline = true;
            this.txttwoexp.Name = "txttwoexp";
            this.txttwoexp.Size = new System.Drawing.Size(218, 28);
            this.txttwoexp.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(242, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Choose Expense Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(242, 285);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Expense Three";
            // 
            // texexpensethree
            // 
            this.texexpensethree.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.texexpensethree.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.texexpensethree.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texexpensethree.Location = new System.Drawing.Point(242, 314);
            this.texexpensethree.Multiline = true;
            this.texexpensethree.Name = "texexpensethree";
            this.texexpensethree.Size = new System.Drawing.Size(218, 28);
            this.texexpensethree.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(251, 354);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Expense Three";
            // 
            // expensefourtxt
            // 
            this.expensefourtxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.expensefourtxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.expensefourtxt.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expensefourtxt.Location = new System.Drawing.Point(242, 383);
            this.expensefourtxt.Multiline = true;
            this.expensefourtxt.Name = "expensefourtxt";
            this.expensefourtxt.Size = new System.Drawing.Size(218, 28);
            this.expensefourtxt.TabIndex = 12;
            // 
            // ExpenseTracking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(765, 577);
            this.ControlBox = false;
            this.Controls.Add(this.expensefourtxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.texexpensethree);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txttwoexp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ExpenseDatePicker);
            this.Controls.Add(this.btnExpenseSaving);
            this.Controls.Add(this.txtExpenseOne);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ExpenseTracking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox expensefourtxt;

        private System.Windows.Forms.TextBox texexpensethree;
        private System.Windows.Forms.Label label6;

        private System.Windows.Forms.Label label5;

        private System.Windows.Forms.TextBox txttwoexp;

        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.DateTimePicker ExpenseDatePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtExpenseOne;
      
      
      
      
      
       
        private System.Windows.Forms.Button btnExpenseSaving;
       
     
      
    }
}