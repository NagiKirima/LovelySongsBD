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
            this.ChoiceSongButton1 = new System.Windows.Forms.Button();
            this.musician_label = new System.Windows.Forms.Label();
            this.song_label1 = new System.Windows.Forms.Label();
            this.SongMusicianDgw = new System.Windows.Forms.DataGridView();
            this.entry_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.s_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.s_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.save_s_m = new System.Windows.Forms.DataGridViewButtonColumn();
            this.del_s_m = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.SongStyleDgw = new System.Windows.Forms.DataGridView();
            this.ChoiceSongButton2 = new System.Windows.Forms.Button();
            this.song_label2 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.AddStyleSongButton = new System.Windows.Forms.Button();
            this.StyleTextBox = new System.Windows.Forms.TextBox();
            this.id_entry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewButtonColumn1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.OpenResultsButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MusicianDgw)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SongDgw)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SongMusicianDgw)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SongStyleDgw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.UserLoginTextBox.Location = new System.Drawing.Point(48, 38);
            this.UserLoginTextBox.MaxLength = 30;
            this.UserLoginTextBox.Multiline = true;
            this.UserLoginTextBox.Name = "UserLoginTextBox";
            this.UserLoginTextBox.Size = new System.Drawing.Size(206, 33);
            this.UserLoginTextBox.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.AddMusicianBtn);
            this.groupBox2.Controls.Add(this.MusicianNameTextBox);
            this.groupBox2.Controls.Add(this.MusicianDgw);
            this.groupBox2.Location = new System.Drawing.Point(12, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(478, 310);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Управление исполнителями";
            // 
            // AddMusicianBtn
            // 
            this.AddMusicianBtn.Location = new System.Drawing.Point(260, 47);
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
            this.MusicianNameTextBox.Location = new System.Drawing.Point(8, 47);
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
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.AddSongButton);
            this.groupBox3.Controls.Add(this.SongNameTextBox);
            this.groupBox3.Controls.Add(this.SongDgw);
            this.groupBox3.Location = new System.Drawing.Point(12, 434);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(478, 370);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Управление песнями";
            // 
            // AddSongButton
            // 
            this.AddSongButton.Location = new System.Drawing.Point(260, 41);
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
            this.SongNameTextBox.Location = new System.Drawing.Point(8, 41);
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
            this.SongDgw.Location = new System.Drawing.Point(8, 80);
            this.SongDgw.Name = "SongDgw";
            this.SongDgw.Size = new System.Drawing.Size(458, 284);
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
            this.groupBox4.Controls.Add(this.ChoiceSongButton1);
            this.groupBox4.Controls.Add(this.musician_label);
            this.groupBox4.Controls.Add(this.song_label1);
            this.groupBox4.Controls.Add(this.SongMusicianDgw);
            this.groupBox4.Location = new System.Drawing.Point(510, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(671, 416);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Связать исполнителя с треком";
            // 
            // AddSongMusicianButton
            // 
            this.AddSongMusicianButton.Location = new System.Drawing.Point(28, 116);
            this.AddSongMusicianButton.Name = "AddSongMusicianButton";
            this.AddSongMusicianButton.Size = new System.Drawing.Size(615, 35);
            this.AddSongMusicianButton.TabIndex = 13;
            this.AddSongMusicianButton.Text = "Добавить связь";
            this.AddSongMusicianButton.UseVisualStyleBackColor = true;
            this.AddSongMusicianButton.Click += new System.EventHandler(this.AddSongMusicianButton_Click);
            // 
            // ChoiceMusicianButton
            // 
            this.ChoiceMusicianButton.Location = new System.Drawing.Point(421, 67);
            this.ChoiceMusicianButton.Name = "ChoiceMusicianButton";
            this.ChoiceMusicianButton.Size = new System.Drawing.Size(223, 35);
            this.ChoiceMusicianButton.TabIndex = 12;
            this.ChoiceMusicianButton.Text = "Выбрать исполнителя";
            this.ChoiceMusicianButton.UseVisualStyleBackColor = true;
            this.ChoiceMusicianButton.Click += new System.EventHandler(this.ChoiceMusicianButton_Click);
            // 
            // ChoiceSongButton1
            // 
            this.ChoiceSongButton1.Location = new System.Drawing.Point(421, 21);
            this.ChoiceSongButton1.Name = "ChoiceSongButton1";
            this.ChoiceSongButton1.Size = new System.Drawing.Size(223, 35);
            this.ChoiceSongButton1.TabIndex = 11;
            this.ChoiceSongButton1.Text = "Выбрать трек";
            this.ChoiceSongButton1.UseVisualStyleBackColor = true;
            this.ChoiceSongButton1.Click += new System.EventHandler(this.ChoiceSongButton_Click);
            // 
            // musician_label
            // 
            this.musician_label.BackColor = System.Drawing.SystemColors.Window;
            this.musician_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.musician_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.musician_label.Location = new System.Drawing.Point(29, 67);
            this.musician_label.Name = "musician_label";
            this.musician_label.Size = new System.Drawing.Size(386, 35);
            this.musician_label.TabIndex = 10;
            this.musician_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // song_label1
            // 
            this.song_label1.BackColor = System.Drawing.SystemColors.Window;
            this.song_label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.song_label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.song_label1.Location = new System.Drawing.Point(29, 21);
            this.song_label1.Name = "song_label1";
            this.song_label1.Size = new System.Drawing.Size(386, 35);
            this.song_label1.TabIndex = 9;
            this.song_label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SongMusicianDgw
            // 
            this.SongMusicianDgw.AllowUserToAddRows = false;
            this.SongMusicianDgw.AllowUserToDeleteRows = false;
            this.SongMusicianDgw.AllowUserToResizeColumns = false;
            this.SongMusicianDgw.AllowUserToResizeRows = false;
            this.SongMusicianDgw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SongMusicianDgw.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.entry_id,
            this.s_id,
            this.m_id,
            this.s_name,
            this.m_name,
            this.save_s_m,
            this.del_s_m});
            this.SongMusicianDgw.Location = new System.Drawing.Point(29, 157);
            this.SongMusicianDgw.Name = "SongMusicianDgw";
            this.SongMusicianDgw.Size = new System.Drawing.Size(615, 250);
            this.SongMusicianDgw.TabIndex = 0;
            this.SongMusicianDgw.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SongMusicianDgw_CellContentClick);
            // 
            // entry_id
            // 
            this.entry_id.HeaderText = "";
            this.entry_id.Name = "entry_id";
            this.entry_id.ReadOnly = true;
            this.entry_id.Visible = false;
            // 
            // s_id
            // 
            this.s_id.HeaderText = "ID Song";
            this.s_id.Name = "s_id";
            this.s_id.ReadOnly = true;
            this.s_id.Width = 40;
            // 
            // m_id
            // 
            this.m_id.HeaderText = "ID Mus";
            this.m_id.Name = "m_id";
            this.m_id.Width = 40;
            // 
            // s_name
            // 
            this.s_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.s_name.HeaderText = "Название";
            this.s_name.Name = "s_name";
            this.s_name.ReadOnly = true;
            // 
            // m_name
            // 
            this.m_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.m_name.HeaderText = "Исполнитель";
            this.m_name.Name = "m_name";
            this.m_name.ReadOnly = true;
            // 
            // save_s_m
            // 
            this.save_s_m.HeaderText = "";
            this.save_s_m.Name = "save_s_m";
            this.save_s_m.ReadOnly = true;
            this.save_s_m.Width = 70;
            // 
            // del_s_m
            // 
            this.del_s_m.HeaderText = "";
            this.del_s_m.Name = "del_s_m";
            this.del_s_m.ReadOnly = true;
            this.del_s_m.Width = 70;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.StyleTextBox);
            this.groupBox5.Controls.Add(this.AddStyleSongButton);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.SongStyleDgw);
            this.groupBox5.Controls.Add(this.ChoiceSongButton2);
            this.groupBox5.Controls.Add(this.song_label2);
            this.groupBox5.Location = new System.Drawing.Point(510, 434);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(671, 370);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Связать жанр с треком";
            // 
            // SongStyleDgw
            // 
            this.SongStyleDgw.AllowUserToAddRows = false;
            this.SongStyleDgw.AllowUserToDeleteRows = false;
            this.SongStyleDgw.AllowUserToResizeColumns = false;
            this.SongStyleDgw.AllowUserToResizeRows = false;
            this.SongStyleDgw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SongStyleDgw.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_entry,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewButtonColumn1});
            this.SongStyleDgw.Location = new System.Drawing.Point(29, 121);
            this.SongStyleDgw.Name = "SongStyleDgw";
            this.SongStyleDgw.Size = new System.Drawing.Size(615, 243);
            this.SongStyleDgw.TabIndex = 8;
            this.SongStyleDgw.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SongStyleDgw_CellContentClick);
            // 
            // ChoiceSongButton2
            // 
            this.ChoiceSongButton2.Location = new System.Drawing.Point(529, 39);
            this.ChoiceSongButton2.Name = "ChoiceSongButton2";
            this.ChoiceSongButton2.Size = new System.Drawing.Size(116, 35);
            this.ChoiceSongButton2.TabIndex = 14;
            this.ChoiceSongButton2.Text = "Выбрать трек";
            this.ChoiceSongButton2.UseVisualStyleBackColor = true;
            this.ChoiceSongButton2.Click += new System.EventHandler(this.ChoiceSongButton2_Click);
            // 
            // song_label2
            // 
            this.song_label2.BackColor = System.Drawing.SystemColors.Window;
            this.song_label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.song_label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.song_label2.Location = new System.Drawing.Point(216, 39);
            this.song_label2.Name = "song_label2";
            this.song_label2.Size = new System.Drawing.Size(307, 35);
            this.song_label2.TabIndex = 14;
            this.song_label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Название жанра";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Название песни";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Псевдоним исполнителя";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(213, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Название песни";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Логин пользователя";
            // 
            // AddStyleSongButton
            // 
            this.AddStyleSongButton.Location = new System.Drawing.Point(28, 80);
            this.AddStyleSongButton.Name = "AddStyleSongButton";
            this.AddStyleSongButton.Size = new System.Drawing.Size(615, 35);
            this.AddStyleSongButton.TabIndex = 14;
            this.AddStyleSongButton.Text = "Добавить связь";
            this.AddStyleSongButton.UseVisualStyleBackColor = true;
            this.AddStyleSongButton.Click += new System.EventHandler(this.AddStyleSongButton_Click);
            // 
            // StyleTextBox
            // 
            this.StyleTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StyleTextBox.Location = new System.Drawing.Point(30, 39);
            this.StyleTextBox.MaxLength = 30;
            this.StyleTextBox.Multiline = true;
            this.StyleTextBox.Name = "StyleTextBox";
            this.StyleTextBox.Size = new System.Drawing.Size(180, 35);
            this.StyleTextBox.TabIndex = 19;
            // 
            // id_entry
            // 
            this.id_entry.HeaderText = "";
            this.id_entry.Name = "id_entry";
            this.id_entry.ReadOnly = true;
            this.id_entry.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 30;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.HeaderText = "Название";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Жанр";
            this.dataGridViewTextBoxColumn3.MaxInputLength = 30;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewButtonColumn1
            // 
            this.dataGridViewButtonColumn1.HeaderText = "";
            this.dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            this.dataGridViewButtonColumn1.ReadOnly = true;
            this.dataGridViewButtonColumn1.Width = 70;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FormsForBD.Properties.Resources.log1;
            this.pictureBox1.Location = new System.Drawing.Point(8, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 34);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // OpenResultsButton
            // 
            this.OpenResultsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OpenResultsButton.Location = new System.Drawing.Point(12, 810);
            this.OpenResultsButton.Name = "OpenResultsButton";
            this.OpenResultsButton.Size = new System.Drawing.Size(1169, 46);
            this.OpenResultsButton.TabIndex = 8;
            this.OpenResultsButton.Text = "Перейти к результатам опроса";
            this.OpenResultsButton.UseVisualStyleBackColor = true;
            this.OpenResultsButton.Click += new System.EventHandler(this.OpenResultsButton_Click);
            // 
            // AdminWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1195, 868);
            this.Controls.Add(this.OpenResultsButton);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AdminWindow";
            this.Text = "CRUD";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MusicianDgw)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SongDgw)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SongMusicianDgw)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SongStyleDgw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.DataGridView SongMusicianDgw;
        private System.Windows.Forms.Label musician_label;
        private System.Windows.Forms.Label song_label1;
        private System.Windows.Forms.Button AddSongMusicianButton;
        private System.Windows.Forms.Button ChoiceMusicianButton;
        private System.Windows.Forms.Button ChoiceSongButton1;
        private System.Windows.Forms.DataGridViewTextBoxColumn entry_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn s_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn s_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_name;
        private System.Windows.Forms.DataGridViewButtonColumn save_s_m;
        private System.Windows.Forms.DataGridViewButtonColumn del_s_m;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button ChoiceSongButton2;
        private System.Windows.Forms.Label song_label2;
        private System.Windows.Forms.DataGridView SongStyleDgw;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox StyleTextBox;
        private System.Windows.Forms.Button AddStyleSongButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_entry;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn1;
        private System.Windows.Forms.Button OpenResultsButton;
    }
}