using System.Windows.Forms;
using System;


namespace PersonalFinanceManager.Properties
{
    public partial class Dashboard : Form
    {
        public static Dashboard instance;
        public Label lbl;
        public Dashboard()
        {
            InitializeComponent();
            instance = this;
            lbl = label1;
        }

       

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}