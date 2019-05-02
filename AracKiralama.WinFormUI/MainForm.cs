using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AracKiralama.WinFormUI.AracServis;
using AracKiralama.WinFormUI.KullaniciSoapServis;
using AutoMapper;

namespace AracKiralama.WinFormUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        

        private void MainForm_Load(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            LoginForm loginForm = new LoginForm();
            loginForm.TopLevel = false;
            mainPanel.Controls.Add(loginForm);
            loginForm.Show();
            loginForm.Dock = DockStyle.Fill;
        }
    }
}
