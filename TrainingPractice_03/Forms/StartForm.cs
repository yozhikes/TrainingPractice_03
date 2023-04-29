using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrainingPractice_03.Forms;

namespace TrainingPractice_03
{
    public partial class StartForm : Form
    {
        DataBase dataBase = new DataBase();
        public StartForm()
        {
            InitializeComponent();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void справочникToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GuideForm guideForm=new GuideForm();
            Hide();
            guideForm.Show();
        }

        private void топливоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FuelForm fuelForm = new FuelForm();
            Hide();
            fuelForm.Show();
        }

        private void учётToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemainsForm remainsForm = new RemainsForm();
            Hide();
            remainsForm.Show();
        }

        private void контактыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ContactsForm contactsForm = new ContactsForm();
            Hide();
            contactsForm.Show();
        }
    }
}
