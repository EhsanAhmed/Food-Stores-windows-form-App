namespace version1
{
    partial class addCustomer
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnAddCustomer = new Guna.UI2.WinForms.Guna2Button();
            this.customerName_Txt = new Guna.UI2.WinForms.Guna2TextBox();
            this.customerPhone_Txt = new Guna.UI2.WinForms.Guna2TextBox();
            this.customerAddress_Txt = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.validAddress = new System.Windows.Forms.Label();
            this.ValidPhone = new System.Windows.Forms.Label();
            this.validName = new System.Windows.Forms.Label();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(129, 122);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "customer Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(122, 350);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "customer Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(122, 240);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "customer Phone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 149);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 25);
            this.label4.TabIndex = 3;
            // 
            // BtnAddCustomer
            // 
            this.BtnAddCustomer.Animated = true;
            this.BtnAddCustomer.AutoRoundedCorners = true;
            this.BtnAddCustomer.BorderRadius = 30;
            this.BtnAddCustomer.CheckedState.Parent = this.BtnAddCustomer;
            this.BtnAddCustomer.CustomImages.Parent = this.BtnAddCustomer;
            this.BtnAddCustomer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnAddCustomer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnAddCustomer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnAddCustomer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnAddCustomer.DisabledState.Parent = this.BtnAddCustomer;
            this.BtnAddCustomer.FillColor = System.Drawing.Color.Maroon;
            this.BtnAddCustomer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnAddCustomer.ForeColor = System.Drawing.Color.White;
            this.BtnAddCustomer.HoverState.Parent = this.BtnAddCustomer;
            this.BtnAddCustomer.Location = new System.Drawing.Point(260, 438);
            this.BtnAddCustomer.Name = "BtnAddCustomer";
            this.BtnAddCustomer.ShadowDecoration.Parent = this.BtnAddCustomer;
            this.BtnAddCustomer.Size = new System.Drawing.Size(180, 62);
            this.BtnAddCustomer.TabIndex = 11;
            this.BtnAddCustomer.Text = "Add Customer";
            this.BtnAddCustomer.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // customerName_Txt
            // 
            this.customerName_Txt.Animated = true;
            this.customerName_Txt.AutoRoundedCorners = true;
            this.customerName_Txt.BorderColor = System.Drawing.Color.Maroon;
            this.customerName_Txt.BorderRadius = 17;
            this.customerName_Txt.BorderThickness = 2;
            this.customerName_Txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.customerName_Txt.DefaultText = "";
            this.customerName_Txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.customerName_Txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.customerName_Txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.customerName_Txt.DisabledState.Parent = this.customerName_Txt;
            this.customerName_Txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.customerName_Txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.customerName_Txt.FocusedState.Parent = this.customerName_Txt;
            this.customerName_Txt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.customerName_Txt.ForeColor = System.Drawing.Color.Black;
            this.customerName_Txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.customerName_Txt.HoverState.Parent = this.customerName_Txt;
            this.customerName_Txt.Location = new System.Drawing.Point(357, 122);
            this.customerName_Txt.Name = "customerName_Txt";
            this.customerName_Txt.PasswordChar = '\0';
            this.customerName_Txt.PlaceholderText = "Name";
            this.customerName_Txt.SelectedText = "";
            this.customerName_Txt.ShadowDecoration.Parent = this.customerName_Txt;
            this.customerName_Txt.Size = new System.Drawing.Size(200, 36);
            this.customerName_Txt.TabIndex = 12;
            this.customerName_Txt.TextChanged += new System.EventHandler(this.customerName_TextChanged);
            // 
            // customerPhone_Txt
            // 
            this.customerPhone_Txt.Animated = true;
            this.customerPhone_Txt.AutoRoundedCorners = true;
            this.customerPhone_Txt.BorderColor = System.Drawing.Color.Maroon;
            this.customerPhone_Txt.BorderRadius = 17;
            this.customerPhone_Txt.BorderThickness = 2;
            this.customerPhone_Txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.customerPhone_Txt.DefaultText = "";
            this.customerPhone_Txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.customerPhone_Txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.customerPhone_Txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.customerPhone_Txt.DisabledState.Parent = this.customerPhone_Txt;
            this.customerPhone_Txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.customerPhone_Txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.customerPhone_Txt.FocusedState.Parent = this.customerPhone_Txt;
            this.customerPhone_Txt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.customerPhone_Txt.ForeColor = System.Drawing.Color.Black;
            this.customerPhone_Txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.customerPhone_Txt.HoverState.Parent = this.customerPhone_Txt;
            this.customerPhone_Txt.Location = new System.Drawing.Point(358, 229);
            this.customerPhone_Txt.Name = "customerPhone_Txt";
            this.customerPhone_Txt.PasswordChar = '\0';
            this.customerPhone_Txt.PlaceholderText = " Phone";
            this.customerPhone_Txt.SelectedText = "";
            this.customerPhone_Txt.ShadowDecoration.Parent = this.customerPhone_Txt;
            this.customerPhone_Txt.Size = new System.Drawing.Size(200, 36);
            this.customerPhone_Txt.TabIndex = 13;
            this.customerPhone_Txt.TextChanged += new System.EventHandler(this.customerPhone_TextChanged);
            // 
            // customerAddress_Txt
            // 
            this.customerAddress_Txt.Animated = true;
            this.customerAddress_Txt.AutoRoundedCorners = true;
            this.customerAddress_Txt.BorderColor = System.Drawing.Color.Maroon;
            this.customerAddress_Txt.BorderRadius = 17;
            this.customerAddress_Txt.BorderThickness = 2;
            this.customerAddress_Txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.customerAddress_Txt.DefaultText = "";
            this.customerAddress_Txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.customerAddress_Txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.customerAddress_Txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.customerAddress_Txt.DisabledState.Parent = this.customerAddress_Txt;
            this.customerAddress_Txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.customerAddress_Txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.customerAddress_Txt.FocusedState.Parent = this.customerAddress_Txt;
            this.customerAddress_Txt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.customerAddress_Txt.ForeColor = System.Drawing.Color.Black;
            this.customerAddress_Txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.customerAddress_Txt.HoverState.Parent = this.customerAddress_Txt;
            this.customerAddress_Txt.Location = new System.Drawing.Point(357, 339);
            this.customerAddress_Txt.Name = "customerAddress_Txt";
            this.customerAddress_Txt.PasswordChar = '\0';
            this.customerAddress_Txt.PlaceholderText = "Address";
            this.customerAddress_Txt.SelectedText = "";
            this.customerAddress_Txt.ShadowDecoration.Parent = this.customerAddress_Txt;
            this.customerAddress_Txt.Size = new System.Drawing.Size(200, 36);
            this.customerAddress_Txt.TabIndex = 14;
            this.customerAddress_Txt.TextChanged += new System.EventHandler(this.customerAddress_TextChanged);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::version1.Properties.Resources.close;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(609, 42);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(27, 19);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 15;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.Click += new System.EventHandler(this.guna2PictureBox1_Click);
            // 
            // validAddress
            // 
            this.validAddress.AutoSize = true;
            this.validAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validAddress.ForeColor = System.Drawing.Color.Maroon;
            this.validAddress.Location = new System.Drawing.Point(369, 378);
            this.validAddress.Name = "validAddress";
            this.validAddress.Size = new System.Drawing.Size(222, 18);
            this.validAddress.TabIndex = 21;
            this.validAddress.Text = "Address must be more than two ";
            // 
            // ValidPhone
            // 
            this.ValidPhone.AutoSize = true;
            this.ValidPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValidPhone.ForeColor = System.Drawing.Color.Maroon;
            this.ValidPhone.Location = new System.Drawing.Point(369, 268);
            this.ValidPhone.Name = "ValidPhone";
            this.ValidPhone.Size = new System.Drawing.Size(186, 18);
            this.ValidPhone.TabIndex = 22;
            this.ValidPhone.Text = "Phone must be 11 number ";
            // 
            // validName
            // 
            this.validName.AutoSize = true;
            this.validName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validName.ForeColor = System.Drawing.Color.Maroon;
            this.validName.Location = new System.Drawing.Point(369, 161);
            this.validName.Name = "validName";
            this.validName.Size = new System.Drawing.Size(204, 18);
            this.validName.TabIndex = 23;
            this.validName.Text = "Name must be more than two";
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 1D;
            this.guna2BorderlessForm1.DragStartTransparencyValue = 1D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // addCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(699, 567);
            this.Controls.Add(this.validName);
            this.Controls.Add(this.ValidPhone);
            this.Controls.Add(this.validAddress);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.customerAddress_Txt);
            this.Controls.Add(this.customerPhone_Txt);
            this.Controls.Add(this.customerName_Txt);
            this.Controls.Add(this.BtnAddCustomer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "addCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "addCustomer";
            this.Load += new System.EventHandler(this.addCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Button BtnAddCustomer;
        private Guna.UI2.WinForms.Guna2TextBox customerName_Txt;
        private Guna.UI2.WinForms.Guna2TextBox customerPhone_Txt;
        private Guna.UI2.WinForms.Guna2TextBox customerAddress_Txt;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label validAddress;
        private System.Windows.Forms.Label ValidPhone;
        private System.Windows.Forms.Label validName;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
    }
}