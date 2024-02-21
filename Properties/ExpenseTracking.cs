using System;
using System.Windows.Forms;
using System.IO;

namespace PersonalFinanceManager.Properties
{
    public partial class ExpenseTracking : Form
    {
        
        public string Username { get; set; }
        public int Index { get; set; }
        public ExpenseTracking()
        {
            InitializeComponent();
        }

        private void btnExpenseSaving_Click(object sender, EventArgs e)
        {
            int userIndex = Index; // Use the Index property
            string username = Username; // Use the Username property
            
            string expenseDate = ExpenseDatePicker.Value.ToShortDateString();
            string expenseOne = txtExpenseOne.Text;
            string expenseTwo = txttwoexp.Text;
            string expenseThree = texexpensethree.Text;
            string expenseFour = expensefourtxt.Text;

            // Prepare the expense data string
            string expenseData = $"index: {Index}, username: {username}, expense date: {expenseDate}, expense one: {expenseOne}, expense two: {expenseTwo}, expense three: {expenseThree}, expense four: {expenseFour}";

            // Write the expense data to the expenses.txt file
            string filePath = "expenses.txt";
            try
            {
                using (StreamWriter writer = File.AppendText(filePath))
                {
                    writer.WriteLine(expenseData);
                }
                MessageBox.Show("Expense details saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving expense details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}