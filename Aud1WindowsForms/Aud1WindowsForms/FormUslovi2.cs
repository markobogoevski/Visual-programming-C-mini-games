using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aud1WindowsForms
{
    public partial class FormUslovi2 : Form
    {
        public FormUslovi2()
        {
            InitializeComponent();
        }

        private void FormUslovi2_Load(object sender, EventArgs e)
        {
            textBox1.Text = "USLOVI USLOVI USLOVI USLOVI USLOVI USLOVI USLOVI USLOVI " +
                "USLOVI USLOVI USLOVI USLOVI USLOVI USLOVI USLOVI USLOVI " +
                "USLOVI USLOVI USLOVI USLOVI USLOVI USLOVI USLOVI USLOVI " +
                "USLOVI USLOVI USLOVI USLOVI USLOVI USLOVI USLOVI USLOVI " +
                "USLOVI USLOVI USLOVI USLOVI USLOVI USLOVI USLOVI USLOVI " +
                "USLOVI USLOVI USLOVI USLOVI USLOVI USLOVI USLOVI USLOVI " +
                "USLOVI USLOVI USLOVI USLOVI USLOVI USLOVI USLOVI USLOVI " +
                "USLOVI USLOVI USLOVI USLOVI USLOVI USLOVI USLOVI USLOVI " +
                "USLOVI USLOVI USLOVI USLOVI USLOVI USLOVI USLOVI USLOVI " +
                "USLOVI USLOVI USLOVI USLOVI USLOVI USLOVI USLOVI USLOVI " +
                "USLOVI USLOVI USLOVI USLOVI USLOVI USLOVI USLOVI USLOVI " +
                "USLOVI USLOVI USLOVI USLOVI USLOVI USLOVI USLOVI USLOVI " +
                "USLOVI USLOVI USLOVI USLOVI USLOVI USLOVI USLOVI USLOVI " +
                "USLOVI USLOVI USLOVI USLOVI USLOVI USLOVI USLOVI USLOVI " +
                "USLOVI USLOVI USLOVI USLOVI USLOVI USLOVI USLOVI USLOVI " +
                "USLOVI USLOVI USLOVI USLOVI USLOVI USLOVI USLOVI USLOVI " +
                "USLOVI USLOVI USLOVI USLOVI USLOVI USLOVI USLOVI USLOVI " +
                "USLOVI USLOVI USLOVI USLOVI USLOVI USLOVI USLOVI USLOVI ";
        }

        private void FormUslovi2_Resize(object sender, EventArgs e)
        {
            textBox1.Size = new System.Drawing.Size(this.Size.Width - 27, this.Size.Height - 48);
        }
    }
}
