using System;
using System.Linq;
using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;

namespace C968
{
    public partial class ProductForm : Form
    {
        private bool modify;
        private bool error;
        private Product modifyProduct;
        private BindingList<Part> associatedParts = new BindingList<Part>();
        private static TableController associatedPartsTable;
        private static TableController candidatePartsTable;
        private Color errorColor = Color.FromArgb(231, 90, 90);
        private Color normalColor = Color.FromArgb(255, 255, 255);

        public ProductForm(string name)
        {
            InitializeComponent();
            InitializeTables();

            Product_Label.Text = name;
            modify = false;
        }

        public ProductForm(string name, Product product)
        {
            InitializeComponent();

            //Update form with provided product information
            Product_Label.Text = name;
            modify = true;
            modifyProduct = product;
            associatedParts = product.AssociatedParts;
            Product_Label.Text = name;
            ID_Box.Text = product.ProductID.ToString();
            Name_Box.Text = product.Name;
            Inventory_Box.Text = product.InStock.ToString();
            Price_Box.Text = product.Price.ToString();
            Min_Box.Text = product.Min.ToString();
            Max_Box.Text = product.Max.ToString();

            InitializeTables();
        }

        private void CheckNumeric(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            try
            {
                ErrorMessage(tb, false, normalColor, "");
                if (tb.Text != "")
                {
                    Int32.Parse(tb.Text);
                }
                else
                {
                    ErrorMessage(tb, true, errorColor, "Error: Expected value.");
                }
                CheckSaveable();
            }
            catch
            {
                ErrorMessage(tb, true, errorColor, "Error: Non-numeric character in numeric only field.");
                tb.BackColor = errorColor;
            }
        }

        private void CheckDecimal(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            try
            {
                ErrorMessage(tb, false, normalColor, "");
                if (tb.Text != "")
                {
                    Decimal.Parse(tb.Text);
                }
                else
                {
                    ErrorMessage(tb, true, errorColor, "Error: Expected value.");
                }
                CheckSaveable();
            }
            catch
            {
                ErrorMessage(tb, true, errorColor, "Error: Non-numeric character in numeric only field.");
                tb.BackColor = errorColor;
            }
        }

        private void Save_Button_Click(object sender, EventArgs e)
        {
            int min = 0;
            int max = 0;
            int inventory = 0;
            decimal price = 0;

            try
            {
                min = Int32.Parse(Min_Box.Text);
                max = Int32.Parse(Max_Box.Text);
                inventory = Int32.Parse(Inventory_Box.Text);
                price = Decimal.Parse(Price_Box.Text);

                if (!modify)
                {
                    //Create new product
                    Product product = new Product(Name_Box.Text, price, inventory, min, max, associatedParts);
                    Inventory.addProduct(product);
                    MainScreen.ProductsTableController.Add(product.ToStringArray());
                }
                else
                {
                    //Modify current product
                    modifyProduct.Name = Name_Box.Text;
                    modifyProduct.Price = price;
                    modifyProduct.InStock = inventory;
                    modifyProduct.Min = min;
                    modifyProduct.Max = max;
                    modifyProduct.AssociatedParts = associatedParts;
                    Inventory.updateProduct(modifyProduct.ProductID, modifyProduct);
                    MainScreen.ProductsTableController.UpdateRow(modifyProduct.ToStringArray());
                }
            }
            catch
            {
                MessageBox.Show("Unable to parse data, no information was saved.");
            }

            MainScreen.ProductsTableController.Update();
            Close();
        }

        private void Add_Button_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(candidatePartsTable.table.Rows[candidatePartsTable.table.CurrentCell.RowIndex].Cells[0].Value.ToString());
            associatedParts.Add(Inventory.lookupPart(id));
            associatedPartsTable.Add(Inventory.lookupPart(id).ToStringArray());
            associatedPartsTable.Update();
            Add_Button.Enabled = false;
        }

