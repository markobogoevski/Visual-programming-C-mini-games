using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        List<Conference> conferences { get; set; }
        public Form1()
        {
            conferences = new List<Conference>();
            InitializeComponent();
            comboBoxYear.Items.Add(-1);
        }
        
        public void filterByYear(int year)
        {
            lbConferences.Items.Clear();
                List<Conference> newList = new List<Conference>();
                foreach (Conference conference in conferences)
                {
                    if (year != -1)
                    {
                        if (conference.year == year)
                            lbConferences.Items.Add(conference);
                    }
                    else
                        lbConferences.Items.Add(conference);
                }
        }
        private void lbConferences_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbConferences.SelectedIndex != -1)
            {
                btnDeleteConference.Enabled = true;
            }
            else
                btnDeleteConference.Enabled = false;
        }

        private void btnAddConference_Click(object sender, EventArgs e)
        {
            AddConference newForm = new AddConference();
            DialogResult = newForm.ShowDialog();
            if(DialogResult == DialogResult.OK)
            {
                conferences.Add(newForm.conference);
                if (!comboBoxYear.Items.Contains(newForm.conference.year))
                    comboBoxYear.Items.Add(newForm.conference.year);

                if (comboBoxYear.SelectedIndex != -1)
                {
                    filterByYear((int)comboBoxYear.SelectedItem);
                }
            }
        }

        private void btnDeleteConference_Click(object sender, EventArgs e)
        {
            if(lbConferences.SelectedIndex!=-1)
            {
                DialogResult = MessageBox.Show("Дали сте сигурни?", "Бришење конференција", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (DialogResult == DialogResult.Yes)
                {
                    Conference toRemove = (Conference)lbConferences.SelectedItem;
                    lbConferences.Items.RemoveAt(lbConferences.SelectedIndex);
                    conferences.Remove(toRemove);
                    btnDeleteConference.Enabled = false;
                    int year = toRemove.year;
                    comboBoxYear.Items.Remove(year);
                }
            }
        }

        private void comboBoxYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxYear.SelectedIndex!=-1)
            {
                filterByYear((int)comboBoxYear.SelectedItem);
            }
        }
    }
}
