﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace taskForDB
{
    public partial class authWindow : Form
    {
        public authWindow()
        {
            InitializeComponent();
        }

        private void login_textBox_TextChanged(object sender, EventArgs e)
        {
            if(login_textBox.Text == "Введите логин")
                login_textBox.Text = "";
        }

        private void password_textBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
