using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AracKiralama.WinFormUI
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void btnYoneticiGiris_Click(object sender, EventArgs e)
        {
            MainForm mainForm = Application.OpenForms["MainForm"] as MainForm;
            Panel mainPanel = mainForm.Controls["mainPanel"] as Panel;
            mainPanel.Controls.Clear();

            FormYonetici formYonetici = new FormYonetici();
            formYonetici.TopLevel = false;
            mainPanel.Controls.Add(formYonetici);
            formYonetici.Show();
            formYonetici.Dock = DockStyle.Fill;
        }

        private void btnCalisanGiris_Click(object sender, EventArgs e)
        {

            MainForm mainForm = Application.OpenForms["MainForm"] as MainForm;
            Panel mainPanel = mainForm.Controls["mainPanel"] as Panel;
            mainPanel.Controls.Clear();

            FormCalisan formCalisan = new FormCalisan();
            formCalisan.TopLevel = false;
            mainPanel.Controls.Add(formCalisan);
            formCalisan.Show();
            formCalisan.Dock = DockStyle.Fill;

        }
    }
}
