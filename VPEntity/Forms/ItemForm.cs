using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace VPEntity
{
    public partial class ItemForm : Form
    {
        public ItemForm()
        {
            InitializeComponent();
        }

        //Можно просто получить список товаров
        public IEnumerable GetItems()
        {
            using (var db = new SupplyModel())
            {
                var items = from item in db.Item
                            select new
                            {
                                item.ID,
                                item.Name,
                                item.Manufacturer,
                                item.Price
                            };
                return items.ToList();
            }
        }

        private void SetItemGrid()
        {
            //itemGrid0.Rows.Clear();
            //using (var db = new SupplyModel())
            //{
            //    var items = db.Item.ToList();
            //    foreach (var item in items)
            //    {
            //        itemGrid0.Rows.Add(item.ID, item.Name, item.Manufacturer, item.Price);
            //    }
            //}

            //Ещё один способ, для этого добавила пустую таблицу itemGrid, старую переименовала в itemGrid0
            itemGrid0.Visible = false;

            itemGrid.DataSource = GetItems();
            itemGrid.Columns[0].HeaderText = "Артикул";
            itemGrid.Columns[1].HeaderText = "Наименование";
            itemGrid.Columns[2].HeaderText = "Производитель";
            itemGrid.Columns[3].HeaderText = "Стоимость";
        }
        private void refreshItem_Click(object sender, EventArgs e)
        {
            SetItemGrid();
        }

        private void ItemForm_Load(object sender, EventArgs e)
        {
            SetItemGrid();
            comboBox.DataSource = GetSuppliers();
        }

        private void addItem_Click(object sender, EventArgs e)
        {
            AddItemForm add = new AddItemForm();
            if (add.ShowDialog(this) == DialogResult.OK)
            {
                SetItemGrid();
            }
        }

        private void removeItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить этот элемент?",
                "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                if (itemGrid.SelectedCells.Count > 0)
                {
                    var i = itemGrid.SelectedCells[0].OwningRow.Index;
                    int itemId = (int)itemGrid[0, i].Value;
                    using (var db = new SupplyModel())
                    {
                        Item item = db.Item.Where(x => x.ID == itemId).First();
                        db.Item.Remove(item);
                        db.SaveChanges();
                    }
                }
            }
            SetItemGrid();
        }


        private void updateItem_Click(object sender, EventArgs e)
        {
            if (itemGrid.SelectedCells.Count > 0)
            {
                var i = itemGrid.SelectedCells[0].OwningRow.Index;
                int itemID = (int)itemGrid[0, i].Value;
                Item item = new Item();
                using (var db = new SupplyModel())
                {
                    item = db.Item.Where(x => x.ID == itemID).First();
                }
                UpdateItemForm ef = new UpdateItemForm();
                ef.oldItem = item;
                if (ef.ShowDialog(this) == DialogResult.OK)
                {
                    SetItemGrid();
                }

            }
        }

        public IEnumerable GetSupplies()
        {
            using (var db = new SupplyModel())
            {
                var supplies = from supply in db.Supply
                               select new
                               {
                                   supply.Date,
                                   Supplier = supply.Supplier.Name,
                                   supply.ItemID,
                                   Item = supply.Item.Name,
                                   supply.Volume,
                                   Overall = supply.Volume * supply.Item.Price
                               };
                return supplies.ToList();
            }
        }

        public IEnumerable GetSuppliers()
        {
            using (var db = new SupplyModel())
            {
                var suppliers = from supplier in db.Supplier
                               select new
                               {
                                   supplier.ID,
                                   supplier.Name
                               };
                return suppliers.ToList();
            }
        }
    }
}
