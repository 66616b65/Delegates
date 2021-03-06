using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace VPEntity
{
    public partial class AddItemForm : Form
    {
        private int id;
        private string name;
        private string manufacturer;
        private decimal price;
        public AddItemForm()
        {
            InitializeComponent();
        }

        private void txtId_Validating(object sender, CancelEventArgs e)
        {
            string input = txtId.Text.Trim();
            if (Regex.IsMatch(input, @"(?<=\s|^)\d+(?=\s|$)"))
            {
                errorProvider.SetError(txtId, String.Empty);
                e.Cancel = false;
            }
            else
            {
                errorProvider.SetError(txtId, "Ошибка!");
                //e.Cancel = true;
            }
        }

        private void txtName_Validating(object sender, CancelEventArgs e)
        {
            string input = txtName.Text.Trim();
            if (String.IsNullOrEmpty(input))
            {
                errorProvider.SetError(txtName, "Ошибка!");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtName, String.Empty);
                e.Cancel = false;
            }
        }

        private void txtManufacturer_Validating(object sender, CancelEventArgs e)
        {
            string input = txtManufacturer.Text.Trim();
            if (String.IsNullOrEmpty(input))
            {
                errorProvider.SetError(txtManufacturer, "Ошибка!");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtManufacturer, String.Empty);
                e.Cancel = false;
            }
        }

        private void txtPrice_Validating(object sender, CancelEventArgs e)
        {
            string input = txtPrice.Text.Trim();
            if (Regex.IsMatch(input, @"^(([0-9]*[,])?[0-9]+)$"))
            {
                errorProvider.SetError(txtPrice, String.Empty);
                e.Cancel = false;
            }
            else
            {
                errorProvider.SetError(txtPrice, "Ошибка!");
                e.Cancel = true;
            }
        }

        private void txtId_Validated(object sender, EventArgs e)
        {
            id = Convert.ToInt32(txtId.Text.Trim());
        }

        private void txtName_Validated(object sender, EventArgs e)
        {
            name = txtName.Text.Trim();
        }

        private void txtManufacturer_Validated(object sender, EventArgs e)
        {
            manufacturer = txtManufacturer.Text.Trim();
        }

        private void txtPrice_Validated(object sender, EventArgs e)
        {
            price = Convert.ToDecimal(txtPrice.Text.Trim());
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.None;
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DialogResult = ValidateChildren() ? DialogResult.OK : DialogResult.None;
            if (DialogResult == DialogResult.OK)
            {
                AddItem();
            }
            this.Close();
        }

        private void AddItem()
        {
            try
            {
                using (var db = new SupplyModel())
                {
                    db.Item.Add(new Item
                    {
                        ID = id,
                        Name = name,
                        Manufacturer = manufacturer,
                        Price = price
                    });
                    db.SaveChanges();
                }
                MessageBox.Show("Данные добавлены!", "Добавлено", MessageBoxButtons.OK);
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка в данных!", "Ошибка", MessageBoxButtons.OK);
            }
        }
    }
}

