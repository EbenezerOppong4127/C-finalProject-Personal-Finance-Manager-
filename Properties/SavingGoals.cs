using System;
using System.Windows.Forms;
using System.IO;
using PersonalFinanceManager.Properties;

namespace PersonalFinanceManager.Properties
{
    public partial class SavingGoals : Form
    {
        // Properties to hold username and index
        public string Username { get; set; }
        public int Index { get; set; }

        public SavingGoals()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            // Your implementation for label click event
        }

        private void saveGoal_Click(object sender, EventArgs e)
        {
            // Collect goal details from the user
            string goalName = txtGoalName.Text;
            string goalAmount = txtGoalAmount.Text;
            string targetDate = txtTargetDate.Text;
            string contributionAmount = txtContributionAmount.Text;

            // Prepare the goal data string
            string goalData = $"Goal Name: {goalName}, Amount: {goalAmount}, Target Date: {targetDate}, " +
                              $"Contribution Amount: {contributionAmount}";

            // Get the current user's index and username from the properties
            int userIndex = Index; // Use the Index property
            string username = Username; // Use the Username property

            // Prepare the full data string including index and username
            string fullData = $"index: {userIndex}, username: {username}, {goalData}";

            // Write the data to the text file
            string filePath = "saving_goal.txt";
            try
            {
                using (StreamWriter writer = File.AppendText(filePath))
                {
                    writer.WriteLine(fullData);
                }
                MessageBox.Show("Goal saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving goal: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}