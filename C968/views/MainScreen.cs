using System;
using System.Windows.Forms;

namespace C968
{
    public partial class MainScreen : Form
    {
        public static TableController PartsTableController;
        public static TableController ProductsTableController;

        public MainScreen()
        {
            InitializeComponent();
            PartsTableController = new TableController(Parts_Table);
            ProductsTableController = new TableController(Products_Table);
        }

        private void Parts_Add_Button_Click(object sender, EventArgs e)
        {
            PartForm addPart = new PartForm("Add Part");
            addPart.Show();
        }

        private void Parts_Modify_Button_Click(object sender, EventArgs e)
        {
            PartForm modifyPart = new PartForm("Modify Part", Inventory.lookupPart(Int32.Parse(PartsTableController.table.Rows[PartsTableController.table.CurrentCell.RowIndex].Cells[0].Value.ToString())));
            modifyPart.Show();
            Parts_Delete_Button.Enabled = false;
            Parts_Modify_Button.Enabled = false;
        }

        private void Parts_Delete_Button_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to delete this part?", "Delete Part", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                int id = Int32.Parse(PartsTableController.table.Rows[PartsTableController.table.CurrentCell.RowIndex].Cells[0].Value.ToString());

                //Delete part from inventory and remove part from table
                Inventory.deletePart(Inventory.lookupPart(id));
                PartsTableController.Remove(id);

                //Disable the parts delete/modify buttons since the part is no longer selected
                Parts_Delete_Button.Enabled = false;
                Parts_Modify_Button.Enabled = false;

                MessageBox.Show("Part deleted!", "Delete Part");
            }
        }

        private void Parts_Search_Button_Click(object sender, EventArgs e)
        {
            PartsTableController.Search(Parts_Search_Box.Text);
        }

        private void Parts_Table_SelectionChanged(object sender, EventArgs e)
        {
            if (PartsTableController.table.Rows[PartsTableController.table.CurrentCell.RowIndex].Cells[0].Value != null)
            {
                Parts_Modify_Button.Enabled = true;
                Parts_Delete_Button.Enabled = true;
            }
            else
            {
                Parts_Modify_Button.Enabled = false;
                Parts_Delete_Button.Enabled = false;
            }
        }

        private void Products_Add_Button_Click(object sender, EventArgs e)
        {
            ProductForm addProduct = new ProductForm("Add Product");
            addProduct.Show();
        }

        private void Products_Modify_Button_Click(object sender, EventArgs e)
        {
            ProductForm modifyProduct = new ProductForm("Modify Product", Inventory.lookupProduct(Int32.Parse(ProductsTableController.table.Rows[ProductsTableController.table.CurrentCell.RowIndex].Cells[0].Value.ToString())));
            modifyProduct.Show();
            Products_Delete_Button.Enabled = false;
            Products_Modify_Button.Enabled = false;
        }

        private void Products_Delete_Button_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to delete this product?", "Delete Product", MessageBoxButtons.YesNo);
            if(result == DialogResult.Yes)
            {
                int id = Int32.Parse(ProductsTableController.table.Rows[ProductsTableController.table.CurrentCell.RowIndex].Cells[0].Value.ToString());
                Product product = Inventory.lookupProduct(id);
                if (product.AssociatedParts.Count == 0)
                {
                    //Deletes product and removes item from table
                    Inventory.removeProduct(id);
                    ProductsTableController.Remove(id);

                    //Disables delete and modify buttons since the part is no longer selected
                    Products_Delete_Button.Enabled = false;
                    Products_Modify_Button.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Unable to delete product. Product still has parts associated with it.");
                }
            }
        }

        private void Products_Search_Button_Click(object sender, EventArgs e)
        {
            ProductsTableController.Search(Products_Search_Box.Text);
        }

        private void Products_Table_SelectionChanged(object sender, EventArgs e)
        {
            if (ProductsTableController.table.Rows[ProductsTableController.table.CurrentCell.RowIndex].Cells[0].Value != null)
            {
                Products_Modify_Button.Enabled = true;
                Products_Delete_Button.Enabled = true;
            }
            else
            {
                Products_Modify_Button.Enabled = false;
                Products_Delete_Button.Enabled = false;
            }
        }

        private void Exit_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
