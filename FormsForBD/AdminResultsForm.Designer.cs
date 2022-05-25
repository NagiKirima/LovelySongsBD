namespace FormsForBD
{
    partial class AdminResultsForm
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
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.ShowButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ChoiceFilterButton = new System.Windows.Forms.Button();
            this.FilterRaitingTextBox = new System.Windows.Forms.TextBox();
            this.DateTextBox = new System.Windows.Forms.TextBox();
            this.PlaylistDgw = new System.Windows.Forms.DataGridView();
            this.ID_song = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_user = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user_surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user_patr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user_age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user_gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.song_title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.song_mark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FilterDateButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.RaitingDgw = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.clear_label = new System.Windows.Forms.LinkLabel();
            this.AddDiscButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.DiscDgw = new System.Windows.Forms.DataGridView();
            this.SongDiscDgw = new System.Windows.Forms.DataGridView();
            this.id_sng = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sng_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sng_count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sng_avg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.raiting_filter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.disc_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_dsc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dsc_filter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_disc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.disc_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.disc_filter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delete_entry = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PlaylistDgw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RaitingDgw)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DiscDgw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SongDiscDgw)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.clear_label);
            this.groupBox6.Controls.Add(this.ShowButton);
            this.groupBox6.Controls.Add(this.label1);
            this.groupBox6.Controls.Add(this.ChoiceFilterButton);
            this.groupBox6.Controls.Add(this.FilterRaitingTextBox);
            this.groupBox6.Controls.Add(this.DateTextBox);
            this.groupBox6.Controls.Add(this.PlaylistDgw);
            this.groupBox6.Controls.Add(this.FilterDateButton);
            this.groupBox6.Controls.Add(this.label7);
            this.groupBox6.Location = new System.Drawing.Point(12, 12);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(968, 414);
            this.groupBox6.TabIndex = 16;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Результаты опроса";
            // 
            // ShowButton
            // 
            this.ShowButton.Location = new System.Drawing.Point(759, 19);
            this.ShowButton.Name = "ShowButton";
            this.ShowButton.Size = new System.Drawing.Size(194, 35);
            this.ShowButton.TabIndex = 21;
            this.ShowButton.Text = "Показать";
            this.ShowButton.UseVisualStyleBackColor = true;
            this.ShowButton.Click += new System.EventHandler(this.ShowButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(385, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 16);
            this.label1.TabIndex = 20;
            this.label1.Text = "По";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ChoiceFilterButton
            // 
            this.ChoiceFilterButton.Location = new System.Drawing.Point(518, 19);
            this.ChoiceFilterButton.Name = "ChoiceFilterButton";
            this.ChoiceFilterButton.Size = new System.Drawing.Size(223, 35);
            this.ChoiceFilterButton.TabIndex = 19;
            this.ChoiceFilterButton.Text = "Выбрать критерии";
            this.ChoiceFilterButton.UseVisualStyleBackColor = true;
            this.ChoiceFilterButton.Click += new System.EventHandler(this.ChoiceFilterButton_Click);
            // 
            // FilterRaitingTextBox
            // 
            this.FilterRaitingTextBox.Enabled = false;
            this.FilterRaitingTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FilterRaitingTextBox.Location = new System.Drawing.Point(417, 19);
            this.FilterRaitingTextBox.MaxLength = 3;
            this.FilterRaitingTextBox.Multiline = true;
            this.FilterRaitingTextBox.Name = "FilterRaitingTextBox";
            this.FilterRaitingTextBox.Size = new System.Drawing.Size(95, 35);
            this.FilterRaitingTextBox.TabIndex = 18;
            // 
            // DateTextBox
            // 
            this.DateTextBox.Enabled = false;
            this.DateTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DateTextBox.Location = new System.Drawing.Point(52, 19);
            this.DateTextBox.MaxLength = 7;
            this.DateTextBox.Multiline = true;
            this.DateTextBox.Name = "DateTextBox";
            this.DateTextBox.Size = new System.Drawing.Size(95, 35);
            this.DateTextBox.TabIndex = 17;
            // 
            // PlaylistDgw
            // 
            this.PlaylistDgw.AllowUserToAddRows = false;
            this.PlaylistDgw.AllowUserToDeleteRows = false;
            this.PlaylistDgw.AllowUserToResizeColumns = false;
            this.PlaylistDgw.AllowUserToResizeRows = false;
            this.PlaylistDgw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PlaylistDgw.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_song,
            this.ID_user,
            this.user_surname,
            this.user_name,
            this.user_patr,
            this.user_age,
            this.user_gender,
            this.song_title,
            this.song_mark});
            this.PlaylistDgw.Location = new System.Drawing.Point(9, 62);
            this.PlaylistDgw.Name = "PlaylistDgw";
            this.PlaylistDgw.Size = new System.Drawing.Size(944, 346);
            this.PlaylistDgw.TabIndex = 16;
            // 
            // ID_song
            // 
            this.ID_song.HeaderText = "ID song";
            this.ID_song.Name = "ID_song";
            this.ID_song.ReadOnly = true;
            this.ID_song.Width = 40;
            // 
            // ID_user
            // 
            this.ID_user.HeaderText = "ID user";
            this.ID_user.Name = "ID_user";
            this.ID_user.ReadOnly = true;
            this.ID_user.Width = 40;
            // 
            // user_surname
            // 
            this.user_surname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.user_surname.HeaderText = "Фамилия";
            this.user_surname.Name = "user_surname";
            this.user_surname.ReadOnly = true;
            // 
            // user_name
            // 
            this.user_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.user_name.HeaderText = "Имя";
            this.user_name.Name = "user_name";
            this.user_name.ReadOnly = true;
            // 
            // user_patr
            // 
            this.user_patr.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.user_patr.HeaderText = "Отчество";
            this.user_patr.Name = "user_patr";
            this.user_patr.ReadOnly = true;
            // 
            // user_age
            // 
            this.user_age.HeaderText = "Возраст";
            this.user_age.Name = "user_age";
            this.user_age.ReadOnly = true;
            this.user_age.Width = 55;
            // 
            // user_gender
            // 
            this.user_gender.HeaderText = "Пол";
            this.user_gender.Name = "user_gender";
            this.user_gender.ReadOnly = true;
            this.user_gender.Width = 40;
            // 
            // song_title
            // 
            this.song_title.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.song_title.HeaderText = "Название";
            this.song_title.Name = "song_title";
            this.song_title.ReadOnly = true;
            // 
            // song_mark
            // 
            this.song_mark.HeaderText = "Оценка";
            this.song_mark.Name = "song_mark";
            this.song_mark.ReadOnly = true;
            this.song_mark.Width = 50;
            // 
            // FilterDateButton
            // 
            this.FilterDateButton.Location = new System.Drawing.Point(153, 18);
            this.FilterDateButton.Name = "FilterDateButton";
            this.FilterDateButton.Size = new System.Drawing.Size(223, 35);
            this.FilterDateButton.TabIndex = 14;
            this.FilterDateButton.Text = "Выбрать дату";
            this.FilterDateButton.UseVisualStyleBackColor = true;
            this.FilterDateButton.Click += new System.EventHandler(this.FilterDateButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(6, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "Дата";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // RaitingDgw
            // 
            this.RaitingDgw.AllowUserToAddRows = false;
            this.RaitingDgw.AllowUserToDeleteRows = false;
            this.RaitingDgw.AllowUserToResizeColumns = false;
            this.RaitingDgw.AllowUserToResizeRows = false;
            this.RaitingDgw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RaitingDgw.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_sng,
            this.sng_name,
            this.sng_count,
            this.sng_avg,
            this.date,
            this.raiting_filter});
            this.RaitingDgw.Location = new System.Drawing.Point(9, 19);
            this.RaitingDgw.Name = "RaitingDgw";
            this.RaitingDgw.Size = new System.Drawing.Size(944, 346);
            this.RaitingDgw.TabIndex = 17;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RaitingDgw);
            this.groupBox1.Location = new System.Drawing.Point(12, 432);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(968, 409);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Рейтинг";
            // 
            // clear_label
            // 
            this.clear_label.AutoSize = true;
            this.clear_label.Location = new System.Drawing.Point(414, 3);
            this.clear_label.Name = "clear_label";
            this.clear_label.Size = new System.Drawing.Size(54, 13);
            this.clear_label.TabIndex = 22;
            this.clear_label.TabStop = true;
            this.clear_label.Text = "Очистить";
            this.clear_label.VisitedLinkColor = System.Drawing.Color.Blue;
            this.clear_label.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.clear_label_LinkClicked);
            // 
            // AddDiscButton
            // 
            this.AddDiscButton.Location = new System.Drawing.Point(12, 803);
            this.AddDiscButton.Name = "AddDiscButton";
            this.AddDiscButton.Size = new System.Drawing.Size(968, 38);
            this.AddDiscButton.TabIndex = 19;
            this.AddDiscButton.Text = "Выпустить пластинку";
            this.AddDiscButton.UseVisualStyleBackColor = true;
            this.AddDiscButton.Click += new System.EventHandler(this.AddDiscButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DiscDgw);
            this.groupBox2.Location = new System.Drawing.Point(997, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(567, 411);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Пластинки";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.SongDiscDgw);
            this.groupBox3.Location = new System.Drawing.Point(997, 432);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(567, 409);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Треки в пластинках";
            // 
            // DiscDgw
            // 
            this.DiscDgw.AllowUserToAddRows = false;
            this.DiscDgw.AllowUserToDeleteRows = false;
            this.DiscDgw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DiscDgw.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_disc,
            this.disc_date,
            this.disc_filter,
            this.delete_entry});
            this.DiscDgw.Location = new System.Drawing.Point(15, 19);
            this.DiscDgw.Name = "DiscDgw";
            this.DiscDgw.ReadOnly = true;
            this.DiscDgw.Size = new System.Drawing.Size(537, 386);
            this.DiscDgw.TabIndex = 0;
            this.DiscDgw.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DiscDgw_CellContentClick);
            // 
            // SongDiscDgw
            // 
            this.SongDiscDgw.AllowUserToAddRows = false;
            this.SongDiscDgw.AllowUserToDeleteRows = false;
            this.SongDiscDgw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SongDiscDgw.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.disc_id,
            this.dataGridViewTextBoxColumn1,
            this.name,
            this.date_dsc,
            this.dsc_filter});
            this.SongDiscDgw.Location = new System.Drawing.Point(15, 19);
            this.SongDiscDgw.Name = "SongDiscDgw";
            this.SongDiscDgw.ReadOnly = true;
            this.SongDiscDgw.Size = new System.Drawing.Size(537, 384);
            this.SongDiscDgw.TabIndex = 1;
            // 
            // id_sng
            // 
            this.id_sng.HeaderText = "ID";
            this.id_sng.Name = "id_sng";
            this.id_sng.ReadOnly = true;
            this.id_sng.Width = 40;
            // 
            // sng_name
            // 
            this.sng_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sng_name.HeaderText = "Название";
            this.sng_name.Name = "sng_name";
            this.sng_name.ReadOnly = true;
            // 
            // sng_count
            // 
            this.sng_count.HeaderText = "Количество человек";
            this.sng_count.Name = "sng_count";
            this.sng_count.ReadOnly = true;
            // 
            // sng_avg
            // 
            this.sng_avg.HeaderText = "Средний балл";
            this.sng_avg.Name = "sng_avg";
            this.sng_avg.ReadOnly = true;
            // 
            // date
            // 
            this.date.HeaderText = "Дата";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            // 
            // raiting_filter
            // 
            this.raiting_filter.HeaderText = "Критерий";
            this.raiting_filter.Name = "raiting_filter";
            this.raiting_filter.ReadOnly = true;
            // 
            // disc_id
            // 
            this.disc_id.HeaderText = "ID disc";
            this.disc_id.Name = "disc_id";
            this.disc_id.ReadOnly = true;
            this.disc_id.Width = 45;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "ID song";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 45;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.HeaderText = "Название";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // date_dsc
            // 
            this.date_dsc.HeaderText = "Дата";
            this.date_dsc.Name = "date_dsc";
            this.date_dsc.ReadOnly = true;
            // 
            // dsc_filter
            // 
            this.dsc_filter.HeaderText = "Критерий";
            this.dsc_filter.Name = "dsc_filter";
            this.dsc_filter.ReadOnly = true;
            // 
            // id_disc
            // 
            this.id_disc.HeaderText = "ID";
            this.id_disc.Name = "id_disc";
            this.id_disc.ReadOnly = true;
            this.id_disc.Width = 30;
            // 
            // disc_date
            // 
            this.disc_date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.disc_date.HeaderText = "Дата";
            this.disc_date.Name = "disc_date";
            this.disc_date.ReadOnly = true;
            // 
            // disc_filter
            // 
            this.disc_filter.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.disc_filter.HeaderText = "Критерий";
            this.disc_filter.Name = "disc_filter";
            this.disc_filter.ReadOnly = true;
            // 
            // delete_entry
            // 
            this.delete_entry.HeaderText = "";
            this.delete_entry.Name = "delete_entry";
            this.delete_entry.ReadOnly = true;
            this.delete_entry.Width = 70;
            // 
            // AdminResultsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1576, 847);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.AddDiscButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AdminResultsForm";
            this.Text = "Составление пластинок";
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PlaylistDgw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RaitingDgw)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DiscDgw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SongDiscDgw)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.DataGridView PlaylistDgw;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_song;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_user;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_patr;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_age;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn song_title;
        private System.Windows.Forms.DataGridViewTextBoxColumn song_mark;
        private System.Windows.Forms.Button FilterDateButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox DateTextBox;
        private System.Windows.Forms.DataGridView RaitingDgw;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ChoiceFilterButton;
        private System.Windows.Forms.TextBox FilterRaitingTextBox;
        private System.Windows.Forms.Button ShowButton;
        private System.Windows.Forms.LinkLabel clear_label;
        private System.Windows.Forms.Button AddDiscButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView DiscDgw;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView SongDiscDgw;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_sng;
        private System.Windows.Forms.DataGridViewTextBoxColumn sng_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn sng_count;
        private System.Windows.Forms.DataGridViewTextBoxColumn sng_avg;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn raiting_filter;
        private System.Windows.Forms.DataGridViewTextBoxColumn disc_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_dsc;
        private System.Windows.Forms.DataGridViewTextBoxColumn dsc_filter;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_disc;
        private System.Windows.Forms.DataGridViewTextBoxColumn disc_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn disc_filter;
        private System.Windows.Forms.DataGridViewButtonColumn delete_entry;
    }
}