﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManageContactsLocal
{
    public partial class FormNewContact: Form
    {
        public FormNewContact()
        {
            InitializeComponent();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string email = txtEmail.Text;
            string phone = txtPhone.Text;
            string address = txtAddress.Text;
            string company = txtCompany.Text;

            Contact c1 = new Contact(name, email, phone, address, company);
            MainForm mainForm = new MainForm("TEST",c1);
            this.Hide();
            mainForm.Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }
    }
}
