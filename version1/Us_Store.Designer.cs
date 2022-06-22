namespace version1
{
    partial class Us_Store
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.storemenu = new Guna.UI2.WinForms.Guna2Panel();
            this.panelStoremenu = new Guna.UI2.WinForms.Guna2Panel();
            this.btnAddStore = new Guna.UI2.WinForms.Guna2Button();
            this.PanelStoreName = new Guna.UI2.WinForms.Guna2Panel();
            this.panelstorebody = new Guna.UI2.WinForms.Guna2Panel();
            this.ShowStoreProductGrid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ComBoxCategory = new Guna.UI2.WinForms.Guna2ComboBox();
            this.ComBoxStores = new Guna.UI2.WinForms.Guna2ComboBox();
            this.AddCategory = new Guna.UI2.WinForms.Guna2Button();
            this.AddProductBtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.storemenu.SuspendLayout();
            this.panelStoremenu.SuspendLayout();
            this.panelstorebody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ShowStoreProductGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // storemenu
            // 
            this.storemenu.Controls.Add(this.panelStoremenu);
            this.storemenu.Controls.Add(this.PanelStoreName);
            this.storemenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.storemenu.Location = new System.Drawing.Point(0, 0);
            this.storemenu.Name = "storemenu";
            this.storemenu.ShadowDecoration.Parent = this.storemenu;
            this.storemenu.Size = new System.Drawing.Size(148, 423);
            this.storemenu.TabIndex = 0;
            // 
            // panelStoremenu
            // 
            this.panelStoremenu.BackColor = System.Drawing.Color.Maroon;
            this.panelStoremenu.Controls.Add(this.guna2Button3);
            this.panelStoremenu.Controls.Add(this.guna2Button2);
            this.panelStoremenu.Controls.Add(this.guna2Button1);
            this.panelStoremenu.Controls.Add(this.btnAddStore);
            this.panelStoremenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelStoremenu.Location = new System.Drawing.Point(0, 47);
            this.panelStoremenu.Name = "panelStoremenu";
            this.panelStoremenu.ShadowDecoration.Parent = this.panelStoremenu;
            this.panelStoremenu.Size = new System.Drawing.Size(148, 376);
            this.panelStoremenu.TabIndex = 1;
            // 
            // btnAddStore
            // 
            this.btnAddStore.Animated = true;
            this.btnAddStore.AutoRoundedCorners = true;
            this.btnAddStore.BorderColor = System.Drawing.Color.White;
            this.btnAddStore.BorderRadius = 23;
            this.btnAddStore.CheckedState.Parent = this.btnAddStore;
            this.btnAddStore.CustomImages.Parent = this.btnAddStore;
            this.btnAddStore.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddStore.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddStore.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddStore.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddStore.DisabledState.Parent = this.btnAddStore;
            this.btnAddStore.FillColor = System.Drawing.Color.White;
            this.btnAddStore.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddStore.ForeColor = System.Drawing.Color.Black;
            this.btnAddStore.HoverState.Parent = this.btnAddStore;
            this.btnAddStore.Location = new System.Drawing.Point(21, 43);
            this.btnAddStore.Name = "btnAddStore";
            this.btnAddStore.ShadowDecoration.Parent = this.btnAddStore;
            this.btnAddStore.Size = new System.Drawing.Size(107, 49);
            this.btnAddStore.TabIndex = 1;
            this.btnAddStore.Text = "Add Store";
            this.btnAddStore.Click += new System.EventHandler(this.btnAddStore_Click);
            // 
            // PanelStoreName
            // 
            this.PanelStoreName.BackColor = System.Drawing.Color.Maroon;
            this.PanelStoreName.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelStoreName.Location = new System.Drawing.Point(0, 0);
            this.PanelStoreName.Name = "PanelStoreName";
            this.PanelStoreName.ShadowDecoration.Parent = this.PanelStoreName;
            this.PanelStoreName.Size = new System.Drawing.Size(148, 47);
            this.PanelStoreName.TabIndex = 0;
            // 
            // panelstorebody
            // 
            this.panelstorebody.BackColor = System.Drawing.Color.White;
            this.panelstorebody.Controls.Add(this.ShowStoreProductGrid);
            this.panelstorebody.Controls.Add(this.ComBoxCategory);
            this.panelstorebody.Controls.Add(this.ComBoxStores);
            this.panelstorebody.Controls.Add(this.AddCategory);
            this.panelstorebody.Controls.Add(this.AddProductBtn);
            this.panelstorebody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelstorebody.Location = new System.Drawing.Point(148, 0);
            this.panelstorebody.Name = "panelstorebody";
            this.panelstorebody.ShadowDecoration.Parent = this.panelstorebody;
            this.panelstorebody.Size = new System.Drawing.Size(623, 423);
            this.panelstorebody.TabIndex = 1;
            this.panelstorebody.Paint += new System.Windows.Forms.PaintEventHandler(this.panelstorebody_Paint);
            // 
            // ShowStoreProductGrid
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.LightSalmon;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            this.ShowStoreProductGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.ShowStoreProductGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ShowStoreProductGrid.BackgroundColor = System.Drawing.Color.White;
            this.ShowStoreProductGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ShowStoreProductGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ShowStoreProductGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Salmon;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Salmon;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ShowStoreProductGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.ShowStoreProductGrid.ColumnHeadersHeight = 30;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ShowStoreProductGrid.DefaultCellStyle = dataGridViewCellStyle9;
            this.ShowStoreProductGrid.EnableHeadersVisualStyles = false;
            this.ShowStoreProductGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ShowStoreProductGrid.Location = new System.Drawing.Point(17, 156);
            this.ShowStoreProductGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ShowStoreProductGrid.Name = "ShowStoreProductGrid";
            this.ShowStoreProductGrid.RowHeadersVisible = false;
            this.ShowStoreProductGrid.RowHeadersWidth = 51;
            this.ShowStoreProductGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ShowStoreProductGrid.Size = new System.Drawing.Size(420, 189);
            this.ShowStoreProductGrid.TabIndex = 11;
            this.ShowStoreProductGrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.ShowStoreProductGrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.ShowStoreProductGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.ShowStoreProductGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.ShowStoreProductGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.ShowStoreProductGrid.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.ShowStoreProductGrid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ShowStoreProductGrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.ShowStoreProductGrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.ShowStoreProductGrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.ShowStoreProductGrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.ShowStoreProductGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.ShowStoreProductGrid.ThemeStyle.HeaderStyle.Height = 30;
            this.ShowStoreProductGrid.ThemeStyle.ReadOnly = false;
            this.ShowStoreProductGrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.ShowStoreProductGrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ShowStoreProductGrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.ShowStoreProductGrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.ShowStoreProductGrid.ThemeStyle.RowsStyle.Height = 22;
            this.ShowStoreProductGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ShowStoreProductGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.ShowStoreProductGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ShowStoreProductGrid_CellContentClick);
            // 
            // ComBoxCategory
            // 
            this.ComBoxCategory.BackColor = System.Drawing.Color.Transparent;
            this.ComBoxCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComBoxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComBoxCategory.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComBoxCategory.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComBoxCategory.FocusedState.Parent = this.ComBoxCategory;
            this.ComBoxCategory.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ComBoxCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.ComBoxCategory.HoverState.Parent = this.ComBoxCategory;
            this.ComBoxCategory.ItemHeight = 30;
            this.ComBoxCategory.ItemsAppearance.Parent = this.ComBoxCategory;
            this.ComBoxCategory.Location = new System.Drawing.Point(40, 70);
            this.ComBoxCategory.Name = "ComBoxCategory";
            this.ComBoxCategory.ShadowDecoration.Parent = this.ComBoxCategory;
            this.ComBoxCategory.Size = new System.Drawing.Size(211, 36);
            this.ComBoxCategory.TabIndex = 10;
            this.ComBoxCategory.SelectedIndexChanged += new System.EventHandler(this.ComBoxCategory_SelectedIndexChanged);
            // 
            // ComBoxStores
            // 
            this.ComBoxStores.BackColor = System.Drawing.Color.Transparent;
            this.ComBoxStores.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComBoxStores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComBoxStores.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComBoxStores.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComBoxStores.FocusedState.Parent = this.ComBoxStores;
            this.ComBoxStores.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ComBoxStores.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.ComBoxStores.HoverState.Parent = this.ComBoxStores;
            this.ComBoxStores.ItemHeight = 30;
            this.ComBoxStores.ItemsAppearance.Parent = this.ComBoxStores;
            this.ComBoxStores.Location = new System.Drawing.Point(339, 70);
            this.ComBoxStores.Name = "ComBoxStores";
            this.ComBoxStores.ShadowDecoration.Parent = this.ComBoxStores;
            this.ComBoxStores.Size = new System.Drawing.Size(211, 36);
            this.ComBoxStores.TabIndex = 7;
            this.ComBoxStores.SelectedIndexChanged += new System.EventHandler(this.ComBoxStores_SelectedIndexChanged);
            // 
            // AddCategory
            // 
            this.AddCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddCategory.Animated = true;
            this.AddCategory.AutoRoundedCorners = true;
            this.AddCategory.BorderColor = System.Drawing.Color.White;
            this.AddCategory.BorderRadius = 18;
            this.AddCategory.CheckedState.Parent = this.AddCategory;
            this.AddCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddCategory.CustomImages.Parent = this.AddCategory;
            this.AddCategory.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AddCategory.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AddCategory.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AddCategory.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AddCategory.DisabledState.Parent = this.AddCategory;
            this.AddCategory.Enabled = false;
            this.AddCategory.FillColor = System.Drawing.Color.Maroon;
            this.AddCategory.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.AddCategory.ForeColor = System.Drawing.Color.White;
            this.AddCategory.HoverState.Parent = this.AddCategory;
            this.AddCategory.Location = new System.Drawing.Point(479, 319);
            this.AddCategory.Name = "AddCategory";
            this.AddCategory.ShadowDecoration.Parent = this.AddCategory;
            this.AddCategory.Size = new System.Drawing.Size(124, 39);
            this.AddCategory.TabIndex = 5;
            this.AddCategory.Text = "Add Category";
            this.AddCategory.Click += new System.EventHandler(this.AddCategory_Click);
            // 
            // AddProductBtn
            // 
            this.AddProductBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddProductBtn.Animated = true;
            this.AddProductBtn.AutoRoundedCorners = true;
            this.AddProductBtn.BorderColor = System.Drawing.Color.Maroon;
            this.AddProductBtn.BorderRadius = 18;
            this.AddProductBtn.CheckedState.Parent = this.AddProductBtn;
            this.AddProductBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddProductBtn.CustomImages.Parent = this.AddProductBtn;
            this.AddProductBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AddProductBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AddProductBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AddProductBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AddProductBtn.DisabledState.Parent = this.AddProductBtn;
            this.AddProductBtn.Enabled = false;
            this.AddProductBtn.FillColor = System.Drawing.Color.Maroon;
            this.AddProductBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.AddProductBtn.ForeColor = System.Drawing.Color.White;
            this.AddProductBtn.HoverState.Parent = this.AddProductBtn;
            this.AddProductBtn.Location = new System.Drawing.Point(479, 364);
            this.AddProductBtn.Name = "AddProductBtn";
            this.AddProductBtn.ShadowDecoration.Parent = this.AddProductBtn;
            this.AddProductBtn.Size = new System.Drawing.Size(124, 39);
            this.AddProductBtn.TabIndex = 6;
            this.AddProductBtn.Text = "Add Product";
            this.AddProductBtn.Click += new System.EventHandler(this.AddProduct_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.Animated = true;
            this.guna2Button1.AutoRoundedCorners = true;
            this.guna2Button1.BorderColor = System.Drawing.Color.White;
            this.guna2Button1.BorderRadius = 23;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.DisabledState.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.White;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.Black;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(21, 128);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(107, 49);
            this.guna2Button1.TabIndex = 2;
            this.guna2Button1.Text = "Edit Store";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click_1);
            // 
            // guna2Button2
            // 
            this.guna2Button2.Animated = true;
            this.guna2Button2.AutoRoundedCorners = true;
            this.guna2Button2.BorderColor = System.Drawing.Color.White;
            this.guna2Button2.BorderRadius = 23;
            this.guna2Button2.CheckedState.Parent = this.guna2Button2;
            this.guna2Button2.CustomImages.Parent = this.guna2Button2;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.DisabledState.Parent = this.guna2Button2;
            this.guna2Button2.FillColor = System.Drawing.Color.White;
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button2.ForeColor = System.Drawing.Color.Black;
            this.guna2Button2.HoverState.Parent = this.guna2Button2;
            this.guna2Button2.Location = new System.Drawing.Point(21, 204);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.ShadowDecoration.Parent = this.guna2Button2;
            this.guna2Button2.Size = new System.Drawing.Size(107, 49);
            this.guna2Button2.TabIndex = 3;
            this.guna2Button2.Text = "Edit Category";
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // guna2Button3
            // 
            this.guna2Button3.Animated = true;
            this.guna2Button3.AutoRoundedCorners = true;
            this.guna2Button3.BorderColor = System.Drawing.Color.White;
            this.guna2Button3.BorderRadius = 23;
            this.guna2Button3.CheckedState.Parent = this.guna2Button3;
            this.guna2Button3.CustomImages.Parent = this.guna2Button3;
            this.guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button3.DisabledState.Parent = this.guna2Button3;
            this.guna2Button3.FillColor = System.Drawing.Color.White;
            this.guna2Button3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button3.ForeColor = System.Drawing.Color.Black;
            this.guna2Button3.HoverState.Parent = this.guna2Button3;
            this.guna2Button3.Location = new System.Drawing.Point(21, 281);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.ShadowDecoration.Parent = this.guna2Button3;
            this.guna2Button3.Size = new System.Drawing.Size(107, 49);
            this.guna2Button3.TabIndex = 4;
            this.guna2Button3.Text = "Edit Product";
            this.guna2Button3.Click += new System.EventHandler(this.guna2Button3_Click);
            // 
            // Us_Store
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.panelstorebody);
            this.Controls.Add(this.storemenu);
            this.Name = "Us_Store";
            this.Size = new System.Drawing.Size(771, 423);
            this.storemenu.ResumeLayout(false);
            this.panelStoremenu.ResumeLayout(false);
            this.panelstorebody.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ShowStoreProductGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel storemenu;
        private Guna.UI2.WinForms.Guna2Panel panelStoremenu;
        private Guna.UI2.WinForms.Guna2Panel PanelStoreName;
        private Guna.UI2.WinForms.Guna2Panel panelstorebody;
        private Guna.UI2.WinForms.Guna2Button btnAddStore;
        private Guna.UI2.WinForms.Guna2Button AddCategory;
        private Guna.UI2.WinForms.Guna2Button AddProductBtn;
        private Guna.UI2.WinForms.Guna2ComboBox ComBoxStores;
        private Guna.UI2.WinForms.Guna2ComboBox ComBoxCategory;
        private Guna.UI2.WinForms.Guna2DataGridView ShowStoreProductGrid;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}
