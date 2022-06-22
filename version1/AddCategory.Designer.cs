namespace version1
{
    partial class AddCategory
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
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CategoryName = new Guna.UI2.WinForms.Guna2TextBox();
            this.CategoryCode = new Guna.UI2.WinForms.Guna2TextBox();
            this.AddCategoryBtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.validName = new System.Windows.Forms.Label();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(176, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 28);
            this.label2.TabIndex = 12;
            this.label2.Text = "Category Code";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(171, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 28);
            this.label1.TabIndex = 11;
            this.label1.Text = "Category Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // CategoryName
            // 
            this.CategoryName.Animated = true;
            this.CategoryName.AutoRoundedCorners = true;
            this.CategoryName.BorderColor = System.Drawing.Color.Maroon;
            this.CategoryName.BorderRadius = 17;
            this.CategoryName.BorderThickness = 2;
            this.CategoryName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CategoryName.DefaultText = "";
            this.CategoryName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.CategoryName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.CategoryName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CategoryName.DisabledState.Parent = this.CategoryName;
            this.CategoryName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CategoryName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CategoryName.FocusedState.Parent = this.CategoryName;
            this.CategoryName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CategoryName.ForeColor = System.Drawing.Color.Black;
            this.CategoryName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CategoryName.HoverState.Parent = this.CategoryName;
            this.CategoryName.Location = new System.Drawing.Point(381, 118);
            this.CategoryName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CategoryName.Name = "CategoryName";
            this.CategoryName.PasswordChar = '\0';
            this.CategoryName.PlaceholderText = "Name";
            this.CategoryName.SelectedText = "";
            this.CategoryName.ShadowDecoration.Parent = this.CategoryName;
            this.CategoryName.Size = new System.Drawing.Size(200, 36);
            this.CategoryName.TabIndex = 15;
            this.CategoryName.TextChanged += new System.EventHandler(this.CategoryName_TextChanged);
            // 
            // CategoryCode
            // 
            this.CategoryCode.Animated = true;
            this.CategoryCode.AutoRoundedCorners = true;
            this.CategoryCode.BorderColor = System.Drawing.Color.Maroon;
            this.CategoryCode.BorderRadius = 17;
            this.CategoryCode.BorderThickness = 2;
            this.CategoryCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CategoryCode.DefaultText = "";
            this.CategoryCode.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.CategoryCode.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.CategoryCode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CategoryCode.DisabledState.Parent = this.CategoryCode;
            this.CategoryCode.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CategoryCode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CategoryCode.FocusedState.Parent = this.CategoryCode;
            this.CategoryCode.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CategoryCode.ForeColor = System.Drawing.Color.Black;
            this.CategoryCode.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CategoryCode.HoverState.Parent = this.CategoryCode;
            this.CategoryCode.Location = new System.Drawing.Point(381, 211);
            this.CategoryCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CategoryCode.Name = "CategoryCode";
            this.CategoryCode.PasswordChar = '\0';
            this.CategoryCode.PlaceholderText = "Code";
            this.CategoryCode.SelectedText = "";
            this.CategoryCode.ShadowDecoration.Parent = this.CategoryCode;
            this.CategoryCode.Size = new System.Drawing.Size(200, 36);
            this.CategoryCode.TabIndex = 16;
            this.CategoryCode.TextChanged += new System.EventHandler(this.CategoryCode_TextChanged);
            // 
            // AddCategoryBtn
            // 
            this.AddCategoryBtn.Animated = true;
            this.AddCategoryBtn.AutoRoundedCorners = true;
            this.AddCategoryBtn.BorderRadius = 22;
            this.AddCategoryBtn.CheckedState.Parent = this.AddCategoryBtn;
            this.AddCategoryBtn.CustomImages.Parent = this.AddCategoryBtn;
            this.AddCategoryBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AddCategoryBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AddCategoryBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AddCategoryBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AddCategoryBtn.DisabledState.Parent = this.AddCategoryBtn;
            this.AddCategoryBtn.Enabled = false;
            this.AddCategoryBtn.FillColor = System.Drawing.Color.Maroon;
            this.AddCategoryBtn.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCategoryBtn.ForeColor = System.Drawing.Color.White;
            this.AddCategoryBtn.HoverState.Parent = this.AddCategoryBtn;
            this.AddCategoryBtn.Location = new System.Drawing.Point(319, 330);
            this.AddCategoryBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddCategoryBtn.Name = "AddCategoryBtn";
            this.AddCategoryBtn.ShadowDecoration.Parent = this.AddCategoryBtn;
            this.AddCategoryBtn.Size = new System.Drawing.Size(180, 46);
            this.AddCategoryBtn.TabIndex = 17;
            this.AddCategoryBtn.Text = "Add New Category";
            this.AddCategoryBtn.Click += new System.EventHandler(this.AddCategoryBtn_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::version1.Properties.Resources.close;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(742, 16);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(24, 21);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 18;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.Click += new System.EventHandler(this.guna2PictureBox1_Click);
            // 
            // validName
            // 
            this.validName.AutoSize = true;
            this.validName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validName.ForeColor = System.Drawing.Color.Maroon;
            this.validName.Location = new System.Drawing.Point(378, 165);
            this.validName.Name = "validName";
            this.validName.Size = new System.Drawing.Size(208, 18);
            this.validName.TabIndex = 20;
            this.validName.Text = "Name must be more than two ";
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 1D;
            this.guna2BorderlessForm1.DragStartTransparencyValue = 1D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // AddCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.validName);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.AddCategoryBtn);
            this.Controls.Add(this.CategoryCode);
            this.Controls.Add(this.CategoryName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddCategory";
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox CategoryName;
        private Guna.UI2.WinForms.Guna2TextBox CategoryCode;
        private Guna.UI2.WinForms.Guna2Button AddCategoryBtn;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label validName;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
    }
}