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
            this.AddMusicianBtn = new System.Windows.Forms.Button();
            this.MusicianNameTextBox = new System.Windows.Forms.TextBox();
            this.MusicianDgw = new System.Windows.Forms.DataGridView();
            this.musician_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musician_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.save_btn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.AddSongButton = new System.Windows.Forms.Button();
            this.SongNameTextBox = new System.Windows.Forms.TextBox();
            this.SongDgw = new System.Windows.Forms.DataGridView();
            this.song_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.song_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.song_len = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.savebtn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.AddSongMusicianButton = new System.Windows.Forms.Button();
            this.ChoiceMusicianButton = new System.Windows.Forms.Button();
            this.ChoiceSongButton = new System.Windows.Forms.Button();
            this.musician_label = new System.Windows.Forms.Label();
            this.song_label = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MusicianDgw)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SongDgw)).BeginInit();
            this.groupBox4.SuspendLayout();
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
            // MusicianDgw
            // 
            this.MusicianDgw.AllowUserToAddRows = false;
            this.MusicianDgw.AllowUserToDeleteRows = false;
            this.MusicianDgw.AllowUserToResizeColumns = false;
            this.MusicianDgw.AllowUserToResizeRows = false;
            this.MusicianDgw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MusicianDgw.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.musician_id,
            this.musician_name,
            this.save_btn});
            this.MusicianDgw.Location = new System.Drawing.Point(8, 86);
            this.MusicianDgw.Name = "MusicianDgw";
            this.MusicianDgw.Size = new System.Drawing.Size(458, 215);
            this.MusicianDgw.TabIndex = 0;
            this.MusicianDgw.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MusicianDgw_CellContentClick);
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
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.AddSongButton);
            this.groupBox3.Controls.Add(this.SongNameTextBox);
            this.groupBox3.Controls.Add(this.SongDgw);
            this.groupBox3.Location = new System.Drawing.Point(12, 434);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(478, 292);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Песни";
            // 
            // AddSongButton
            // 
            this.AddSongButton.Location = new System.Drawing.Point(260, 21);
            this.AddSongButton.Name = "AddSongButton";
            this.AddSongButton.Size = new System.Drawing.Size(206, 33);
            this.AddSongButton.TabIndex = 7;
            this.AddSongButton.Text = "Добавить трек";
            this.AddSongButton.UseVisualStyleBackColor = true;
            this.AddSongButton.Click += new System.EventHandler(this.AddSongButton_Click);
            // 
            // SongNameTextBox
            // 
            this.SongNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SongNameTextBox.Location = new System.Drawing.Point(8, 21);
            this.SongNameTextBox.MaxLength = 60;
            this.SongNameTextBox.Multiline = true;
            this.SongNameTextBox.Name = "SongNameTextBox";
            this.SongNameTextBox.Size = new System.Drawing.Size(246, 33);
            this.SongNameTextBox.TabIndex = 7;
            // 
            // SongDgw
            // 
            this.SongDgw.AllowUserToAddRows = false;
            this.SongDgw.AllowUserToDeleteRows = false;
            this.SongDgw.AllowUserToResizeColumns = false;
            this.SongDgw.AllowUserToResizeRows = false;
            this.SongDgw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SongDgw.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.song_id,
            this.song_name,
            this.song_len,
            this.savebtn});
            this.SongDgw.Location = new System.Drawing.Point(8, 60);
            this.SongDgw.Name = "SongDgw";
            this.SongDgw.Size = new System.Drawing.Size(458, 215);
            this.SongDgw.TabIndex = 0;
            this.SongDgw.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SongDgw_CellContentClick);
            // 
            // song_id
            // 
            this.song_id.HeaderText = "ID";
            this.song_id.Name = "song_id";
            this.song_id.ReadOnly = true;
            this.song_id.Width = 30;
            // 
            // song_name
            // 
            this.song_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.song_name.HeaderText = "Название";
            this.song_name.Name = "song_name";
            // 
            // song_len
            // 
            this.song_len.HeaderText = "Длина";
            this.song_len.Name = "song_len";
            this.song_len.Width = 60;
            // 
            // savebtn
            // 
            this.savebtn.HeaderText = "";
            this.savebtn.Name = "savebtn";
            this.savebtn.ReadOnly = true;
            this.savebtn.Width = 70;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.AddSongMusicianButton);
            this.groupBox4.Controls.Add(this.ChoiceMusicianButton);
            this.groupBox4.Controls.Add(this.ChoiceSongButton);
            this.groupBox4.Controls.Add(this.musician_label);
            this.groupBox4.Controls.Add(this.song_label);
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Location = new System.Drawing.Point(510, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(554, 416);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Связать исполнителя с треком";
            // 
            // AddSongMusicianButton
            // 
            this.AddSongMusicianButton.Location = new System.Drawing.Point(29, 108);
            this.AddSongMusicianButton.Name = "AddSongMusicianButton";
            this.AddSongMusicianButton.Size = new System.Drawing.Size(458, 35);
            this.AddSongMusicianButton.TabIndex = 13;
            this.AddSongMusicianButton.Text = "Добавить связь";
            this.AddSongMusicianButton.UseVisualStyleBackColor = true;
            // 
            // ChoiceMusicianButton
            // 
            this.ChoiceMusicianButton.Location = new System.Drawing.Point(325, 67);
            this.ChoiceMusicianButton.Name = "ChoiceMusicianButton";
            this.ChoiceMusicianButton.Size = new System.Drawing.Size(162, 35);
            this.ChoiceMusicianButton.TabIndex = 12;
            this.ChoiceMusicianButton.Text = "Выбрать исполнителя";
            this.ChoiceMusicianButton.UseVisualStyleBackColor = true;
            this.ChoiceMusicianButton.Click += new System.EventHandler(this.ChoiceMusicianButton_Click);
            // 
            // ChoiceSongButton
            // 
            this.ChoiceSongButton.Location = new System.Drawing.Point(325, 21);
            this.ChoiceSongButton.Name = "ChoiceSongButton";
            this.ChoiceSongButton.Size = new System.Drawing.Size(162, 35);
            this.ChoiceSongButton.TabIndex = 11;
            this.ChoiceSongButton.Text = "Выбрать трек";
            this.ChoiceSongButton.UseVisualStyleBackColor = true;
            this.ChoiceSongButton.Click += new System.EventHandler(this.ChoiceSongButton_Click);
            // 
            // musician_label
            // 
            this.musician_label.BackColor = System.Drawing.SystemColors.Window;
            this.musician_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.musician_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.musician_label.Location = new System.Drawing.Point(29, 67);
            this.musician_label.Name = "musician_label";
            this.musician_label.Size = new System.Drawing.Size(290, 35);
            this.musician_label.TabIndex = 10;
            this.musician_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // song_label
            // 
            this.song_label.BackColor = System.Drawing.SystemColors.Window;
            this.song_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.song_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.song_label.Location = new System.Drawing.Point(29, 21);
            this.song_label.Name = "song_label";
            this.song_label.Size = new System.Drawing.Size(290, 35);
            this.song_label.TabIndex = 9;
            this.song_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(29, 157);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(458, 250);
            this.dataGridView1.TabIndex = 0;
            // 
            // AdminWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1138, 786);
            this.Controls.Add(this.groupBox4);
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
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SongDgw)).EndInit();
            this.groupBox4.ResumeLayout(false);
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
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView SongDgw;
        private System.Windows.Forms.Button AddSongButton;
        private System.Windows.Forms.TextBox SongNameTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn musician_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn musician_name;
        private System.Windows.Forms.DataGridViewButtonColumn save_btn;
        private System.Windows.Forms.DataGridViewTextBoxColumn song_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn song_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn song_len;
        private System.Windows.Forms.DataGridViewButtonColumn savebtn;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label musician_label;
        private System.Windows.Forms.Label song_label;
        private System.Windows.Forms.Button AddSongMusicianButton;
        private System.Windows.Forms.Button ChoiceMusicianButton;
        private System.Windows.Forms.Button ChoiceSongButton;
    }
}