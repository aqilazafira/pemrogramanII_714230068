﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using P10_714230068.controller;

namespace P10_714230068.view
{
    public partial class FormLogin : Form
    {
        CekLogin Login = new CekLogin();
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (tbUsername.Text == "" || tbPassword.Text == "")
            {
                MessageBox.Show("Username dan Password tidak boleh kosong !!!!!");
            }
            else
            {
                string username = tbUsername.Text;
                string password = tbPassword.Text;

                bool status = Login.cek_login(username, password);
                if (status)
                {
                    MessageBox.Show("Login Berhasil", "Berhasil");
                    ParentForm pform = new ParentForm();
                    this.Hide();
                    pform.Show();
                }
                else
                {
                    MessageBox.Show("Gagal Login", "Gagal");
                }
            }
        }
    }
}