        private void Delete_Button_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure your want to remove the part?","Remove Part", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                int id = Int32.Parse(associatedPartsTable.table.Rows[associatedPartsTable.table.CurrentCell.RowIndex].Cells[0].Value.ToString());
                associatedParts.Remove(associatedParts.SingleOrDefault(p => p.PartID == id));
                associatedPartsTable.Remove(id);
                associatedPartsTable.Update();
                Delete_Button.Enabled = false;
                MessageBox.Show("Part removed!", "Remove Part");
            }
        }

        private void Search_Button_Click(object sender, EventArgs e)
        {
            string search = Search_Box.Text;
            Int32.TryParse(search, out int searchNum);
            if (candidatePartsTable.table.Rows.Count > 1)
            {
                if (searchNum == 0)
                {
                    for (int i = 0; i < candidatePartsTable.table.Rows.Count - 1; i++)
                    {
                        if (string.Compare(candidatePartsTable.table.Rows[i].Cells[1].Value.ToString().ToLower(), search.ToLower()) == 0)
                        {
                            candidatePartsTable.table.Rows[i].Selected = true;
                            break;
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < candidatePartsTable.table.Rows.Count - 1; i++)
                    {
                        if (Int32.Parse(candidatePartsTable.table.Rows[i].Cells[0].Value.ToString()) == searchNum)
                        {
                            candidatePartsTable.table.Rows[i].Selected = true;
                            break;
                        }
                    }
                }
            }
        }

        private void CandidateParts_Table_SelectionChanged(object sender, EventArgs e)
        {
            if (candidatePartsTable.table.Rows[candidatePartsTable.table.CurrentCell.RowIndex].Cells[0].Value != null)
                Add_Button.Enabled = true;
            else Add_Button.Enabled = false;
        }

        private void AssociatedParts_Tabel_SelectionChanged(object sender, EventArgs e)
        {
            if (associatedPartsTable.table.Rows[associatedPartsTable.table.CurrentCell.RowIndex].Cells[0].Value != null)
                Delete_Button.Enabled = true;
            else Delete_Button.Enabled = false;
        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CheckSaveable()
        {
            int min = 0;
            int max = 0;
            int inventory = 0;
            bool checkedRangeInventory = false;

            if (Min_Box.Text != ""
               && Max_Box.Text != "")
            {
                min = Int32.Parse(Min_Box.Text);
                max = Int32.Parse(Max_Box.Text);
                checkedRangeInventory = CheckRange(min, max);
            }

            if (Min_Box.Text != ""
               && Max_Box.Text != ""
               && Inventory_Box.Text != "")
            {
                inventory = Int32.Parse(Inventory_Box.Text);
                checkedRangeInventory = CheckInventory(min, max, inventory);
            }

            if (!error
                && Name_Box.Text != ""
                && Inventory_Box.Text != ""
                && Price_Box.Text != ""
                && Min_Box.Text != ""
                && Max_Box.Text != ""
                && checkedRangeInventory)
            {
                Save_Button.Enabled = true;
            }
            else
            {
                Save_Button.Enabled = false;
            }
        }

        private bool CheckRange(int min, int max)
        {
            if (min >= max)
            {
                ErrorMessage(Min_Box, true, errorColor);
                ErrorMessage(Max_Box, true, errorColor, "Error: Min is greater than or equal to Max.");
                return false;
            }
            else
            {
                ErrorMessage(Min_Box, false, normalColor);
                ErrorMessage(Max_Box, false, normalColor, "");
                return false;
            }
        }

        private bool CheckInventory(int min, int max, int inventory)
        {
            if (inventory < min
                || inventory > max)
            {
                ErrorMessage(Inventory_Box, true, errorColor, "Error: Inventory is out of range.");
                return false;
            }
            else
            {
                ErrorMessage(Inventory_Box, false, normalColor, "");
                return true;
            }
        }

        private void ErrorMessage(TextBox tb, bool error, Color color)
        {
            tb.BackColor = color;
            this.error = error;
        }

        private void ErrorMessage(TextBox tb, bool error, Color color, string message)
        {
            Error_Message.Text = message;
            tb.BackColor = color;
            this.error = error;
        }

        private void InitializeTables()
        {
            associatedPartsTable = new TableController(AssociatedParts_Table);
            candidatePartsTable = new TableController(CandidateParts_Table);

            //Add candidate parts to table 
            foreach(Part p in Inventory.AllParts)
            {
                candidatePartsTable.Add(p.ToStringArray());
            }

            //Add associated parts to table
            foreach(Part p in associatedParts)
            {
                associatedPartsTable.Add(p.ToStringArray());
            }

            //update table to display information
            associatedPartsTable.Update();
            candidatePartsTable.Update();
        }
    }
}
