using System;
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
    public partial class MainForm: Form
    {
        public MainForm(string username, Contact contact = null)
        {
            InitializeComponent();
            label3.Text = "Welcome, " + username;
            LoadContacts();

            if (contact != null)
            {
                createNewContact(contact);
            }
        }

        public void createNewContact(Contact contact)
        {
            ListViewItem item = new ListViewItem(contact.Name);
            item.SubItems.Add(contact.Email);
            item.SubItems.Add(contact.Phone);
            item.SubItems.Add(contact.Address);
            item.SubItems.Add(contact.Company);
            listViewContacts.Items.Add(item);
        }




        private void btnSignOut_Click(object sender, EventArgs e)
        {

        }

        private void LoadContacts()
        {
            // Create a new ListViewItem for each contact
            ListViewItem item = new ListViewItem("John Doe");
            item.SubItems.Add("john.doe@example.com");
            item.SubItems.Add("+1 (555) 123-4567");
            item.SubItems.Add("10 Example Lane, Glasgow, Scotland");
            item.SubItems.Add("ABC Corp.");
            listViewContacts.Items.Add(item);
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            FormNewContact formNewContact = new FormNewContact();
            formNewContact.Show();

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {

        }
    }
}
