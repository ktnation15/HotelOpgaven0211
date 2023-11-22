namespace HotelOpgaven0211
{
    partial class MainMenu
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
            this.MainMenuBtn = new System.Windows.Forms.Button();
            this.MmBookingBtn = new System.Windows.Forms.Button();
            this.MmHotelBtn = new System.Windows.Forms.Button();
            this.MmGuestBtn = new System.Windows.Forms.Button();
            this.MmRoomBtn = new System.Windows.Forms.Button();
            this.MmFacilitiesBtn = new System.Windows.Forms.Button();
            this.MmExitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MainMenuBtn
            // 
            this.MainMenuBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuBtn.Location = new System.Drawing.Point(274, 44);
            this.MainMenuBtn.Name = "MainMenuBtn";
            this.MainMenuBtn.Size = new System.Drawing.Size(238, 91);
            this.MainMenuBtn.TabIndex = 0;
            this.MainMenuBtn.Text = "Main Menu";
            this.MainMenuBtn.UseVisualStyleBackColor = true;
            // 
            // MmBookingBtn
            // 
            this.MmBookingBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MmBookingBtn.Location = new System.Drawing.Point(42, 153);
            this.MmBookingBtn.Name = "MmBookingBtn";
            this.MmBookingBtn.Size = new System.Drawing.Size(195, 55);
            this.MmBookingBtn.TabIndex = 1;
            this.MmBookingBtn.Text = "Booking";
            this.MmBookingBtn.UseVisualStyleBackColor = true;
            this.MmBookingBtn.Click += new System.EventHandler(this.MmBookingBtn_Click);
            // 
            // MmHotelBtn
            // 
            this.MmHotelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MmHotelBtn.Location = new System.Drawing.Point(295, 153);
            this.MmHotelBtn.Name = "MmHotelBtn";
            this.MmHotelBtn.Size = new System.Drawing.Size(195, 55);
            this.MmHotelBtn.TabIndex = 2;
            this.MmHotelBtn.Text = "Hoteller";
            this.MmHotelBtn.UseVisualStyleBackColor = true;
            this.MmHotelBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // MmGuestBtn
            // 
            this.MmGuestBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MmGuestBtn.Location = new System.Drawing.Point(544, 153);
            this.MmGuestBtn.Name = "MmGuestBtn";
            this.MmGuestBtn.Size = new System.Drawing.Size(195, 55);
            this.MmGuestBtn.TabIndex = 3;
            this.MmGuestBtn.Text = "Guest";
            this.MmGuestBtn.UseVisualStyleBackColor = true;
            // 
            // MmRoomBtn
            // 
            this.MmRoomBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MmRoomBtn.Location = new System.Drawing.Point(42, 247);
            this.MmRoomBtn.Name = "MmRoomBtn";
            this.MmRoomBtn.Size = new System.Drawing.Size(195, 55);
            this.MmRoomBtn.TabIndex = 4;
            this.MmRoomBtn.Text = "Rooms";
            this.MmRoomBtn.UseVisualStyleBackColor = true;
            // 
            // MmFacilitiesBtn
            // 
            this.MmFacilitiesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MmFacilitiesBtn.Location = new System.Drawing.Point(295, 247);
            this.MmFacilitiesBtn.Name = "MmFacilitiesBtn";
            this.MmFacilitiesBtn.Size = new System.Drawing.Size(195, 55);
            this.MmFacilitiesBtn.TabIndex = 5;
            this.MmFacilitiesBtn.Text = "Facilities";
            this.MmFacilitiesBtn.UseVisualStyleBackColor = true;
            this.MmFacilitiesBtn.Click += new System.EventHandler(this.MmFacilitiesBtn_Click);
            // 
            // MmExitBtn
            // 
            this.MmExitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MmExitBtn.Location = new System.Drawing.Point(544, 247);
            this.MmExitBtn.Name = "MmExitBtn";
            this.MmExitBtn.Size = new System.Drawing.Size(195, 55);
            this.MmExitBtn.TabIndex = 6;
            this.MmExitBtn.Text = "Exit";
            this.MmExitBtn.UseVisualStyleBackColor = true;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MmExitBtn);
            this.Controls.Add(this.MmFacilitiesBtn);
            this.Controls.Add(this.MmRoomBtn);
            this.Controls.Add(this.MmGuestBtn);
            this.Controls.Add(this.MmHotelBtn);
            this.Controls.Add(this.MmBookingBtn);
            this.Controls.Add(this.MainMenuBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button MainMenuBtn;
        private System.Windows.Forms.Button MmBookingBtn;
        private System.Windows.Forms.Button MmHotelBtn;
        private System.Windows.Forms.Button MmGuestBtn;
        private System.Windows.Forms.Button MmRoomBtn;
        private System.Windows.Forms.Button MmFacilitiesBtn;
        private System.Windows.Forms.Button MmExitBtn;
    }
}

