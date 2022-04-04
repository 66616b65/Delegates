
namespace VPEntity
{
    partial class ItemForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.itemGrid0 = new System.Windows.Forms.DataGridView();
            this.IdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ManufacturerColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.refreshItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemGrid = new System.Windows.Forms.DataGridView();
            this.comboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.itemGrid0)).BeginInit();
            this.itemContextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // itemGrid0
            // 
            this.itemGrid0.BackgroundColor = System.Drawing.SystemColors.Window;
            this.itemGrid0.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.itemGrid0.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.itemGrid0.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.itemGrid0.ColumnHeadersHeight = 29;
            this.itemGrid0.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdColumn,
            this.NameColumn,
            this.ManufacturerColumn,
            this.PriceColumn});
            this.itemGrid0.ContextMenuStrip = this.itemContextMenu;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.itemGrid0.DefaultCellStyle = dataGridViewCellStyle2;
            this.itemGrid0.GridColor = System.Drawing.SystemColors.InactiveCaption;
            this.itemGrid0.Location = new System.Drawing.Point(13, 13);
            this.itemGrid0.Margin = new System.Windows.Forms.Padding(4);
            this.itemGrid0.Name = "itemGrid0";
            this.itemGrid0.RowHeadersVisible = false;
            this.itemGrid0.RowHeadersWidth = 51;
            this.itemGrid0.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.itemGrid0.RowTemplate.Height = 24;
            this.itemGrid0.RowTemplate.ReadOnly = true;
            this.itemGrid0.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.itemGrid0.Size = new System.Drawing.Size(927, 288);
            this.itemGrid0.TabIndex = 0;
            // 
            // IdColumn
            // 
            this.IdColumn.HeaderText = "Артикул";
            this.IdColumn.MinimumWidth = 6;
            this.IdColumn.Name = "IdColumn";
            this.IdColumn.Width = 120;
            // 
            // NameColumn
            // 
            this.NameColumn.HeaderText = "Наименование";
            this.NameColumn.MinimumWidth = 6;
            this.NameColumn.Name = "NameColumn";
            this.NameColumn.Width = 200;
            // 
            // ManufacturerColumn
            // 
            this.ManufacturerColumn.HeaderText = "Производитель";
            this.ManufacturerColumn.MinimumWidth = 6;
            this.ManufacturerColumn.Name = "ManufacturerColumn";
            this.ManufacturerColumn.Width = 200;
            // 
            // PriceColumn
            // 
            this.PriceColumn.HeaderText = "Цена";
            this.PriceColumn.MinimumWidth = 6;
            this.PriceColumn.Name = "PriceColumn";
            this.PriceColumn.Width = 125;
            // 
            // itemContextMenu
            // 
            this.itemContextMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.itemContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshItem,
            this.addItem,
            this.updateItem,
            this.removeItem});
            this.itemContextMenu.Name = "itemContextMenu";
            this.itemContextMenu.Size = new System.Drawing.Size(148, 100);
            // 
            // refreshItem
            // 
            this.refreshItem.Name = "refreshItem";
            this.refreshItem.Size = new System.Drawing.Size(147, 24);
            this.refreshItem.Text = "Обновить";
            this.refreshItem.Click += new System.EventHandler(this.refreshItem_Click);
            // 
            // addItem
            // 
            this.addItem.Name = "addItem";
            this.addItem.Size = new System.Drawing.Size(147, 24);
            this.addItem.Text = "Добавить";
            this.addItem.Click += new System.EventHandler(this.addItem_Click);
            // 
            // updateItem
            // 
            this.updateItem.Name = "updateItem";
            this.updateItem.Size = new System.Drawing.Size(147, 24);
            this.updateItem.Text = "Изменить";
            this.updateItem.Click += new System.EventHandler(this.updateItem_Click);
            // 
            // removeItem
            // 
            this.removeItem.Name = "removeItem";
            this.removeItem.Size = new System.Drawing.Size(147, 24);
            this.removeItem.Text = "Удалить";
            this.removeItem.Click += new System.EventHandler(this.removeItem_Click);
            // 
            // itemGrid
            // 
            this.itemGrid.BackgroundColor = System.Drawing.SystemColors.Window;
            this.itemGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.itemGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.itemGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.itemGrid.ColumnHeadersHeight = 29;
            this.itemGrid.ContextMenuStrip = this.itemContextMenu;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.itemGrid.DefaultCellStyle = dataGridViewCellStyle4;
            this.itemGrid.GridColor = System.Drawing.SystemColors.InactiveCaption;
            this.itemGrid.Location = new System.Drawing.Point(13, 13);
            this.itemGrid.Margin = new System.Windows.Forms.Padding(4);
            this.itemGrid.Name = "itemGrid";
            this.itemGrid.RowHeadersVisible = false;
            this.itemGrid.RowHeadersWidth = 51;
            this.itemGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.itemGrid.RowTemplate.Height = 24;
            this.itemGrid.RowTemplate.ReadOnly = true;
            this.itemGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.itemGrid.Size = new System.Drawing.Size(817, 288);
            this.itemGrid.TabIndex = 1;
            // 
            // comboBox
            // 
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Location = new System.Drawing.Point(12, 260);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(234, 24);
            this.comboBox.TabIndex = 2;
            // 
            // ItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(834, 368);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.itemGrid);
            this.Controls.Add(this.itemGrid0);
            this.Name = "ItemForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Товары";
            this.Load += new System.EventHandler(this.ItemForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.itemGrid0)).EndInit();
            this.itemContextMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.itemGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView itemGrid0;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ManufacturerColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceColumn;
        private System.Windows.Forms.ContextMenuStrip itemContextMenu;
        private System.Windows.Forms.ToolStripMenuItem refreshItem;
        private System.Windows.Forms.ToolStripMenuItem addItem;
        private System.Windows.Forms.ToolStripMenuItem updateItem;
        private System.Windows.Forms.ToolStripMenuItem removeItem;
        private System.Windows.Forms.DataGridView itemGrid;
        private System.Windows.Forms.ComboBox comboBox;
    }
}

