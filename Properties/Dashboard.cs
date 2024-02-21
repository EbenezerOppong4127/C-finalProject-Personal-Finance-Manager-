using System.Windows.Forms;
using System;
using PersonalFinanceManager.Properties;


namespace PersonalFinanceManager.Properties
{
    public partial class Dashboard : Form
    
    
    {
        
        
        public static Dashboard instance;
        public Label lbl;
        private string username;
        private int index;

        public Dashboard(string username, int index)
        {
            InitializeComponent();
            this.username = username;
            this.index = index;
            usernameDash.Text = "Welcome, " + username; // Set the username on the dashboard label
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

           mainpanel.Controls.Add(form);
           mainpanel.Tag = form;
           form.Show();
       }

       private void SavingGoal_Click(object sender, EventArgs e)
       {
           LoadForm(new SavingGoals());
       }
    }
}