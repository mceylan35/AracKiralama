﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
         // KullaniciServisSoapClient sp=new KullaniciServisSoapClient();
            AracServisSoapClient aracServis=new AracServisSoapClient();
        
            dataGridView1.DataSource = aracServis.GetAll();



        }
    }
}
