namespace HotelOpgaven0211
{
    partial class BookingLbl
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
            this.BookingTb = new System.Windows.Forms.Label();
            this.BookingIdLbl = new System.Windows.Forms.Label();
            this.HotelNoLbl = new System.Windows.Forms.Label();
            this.GuestNoLbl = new System.Windows.Forms.Label();
            this.RoomNoLbl = new System.Windows.Forms.Label();
            this.txtBookingId = new System.Windows.Forms.TextBox();
            this.txtHotelNo = new System.Windows.Forms.TextBox();
            this.txtGuestNo = new System.Windows.Forms.TextBox();
            this.txtRoomNo = new System.Windows.Forms.TextBox();
            this.InsertBookingBtn = new System.Windows.Forms.Button();
            this.UpdateBookingBtn = new System.Windows.Forms.Button();
            this.DeleteBookingBtn = new System.Windows.Forms.Button();
            this.ShowAllBookingBtn = new System.Windows.Forms.Button();
            this.ExitBookingBtn = new System.Windows.Forms.Button();
            this.MenuBookingBtn = new System.Windows.Forms.Button();
            this.FindBar = new System.Windows.Forms.TextBox();
            this.FindBookingBtn = new System.Windows.Forms.Button();
            this.dataGridViewBooking = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooking)).BeginInit();
            this.SuspendLayout();
            // 
            // BookingTb
            // 
            this.BookingTb.AutoSize = true;
            this.BookingTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookingTb.Location = new System.Drawing.Point(635, 9);
            this.BookingTb.Name = "BookingTb";
            this.BookingTb.Size = new System.Drawing.Size(154, 40);
            this.BookingTb.TabIndex = 0;
            this.BookingTb.Text = "Booking";
            // 
            // BookingIdLbl
            // 
            this.BookingIdLbl.AutoSize = true;
            this.BookingIdLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookingIdLbl.Location = new System.Drawing.Point(36, 68);
            this.BookingIdLbl.Name = "BookingIdLbl";
            this.BookingIdLbl.Size = new System.Drawing.Size(104, 25);
            this.BookingIdLbl.TabIndex = 1;
            this.BookingIdLbl.Text = "Booking Id";
            // 
            // HotelNoLbl
            // 
            this.HotelNoLbl.AutoSize = true;
            this.HotelNoLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HotelNoLbl.Location = new System.Drawing.Point(36, 100);
            this.HotelNoLbl.Name = "HotelNoLbl";
            this.HotelNoLbl.Size = new System.Drawing.Size(87, 25);
            this.HotelNoLbl.TabIndex = 2;
            this.HotelNoLbl.Text = "Hotel No";
            // 
            // GuestNoLbl
            // 
            this.GuestNoLbl.AutoSize = true;
            this.GuestNoLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuestNoLbl.Location = new System.Drawing.Point(36, 133);
            this.GuestNoLbl.Name = "GuestNoLbl";
            this.GuestNoLbl.Size = new System.Drawing.Size(94, 25);
            this.GuestNoLbl.TabIndex = 3;
            this.GuestNoLbl.Text = "Guest No";
            // 
            // RoomNoLbl
            // 
            this.RoomNoLbl.AutoSize = true;
            this.RoomNoLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoomNoLbl.Location = new System.Drawing.Point(36, 165);
            this.RoomNoLbl.Name = "RoomNoLbl";
            this.RoomNoLbl.Size = new System.Drawing.Size(93, 25);
            this.RoomNoLbl.TabIndex = 4;
            this.RoomNoLbl.Text = "Room No";
            // 
            // txtBookingId
            // 
            this.txtBookingId.Location = new System.Drawing.Point(158, 69);
            this.txtBookingId.Name = "txtBookingId";
            this.txtBookingId.Size = new System.Drawing.Size(145, 26);
            this.txtBookingId.TabIndex = 5;
            this.txtBookingId.TextChanged += new System.EventHandler(this.txtBookingId_TextChanged);
            // 
            // txtHotelNo
            // 
            this.txtHotelNo.Location = new System.Drawing.Point(158, 101);
            this.txtHotelNo.Name = "txtHotelNo";
            this.txtHotelNo.Size = new System.Drawing.Size(145, 26);
            this.txtHotelNo.TabIndex = 6;
            // 
            // txtGuestNo
            // 
            this.txtGuestNo.Location = new System.Drawing.Point(158, 133);
            this.txtGuestNo.Name = "txtGuestNo";
            this.txtGuestNo.Size = new System.Drawing.Size(145, 26);
            this.txtGuestNo.TabIndex = 7;
            // 
            // txtRoomNo
            // 
            this.txtRoomNo.Location = new System.Drawing.Point(158, 165);
            this.txtRoomNo.Name = "txtRoomNo";
            this.txtRoomNo.Size = new System.Drawing.Size(145, 26);
            this.txtRoomNo.TabIndex = 8;
            // 
            // InsertBookingBtn
            // 
            this.InsertBookingBtn.Location = new System.Drawing.Point(41, 251);
            this.InsertBookingBtn.Name = "InsertBookingBtn";
            this.InsertBookingBtn.Size = new System.Drawing.Size(119, 39);
            this.InsertBookingBtn.TabIndex = 9;
            this.InsertBookingBtn.Text = "Insert";
            this.InsertBookingBtn.UseVisualStyleBackColor = true;
            this.InsertBookingBtn.Click += new System.EventHandler(this.InsertBookingBtn_Click);
            // 
            // UpdateBookingBtn
            // 
            this.UpdateBookingBtn.Location = new System.Drawing.Point(195, 251);
            this.UpdateBookingBtn.Name = "UpdateBookingBtn";
            this.UpdateBookingBtn.Size = new System.Drawing.Size(108, 39);
            this.UpdateBookingBtn.TabIndex = 10;
            this.UpdateBookingBtn.Text = "Update";
            this.UpdateBookingBtn.UseVisualStyleBackColor = true;
            this.UpdateBookingBtn.Click += new System.EventHandler(this.UpdateBookingBtn_Click);
            // 
            // DeleteBookingBtn
            // 
            this.DeleteBookingBtn.Location = new System.Drawing.Point(41, 323);
            this.DeleteBookingBtn.Name = "DeleteBookingBtn";
            this.DeleteBookingBtn.Size = new System.Drawing.Size(119, 39);
            this.DeleteBookingBtn.TabIndex = 11;
            this.DeleteBookingBtn.Text = "Delete";
            this.DeleteBookingBtn.UseVisualStyleBackColor = true;
            this.DeleteBookingBtn.Click += new System.EventHandler(this.DeleteBookingBtn_Click);
            // 
            // ShowAllBookingBtn
            // 
            this.ShowAllBookingBtn.Location = new System.Drawing.Point(195, 323);
            this.ShowAllBookingBtn.Name = "ShowAllBookingBtn";
            this.ShowAllBookingBtn.Size = new System.Drawing.Size(108, 39);
            this.ShowAllBookingBtn.TabIndex = 12;
            this.ShowAllBookingBtn.Text = "Show All";
            this.ShowAllBookingBtn.UseVisualStyleBackColor = true;
            this.ShowAllBookingBtn.Click += new System.EventHandler(this.ShowAllBookingBtn_Click);
            // 
            // ExitBookingBtn
            // 
            this.ExitBookingBtn.Location = new System.Drawing.Point(41, 390);
            this.ExitBookingBtn.Name = "ExitBookingBtn";
            this.ExitBookingBtn.Size = new System.Drawing.Size(119, 39);
            this.ExitBookingBtn.TabIndex = 13;
            this.ExitBookingBtn.Text = "Exit";
            this.ExitBookingBtn.UseVisualStyleBackColor = true;
            this.ExitBookingBtn.Click += new System.EventHandler(this.ExitBookingBtn_Click);
            // 
            // MenuBookingBtn
            // 
            this.MenuBookingBtn.Location = new System.Drawing.Point(195, 390);
            this.MenuBookingBtn.Name = "MenuBookingBtn";
            this.MenuBookingBtn.Size = new System.Drawing.Size(108, 39);
            this.MenuBookingBtn.TabIndex = 14;
            this.MenuBookingBtn.Text = "Menu";
            this.MenuBookingBtn.UseVisualStyleBackColor = true;
            // 
            // FindBar
            // 
            this.FindBar.Location = new System.Drawing.Point(355, 69);
            this.FindBar.Name = "FindBar";
            this.FindBar.Size = new System.Drawing.Size(1056, 26);
            this.FindBar.TabIndex = 15;
            // 
            // FindBookingBtn
            // 
            this.FindBookingBtn.Location = new System.Drawing.Point(1452, 63);
            this.FindBookingBtn.Name = "FindBookingBtn";
            this.FindBookingBtn.Size = new System.Drawing.Size(82, 39);
            this.FindBookingBtn.TabIndex = 16;
            this.FindBookingBtn.Text = "Find";
            this.FindBookingBtn.UseVisualStyleBackColor = true;
            this.FindBookingBtn.Click += new System.EventHandler(this.FindBookingBtn_Click);
            // 
            // dataGridViewBooking
            // 
            this.dataGridViewBooking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBooking.Location = new System.Drawing.Point(355, 115);
            this.dataGridViewBooking.Name = "dataGridViewBooking";
            this.dataGridViewBooking.RowHeadersWidth = 62;
            this.dataGridViewBooking.RowTemplate.Height = 28;
            this.dataGridViewBooking.Size = new System.Drawing.Size(1179, 314);
            this.dataGridViewBooking.TabIndex = 17;
            // 
            // BookingLbl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1540, 568);
            this.Controls.Add(this.dataGridViewBooking);
            this.Controls.Add(this.FindBookingBtn);
            this.Controls.Add(this.FindBar);
            this.Controls.Add(this.MenuBookingBtn);
            this.Controls.Add(this.ExitBookingBtn);
            this.Controls.Add(this.ShowAllBookingBtn);
            this.Controls.Add(this.DeleteBookingBtn);
            this.Controls.Add(this.UpdateBookingBtn);
            this.Controls.Add(this.InsertBookingBtn);
            this.Controls.Add(this.txtRoomNo);
            this.Controls.Add(this.txtGuestNo);
            this.Controls.Add(this.txtHotelNo);
            this.Controls.Add(this.txtBookingId);
            this.Controls.Add(this.RoomNoLbl);
            this.Controls.Add(this.GuestNoLbl);
            this.Controls.Add(this.HotelNoLbl);
            this.Controls.Add(this.BookingIdLbl);
            this.Controls.Add(this.BookingTb);
            this.Name = "BookingLbl";
            this.Text = "Booking";
            this.Load += new System.EventHandler(this.BookingLbl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooking)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BookingTb;
        private System.Windows.Forms.Label BookingIdLbl;
        private System.Windows.Forms.Label HotelNoLbl;
        private System.Windows.Forms.Label GuestNoLbl;
        private System.Windows.Forms.Label RoomNoLbl;
        private System.Windows.Forms.TextBox txtBookingId;
        private System.Windows.Forms.TextBox txtHotelNo;
        private System.Windows.Forms.TextBox txtGuestNo;
        private System.Windows.Forms.TextBox txtRoomNo;
        private System.Windows.Forms.Button InsertBookingBtn;
        private System.Windows.Forms.Button UpdateBookingBtn;
        private System.Windows.Forms.Button DeleteBookingBtn;
        private System.Windows.Forms.Button ShowAllBookingBtn;
        private System.Windows.Forms.Button ExitBookingBtn;
        private System.Windows.Forms.Button MenuBookingBtn;
        private System.Windows.Forms.TextBox FindBar;
        private System.Windows.Forms.Button FindBookingBtn;
        private System.Windows.Forms.DataGridView dataGridViewBooking;
    }
}