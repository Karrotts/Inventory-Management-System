using System;
using System.Windows.Forms;
using System.Drawing;

namespace C968
{
    public partial class PartForm : Form
    {
        private bool modify;
        private bool error;
        private Part modifyPart;
        private Color errorColor = Color.FromArgb(231, 90, 90);
        private Color normalColor = Color.FromArgb(255, 255, 255);

        public PartForm(string name)
        {
            InitializeComponent();
            AddPart_Label.Text = name;
            modify = false;
            error = true;
        }

        public PartForm(string name, Part part)
        {
            InitializeComponent();
            modify = true;
            error = true;
            modifyPart = part;
            AddPart_Label.Text = name;
            ID_Box.Text = part.PartID.ToString();
            Name_Box.Text = part.Name;
            Inventory_Box.Text = part.InStock.ToString();
            PriceCost_Box.Text = part.Price.ToString();
            Min_Box.Text = part.Min.ToString();
            Max_Box.Text = part.Max.ToString();

            if (part.GetType() == typeof(Inhouse))
            {
                Outsourced_Radio.Checked = false;
                InHouse_Radio.Checked = true;
                Inhouse inhousePart = (Inhouse)part;
                MachineCompany_Box.Text = inhousePart.MachineID.ToString();
            }
            else
            {
                Outsourced_Radio.Checked = true;
                InHouse_Radio.Checked = false;
                Outsourced outsourcedPart = (Outsourced)part;
                MachineCompany_Box.Text = outsourcedPart.CompanyName;
            }
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

        private void MachineCompany_Box_TextChanged(object sender, EventArgs e)
        {
            if (InHouse_Radio.Checked)
            {
                CheckNumeric(sender, e);
            }
        }

        private void Save_Button_Click(object sender, EventArgs e)
        {
            try
            {
                int min = Int32.Parse(Min_Box.Text);
                int max = Int32.Parse(Max_Box.Text);
                int inventory = Int32.Parse(Inventory_Box.Text);
                decimal price = Decimal.Parse(PriceCost_Box.Text);

                if (InHouse_Radio.Checked)
                {
                    int machineID = Int32.Parse(MachineCompany_Box.Text);
                    if (!modify)
                    {
                        Inhouse part = new Inhouse(Name_Box.Text, price, inventory, min, max, machineID);
                        Inventory.addPart(part);
                        MainScreen.PartsTableController.Add(part.ToStringArray());
                    }
                    else
                    {
                        Inhouse part = new Inhouse(Name_Box.Text, price, inventory, min, max, machineID);
                        Part.count -= 1;
                        part.PartID = modifyPart.PartID;
                        Inventory.updatePart(Int32.Parse(ID_Box.Text), part);
                        MainScreen.PartsTableController.UpdateRow(part.ToStringArray());
                    }
                }
                else
                {
                    if (!modify)
                    {
                        Outsourced part = new Outsourced(Name_Box.Text, price, inventory, min, max, MachineCompany_Box.Text);
                        Inventory.addPart(part);
                        MainScreen.PartsTableController.Add(part.ToStringArray());
                    }
                    else
                    {
                        Outsourced part = new Outsourced(Name_Box.Text, price, inventory, min, max, MachineCompany_Box.Text);
                        Part.count -= 1;
                        part.PartID = modifyPart.PartID;
                        Inventory.updatePart(Int32.Parse(ID_Box.Text), part);
                        MainScreen.PartsTableController.UpdateRow(part.ToStringArray());
                    }
                }
                MainScreen.PartsTableController.Update();
                Close();
            }
            catch
            {
                MessageBox.Show("Unable to parse data, no information was saved.");
            }
        }

        private void InHouse_Radio_CheckedChanged(object sender, EventArgs e)
        {
            MachineCompany_Label.Text = "Machine ID";
        }

        private void Outsourced_Radio_CheckedChanged(object sender, EventArgs e)
        {
            MachineCompany_Label.Text = "Company Name";
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

            if(Min_Box.Text != ""
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
                && PriceCost_Box.Text != ""
                && Min_Box.Text != ""
                && Max_Box.Text != ""
                && MachineCompany_Box.Text != ""
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
            if (inventory < min || inventory > max)
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
    }
}
