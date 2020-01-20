namespace C968
{
    partial class ProductForm
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
            this.CandidateParts_Table = new System.Windows.Forms.DataGridView();
            this.CandidatePartsID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CandidatePartsName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CandidatePartsInventory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CandidatePartsPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CandidatePartsMin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CandidatePartsMax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AssociatedParts_Table = new System.Windows.Forms.DataGridView();
            this.AssociatedPartsID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AssociatedPartsName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AssociatedPartsInventory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AssociatedPartsPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AssociatedPartsMin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AssociatedPartsMax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CandidateParts_Label = new System.Windows.Forms.Label();
            this.AssociatedParts_Label = new System.Windows.Forms.Label();
            this.Add_Button = new System.Windows.Forms.Button();
            this.Delete_Button = new System.Windows.Forms.Button();
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.Save_Button = new System.Windows.Forms.Button();
            this.ID_Box = new System.Windows.Forms.TextBox();
            this.Name_Box = new System.Windows.Forms.TextBox();
            this.Inventory_Box = new System.Windows.Forms.TextBox();
            this.Price_Box = new System.Windows.Forms.TextBox();
            this.Max_Box = new System.Windows.Forms.TextBox();
            this.Min_Box = new System.Windows.Forms.TextBox();
            this.Search_Box = new System.Windows.Forms.TextBox();
            this.Search_Button = new System.Windows.Forms.Button();
            this.Product_Label = new System.Windows.Forms.Label();
            this.ID_Label = new System.Windows.Forms.Label();
            this.Name_Label = new System.Windows.Forms.Label();
            this.Inventory_Label = new System.Windows.Forms.Label();
            this.Price_Label = new System.Windows.Forms.Label();
            this.Max_Label = new System.Windows.Forms.Label();
            this.Min_Label = new System.Windows.Forms.Label();
            this.Error_Message = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CandidateParts_Table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AssociatedParts_Table)).BeginInit();
            this.SuspendLayout();
            // 
            // CandidateParts_Table
            // 
            this.CandidateParts_Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CandidateParts_Table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CandidatePartsID,
            this.CandidatePartsName,
            this.CandidatePartsInventory,
            this.CandidatePartsPrice,
            this.CandidatePartsMin,
            this.CandidatePartsMax});
            this.CandidateParts_Table.Location = new System.Drawing.Point(567, 135);
            this.CandidateParts_Table.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CandidateParts_Table.Name = "CandidateParts_Table";
            this.CandidateParts_Table.RowHeadersWidth = 51;
            this.CandidateParts_Table.Size = new System.Drawing.Size(603, 201);
            this.CandidateParts_Table.TabIndex = 3;
            this.CandidateParts_Table.SelectionChanged += new System.EventHandler(this.CandidateParts_Table_SelectionChanged);
            // 
            // CandidatePartsID
            // 
            this.CandidatePartsID.HeaderText = "Part ID";
            this.CandidatePartsID.MinimumWidth = 6;
            this.CandidatePartsID.Name = "CandidatePartsID";
            this.CandidatePartsID.ReadOnly = true;
            this.CandidatePartsID.Width = 65;
            // 
            // CandidatePartsName
            // 
            this.CandidatePartsName.HeaderText = "Name";
            this.CandidatePartsName.MinimumWidth = 6;
            this.CandidatePartsName.Name = "CandidatePartsName";
            this.CandidatePartsName.ReadOnly = true;
            this.CandidatePartsName.Width = 65;
            // 
            // CandidatePartsInventory
            // 
            this.CandidatePartsInventory.HeaderText = "Inventory";
            this.CandidatePartsInventory.MinimumWidth = 6;
            this.CandidatePartsInventory.Name = "CandidatePartsInventory";
            this.CandidatePartsInventory.ReadOnly = true;
            this.CandidatePartsInventory.Width = 65;
            // 
            // CandidatePartsPrice
            // 
            this.CandidatePartsPrice.HeaderText = "Price";
            this.CandidatePartsPrice.MinimumWidth = 6;
            this.CandidatePartsPrice.Name = "CandidatePartsPrice";
            this.CandidatePartsPrice.ReadOnly = true;
            this.CandidatePartsPrice.Width = 65;
            // 
            // CandidatePartsMin
            // 
            this.CandidatePartsMin.HeaderText = "Min";
            this.CandidatePartsMin.MinimumWidth = 6;
            this.CandidatePartsMin.Name = "CandidatePartsMin";
            this.CandidatePartsMin.ReadOnly = true;
            this.CandidatePartsMin.Width = 65;
            // 
            // CandidatePartsMax
            // 
            this.CandidatePartsMax.HeaderText = "Max";
            this.CandidatePartsMax.MinimumWidth = 6;
            this.CandidatePartsMax.Name = "CandidatePartsMax";
            this.CandidatePartsMax.ReadOnly = true;
            this.CandidatePartsMax.Width = 65;
            // 
            // AssociatedParts_Table
            // 
            this.AssociatedParts_Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AssociatedParts_Table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AssociatedPartsID,
            this.AssociatedPartsName,
            this.AssociatedPartsInventory,
            this.AssociatedPartsPrice,
            this.AssociatedPartsMin,
            this.AssociatedPartsMax});
            this.AssociatedParts_Table.Location = new System.Drawing.Point(567, 436);
            this.AssociatedParts_Table.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AssociatedParts_Table.Name = "AssociatedParts_Table";
            this.AssociatedParts_Table.RowHeadersWidth = 51;
            this.AssociatedParts_Table.Size = new System.Drawing.Size(603, 201);
            this.AssociatedParts_Table.TabIndex = 5;
            this.AssociatedParts_Table.SelectionChanged += new System.EventHandler(this.AssociatedParts_Tabel_SelectionChanged);
            // 
            // AssociatedPartsID
            // 
            this.AssociatedPartsID.HeaderText = "Part ID";
            this.AssociatedPartsID.MinimumWidth = 6;
            this.AssociatedPartsID.Name = "AssociatedPartsID";
            this.AssociatedPartsID.ReadOnly = true;
            this.AssociatedPartsID.Width = 65;
            // 
            // AssociatedPartsName
            // 
            this.AssociatedPartsName.HeaderText = "Name";
            this.AssociatedPartsName.MinimumWidth = 6;
            this.AssociatedPartsName.Name = "AssociatedPartsName";
            this.AssociatedPartsName.ReadOnly = true;
            this.AssociatedPartsName.Width = 65;
            // 
            // AssociatedPartsInventory
            // 
            this.AssociatedPartsInventory.HeaderText = "Inventory";
            this.AssociatedPartsInventory.MinimumWidth = 6;
            this.AssociatedPartsInventory.Name = "AssociatedPartsInventory";
            this.AssociatedPartsInventory.ReadOnly = true;
            this.AssociatedPartsInventory.Width = 65;
            // 
            // AssociatedPartsPrice
            // 
            this.AssociatedPartsPrice.HeaderText = "Price";
            this.AssociatedPartsPrice.MinimumWidth = 6;
            this.AssociatedPartsPrice.Name = "AssociatedPartsPrice";
            this.AssociatedPartsPrice.ReadOnly = true;
            this.AssociatedPartsPrice.Width = 65;
            // 
            // AssociatedPartsMin
            // 
            this.AssociatedPartsMin.HeaderText = "Min";
            this.AssociatedPartsMin.MinimumWidth = 6;
            this.AssociatedPartsMin.Name = "AssociatedPartsMin";
            this.AssociatedPartsMin.ReadOnly = true;
            this.AssociatedPartsMin.Width = 65;
            // 
            // AssociatedPartsMax
            // 
            this.AssociatedPartsMax.HeaderText = "Max";
            this.AssociatedPartsMax.MinimumWidth = 6;
            this.AssociatedPartsMax.Name = "AssociatedPartsMax";
            this.AssociatedPartsMax.ReadOnly = true;
            this.AssociatedPartsMax.Width = 65;
            // 
            // CandidateParts_Label
            // 
            this.CandidateParts_Label.AutoSize = true;
            this.CandidateParts_Label.Location = new System.Drawing.Point(567, 111);
            this.CandidateParts_Label.Name = "CandidateParts_Label";
            this.CandidateParts_Label.Size = new System.Drawing.Size(126, 17);
            this.CandidateParts_Label.TabIndex = 6;
            this.CandidateParts_Label.Text = "All candidate Parts";
            // 
            // AssociatedParts_Label
            // 
            this.AssociatedParts_Label.AutoSize = true;
            this.AssociatedParts_Label.Location = new System.Drawing.Point(567, 412);
            this.AssociatedParts_Label.Name = "AssociatedParts_Label";
            this.AssociatedParts_Label.Size = new System.Drawing.Size(198, 17);
            this.AssociatedParts_Label.TabIndex = 7;
            this.AssociatedParts_Label.Text = "Parts Associated with this Part";
            // 
            // Add_Button
            // 
            this.Add_Button.Enabled = false;
            this.Add_Button.Location = new System.Drawing.Point(1080, 353);
            this.Add_Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Add_Button.Name = "Add_Button";
            this.Add_Button.Size = new System.Drawing.Size(91, 34);
            this.Add_Button.TabIndex = 8;
            this.Add_Button.Text = "Add";
            this.Add_Button.UseVisualStyleBackColor = true;
            this.Add_Button.Click += new System.EventHandler(this.Add_Button_Click);
            // 
            // Delete_Button
            // 
            this.Delete_Button.Enabled = false;
            this.Delete_Button.Location = new System.Drawing.Point(1080, 657);
            this.Delete_Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Delete_Button.Name = "Delete_Button";
            this.Delete_Button.Size = new System.Drawing.Size(91, 34);
            this.Delete_Button.TabIndex = 9;
            this.Delete_Button.Text = "Delete";
            this.Delete_Button.UseVisualStyleBackColor = true;
            this.Delete_Button.Click += new System.EventHandler(this.Delete_Button_Click);
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.Location = new System.Drawing.Point(1080, 721);
            this.Cancel_Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(91, 34);
            this.Cancel_Button.TabIndex = 10;
            this.Cancel_Button.Text = "Cancel";
            this.Cancel_Button.UseVisualStyleBackColor = true;
            this.Cancel_Button.Click += new System.EventHandler(this.Cancel_Button_Click);
            // 
            // Save_Button
            // 
            this.Save_Button.Enabled = false;
            this.Save_Button.Location = new System.Drawing.Point(973, 721);
            this.Save_Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Save_Button.Name = "Save_Button";
            this.Save_Button.Size = new System.Drawing.Size(91, 34);
            this.Save_Button.TabIndex = 11;
            this.Save_Button.Text = "Save";
            this.Save_Button.UseVisualStyleBackColor = true;
            this.Save_Button.Click += new System.EventHandler(this.Save_Button_Click);
            // 
            // ID_Box
            // 
            this.ID_Box.Enabled = false;
            this.ID_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID_Box.Location = new System.Drawing.Point(211, 233);
            this.ID_Box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ID_Box.Name = "ID_Box";
            this.ID_Box.Size = new System.Drawing.Size(191, 30);
            this.ID_Box.TabIndex = 12;
            this.ID_Box.Text = "Auto-Generated";
            // 
            // Name_Box
            // 
            this.Name_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_Box.Location = new System.Drawing.Point(211, 295);
            this.Name_Box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name_Box.Name = "Name_Box";
            this.Name_Box.Size = new System.Drawing.Size(191, 30);
            this.Name_Box.TabIndex = 13;
            // 
            // Inventory_Box
            // 
            this.Inventory_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Inventory_Box.Location = new System.Drawing.Point(211, 357);
            this.Inventory_Box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Inventory_Box.Name = "Inventory_Box";
            this.Inventory_Box.Size = new System.Drawing.Size(191, 30);
            this.Inventory_Box.TabIndex = 14;
            this.Inventory_Box.TextChanged += new System.EventHandler(this.CheckNumeric);
            // 
            // Price_Box
            // 
            this.Price_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Price_Box.Location = new System.Drawing.Point(211, 421);
            this.Price_Box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Price_Box.Name = "Price_Box";
            this.Price_Box.Size = new System.Drawing.Size(191, 30);
            this.Price_Box.TabIndex = 15;
            this.Price_Box.TextChanged += new System.EventHandler(this.CheckDecimal);
            // 
            // Max_Box
            // 
            this.Max_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Max_Box.Location = new System.Drawing.Point(355, 484);
            this.Max_Box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Max_Box.Name = "Max_Box";
            this.Max_Box.Size = new System.Drawing.Size(117, 30);
            this.Max_Box.TabIndex = 17;
            this.Max_Box.TextChanged += new System.EventHandler(this.CheckNumeric);
            // 
            // Min_Box
            // 
            this.Min_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Min_Box.Location = new System.Drawing.Point(141, 484);
            this.Min_Box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Min_Box.Name = "Min_Box";
            this.Min_Box.Size = new System.Drawing.Size(117, 30);
            this.Min_Box.TabIndex = 16;
            this.Min_Box.TextChanged += new System.EventHandler(this.CheckNumeric);
            // 
            // Search_Box
            // 
            this.Search_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_Box.Location = new System.Drawing.Point(979, 78);
            this.Search_Box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Search_Box.Name = "Search_Box";
            this.Search_Box.Size = new System.Drawing.Size(191, 30);
            this.Search_Box.TabIndex = 18;
            // 
            // Search_Button
            // 
            this.Search_Button.Location = new System.Drawing.Point(849, 78);
            this.Search_Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Search_Button.Name = "Search_Button";
            this.Search_Button.Size = new System.Drawing.Size(91, 34);
            this.Search_Button.TabIndex = 19;
            this.Search_Button.Text = "Search";
            this.Search_Button.UseVisualStyleBackColor = true;
            this.Search_Button.Click += new System.EventHandler(this.Search_Button_Click);
            // 
            // Product_Label
            // 
            this.Product_Label.AutoSize = true;
            this.Product_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Product_Label.Location = new System.Drawing.Point(12, 9);
            this.Product_Label.Name = "Product_Label";
            this.Product_Label.Size = new System.Drawing.Size(79, 25);
            this.Product_Label.TabIndex = 20;
            this.Product_Label.Text = "Product";
            // 
            // ID_Label
            // 
            this.ID_Label.AutoSize = true;
            this.ID_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID_Label.Location = new System.Drawing.Point(115, 233);
            this.ID_Label.Name = "ID_Label";
            this.ID_Label.Size = new System.Drawing.Size(27, 24);
            this.ID_Label.TabIndex = 21;
            this.ID_Label.Text = "ID";
            // 
            // Name_Label
            // 
            this.Name_Label.AutoSize = true;
            this.Name_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_Label.Location = new System.Drawing.Point(80, 295);
            this.Name_Label.Name = "Name_Label";
            this.Name_Label.Size = new System.Drawing.Size(61, 24);
            this.Name_Label.TabIndex = 22;
            this.Name_Label.Text = "Name";
            // 
            // Inventory_Label
            // 
            this.Inventory_Label.AutoSize = true;
            this.Inventory_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Inventory_Label.Location = new System.Drawing.Point(55, 357);
            this.Inventory_Label.Name = "Inventory_Label";
            this.Inventory_Label.Size = new System.Drawing.Size(86, 24);
            this.Inventory_Label.TabIndex = 23;
            this.Inventory_Label.Text = "Inventory";
            // 
            // Price_Label
            // 
            this.Price_Label.AutoSize = true;
            this.Price_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Price_Label.Location = new System.Drawing.Point(88, 421);
            this.Price_Label.Name = "Price_Label";
            this.Price_Label.Size = new System.Drawing.Size(53, 24);
            this.Price_Label.TabIndex = 24;
            this.Price_Label.Text = "Price";
            // 
            // Max_Label
            // 
            this.Max_Label.AutoSize = true;
            this.Max_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Max_Label.Location = new System.Drawing.Point(289, 484);
            this.Max_Label.Name = "Max_Label";
            this.Max_Label.Size = new System.Drawing.Size(46, 24);
            this.Max_Label.TabIndex = 25;
            this.Max_Label.Text = "Max";
            // 
            // Min_Label
            // 
            this.Min_Label.AutoSize = true;
            this.Min_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Min_Label.Location = new System.Drawing.Point(80, 484);
            this.Min_Label.Name = "Min_Label";
            this.Min_Label.Size = new System.Drawing.Size(41, 24);
            this.Min_Label.TabIndex = 26;
            this.Min_Label.Text = "Min";
            // 
            // Error_Message
            // 
            this.Error_Message.AutoSize = true;
            this.Error_Message.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Error_Message.ForeColor = System.Drawing.Color.Red;
            this.Error_Message.Location = new System.Drawing.Point(19, 57);
            this.Error_Message.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Error_Message.Name = "Error_Message";
            this.Error_Message.Size = new System.Drawing.Size(0, 17);
            this.Error_Message.TabIndex = 27;
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1268, 783);
            this.Controls.Add(this.Error_Message);
            this.Controls.Add(this.Min_Label);
            this.Controls.Add(this.Max_Label);
            this.Controls.Add(this.Price_Label);
            this.Controls.Add(this.Inventory_Label);
            this.Controls.Add(this.Name_Label);
            this.Controls.Add(this.ID_Label);
            this.Controls.Add(this.Product_Label);
            this.Controls.Add(this.Search_Button);
            this.Controls.Add(this.Search_Box);
            this.Controls.Add(this.Min_Box);
            this.Controls.Add(this.Max_Box);
            this.Controls.Add(this.Price_Box);
            this.Controls.Add(this.Inventory_Box);
            this.Controls.Add(this.Name_Box);
            this.Controls.Add(this.ID_Box);
            this.Controls.Add(this.Save_Button);
            this.Controls.Add(this.Cancel_Button);
            this.Controls.Add(this.Delete_Button);
            this.Controls.Add(this.Add_Button);
            this.Controls.Add(this.AssociatedParts_Label);
            this.Controls.Add(this.CandidateParts_Label);
            this.Controls.Add(this.AssociatedParts_Table);
            this.Controls.Add(this.CandidateParts_Table);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ProductForm";
            this.Text = "Product Form";
            ((System.ComponentModel.ISupportInitialize)(this.CandidateParts_Table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AssociatedParts_Table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView CandidateParts_Table;
        private System.Windows.Forms.DataGridView AssociatedParts_Table;
        private System.Windows.Forms.Label CandidateParts_Label;
        private System.Windows.Forms.Label AssociatedParts_Label;
        private System.Windows.Forms.Button Add_Button;
        private System.Windows.Forms.Button Delete_Button;
        private System.Windows.Forms.Button Cancel_Button;
        private System.Windows.Forms.Button Save_Button;
        private System.Windows.Forms.TextBox ID_Box;
        private System.Windows.Forms.TextBox Name_Box;
        private System.Windows.Forms.TextBox Inventory_Box;
        private System.Windows.Forms.TextBox Price_Box;
        private System.Windows.Forms.TextBox Max_Box;
        private System.Windows.Forms.TextBox Min_Box;
        private System.Windows.Forms.TextBox Search_Box;
        private System.Windows.Forms.Button Search_Button;
        private System.Windows.Forms.Label Product_Label;
        private System.Windows.Forms.Label ID_Label;
        private System.Windows.Forms.Label Name_Label;
        private System.Windows.Forms.Label Inventory_Label;
        private System.Windows.Forms.Label Price_Label;
        private System.Windows.Forms.Label Max_Label;
        private System.Windows.Forms.Label Min_Label;
        private System.Windows.Forms.DataGridViewTextBoxColumn CandidatePartsID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CandidatePartsName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CandidatePartsInventory;
        private System.Windows.Forms.DataGridViewTextBoxColumn CandidatePartsPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn CandidatePartsMin;
        private System.Windows.Forms.DataGridViewTextBoxColumn CandidatePartsMax;
        private System.Windows.Forms.DataGridViewTextBoxColumn AssociatedPartsID;
        private System.Windows.Forms.DataGridViewTextBoxColumn AssociatedPartsName;
        private System.Windows.Forms.DataGridViewTextBoxColumn AssociatedPartsInventory;
        private System.Windows.Forms.DataGridViewTextBoxColumn AssociatedPartsPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn AssociatedPartsMin;
        private System.Windows.Forms.DataGridViewTextBoxColumn AssociatedPartsMax;
        private System.Windows.Forms.Label Error_Message;
    }
}