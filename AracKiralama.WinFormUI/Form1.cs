using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AracKiralama.WinFormUI.AracSoapService;
using AracKiralama.WinFormUI.KullaniciSoapServis;

namespace AracKiralama.WinFormUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KullaniciSoapServiceSoapClient sp=new KullaniciSoapServiceSoapClient();
            dataGridView1.DataSource= sp.KullaniciListele();
            
            

        }
    }
}
