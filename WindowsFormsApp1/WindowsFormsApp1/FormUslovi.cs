using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormUslovi : Form
    {
        public FormUslovi()
        {
            InitializeComponent();
        }

        private void FormUslovi_Load(object sender, EventArgs e)
        {
            textBox1.Text = "PASPDPASPDPASDPASPDPASPDPASDPPASDPAPSDP" +
                "asdasdasdasdasd" +
                "asdasdasd" +
                "PASPDPASPDPASDPASPDPASPDPASDPPASDPAPSDP" +
                "asdasdasdasdasd" +
                "asdasdasd" + "PASPDPASPDPASDPASPDPASPDPASDPPASDPAPSDP" +
                "asdasdasdasdasd" +
                "asdasdasd" + "PASPDPASPDPASDPASPDPASPDPASDPPASDPAPSDP" +
                "asdasdasdasdasd" +
                "asdasdasd" + "PASPDPASPDPASDPASPDPASPDPASDPPASDPAPSDP" +
                "asdasdasdasdasd" +
                "asdasdasd" + "PASPDPASPDPASDPASPDPASPDPASDPPASDPAPSDP" +
                "asdasdasdasdasd" +
                "asdasdasd" + "PASPDPASPDPASDPASPDPASPDPASDPPASDPAPSDP" +
                "asdasdasdasdasd" +
                "asdasdasd" + "PASPDPASPDPASDPASPDPASPDPASDPPASDPAPSDP" +
                "asdasdasdasdasd" +
                "asdasdasd" + "PASPDPASPDPASDPASPDPASPDPASDPPASDPAPSDP" +
                "asdasdasdasdasd" +
                "asdasdasd" + "PASPDPASPDPASDPASPDPASPDPASDPPASDPAPSDP" +
                "asdasdasdasdasd" +
                "asdasdasd" + "PASPDPASPDPASDPASPDPASPDPASDPPASDPAPSDP" +
                "asdasdasdasdasd" +
                "asdasdasd" + "PASPDPASPDPASDPASPDPASPDPASDPPASDPAPSDP" +
                "asdasdasdasdasd" +
                "asdasdasd" + "PASPDPASPDPASDPASPDPASPDPASDPPASDPAPSDP" +
                "asdasdasdasdasd" +
                "asdasdasd" + "PASPDPASPDPASDPASPDPASPDPASDPPASDPAPSDP" +
                "asdasdasdasdasd" +
                "asdasdasd" + "";
                
        }

        private void FormUslovi_Resize(object sender, EventArgs e)
        {
            textBox1.Size = new System.Drawing.Size(this.Size.Width - 27, this.Size.Height - 48);
        }
    }
}
