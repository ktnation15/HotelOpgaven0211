namespace HotelOpgaven0211
{
    partial class Hotel
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
            this.HotelTb = new System.Windows.Forms.Label();
            this.HotelHotelNoLbl = new System.Windows.Forms.Label();
            this.HotelNameLbl = new System.Windows.Forms.Label();
            this.HotelAddressLbl = new System.Windows.Forms.Label();
            this.txtHotelNo = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.InsertHotelBtn = new System.Windows.Forms.Button();
            this.UpdateHotelBtn = new System.Windows.Forms.Button();
            this.DeleteHotelBtn = new System.Windows.Forms.Button();
            this.ShowAllHotelBtn = new System.Windows.Forms.Button();
            this.ExitHotelBtn = new System.Windows.Forms.Button();
            this.MenuHotelBtn = new System.Windows.Forms.Button();
            this.FindBarHotel = new System.Windows.Forms.TextBox();
            this.FindHotelBtn = new System.Windows.Forms.Button();
            this.dataGridViewHotel = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHotel)).BeginInit();
            this.SuspendLayout();
            // 
            // HotelTb
            // 
            this.HotelTb.AutoSize = true;
            this.HotelTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HotelTb.Location = new System.Drawing.Point(635, 9);
            this.HotelTb.Name = "HotelTb";
            this.HotelTb.Size = new System.Drawing.Size(106, 40);
            this.HotelTb.TabIndex = 6;
            this.HotelTb.Text = "Hotel";
            // 
            // HotelHotelNoLbl
            // 
            this.HotelHotelNoLbl.AutoSize = true;
            this.HotelHotelNoLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HotelHotelNoLbl.Location = new System.Drawing.Point(46, 53);
            this.HotelHotelNoLbl.Name = "HotelHotelNoLbl";
            this.HotelHotelNoLbl.Size = new System.Drawing.Size(116, 29);
            this.HotelHotelNoLbl.TabIndex = 7;
            this.HotelHotelNoLbl.Text = "Hotel No";
            // 
            // HotelNameLbl
            // 
            this.HotelNameLbl.AutoSize = true;
            this.HotelNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HotelNameLbl.Location = new System.Drawing.Point(46, 93);
            this.HotelNameLbl.Name = "HotelNameLbl";
            this.HotelNameLbl.Size = new System.Drawing.Size(82, 29);
            this.HotelNameLbl.TabIndex = 8;
            this.HotelNameLbl.Text = "Name";
            // 
            // HotelAddressLbl
            // 
            this.HotelAddressLbl.AutoSize = true;
            this.HotelAddressLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HotelAddressLbl.Location = new System.Drawing.Point(46, 137);
            this.HotelAddressLbl.Name = "HotelAddressLbl";
            this.HotelAddressLbl.Size = new System.Drawing.Size(109, 29);
            this.HotelAddressLbl.TabIndex = 9;
            this.HotelAddressLbl.Text = "Address";
            // 
            // txtHotelNo
            // 
            this.txtHotelNo.Location = new System.Drawing.Point(174, 53);
            this.txtHotelNo.Name = "txtHotelNo";
            this.txtHotelNo.Size = new System.Drawing.Size(145, 26);
            this.txtHotelNo.TabIndex = 10;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(174, 97);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(145, 26);
            this.txtName.TabIndex = 11;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(174, 141);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(145, 26);
            this.txtAddress.TabIndex = 12;
            // 
            // InsertHotelBtn
            // 
            this.InsertHotelBtn.Location = new System.Drawing.Point(51, 191);
            this.InsertHotelBtn.Name = "InsertHotelBtn";
            this.InsertHotelBtn.Size = new System.Drawing.Size(119, 39);
            this.InsertHotelBtn.TabIndex = 13;
            this.InsertHotelBtn.Text = "Insert";
            this.InsertHotelBtn.UseVisualStyleBackColor = true;
            this.InsertHotelBtn.Click += new System.EventHandler(this.InsertHotelBtn_Click_1);
            // 
            // UpdateHotelBtn
            // 
            this.UpdateHotelBtn.Location = new System.Drawing.Point(200, 191);
            this.UpdateHotelBtn.Name = "UpdateHotelBtn";
            this.UpdateHotelBtn.Size = new System.Drawing.Size(119, 39);
            this.UpdateHotelBtn.TabIndex = 14;
            this.UpdateHotelBtn.Text = "Update";
            this.UpdateHotelBtn.UseVisualStyleBackColor = true;
            this.UpdateHotelBtn.Click += new System.EventHandler(this.UpdateHotelBtn_Click_1);
            // 
            // DeleteHotelBtn
            // 
            this.DeleteHotelBtn.Location = new System.Drawing.Point(51, 257);
            this.DeleteHotelBtn.Name = "DeleteHotelBtn";
            this.DeleteHotelBtn.Size = new System.Drawing.Size(119, 39);
            this.DeleteHotelBtn.TabIndex = 15;
            this.DeleteHotelBtn.Text = "Delete";
            this.DeleteHotelBtn.UseVisualStyleBackColor = true;
            this.DeleteHotelBtn.Click += new System.EventHandler(this.DeleteHotelBtn_Click);
            // 
            // ShowAllHotelBtn
            // 
            this.ShowAllHotelBtn.Location = new System.Drawing.Point(200, 257);
            this.ShowAllHotelBtn.Name = "ShowAllHotelBtn";
            this.ShowAllHotelBtn.Size = new System.Drawing.Size(119, 39);
            this.ShowAllHotelBtn.TabIndex = 16;
            this.ShowAllHotelBtn.Text = "Show All";
            this.ShowAllHotelBtn.UseVisualStyleBackColor = true;
            this.ShowAllHotelBtn.Click += new System.EventHandler(this.ShowAllHotelBtn_Click_1);
            // 
            // ExitHotelBtn
            // 
            this.ExitHotelBtn.Location = new System.Drawing.Point(51, 325);
            this.ExitHotelBtn.Name = "ExitHotelBtn";
            this.ExitHotelBtn.Size = new System.Drawing.Size(119, 39);
            this.ExitHotelBtn.TabIndex = 17;
            this.ExitHotelBtn.Text = "Exit";
            this.ExitHotelBtn.UseVisualStyleBackColor = true;
            this.ExitHotelBtn.Click += new System.EventHandler(this.ExitHotelBtn_Click_1);
            // 
            // MenuHotelBtn
            // 
            this.MenuHotelBtn.Location = new System.Drawing.Point(200, 325);
            this.MenuHotelBtn.Name = "MenuHotelBtn";
            this.MenuHotelBtn.Size = new System.Drawing.Size(119, 39);
            this.MenuHotelBtn.TabIndex = 18;
            this.MenuHotelBtn.Text = "Menu";
            this.MenuHotelBtn.UseVisualStyleBackColor = true;
            // 
            // FindBarHotel
            // 
            this.FindBarHotel.Location = new System.Drawing.Point(336, 57);
            this.FindBarHotel.Name = "FindBarHotel";
            this.FindBarHotel.Size = new System.Drawing.Size(1056, 26);
            this.FindBarHotel.TabIndex = 19;
            // 
            // FindHotelBtn
            // 
            this.FindHotelBtn.Location = new System.Drawing.Point(1409, 43);
            this.FindHotelBtn.Name = "FindHotelBtn";
            this.FindHotelBtn.Size = new System.Drawing.Size(119, 39);
            this.FindHotelBtn.TabIndex = 20;
            this.FindHotelBtn.Text = "Find";
            this.FindHotelBtn.UseVisualStyleBackColor = true;
            // 
            // dataGridViewHotel
            // 
            this.dataGridViewHotel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHotel.Location = new System.Drawing.Point(349, 97);
            this.dataGridViewHotel.Name = "dataGridViewHotel";
            this.dataGridViewHotel.RowHeadersWidth = 62;
            this.dataGridViewHotel.RowTemplate.Height = 28;
            this.dataGridViewHotel.Size = new System.Drawing.Size(1179, 314);
            this.dataGridViewHotel.TabIndex = 21;
            this.dataGridViewHotel.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewHotel_CellContentClick_1);
            // 
            // Hotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1540, 568);
            this.Controls.Add(this.dataGridViewHotel);
            this.Controls.Add(this.FindHotelBtn);
            this.Controls.Add(this.FindBarHotel);
            this.Controls.Add(this.MenuHotelBtn);
            this.Controls.Add(this.ExitHotelBtn);
            this.Controls.Add(this.ShowAllHotelBtn);
            this.Controls.Add(this.DeleteHotelBtn);
            this.Controls.Add(this.UpdateHotelBtn);
            this.Controls.Add(this.InsertHotelBtn);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtHotelNo);
            this.Controls.Add(this.HotelAddressLbl);
            this.Controls.Add(this.HotelNameLbl);
            this.Controls.Add(this.HotelHotelNoLbl);
            this.Controls.Add(this.HotelTb);
            this.Name = "Hotel";
            this.Text = "Hotel";
            this.Load += new System.EventHandler(this.Hotel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHotel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HotelTb;
        private System.Windows.Forms.Label HotelHotelNoLbl;
        private System.Windows.Forms.Label HotelNameLbl;
        private System.Windows.Forms.Label HotelAddressLbl;
        private System.Windows.Forms.TextBox txtHotelNo;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Button InsertHotelBtn;
        private System.Windows.Forms.Button UpdateHotelBtn;
        private System.Windows.Forms.Button DeleteHotelBtn;
        private System.Windows.Forms.Button ShowAllHotelBtn;
        private System.Windows.Forms.Button ExitHotelBtn;
        private System.Windows.Forms.Button MenuHotelBtn;
        private System.Windows.Forms.TextBox FindBarHotel;
        private System.Windows.Forms.Button FindHotelBtn;
        private System.Windows.Forms.DataGridView dataGridViewHotel;
    }
}