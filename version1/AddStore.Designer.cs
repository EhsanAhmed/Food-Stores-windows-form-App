namespace version1
{
    partial class AddStore
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
            this.BtnAddNewStore = new Guna.UI2.WinForms.Guna2Button();
            this.StoreName_txt = new Guna.UI2.WinForms.Guna2TextBox();
            this.StoreLocation_txt = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.validName = new System.Windows.Forms.Label();
            this.valiadLocation = new System.Windows.Forms.Label();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(185, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 28);
            this.label2.TabIndex = 7;
            this.label2.Text = "Store Location";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(185, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 28);
            this.label1.TabIndex = 6;
            this.label1.Text = "Store Name";
            // 
            // BtnAddNewStore
            // 
            this.BtnAddNewStore.Animated = true;
            this.BtnAddNewStore.AutoRoundedCorners = true;
            this.BtnAddNewStore.BorderRadius = 25;
            this.BtnAddNewStore.CheckedState.Parent = this.BtnAddNewStore;
            this.BtnAddNewStore.CustomImages.Parent = this.BtnAddNewStore;
            this.BtnAddNewStore.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnAddNewStore.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnAddNewStore.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnAddNewStore.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnAddNewStore.DisabledState.Parent = this.BtnAddNewStore;
            this.BtnAddNewStore.FillColor = System.Drawing.Color.Maroon;
            this.BtnAddNewStore.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnAddNewStore.ForeColor = System.Drawing.Color.White;
            this.BtnAddNewStore.HoverState.Parent = this.BtnAddNewStore;
            this.BtnAddNewStore.Location = new System.Drawing.Point(268, 331);
            this.BtnAddNewStore.Name = "BtnAddNewStore";
            this.BtnAddNewStore.ShadowDecoration.Parent = this.BtnAddNewStore;
            this.BtnAddNewStore.Size = new System.Drawing.Size(191, 52);
            this.BtnAddNewStore.TabIndex = 10;
            this.BtnAddNewStore.Text = "Add New Store";
            this.BtnAddNewStore.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // StoreName_txt
            // 
            this.StoreName_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.StoreName_txt.DefaultText = "";
            this.StoreName_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.StoreName_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.StoreName_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.StoreName_txt.DisabledState.Parent = this.StoreName_txt;
            this.StoreName_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.StoreName_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.StoreName_txt.FocusedState.Parent = this.StoreName_txt;
            this.StoreName_txt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.StoreName_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.StoreName_txt.HoverState.Parent = this.StoreName_txt;
            this.StoreName_txt.Location = new System.Drawing.Point(352, 118);
            this.StoreName_txt.Name = "StoreName_txt";
            this.StoreName_txt.PasswordChar = '\0';
            this.StoreName_txt.PlaceholderText = "";
            this.StoreName_txt.SelectedText = "";
            this.StoreName_txt.ShadowDecoration.Parent = this.StoreName_txt;
            this.StoreName_txt.Size = new System.Drawing.Size(227, 39);
            this.StoreName_txt.TabIndex = 11;
            this.StoreName_txt.TextChanged += new System.EventHandler(this.StoreName_txt_TextChanged);
            // 
            // StoreLocation_txt
            // 
            this.StoreLocation_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.StoreLocation_txt.DefaultText = "";
            this.StoreLocation_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.StoreLocation_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.StoreLocation_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.StoreLocation_txt.DisabledState.Parent = this.StoreLocation_txt;
            this.StoreLocation_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.StoreLocation_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.StoreLocation_txt.FocusedState.Parent = this.StoreLocation_txt;
            this.StoreLocation_txt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.StoreLocation_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.StoreLocation_txt.HoverState.Parent = this.StoreLocation_txt;
            this.StoreLocation_txt.Location = new System.Drawing.Point(352, 235);
            this.StoreLocation_txt.Name = "StoreLocation_txt";
            this.StoreLocation_txt.PasswordChar = '\0';
            this.StoreLocation_txt.PlaceholderText = "";
            this.StoreLocation_txt.SelectedText = "";
            this.StoreLocation_txt.ShadowDecoration.Parent = this.StoreLocation_txt;
            this.StoreLocation_txt.Size = new System.Drawing.Size(227, 39);
            this.StoreLocation_txt.TabIndex = 12;
            this.StoreLocation_txt.TextChanged += new System.EventHandler(this.StoreLocation_txt_TextChanged);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::version1.Properties.Resources.close;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(692, 12);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(30, 26);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 16;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.Click += new System.EventHandler(this.guna2PictureBox1_Click);
            // 
            // validName
            // 
            this.validName.AutoSize = true;
            this.validName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validName.ForeColor = System.Drawing.Color.Maroon;
            this.validName.Location = new System.Drawing.Point(349, 160);
            this.validName.Name = "validName";
            this.validName.Size = new System.Drawing.Size(208, 18);
            this.validName.TabIndex = 17;
            this.validName.Text = "Name must be more than two ";
            // 
            // valiadLocation
            // 
            this.valiadLocation.AutoSize = true;
            this.valiadLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valiadLocation.ForeColor = System.Drawing.Color.Maroon;
            this.valiadLocation.Location = new System.Drawing.Point(349, 277);
            this.valiadLocation.Name = "valiadLocation";
            this.valiadLocation.Size = new System.Drawing.Size(208, 18);
            this.valiadLocation.TabIndex = 18;
            this.valiadLocation.Text = "Name must be more than two ";
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 1D;
            this.guna2BorderlessForm1.DragStartTransparencyValue = 1D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // AddStore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(748, 450);
            this.Controls.Add(this.valiadLocation);
            this.Controls.Add(this.validName);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.StoreLocation_txt);
            this.Controls.Add(this.StoreName_txt);
            this.Controls.Add(this.BtnAddNewStore);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddStore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.FormRegisteration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button BtnAddNewStore;
        private Guna.UI2.WinForms.Guna2TextBox StoreName_txt;
        private Guna.UI2.WinForms.Guna2TextBox StoreLocation_txt;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label validName;
        private System.Windows.Forms.Label valiadLocation;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
    }
}