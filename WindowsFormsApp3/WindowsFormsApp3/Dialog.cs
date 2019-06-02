using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Dialog : Form
    {

        public Team team { get; set; }
        public Dialog()
        {
            InitializeComponent();
        }

        private void btnEnterTeam_Click(object sender, EventArgs e)
        {
            if (tbCityName.Text.Length != 0 && tbTeamName.Text.Length != 0)
            {
                team = new Team(tbTeamName.Text, tbCityName.Text);
                DialogResult = DialogResult.OK;
            }
            else
                MessageBox.Show("Enter name/city!");
        }

        private void btnCancelTeam_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void tbTeamName_Validating(object sender, CancelEventArgs e)
        {
            String message = "";
            if (tbTeamName.Text.Length == 0)
            {
                message = "You have to enter a team name!";
                errorProvider1.SetError(tbTeamName, message);
                e.Cancel = true;
            }
            else
                errorProvider1.SetError(tbTeamName, "");
        }

        private void tbCityName_Validating(object sender, CancelEventArgs e)
        {
            String message = "";
            if (tbCityName.Text.Length == 0)
            {
                message = "You have to enter a team city!";
                errorProvider1.SetError(tbCityName, message);
                e.Cancel = true;
            }
            else
                errorProvider1.SetError(tbCityName, "");
        }
    }
}
