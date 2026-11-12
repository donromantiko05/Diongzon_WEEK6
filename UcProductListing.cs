using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DiongzonWeek6
{
    public partial class UcProductListing : UserControl
    {
        private readonly string[] units = { "Piece", "Box", "Kilogram" };
        private readonly List<string> shoppingList = new List<string>();

        public UcProductListing()
        {
            InitializeComponent();
            cmbUnit.Items.AddRange(units);
            cmbUnit.SelectedIndex = 0;
        }

        private void Add_Click(object sender, EventArgs e)
        {
            string item = txtDescription.Text.Trim();
            string unit = cmbUnit.SelectedItem == null ? null : cmbUnit.SelectedItem.ToString();

            if (string.IsNullOrWhiteSpace(item))
            {
                MessageBox.Show("Please enter a product description.");
                txtDescription.Focus();
                return;
            }

            decimal amount;
            if (!decimal.TryParse(txtAmount.Text, out amount) || amount <= 0)
            {
                MessageBox.Show("Please enter a valid amount.");
                txtAmount.Focus();
                return;
            }

            if (string.IsNullOrEmpty(unit))
            {
                MessageBox.Show("Please select a unit.");
                cmbUnit.Focus();
                return;
            }

            string product = string.Format("{0} - {1} {2}", item, amount, unit);
            shoppingList.Add(product);
            lstProducts.Items.Add(product);
            lstProducts.SelectedIndex = lstProducts.Items.Count - 1;

            txtDescription.Clear();
            txtAmount.Clear();
            cmbUnit.SelectedIndex = 0;
            txtDescription.Focus();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            int selectedIndex = lstProducts.SelectedIndex;
            if (selectedIndex < 0)
                return;

            shoppingList.RemoveAt(selectedIndex);
            lstProducts.Items.RemoveAt(selectedIndex);
        }

        private void lstProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnDelete.Enabled = lstProducts.SelectedIndex >= 0;
        }

        private void Input_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && sender != lstProducts)
            {
                e.SuppressKeyPress = true;
                Add_Click(btnAdd, EventArgs.Empty);
            }
            else if (e.KeyCode == Keys.Delete && sender == lstProducts && lstProducts.SelectedIndex >= 0)
            {
                e.SuppressKeyPress = true;
                Delete_Click(btnDelete, EventArgs.Empty);
            }
        }
    }
}
