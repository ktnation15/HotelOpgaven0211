namespace HotelOpgaven0211
{
    partial class Guest
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
            this.GuestNoLbl = new System.Windows.Forms.Label();
            this.NameLbl = new System.Windows.Forms.Label();
            this.AddressLbl = new System.Windows.Forms.Label();
            this.GuestTb = new System.Windows.Forms.Label();
            this.txtGuestNo = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.InsertGuestBtn = new System.Windows.Forms.Button();
            this.UpdateGuestBtn = new System.Windows.Forms.Button();
            this.DeleleGuestBtn = new System.Windows.Forms.Button();
            this.ShowAllGuestBtn = new System.Windows.Forms.Button();
            this.ExitGuestBtn = new System.Windows.Forms.Button();
            this.MenuGuestBtn = new System.Windows.Forms.Button();
            this.FindBarGuest = new System.Windows.Forms.TextBox();
            this.FindGuestBtn = new System.Windows.Forms.Button();
            this.dataGridViewGuest = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGuest)).BeginInit();
            this.SuspendLayout();
            // 
            // GuestNoLbl
            // 
            this.GuestNoLbl.AutoSize = true;
            this.GuestNoLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuestNoLbl.Location = new System.Drawing.Point(46, 53);
            this.GuestNoLbl.Name = "GuestNoLbl";
            this.GuestNoLbl.Size = new System.Drawing.Size(122, 29);
            this.GuestNoLbl.TabIndex = 2;
            this.GuestNoLbl.Text = "Guest No";
            // 
            // NameLbl
            // 
            this.NameLbl.AutoSize = true;
            this.NameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLbl.Location = new System.Drawing.Point(46, 93);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(82, 29);
            this.NameLbl.TabIndex = 3;
            this.NameLbl.Text = "Name";
            // 
            // AddressLbl
            // 
            this.AddressLbl.AutoSize = true;
            this.AddressLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressLbl.Location = new System.Drawing.Point(46, 137);
            this.AddressLbl.Name = "AddressLbl";
            this.AddressLbl.Size = new System.Drawing.Size(109, 29);
            this.AddressLbl.TabIndex = 4;
            this.AddressLbl.Text = "Address";
            // 
            // GuestTb
            // 
            this.GuestTb.AutoSize = true;
            this.GuestTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuestTb.Location = new System.Drawing.Point(635, 9);
            this.GuestTb.Name = "GuestTb";
            this.GuestTb.Size = new System.Drawing.Size(118, 40);
            this.GuestTb.TabIndex = 5;
            this.GuestTb.Text = "Guest";
            // 
            // txtGuestNo
            // 
            this.txtGuestNo.Location = new System.Drawing.Point(174, 53);
            this.txtGuestNo.Name = "txtGuestNo";
            this.txtGuestNo.Size = new System.Drawing.Size(145, 26);
            this.txtGuestNo.TabIndex = 6;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(174, 97);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(145, 26);
            this.txtName.TabIndex = 7;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(174, 141);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(145, 26);
            this.txtAddress.TabIndex = 8;
            // 
            // InsertGuestBtn
            // 
            this.InsertGuestBtn.Location = new System.Drawing.Point(51, 191);
            this.InsertGuestBtn.Name = "InsertGuestBtn";
            this.InsertGuestBtn.Size = new System.Drawing.Size(119, 39);
            this.InsertGuestBtn.TabIndex = 10;
            this.InsertGuestBtn.Text = "Insert";
            this.InsertGuestBtn.UseVisualStyleBackColor = true;
            this.InsertGuestBtn.Click += new System.EventHandler(this.InsertGuestBtn_Click);
            // 
            // UpdateGuestBtn
            // 
            this.UpdateGuestBtn.Location = new System.Drawing.Point(200, 191);
            this.UpdateGuestBtn.Name = "UpdateGuestBtn";
            this.UpdateGuestBtn.Size = new System.Drawing.Size(119, 39);
            this.UpdateGuestBtn.TabIndex = 11;
            this.UpdateGuestBtn.Text = "Update";
            this.UpdateGuestBtn.UseVisualStyleBackColor = true;
            this.UpdateGuestBtn.Click += new System.EventHandler(this.UpdateGuestBtn_Click);
            // 
            // DeleleGuestBtn
            // 
            this.DeleleGuestBtn.Location = new System.Drawing.Point(51, 257);
            this.DeleleGuestBtn.Name = "DeleleGuestBtn";
            this.DeleleGuestBtn.Size = new System.Drawing.Size(119, 39);
            this.DeleleGuestBtn.TabIndex = 12;
            this.DeleleGuestBtn.Text = "Delete";
            this.DeleleGuestBtn.UseVisualStyleBackColor = true;
            this.DeleleGuestBtn.Click += new System.EventHandler(this.DeleleGuestBtn_Click);
            // 
            // ShowAllGuestBtn
            // 
            this.ShowAllGuestBtn.Location = new System.Drawing.Point(200, 257);
            this.ShowAllGuestBtn.Name = "ShowAllGuestBtn";
            this.ShowAllGuestBtn.Size = new System.Drawing.Size(119, 39);
            this.ShowAllGuestBtn.TabIndex = 13;
            this.ShowAllGuestBtn.Text = "Show All";
            this.ShowAllGuestBtn.UseVisualStyleBackColor = true;
            this.ShowAllGuestBtn.Click += new System.EventHandler(this.ShowAllGuestBtn_Click);
            // 
            // ExitGuestBtn
            // 
            this.ExitGuestBtn.Location = new System.Drawing.Point(51, 325);
            this.ExitGuestBtn.Name = "ExitGuestBtn";
            this.ExitGuestBtn.Size = new System.Drawing.Size(119, 39);
            this.ExitGuestBtn.TabIndex = 14;
            this.ExitGuestBtn.Text = "Exit";
            this.ExitGuestBtn.UseVisualStyleBackColor = true;
            this.ExitGuestBtn.Click += new System.EventHandler(this.ExitGuestBtn_Click);
            // 
            // MenuGuestBtn
            // 
            this.MenuGuestBtn.Location = new System.Drawing.Point(200, 325);
            this.MenuGuestBtn.Name = "MenuGuestBtn";
            this.MenuGuestBtn.Size = new System.Drawing.Size(119, 39);
            this.MenuGuestBtn.TabIndex = 15;
            this.MenuGuestBtn.Text = "Menu";
            this.MenuGuestBtn.UseVisualStyleBackColor = true;
            this.MenuGuestBtn.Click += new System.EventHandler(this.MenuGuestBtn_Click);
            // 
            // FindBarGuest
            // 
            this.FindBarGuest.Location = new System.Drawing.Point(336, 57);
            this.FindBarGuest.Name = "FindBarGuest";
            this.FindBarGuest.Size = new System.Drawing.Size(1056, 26);
            this.FindBarGuest.TabIndex = 16;
            // 
            // FindGuestBtn
            // 
            this.FindGuestBtn.Location = new System.Drawing.Point(1409, 43);
            this.FindGuestBtn.Name = "FindGuestBtn";
            this.FindGuestBtn.Size = new System.Drawing.Size(119, 39);
            this.FindGuestBtn.TabIndex = 17;
            this.FindGuestBtn.Text = "Find";
            this.FindGuestBtn.UseVisualStyleBackColor = true;
            this.FindGuestBtn.Click += new System.EventHandler(this.FindGuestBtn_Click);
            // 
            // dataGridViewGuest
            // 
            this.dataGridViewGuest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGuest.Location = new System.Drawing.Point(349, 97);
            this.dataGridViewGuest.Name = "dataGridViewGuest";
            this.dataGridViewGuest.RowHeadersWidth = 62;
            this.dataGridViewGuest.RowTemplate.Height = 28;
            this.dataGridViewGuest.Size = new System.Drawing.Size(1179, 314);
            this.dataGridViewGuest.TabIndex = 18;
            this.dataGridViewGuest.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewGuest_CellContentClick);
            // 
            // Guest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1540, 568);
            this.Controls.Add(this.dataGridViewGuest);
            this.Controls.Add(this.FindGuestBtn);
            this.Controls.Add(this.FindBarGuest);
            this.Controls.Add(this.MenuGuestBtn);
            this.Controls.Add(this.ExitGuestBtn);
            this.Controls.Add(this.ShowAllGuestBtn);
            this.Controls.Add(this.DeleleGuestBtn);
            this.Controls.Add(this.UpdateGuestBtn);
            this.Controls.Add(this.InsertGuestBtn);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtGuestNo);
            this.Controls.Add(this.GuestTb);
            this.Controls.Add(this.AddressLbl);
            this.Controls.Add(this.NameLbl);
            this.Controls.Add(this.GuestNoLbl);
            this.Name = "Guest";
            this.Text = "Guest";
            this.Load += new System.EventHandler(this.Guest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGuest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label GuestNoLbl;
        private System.Windows.Forms.Label NameLbl;
        private System.Windows.Forms.Label AddressLbl;
        private System.Windows.Forms.Label GuestTb;
        private System.Windows.Forms.TextBox txtGuestNo;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Button InsertGuestBtn;
        private System.Windows.Forms.Button UpdateGuestBtn;
        private System.Windows.Forms.Button DeleleGuestBtn;
        private System.Windows.Forms.Button ShowAllGuestBtn;
        private System.Windows.Forms.Button ExitGuestBtn;
        private System.Windows.Forms.Button MenuGuestBtn;
        private System.Windows.Forms.TextBox FindBarGuest;
        private System.Windows.Forms.Button FindGuestBtn;
        private System.Windows.Forms.DataGridView dataGridViewGuest;
    }
}