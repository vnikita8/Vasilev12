﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vasilev12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ACipher aCipher = new ACipher();
            aCipher.encryption = "АбВгДЯ";
            aCipher.encode();
            richTextBox1.Text = aCipher.encryption;
        }
    }
}
