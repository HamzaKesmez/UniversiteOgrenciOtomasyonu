﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ÜniÖğrenciOtomasyonu
{
    public partial class Animasyon : Form
    {
        public Animasyon()
        {
            InitializeComponent();
        }
        bool islem = false;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(islem==false)
            {
                this.Opacity += 0.01;
            }
            if(this.Opacity == 1.0) 
            {
                islem = true;
            }
            if(islem==true)
            {
                this.Opacity -= 0.009;
                if(this.Opacity ==0) 
                {
                    kullanıcıGiris giris=new kullanıcıGiris();
                    giris.Show();
                    this.Hide();
                    timer1.Enabled = false;
                }
            }
        }
    }
}
