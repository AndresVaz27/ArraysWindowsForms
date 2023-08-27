using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArraysWindowsForms
{
    public partial class Form1 : Form
    {
        private Contact[] contacts = new Contact[3]; // Array to store contacts
        private int contactCount = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAddContact_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            string phoneNumber = textBoxPhoneNumber.Text;

            if (!string.IsNullOrWhiteSpace(name) && !string.IsNullOrWhiteSpace(phoneNumber) && contactCount < contacts.Length)
            {
                Contact newContact = new Contact { Name = name, PhoneNumber = phoneNumber };
                contacts[contactCount] = newContact;
                contactCount++;
                RefreshContactList();
            }
            else
            {
                MessageBox.Show("Unable to add contact. Either data is missing or the list is full.");
            }
        }

        private void buttonViewContact_Click(object sender, EventArgs e)
        {
            int selectedIndex = listBoxContacts.SelectedIndex;
            if (selectedIndex >= 0 && selectedIndex < contactCount)
            {
                Contact selectedContact = contacts[selectedIndex];
                MessageBox.Show($"Name: {selectedContact.Name}\nPhone Number: {selectedContact.PhoneNumber}");
            }
        }

        private void buttonRemoveContact_Click(object sender, EventArgs e)
        {
            int selectedIndex = listBoxContacts.SelectedIndex;
            if (selectedIndex >= 0 && selectedIndex < contactCount)
            {
                for (int i = selectedIndex; i < contactCount - 1; i++)
                {
                    contacts[i] = contacts[i + 1];
                }
                contactCount--;
                RefreshContactList();
            }
        }

        private void RefreshContactList()
        {
            listBoxContacts.Items.Clear();
            for (int i = 0; i < contactCount; i++)
            {
                listBoxContacts.Items.Add(contacts[i]);
            }
            labelContactCount.Text = $"Total Contacts: {contactCount}/{contacts.Length}";
            textBoxName.Clear();
            textBoxPhoneNumber.Clear();
        }

    }
}
