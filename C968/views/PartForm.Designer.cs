namespace C968
{
    partial class PartForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AddPart_Label = new System.Windows.Forms.Label();
            this.InHouse_Radio = new System.Windows.Forms.RadioButton();
            this.Outsourced_Radio = new System.Windows.Forms.RadioButton();
            this.ID_Box = new System.Windows.Forms.TextBox();
            this.Name_Box = new System.Windows.Forms.TextBox();
            this.Inventory_Box = new System.Windows.Forms.TextBox();
            this.Min_Box = new System.Windows.Forms.TextBox();
            this.Max_Box = new System.Windows.Forms.TextBox();
            this.MachineCompany_Box = new System.Windows.Forms.TextBox();
            this.ID_Label = new System.Windows.Forms.Label();
            this.Name_Label = new System.Windows.Forms.Label();
            this.Inventory_Label = new System.Windows.Forms.Label();
            this.PriceCost_Label = new System.Windows.Forms.Label();
            this.Min_Label = new System.Windows.Forms.Label();
            this.Max_Label = new System.Windows.Forms.Label();
            this.MachineCompany_Label = new System.Windows.Forms.Label();
            this.Save_Button = new System.Windows.Forms.Button();
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.Error_Message = new System.Windows.Forms.Label();
            this.PriceCost_Box = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // AddPart_Label
            // 
            this.AddPart_Label.AutoSize = true;
            this.AddPart_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddPart_Label.Location = new System.Drawing.Point(10, 11);
            this.AddPart_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AddPart_Label.Name = "AddPart_Label";
            this.AddPart_Label.Size = new System.Drawing.Size(88, 25);
            this.AddPart_Label.TabIndex = 0;
            this.AddPart_Label.Text = "Add Part";
            // 
            // InHouse_Radio
            // 
            this.InHouse_Radio.AutoSize = true;
            this.InHouse_Radio.Location = new System.Drawing.Point(136, 15);
            this.InHouse_Radio.Margin = new System.Windows.Forms.Padding(2);
            this.InHouse_Radio.Name = "InHouse_Radio";
            this.InHouse_Radio.Size = new System.Drawing.Size(78, 19);
            this.InHouse_Radio.TabIndex = 1;
            this.InHouse_Radio.TabStop = true;
            this.InHouse_Radio.Text = "In-House";
            this.InHouse_Radio.UseVisualStyleBackColor = true;
            this.InHouse_Radio.CheckedChanged += new System.EventHandler(this.InHouse_Radio_CheckedChanged);
            // 
            // Outsourced_Radio
            // 
            this.Outsourced_Radio.AutoSize = true;
            this.Outsourced_Radio.Location = new System.Drawing.Point(224, 15);
            this.Outsourced_Radio.Margin = new System.Windows.Forms.Padding(2);
            this.Outsourced_Radio.Name = "Outsourced_Radio";
            this.Outsourced_Radio.Size = new System.Drawing.Size(91, 19);
            this.Outsourced_Radio.TabIndex = 2;
            this.Outsourced_Radio.TabStop = true;
            this.Outsourced_Radio.Text = "Outsourced";
            this.Outsourced_Radio.UseVisualStyleBackColor = true;
            this.Outsourced_Radio.CheckedChanged += new System.EventHandler(this.Outsourced_Radio_CheckedChanged);
            // 
            // ID_Box
            // 
            this.ID_Box.Enabled = false;
            this.ID_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID_Box.Location = new System.Drawing.Point(136, 63);
            this.ID_Box.Margin = new System.Windows.Forms.Padding(2);
            this.ID_Box.Name = "ID_Box";
            this.ID_Box.Size = new System.Drawing.Size(166, 30);
            this.ID_Box.TabIndex = 3;
            this.ID_Box.Text = "Auto-Generated";
            // 
            // Name_Box
            // 
            this.Name_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_Box.Location = new System.Drawing.Point(136, 112);
            this.Name_Box.Margin = new System.Windows.Forms.Padding(2);
            this.Name_Box.Name = "Name_Box";
            this.Name_Box.Size = new System.Drawing.Size(166, 30);
            this.Name_Box.TabIndex = 4;
            // 
            // Inventory_Box
            // 
            this.Inventory_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Inventory_Box.Location = new System.Drawing.Point(136, 159);
            this.Inventory_Box.Margin = new System.Windows.Forms.Padding(2);
            this.Inventory_Box.Name = "Inventory_Box";
            this.Inventory_Box.Size = new System.Drawing.Size(166, 30);
            this.Inventory_Box.TabIndex = 5;
            this.Inventory_Box.TextChanged += new System.EventHandler(this.CheckNumeric);
            // 
            // Min_Box
            // 
            this.Min_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Min_Box.Location = new System.Drawing.Point(136, 254);
            this.Min_Box.Margin = new System.Windows.Forms.Padding(2);
            this.Min_Box.Name = "Min_Box";
            this.Min_Box.Size = new System.Drawing.Size(71, 30);
            this.Min_Box.TabIndex = 7;
            this.Min_Box.TextChanged += new System.EventHandler(this.CheckNumeric);
            // 
            // Max_Box
            // 
            this.Max_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Max_Box.Location = new System.Drawing.Point(265, 254);
            this.Max_Box.Margin = new System.Windows.Forms.Padding(2);
            this.Max_Box.Name = "Max_Box";
            this.Max_Box.Size = new System.Drawing.Size(71, 30);
            this.Max_Box.TabIndex = 8;
            this.Max_Box.TextChanged += new System.EventHandler(this.CheckNumeric);
            // 
            // MachineCompany_Box
            // 
            this.MachineCompany_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MachineCompany_Box.Location = new System.Drawing.Point(136, 301);
            this.MachineCompany_Box.Margin = new System.Windows.Forms.Padding(2);
            this.MachineCompany_Box.Name = "MachineCompany_Box";
            this.MachineCompany_Box.Size = new System.Drawing.Size(166, 30);
            this.MachineCompany_Box.TabIndex = 9;
            this.MachineCompany_Box.TextChanged += new System.EventHandler(this.MachineCompany_Box_TextChanged);
            // 
            // ID_Label
            // 
            this.ID_Label.AutoSize = true;
            this.ID_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID_Label.Location = new System.Drawing.Point(92, 63);
            this.ID_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ID_Label.Name = "ID_Label";
            this.ID_Label.Size = new System.Drawing.Size(26, 20);
            this.ID_Label.TabIndex = 10;
            this.ID_Label.Text = "ID";
            // 
            // Name_Label
            // 
            this.Name_Label.AutoSize = true;
            this.Name_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_Label.Location = new System.Drawing.Point(72, 112);
            this.Name_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Name_Label.Name = "Name_Label";
            this.Name_Label.Size = new System.Drawing.Size(53, 20);
            this.Name_Label.TabIndex = 11;
            this.Name_Label.Text = "Name";
            // 
            // Inventory_Label
            // 
            this.Inventory_Label.AutoSize = true;
            this.Inventory_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Inventory_Label.Location = new System.Drawing.Point(55, 159);
            this.Inventory_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Inventory_Label.Name = "Inventory_Label";
            this.Inventory_Label.Size = new System.Drawing.Size(76, 20);
            this.Inventory_Label.TabIndex = 12;
            this.Inventory_Label.Text = "Inventory";
            // 
            // PriceCost_Label
            // 
            this.PriceCost_Label.AutoSize = true;
            this.PriceCost_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceCost_Label.Location = new System.Drawing.Point(38, 212);
            this.PriceCost_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PriceCost_Label.Name = "PriceCost_Label";
            this.PriceCost_Label.Size = new System.Drawing.Size(98, 20);
            this.PriceCost_Label.TabIndex = 13;
            this.PriceCost_Label.Text = "Price / Cost";
            // 
            // Min_Label
            // 
            this.Min_Label.AutoSize = true;
            this.Min_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Min_Label.Location = new System.Drawing.Point(85, 254);
            this.Min_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Min_Label.Name = "Min_Label";
            this.Min_Label.Size = new System.Drawing.Size(36, 20);
            this.Min_Label.TabIndex = 14;
            this.Min_Label.Text = "Min";
            // 
            // Max_Label
            // 
            this.Max_Label.AutoSize = true;
            this.Max_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Max_Label.Location = new System.Drawing.Point(220, 254);
            this.Max_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Max_Label.Name = "Max_Label";
            this.Max_Label.Size = new System.Drawing.Size(40, 20);
            this.Max_Label.TabIndex = 15;
            this.Max_Label.Text = "Max";
            // 
            // MachineCompany_Label
            // 
            this.MachineCompany_Label.AutoSize = true;
            this.MachineCompany_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MachineCompany_Label.Location = new System.Drawing.Point(16, 301);
            this.MachineCompany_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MachineCompany_Label.Name = "MachineCompany_Label";
            this.MachineCompany_Label.Size = new System.Drawing.Size(94, 20);
            this.MachineCompany_Label.TabIndex = 16;
            this.MachineCompany_Label.Text = "Machine ID";
            // 
            // Save_Button
            // 
            this.Save_Button.Enabled = false;
            this.Save_Button.Location = new System.Drawing.Point(244, 344);
            this.Save_Button.Margin = new System.Windows.Forms.Padding(2);
            this.Save_Button.Name = "Save_Button";
            this.Save_Button.Size = new System.Drawing.Size(56, 26);
            this.Save_Button.TabIndex = 17;
            this.Save_Button.Text = "Save";
            this.Save_Button.UseVisualStyleBackColor = true;
            this.Save_Button.Click += new System.EventHandler(this.Save_Button_Click);
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.Location = new System.Drawing.Point(313, 344);
            this.Cancel_Button.Margin = new System.Windows.Forms.Padding(2);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(56, 26);
            this.Cancel_Button.TabIndex = 18;
            this.Cancel_Button.Text = "Cancel";
            this.Cancel_Button.UseVisualStyleBackColor = true;
            this.Cancel_Button.Click += new System.EventHandler(this.Cancel_Button_Click);
            // 
            // Error_Message
            // 
            this.Error_Message.AutoSize = true;
            this.Error_Message.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Error_Message.ForeColor = System.Drawing.Color.Red;
            this.Error_Message.Location = new System.Drawing.Point(29, 41);
            this.Error_Message.Name = "Error_Message";
            this.Error_Message.Size = new System.Drawing.Size(0, 15);
            this.Error_Message.TabIndex = 19;
            // 
            // PriceCost_Box
            // 
            this.PriceCost_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceCost_Box.Location = new System.Drawing.Point(136, 205);
            this.PriceCost_Box.Name = "PriceCost_Box";
            this.PriceCost_Box.Size = new System.Drawing.Size(166, 30);
            this.PriceCost_Box.TabIndex = 6;
            this.PriceCost_Box.TextChanged += new System.EventHandler(this.CheckDecimal);
            // 
            // PartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 387);
            this.Controls.Add(this.PriceCost_Box);
            this.Controls.Add(this.Error_Message);
            this.Controls.Add(this.Cancel_Button);
            this.Controls.Add(this.Save_Button);
            this.Controls.Add(this.MachineCompany_Label);
            this.Controls.Add(this.Max_Label);
            this.Controls.Add(this.Min_Label);
            this.Controls.Add(this.PriceCost_Label);
            this.Controls.Add(this.Inventory_Label);
            this.Controls.Add(this.Name_Label);
            this.Controls.Add(this.ID_Label);
            this.Controls.Add(this.MachineCompany_Box);
            this.Controls.Add(this.Max_Box);
            this.Controls.Add(this.Min_Box);
            this.Controls.Add(this.Inventory_Box);
            this.Controls.Add(this.Name_Box);
            this.Controls.Add(this.ID_Box);
            this.Controls.Add(this.Outsourced_Radio);
            this.Controls.Add(this.InHouse_Radio);
            this.Controls.Add(this.AddPart_Label);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PartForm";
            this.Text = "Add Part";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AddPart_Label;
        private System.Windows.Forms.RadioButton InHouse_Radio;
        private System.Windows.Forms.RadioButton Outsourced_Radio;
        private System.Windows.Forms.TextBox ID_Box;
        private System.Windows.Forms.TextBox Name_Box;
        private System.Windows.Forms.TextBox Inventory_Box;
        private System.Windows.Forms.TextBox Min_Box;
        private System.Windows.Forms.TextBox Max_Box;
        private System.Windows.Forms.TextBox MachineCompany_Box;
        private System.Windows.Forms.Label ID_Label;
        private System.Windows.Forms.Label Name_Label;
        private System.Windows.Forms.Label Inventory_Label;
        private System.Windows.Forms.Label PriceCost_Label;
        private System.Windows.Forms.Label Min_Label;
        private System.Windows.Forms.Label Max_Label;
        private System.Windows.Forms.Label MachineCompany_Label;
        private System.Windows.Forms.Button Save_Button;
        private System.Windows.Forms.Button Cancel_Button;
        private System.Windows.Forms.Label Error_Message;
        private System.Windows.Forms.TextBox PriceCost_Box;
    }
}