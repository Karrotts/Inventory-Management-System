namespace C968
{
    partial class MainScreen
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
            this.Main_Label = new System.Windows.Forms.Label();
            this.Parts_Table = new System.Windows.Forms.DataGridView();
            this.PartsPartID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartsName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartsInventory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartsPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartsMin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartsMax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Parts_Label = new System.Windows.Forms.Label();
            this.Parts_Search_Box = new System.Windows.Forms.TextBox();
            this.Parts_Search_Button = new System.Windows.Forms.Button();
            this.Parts_Add_Button = new System.Windows.Forms.Button();
            this.Parts_Modify_Button = new System.Windows.Forms.Button();
            this.Parts_Delete_Button = new System.Windows.Forms.Button();
            this.Products_Delete_Button = new System.Windows.Forms.Button();
            this.Products_Modify_Button = new System.Windows.Forms.Button();
            this.Products_Add_Button = new System.Windows.Forms.Button();
            this.Products_Search_Button = new System.Windows.Forms.Button();
            this.Products_Search_Box = new System.Windows.Forms.TextBox();
            this.Products_Label = new System.Windows.Forms.Label();
            this.Products_Table = new System.Windows.Forms.DataGridView();
            this.ProductsPartID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductsName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductsInventory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductsPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductsMin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductsMax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Exit_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Parts_Table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Products_Table)).BeginInit();
            this.SuspendLayout();
            // 
            // Main_Label
            // 
            this.Main_Label.AutoSize = true;
            this.Main_Label.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Main_Label.Location = new System.Drawing.Point(11, 5);
            this.Main_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Main_Label.Name = "Main_Label";
            this.Main_Label.Size = new System.Drawing.Size(307, 24);
            this.Main_Label.TabIndex = 1;
            this.Main_Label.Text = "Inventory Management System";
            // 
            // Parts_Table
            // 
            this.Parts_Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Parts_Table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PartsPartID,
            this.PartsName,
            this.PartsInventory,
            this.PartsPrice,
            this.PartsMin,
            this.PartsMax});
            this.Parts_Table.Location = new System.Drawing.Point(22, 135);
            this.Parts_Table.Margin = new System.Windows.Forms.Padding(4);
            this.Parts_Table.Name = "Parts_Table";
            this.Parts_Table.RowHeadersWidth = 51;
            this.Parts_Table.Size = new System.Drawing.Size(730, 281);
            this.Parts_Table.TabIndex = 2;
            this.Parts_Table.SelectionChanged += new System.EventHandler(this.Parts_Table_SelectionChanged);
            // 
            // PartsPartID
            // 
            this.PartsPartID.HeaderText = "Part ID";
            this.PartsPartID.MinimumWidth = 6;
            this.PartsPartID.Name = "PartsPartID";
            this.PartsPartID.ReadOnly = true;
            this.PartsPartID.Width = 85;
            // 
            // PartsName
            // 
            this.PartsName.HeaderText = "Name";
            this.PartsName.MinimumWidth = 6;
            this.PartsName.Name = "PartsName";
            this.PartsName.ReadOnly = true;
            this.PartsName.Width = 85;
            // 
            // PartsInventory
            // 
            this.PartsInventory.HeaderText = "Inventory";
            this.PartsInventory.MinimumWidth = 6;
            this.PartsInventory.Name = "PartsInventory";
            this.PartsInventory.ReadOnly = true;
            this.PartsInventory.Width = 85;
            // 
            // PartsPrice
            // 
            this.PartsPrice.HeaderText = "Price";
            this.PartsPrice.MinimumWidth = 6;
            this.PartsPrice.Name = "PartsPrice";
            this.PartsPrice.ReadOnly = true;
            this.PartsPrice.Width = 85;
            // 
            // PartsMin
            // 
            this.PartsMin.HeaderText = "Min";
            this.PartsMin.MinimumWidth = 6;
            this.PartsMin.Name = "PartsMin";
            this.PartsMin.ReadOnly = true;
            this.PartsMin.Width = 85;
            // 
            // PartsMax
            // 
            this.PartsMax.HeaderText = "Max";
            this.PartsMax.MinimumWidth = 6;
            this.PartsMax.Name = "PartsMax";
            this.PartsMax.ReadOnly = true;
            this.PartsMax.Width = 85;
            // 
            // Parts_Label
            // 
            this.Parts_Label.AutoSize = true;
            this.Parts_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Parts_Label.Location = new System.Drawing.Point(17, 106);
            this.Parts_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Parts_Label.Name = "Parts_Label";
            this.Parts_Label.Size = new System.Drawing.Size(57, 25);
            this.Parts_Label.TabIndex = 3;
            this.Parts_Label.Text = "Parts";
            // 
            // Parts_Search_Box
            // 
            this.Parts_Search_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Parts_Search_Box.Location = new System.Drawing.Point(527, 99);
            this.Parts_Search_Box.Margin = new System.Windows.Forms.Padding(4);
            this.Parts_Search_Box.Name = "Parts_Search_Box";
            this.Parts_Search_Box.Size = new System.Drawing.Size(225, 28);
            this.Parts_Search_Box.TabIndex = 4;
            // 
            // Parts_Search_Button
            // 
            this.Parts_Search_Button.Location = new System.Drawing.Point(447, 97);
            this.Parts_Search_Button.Margin = new System.Windows.Forms.Padding(4);
            this.Parts_Search_Button.Name = "Parts_Search_Button";
            this.Parts_Search_Button.Size = new System.Drawing.Size(72, 34);
            this.Parts_Search_Button.TabIndex = 5;
            this.Parts_Search_Button.Text = "Search";
            this.Parts_Search_Button.UseVisualStyleBackColor = true;
            this.Parts_Search_Button.Click += new System.EventHandler(this.Parts_Search_Button_Click);
            // 
            // Parts_Add_Button
            // 
            this.Parts_Add_Button.Location = new System.Drawing.Point(435, 424);
            this.Parts_Add_Button.Margin = new System.Windows.Forms.Padding(4);
            this.Parts_Add_Button.Name = "Parts_Add_Button";
            this.Parts_Add_Button.Size = new System.Drawing.Size(100, 42);
            this.Parts_Add_Button.TabIndex = 6;
            this.Parts_Add_Button.Text = "Add";
            this.Parts_Add_Button.UseVisualStyleBackColor = true;
            this.Parts_Add_Button.Click += new System.EventHandler(this.Parts_Add_Button_Click);
            // 
            // Parts_Modify_Button
            // 
            this.Parts_Modify_Button.Location = new System.Drawing.Point(543, 424);
            this.Parts_Modify_Button.Margin = new System.Windows.Forms.Padding(4);
            this.Parts_Modify_Button.Name = "Parts_Modify_Button";
            this.Parts_Modify_Button.Size = new System.Drawing.Size(100, 42);
            this.Parts_Modify_Button.TabIndex = 7;
            this.Parts_Modify_Button.Text = "Modify";
            this.Parts_Modify_Button.UseVisualStyleBackColor = true;
            this.Parts_Modify_Button.Click += new System.EventHandler(this.Parts_Modify_Button_Click);
            // 
            // Parts_Delete_Button
            // 
            this.Parts_Delete_Button.Location = new System.Drawing.Point(651, 424);
            this.Parts_Delete_Button.Margin = new System.Windows.Forms.Padding(4);
            this.Parts_Delete_Button.Name = "Parts_Delete_Button";
            this.Parts_Delete_Button.Size = new System.Drawing.Size(100, 42);
            this.Parts_Delete_Button.TabIndex = 8;
            this.Parts_Delete_Button.Text = "Delete";
            this.Parts_Delete_Button.UseVisualStyleBackColor = true;
            this.Parts_Delete_Button.Click += new System.EventHandler(this.Parts_Delete_Button_Click);
            // 
            // Products_Delete_Button
            // 
            this.Products_Delete_Button.Enabled = false;
            this.Products_Delete_Button.Location = new System.Drawing.Point(1413, 424);
            this.Products_Delete_Button.Margin = new System.Windows.Forms.Padding(4);
            this.Products_Delete_Button.Name = "Products_Delete_Button";
            this.Products_Delete_Button.Size = new System.Drawing.Size(100, 42);
            this.Products_Delete_Button.TabIndex = 15;
            this.Products_Delete_Button.Text = "Delete";
            this.Products_Delete_Button.UseVisualStyleBackColor = true;
            this.Products_Delete_Button.Click += new System.EventHandler(this.Products_Delete_Button_Click);
            // 
            // Products_Modify_Button
            // 
            this.Products_Modify_Button.Enabled = false;
            this.Products_Modify_Button.Location = new System.Drawing.Point(1305, 424);
            this.Products_Modify_Button.Margin = new System.Windows.Forms.Padding(4);
            this.Products_Modify_Button.Name = "Products_Modify_Button";
            this.Products_Modify_Button.Size = new System.Drawing.Size(100, 42);
            this.Products_Modify_Button.TabIndex = 14;
            this.Products_Modify_Button.Text = "Modify";
            this.Products_Modify_Button.UseVisualStyleBackColor = true;
            this.Products_Modify_Button.Click += new System.EventHandler(this.Products_Modify_Button_Click);
            // 
            // Products_Add_Button
            // 
            this.Products_Add_Button.Location = new System.Drawing.Point(1197, 424);
            this.Products_Add_Button.Margin = new System.Windows.Forms.Padding(4);
            this.Products_Add_Button.Name = "Products_Add_Button";
            this.Products_Add_Button.Size = new System.Drawing.Size(100, 42);
            this.Products_Add_Button.TabIndex = 13;
            this.Products_Add_Button.Text = "Add";
            this.Products_Add_Button.UseVisualStyleBackColor = true;
            this.Products_Add_Button.Click += new System.EventHandler(this.Products_Add_Button_Click);
            // 
            // Products_Search_Button
            // 
            this.Products_Search_Button.Location = new System.Drawing.Point(1212, 97);
            this.Products_Search_Button.Margin = new System.Windows.Forms.Padding(4);
            this.Products_Search_Button.Name = "Products_Search_Button";
            this.Products_Search_Button.Size = new System.Drawing.Size(72, 34);
            this.Products_Search_Button.TabIndex = 12;
            this.Products_Search_Button.Text = "Search";
            this.Products_Search_Button.UseVisualStyleBackColor = true;
            this.Products_Search_Button.Click += new System.EventHandler(this.Products_Search_Button_Click);
            // 
            // Products_Search_Box
            // 
            this.Products_Search_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Products_Search_Box.Location = new System.Drawing.Point(1292, 99);
            this.Products_Search_Box.Margin = new System.Windows.Forms.Padding(4);
            this.Products_Search_Box.Name = "Products_Search_Box";
            this.Products_Search_Box.Size = new System.Drawing.Size(225, 28);
            this.Products_Search_Box.TabIndex = 11;
            // 
            // Products_Label
            // 
            this.Products_Label.AutoSize = true;
            this.Products_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Products_Label.Location = new System.Drawing.Point(780, 106);
            this.Products_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Products_Label.Name = "Products_Label";
            this.Products_Label.Size = new System.Drawing.Size(89, 25);
            this.Products_Label.TabIndex = 10;
            this.Products_Label.Text = "Products";
            // 
            // Products_Table
            // 
            this.Products_Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Products_Table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductsPartID,
            this.ProductsName,
            this.ProductsInventory,
            this.ProductsPrice,
            this.ProductsMin,
            this.ProductsMax});
            this.Products_Table.Location = new System.Drawing.Point(785, 135);
            this.Products_Table.Margin = new System.Windows.Forms.Padding(4);
            this.Products_Table.Name = "Products_Table";
            this.Products_Table.RowHeadersWidth = 51;
            this.Products_Table.Size = new System.Drawing.Size(731, 281);
            this.Products_Table.TabIndex = 9;
            this.Products_Table.SelectionChanged += new System.EventHandler(this.Products_Table_SelectionChanged);
            // 
            // ProductsPartID
            // 
            this.ProductsPartID.HeaderText = "Part ID";
            this.ProductsPartID.MinimumWidth = 6;
            this.ProductsPartID.Name = "ProductsPartID";
            this.ProductsPartID.ReadOnly = true;
            this.ProductsPartID.Width = 85;
            // 
            // ProductsName
            // 
            this.ProductsName.HeaderText = "Name";
            this.ProductsName.MinimumWidth = 6;
            this.ProductsName.Name = "ProductsName";
            this.ProductsName.ReadOnly = true;
            this.ProductsName.Width = 85;
            // 
            // ProductsInventory
            // 
            this.ProductsInventory.HeaderText = "Inventory";
            this.ProductsInventory.MinimumWidth = 6;
            this.ProductsInventory.Name = "ProductsInventory";
            this.ProductsInventory.ReadOnly = true;
            this.ProductsInventory.Width = 85;
            // 
            // ProductsPrice
            // 
            this.ProductsPrice.HeaderText = "Price";
            this.ProductsPrice.MinimumWidth = 6;
            this.ProductsPrice.Name = "ProductsPrice";
            this.ProductsPrice.ReadOnly = true;
            this.ProductsPrice.Width = 85;
            // 
            // ProductsMin
            // 
            this.ProductsMin.HeaderText = "Min";
            this.ProductsMin.MinimumWidth = 6;
            this.ProductsMin.Name = "ProductsMin";
            this.ProductsMin.ReadOnly = true;
            this.ProductsMin.Width = 85;
            // 
            // ProductsMax
            // 
            this.ProductsMax.HeaderText = "Max";
            this.ProductsMax.MinimumWidth = 6;
            this.ProductsMax.Name = "ProductsMax";
            this.ProductsMax.ReadOnly = true;
            this.ProductsMax.Width = 85;
            // 
            // Exit_Button
            // 
            this.Exit_Button.Location = new System.Drawing.Point(1412, 483);
            this.Exit_Button.Margin = new System.Windows.Forms.Padding(4);
            this.Exit_Button.Name = "Exit_Button";
            this.Exit_Button.Size = new System.Drawing.Size(100, 42);
            this.Exit_Button.TabIndex = 16;
            this.Exit_Button.Text = "Exit";
            this.Exit_Button.UseVisualStyleBackColor = true;
            this.Exit_Button.Click += new System.EventHandler(this.Exit_Button_Click);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1585, 534);
            this.Controls.Add(this.Exit_Button);
            this.Controls.Add(this.Products_Delete_Button);
            this.Controls.Add(this.Products_Modify_Button);
            this.Controls.Add(this.Products_Add_Button);
            this.Controls.Add(this.Products_Search_Button);
            this.Controls.Add(this.Products_Search_Box);
            this.Controls.Add(this.Products_Label);
            this.Controls.Add(this.Products_Table);
            this.Controls.Add(this.Parts_Delete_Button);
            this.Controls.Add(this.Parts_Modify_Button);
            this.Controls.Add(this.Parts_Add_Button);
            this.Controls.Add(this.Parts_Search_Button);
            this.Controls.Add(this.Parts_Search_Box);
            this.Controls.Add(this.Parts_Label);
            this.Controls.Add(this.Parts_Table);
            this.Controls.Add(this.Main_Label);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainScreen";
            this.Text = "Main Screen";
            ((System.ComponentModel.ISupportInitialize)(this.Parts_Table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Products_Table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Main_Label;
        private System.Windows.Forms.DataGridView Parts_Table;
        private System.Windows.Forms.Label Parts_Label;
        private System.Windows.Forms.TextBox Parts_Search_Box;
        private System.Windows.Forms.Button Parts_Search_Button;
        private System.Windows.Forms.Button Parts_Add_Button;
        private System.Windows.Forms.Button Parts_Modify_Button;
        private System.Windows.Forms.Button Parts_Delete_Button;
        private System.Windows.Forms.Button Products_Delete_Button;
        private System.Windows.Forms.Button Products_Modify_Button;
        private System.Windows.Forms.Button Products_Add_Button;
        private System.Windows.Forms.Button Products_Search_Button;
        private System.Windows.Forms.TextBox Products_Search_Box;
        private System.Windows.Forms.Label Products_Label;
        private System.Windows.Forms.DataGridView Products_Table;
        private System.Windows.Forms.Button Exit_Button;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartsPartID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartsName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartsInventory;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartsPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartsMin;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartsMax;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductsPartID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductsName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductsInventory;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductsPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductsMin;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductsMax;
    }
}