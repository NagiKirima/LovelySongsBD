namespace FormsForBD
{
    partial class UserWindow
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.StyleRadioButton = new System.Windows.Forms.RadioButton();
            this.MusicianRadioButton = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.AllSongDgw = new System.Windows.Forms.DataGridView();
            this.id_song = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.song_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filter_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.FilterButton = new System.Windows.Forms.Button();
            this.FilterTextBox = new System.Windows.Forms.TextBox();
            this.SendDgw = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewButtonColumn1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.login_label = new System.Windows.Forms.Label();
            this.FixUserDataButton = new System.Windows.Forms.Button();
            this.SaveSongButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AllSongDgw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SendDgw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.StyleRadioButton);
            this.groupBox1.Controls.Add(this.MusicianRadioButton);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(210, 85);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // StyleRadioButton
            // 
            this.StyleRadioButton.AutoSize = true;
            this.StyleRadioButton.Location = new System.Drawing.Point(84, 52);
            this.StyleRadioButton.Name = "StyleRadioButton";
            this.StyleRadioButton.Size = new System.Drawing.Size(63, 20);
            this.StyleRadioButton.TabIndex = 2;
            this.StyleRadioButton.TabStop = true;
            this.StyleRadioButton.Text = "Жанр";
            this.StyleRadioButton.UseVisualStyleBackColor = true;
            // 
            // MusicianRadioButton
            // 
            this.MusicianRadioButton.AutoSize = true;
            this.MusicianRadioButton.Location = new System.Drawing.Point(84, 19);
            this.MusicianRadioButton.Name = "MusicianRadioButton";
            this.MusicianRadioButton.Size = new System.Drawing.Size(113, 20);
            this.MusicianRadioButton.TabIndex = 1;
            this.MusicianRadioButton.TabStop = true;
            this.MusicianRadioButton.Text = "Исполнитель";
            this.MusicianRadioButton.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FormsForBD.Properties.Resources.filter;
            this.pictureBox1.Location = new System.Drawing.Point(6, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // AllSongDgw
            // 
            this.AllSongDgw.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.AllSongDgw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AllSongDgw.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_song,
            this.song_name,
            this.filter_name,
            this.btn});
            this.AllSongDgw.Location = new System.Drawing.Point(12, 116);
            this.AllSongDgw.Name = "AllSongDgw";
            this.AllSongDgw.Size = new System.Drawing.Size(564, 408);
            this.AllSongDgw.TabIndex = 2;
            this.AllSongDgw.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AllSongDgw_CellContentClick);
            // 
            // id_song
            // 
            this.id_song.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.id_song.HeaderText = "ID";
            this.id_song.Name = "id_song";
            this.id_song.ReadOnly = true;
            this.id_song.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.id_song.Visible = false;
            this.id_song.Width = 30;
            // 
            // song_name
            // 
            this.song_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.song_name.HeaderText = "Название";
            this.song_name.MinimumWidth = 210;
            this.song_name.Name = "song_name";
            this.song_name.ReadOnly = true;
            // 
            // filter_name
            // 
            this.filter_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.filter_name.HeaderText = "Музыкант/жанр";
            this.filter_name.MinimumWidth = 210;
            this.filter_name.Name = "filter_name";
            this.filter_name.ReadOnly = true;
            // 
            // btn
            // 
            this.btn.HeaderText = "";
            this.btn.Name = "btn";
            this.btn.ReadOnly = true;
            // 
            // FilterButton
            // 
            this.FilterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FilterButton.Location = new System.Drawing.Point(228, 64);
            this.FilterButton.Name = "FilterButton";
            this.FilterButton.Size = new System.Drawing.Size(284, 33);
            this.FilterButton.TabIndex = 3;
            this.FilterButton.Text = "Выбрать";
            this.FilterButton.UseVisualStyleBackColor = true;
            this.FilterButton.Click += new System.EventHandler(this.FilterButton_Click);
            // 
            // FilterTextBox
            // 
            this.FilterTextBox.Enabled = false;
            this.FilterTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FilterTextBox.Location = new System.Drawing.Point(228, 22);
            this.FilterTextBox.MaxLength = 128;
            this.FilterTextBox.Multiline = true;
            this.FilterTextBox.Name = "FilterTextBox";
            this.FilterTextBox.Size = new System.Drawing.Size(284, 36);
            this.FilterTextBox.TabIndex = 5;
            this.FilterTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SendDgw
            // 
            this.SendDgw.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.SendDgw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SendDgw.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.user_id,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewButtonColumn1});
            this.SendDgw.Location = new System.Drawing.Point(611, 116);
            this.SendDgw.Name = "SendDgw";
            this.SendDgw.Size = new System.Drawing.Size(564, 408);
            this.SendDgw.TabIndex = 6;
            this.SendDgw.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SendDgw_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn1.Visible = false;
            this.dataGridViewTextBoxColumn1.Width = 30;
            // 
            // user_id
            // 
            this.user_id.HeaderText = "ID пользователя";
            this.user_id.Name = "user_id";
            this.user_id.ReadOnly = true;
            this.user_id.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.HeaderText = "Название";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 210;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.HeaderText = "Оценка";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 210;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewButtonColumn1
            // 
            this.dataGridViewButtonColumn1.HeaderText = "";
            this.dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            this.dataGridViewButtonColumn1.ReadOnly = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::FormsForBD.Properties.Resources.log1;
            this.pictureBox2.Location = new System.Drawing.Point(608, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(34, 34);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // login_label
            // 
            this.login_label.BackColor = System.Drawing.SystemColors.Window;
            this.login_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.login_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login_label.Location = new System.Drawing.Point(659, 12);
            this.login_label.Name = "login_label";
            this.login_label.Size = new System.Drawing.Size(290, 35);
            this.login_label.TabIndex = 8;
            this.login_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FixUserDataButton
            // 
            this.FixUserDataButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FixUserDataButton.Location = new System.Drawing.Point(977, 12);
            this.FixUserDataButton.Name = "FixUserDataButton";
            this.FixUserDataButton.Size = new System.Drawing.Size(198, 51);
            this.FixUserDataButton.TabIndex = 9;
            this.FixUserDataButton.Text = "Исправить личную информацию";
            this.FixUserDataButton.UseVisualStyleBackColor = true;
            this.FixUserDataButton.Click += new System.EventHandler(this.FixUserDataButton_Click);
            // 
            // SaveSongButton
            // 
            this.SaveSongButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveSongButton.Location = new System.Drawing.Point(977, 69);
            this.SaveSongButton.Name = "SaveSongButton";
            this.SaveSongButton.Size = new System.Drawing.Size(198, 36);
            this.SaveSongButton.TabIndex = 10;
            this.SaveSongButton.Text = "Сохранить плейлист";
            this.SaveSongButton.UseVisualStyleBackColor = true;
            this.SaveSongButton.Click += new System.EventHandler(this.SaveSongButton_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(608, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 34);
            this.label1.TabIndex = 11;
            this.label1.Text = "Ваш плейлист:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UserWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 538);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SaveSongButton);
            this.Controls.Add(this.FixUserDataButton);
            this.Controls.Add(this.login_label);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.SendDgw);
            this.Controls.Add(this.FilterTextBox);
            this.Controls.Add(this.FilterButton);
            this.Controls.Add(this.AllSongDgw);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "UserWindow";
            this.Text = "Любимые песни";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AllSongDgw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SendDgw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton StyleRadioButton;
        private System.Windows.Forms.RadioButton MusicianRadioButton;
        private System.Windows.Forms.DataGridView AllSongDgw;
        private System.Windows.Forms.Button FilterButton;
        internal System.Windows.Forms.TextBox FilterTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_song;
        private System.Windows.Forms.DataGridViewTextBoxColumn song_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn filter_name;
        private System.Windows.Forms.DataGridViewButtonColumn btn;
        private System.Windows.Forms.DataGridView SendDgw;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label login_label;
        private System.Windows.Forms.Button FixUserDataButton;
        private System.Windows.Forms.Button SaveSongButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn1;
    }
}