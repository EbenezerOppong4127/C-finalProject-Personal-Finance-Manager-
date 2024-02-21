using System.Windows.Forms;
using System;
using System.Globalization;
using System.IO;
using PersonalFinanceManager.Properties;



namespace PersonalFinanceManager.Properties
{
    public partial class Dashboard : Form
    
    
    {
        
        
        public static Dashboard instance;
        public Label lbl;
        private readonly string username;
        private readonly int index;

        public Dashboard(string username, int index)
        {
            InitializeComponent();
            this.username = username;
            this.index = index;
            usernameDash.Text = "Welcome, " + username; // Set the username on the dashboard label
            
            // Retrieve the amount for the specified user from the saving_goal.txt file
            try
            {
                string filePath = "saving_goal.txt";
                string[] lines = File.ReadAllLines(filePath);

                // Find the line containing the user's information
                foreach (string line in lines)
                {
                    if (line.Contains($"index: {index}, username: {username}"))
                    {
                        // Parse the amount from the line
                        int startIndex = line.IndexOf("Amount: ") + "Amount: ".Length;
                        int endIndex = line.IndexOf(",", startIndex);
                        string amountStr = line.Substring(startIndex, endIndex - startIndex);

                        // Set the amount string to the label
                        setTotalBalence.Text = $"Total Balance: {amountStr}$";
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error reading saving_goal.txt: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
       public void LoadForm(Form form)
       {
           if (mainpanel.Controls.Count > 0)
               mainpanel.Controls.RemoveAt(0);

           form.TopLevel = false;
           form.Dock = DockStyle.Fill;

           if (form is SavingGoals savingGoalsForm)
           {
               savingGoalsForm.Username = username;
               savingGoalsForm.Index = index;
           }
           
           if (form is ExpenseTracking expenseTrackingForm)
           {
               expenseTrackingForm.Username = username;
               expenseTrackingForm.Index = index;
           }

           mainpanel.Controls.Add(form);
           mainpanel.Tag = form;
           form.Show();
       }

       private void SavingGoal_Click(object sender, EventArgs e)
       {
           LoadForm(new SavingGoals());
       }

       private void expenseTrack_Click(object sender, EventArgs e)
       {
           LoadForm(new ExpenseTracking());
       }
    }
}