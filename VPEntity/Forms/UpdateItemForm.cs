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
    public partial class UpdateItemForm : Form
    {
        public Item oldItem;
        private int id;
        private string name;
        private string manufacturer;
        private decimal price;
        public UpdateItemForm()
        {
            InitializeComponent();
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DialogResult = ValidateChildren() ? DialogResult.OK : DialogResult.None;
            if (DialogResult == DialogResult.OK)
            {
                UpdateItem();
            }
            this.Close();
        }

        private void UpdateItem()
        {
            try
            {
                using (var db = new SupplyModel())
                {
                    Item item = db.Item.Where(x => x.ID == id).First();
                    item.Name = name;
                    item.Manufacturer = manufacturer;
                    item.Price = price;
                    db.SaveChanges();
                }
                MessageBox.Show("Данные изменены!", "Изменено", MessageBoxButtons.OK);
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка в данных!", "Ошибка", MessageBoxButtons.OK);
            }
        }

        private void UpdateItemForm_Load(object sender, EventArgs e)
        {
            txtId.Text = oldItem.ID.ToString();
            txtName.Text = oldItem.Name;
            txtManufacturer.Text = oldItem.Manufacturer;
            txtPrice.Text = oldItem.Price.ToString();

            //Артикул нельзя поменять
            txtId.Enabled = false;
            id = oldItem.ID;
        }
    }
}

