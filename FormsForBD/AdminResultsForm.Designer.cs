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
            this.DateTextBox = new System.Windows.Forms.TextBox();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PlaylistDgw)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox6
            // 
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
            this.FilterDateButton.Location = new System.Drawing.Point(244, 19);
            this.FilterDateButton.Name = "FilterDateButton";
            this.FilterDateButton.Size = new System.Drawing.Size(223, 37);
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
            // DateTextBox
            // 
            this.DateTextBox.Enabled = false;
            this.DateTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DateTextBox.Location = new System.Drawing.Point(52, 19);
            this.DateTextBox.MaxLength = 30;
            this.DateTextBox.Multiline = true;
            this.DateTextBox.Name = "DateTextBox";
            this.DateTextBox.Size = new System.Drawing.Size(186, 37);
            this.DateTextBox.TabIndex = 17;
            // 
            // AdminResultsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 438);
            this.Controls.Add(this.groupBox6);
            this.Name = "AdminResultsForm";
            this.Text = "AdminResultsForm";
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PlaylistDgw)).EndInit();
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
    }
}