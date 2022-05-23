namespace FormsForBD
{
    partial class AdminWindow
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
            this.RegistrateUserPassword = new System.Windows.Forms.Button();
            this.EntryUserButton = new System.Windows.Forms.Button();
            this.UserLoginTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.MusicianDgw = new System.Windows.Forms.DataGridView();
            this.MusicianNameTextBox = new System.Windows.Forms.TextBox();
            this.AddMusicianBtn = new System.Windows.Forms.Button();
            this.musician_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musician_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.save_btn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.delete_btn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MusicianDgw)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // RegistrateUserPassword
            // 
            this.RegistrateUserPassword.Location = new System.Drawing.Point(260, 58);
            this.RegistrateUserPassword.Name = "RegistrateUserPassword";
            this.RegistrateUserPassword.Size = new System.Drawing.Size(206, 33);
            this.RegistrateUserPassword.TabIndex = 0;
            this.RegistrateUserPassword.Text = "Зарегистрировать пользователя";
            this.RegistrateUserPassword.UseVisualStyleBackColor = true;
            this.RegistrateUserPassword.Click += new System.EventHandler(this.RegistrateUserPassword_Click);
            // 
            // EntryUserButton
            // 
            this.EntryUserButton.Location = new System.Drawing.Point(260, 19);
            this.EntryUserButton.Name = "EntryUserButton";
            this.EntryUserButton.Size = new System.Drawing.Size(206, 33);
            this.EntryUserButton.TabIndex = 1;
            this.EntryUserButton.Text = "Войти как пользователь";
            this.EntryUserButton.UseVisualStyleBackColor = true;
            this.EntryUserButton.Click += new System.EventHandler(this.EntryUserButton_Click);
            // 
            // UserLoginTextBox
            // 
            this.UserLoginTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserLoginTextBox.Location = new System.Drawing.Point(48, 19);
            this.UserLoginTextBox.MaxLength = 30;
            this.UserLoginTextBox.Multiline = true;
            this.UserLoginTextBox.Name = "UserLoginTextBox";
            this.UserLoginTextBox.Size = new System.Drawing.Size(206, 33);
            this.UserLoginTextBox.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.EntryUserButton);
            this.groupBox1.Controls.Add(this.UserLoginTextBox);
            this.groupBox1.Controls.Add(this.RegistrateUserPassword);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(478, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FormsForBD.Properties.Resources.log1;
            this.pictureBox1.Location = new System.Drawing.Point(8, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 34);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.AddMusicianBtn);
            this.groupBox2.Controls.Add(this.MusicianNameTextBox);
            this.groupBox2.Controls.Add(this.MusicianDgw);
            this.groupBox2.Location = new System.Drawing.Point(12, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(478, 310);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Исполнители";
            // 
            // MusicianDgw
            // 
            this.MusicianDgw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MusicianDgw.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.musician_id,
            this.musician_name,
            this.save_btn,
            this.delete_btn});
            this.MusicianDgw.Location = new System.Drawing.Point(8, 86);
            this.MusicianDgw.Name = "MusicianDgw";
            this.MusicianDgw.Size = new System.Drawing.Size(458, 215);
            this.MusicianDgw.TabIndex = 0;
            this.MusicianDgw.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MusicianDgw_CellContentClick);
            // 
            // MusicianNameTextBox
            // 
            this.MusicianNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MusicianNameTextBox.Location = new System.Drawing.Point(8, 37);
            this.MusicianNameTextBox.MaxLength = 30;
            this.MusicianNameTextBox.Multiline = true;
            this.MusicianNameTextBox.Name = "MusicianNameTextBox";
            this.MusicianNameTextBox.Size = new System.Drawing.Size(246, 33);
            this.MusicianNameTextBox.TabIndex = 6;
            // 
            // AddMusicianBtn
            // 
            this.AddMusicianBtn.Location = new System.Drawing.Point(260, 37);
            this.AddMusicianBtn.Name = "AddMusicianBtn";
            this.AddMusicianBtn.Size = new System.Drawing.Size(206, 33);
            this.AddMusicianBtn.TabIndex = 6;
            this.AddMusicianBtn.Text = "Добавить";
            this.AddMusicianBtn.UseVisualStyleBackColor = true;
            this.AddMusicianBtn.Click += new System.EventHandler(this.AddMusicianBtn_Click);
            // 
            // musician_id
            // 
            this.musician_id.HeaderText = "ID";
            this.musician_id.Name = "musician_id";
            this.musician_id.ReadOnly = true;
            this.musician_id.Width = 30;
            // 
            // musician_name
            // 
            this.musician_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.musician_name.HeaderText = "Исполнитель";
            this.musician_name.Name = "musician_name";
            // 
            // save_btn
            // 
            this.save_btn.HeaderText = "";
            this.save_btn.Name = "save_btn";
            this.save_btn.ReadOnly = true;
            this.save_btn.Width = 70;
            // 
            // delete_btn
            // 
            this.delete_btn.HeaderText = "";
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.ReadOnly = true;
            this.delete_btn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.delete_btn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.delete_btn.Width = 70;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(496, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(516, 299);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Песни";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 82);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(484, 199);
            this.dataGridView1.TabIndex = 0;
            // 
            // AdminWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 629);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AdminWindow";
            this.Text = "CRUD";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MusicianDgw)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button RegistrateUserPassword;
        private System.Windows.Forms.Button EntryUserButton;
        private System.Windows.Forms.TextBox UserLoginTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button AddMusicianBtn;
        private System.Windows.Forms.TextBox MusicianNameTextBox;
        private System.Windows.Forms.DataGridView MusicianDgw;
        private System.Windows.Forms.DataGridViewTextBoxColumn musician_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn musician_name;
        private System.Windows.Forms.DataGridViewButtonColumn save_btn;
        private System.Windows.Forms.DataGridViewButtonColumn delete_btn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}