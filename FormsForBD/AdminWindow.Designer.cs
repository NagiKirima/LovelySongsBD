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
            this.PeopleTable = new System.Windows.Forms.DataGridView();
            this.HumanID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.music = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PeopleAge = new System.Windows.Forms.TextBox();
            this.PeopleName = new System.Windows.Forms.TextBox();
            this.PeopleGroupBox = new System.Windows.Forms.GroupBox();
            this.PeopleMusicCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.AddPeopleButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.GenderRadioButtonM = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.GenderRadioButtonF = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.MusicGroupBox = new System.Windows.Forms.GroupBox();
            this.MusciOwnerTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.AddMusicButton = new System.Windows.Forms.Button();
            this.MusicNameTextBox = new System.Windows.Forms.TextBox();
            this.RatingFiltersGroupBox = new System.Windows.Forms.GroupBox();
            this.OtherFilterGroupBox = new System.Windows.Forms.GroupBox();
            this.NoneOtherFilterRadioButton = new System.Windows.Forms.RadioButton();
            this.VoteOtherFilterRadioButton = new System.Windows.Forms.RadioButton();
            this.PointsOtherFilterRadioButton = new System.Windows.Forms.RadioButton();
            this.CreateRatingButton = new System.Windows.Forms.Button();
            this.GenderFilterGroupBox = new System.Windows.Forms.GroupBox();
            this.NoneGenderFilterRadioButton = new System.Windows.Forms.RadioButton();
            this.FemaleGenderFilterRadioButton = new System.Windows.Forms.RadioButton();
            this.MaleGenderFilterRadioButton = new System.Windows.Forms.RadioButton();
            this.AgeFilterGroupBox = new System.Windows.Forms.GroupBox();
            this.NoneAgeFilterRadioButton = new System.Windows.Forms.RadioButton();
            this.AgeFilterTextBox = new System.Windows.Forms.TextBox();
            this.LessAgeFilterRadioButton = new System.Windows.Forms.RadioButton();
            this.EqualsAgeFilterRadioButton = new System.Windows.Forms.RadioButton();
            this.MoreAgeFilterRadioButton = new System.Windows.Forms.RadioButton();
            this.RatingTable = new System.Windows.Forms.DataGridView();
            this.MusicId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MusicName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Owner = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PeopleCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Points = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.DeleteRowsGroupBox = new System.Windows.Forms.GroupBox();
            this.MusicIdCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.PeopleIdCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.DeleteMusicButton = new System.Windows.Forms.Button();
            this.DeletePeopleButton = new System.Windows.Forms.Button();
            this.AlbumTable = new System.Windows.Forms.DataGridView();
            this.AlbumID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AgeBench = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GenderBench = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PointBench = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MusicList = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddAlbumButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PeopleTable)).BeginInit();
            this.PeopleGroupBox.SuspendLayout();
            this.MusicGroupBox.SuspendLayout();
            this.RatingFiltersGroupBox.SuspendLayout();
            this.OtherFilterGroupBox.SuspendLayout();
            this.GenderFilterGroupBox.SuspendLayout();
            this.AgeFilterGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RatingTable)).BeginInit();
            this.DeleteRowsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AlbumTable)).BeginInit();
            this.SuspendLayout();
            // 
            // PeopleTable
            // 
            this.PeopleTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PeopleTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HumanID,
            this.name,
            this.age,
            this.gender,
            this.music});
            this.PeopleTable.Location = new System.Drawing.Point(12, 172);
            this.PeopleTable.Name = "PeopleTable";
            this.PeopleTable.Size = new System.Drawing.Size(469, 243);
            this.PeopleTable.TabIndex = 0;
            // 
            // HumanID
            // 
            this.HumanID.Frozen = true;
            this.HumanID.HeaderText = "ID";
            this.HumanID.Name = "HumanID";
            this.HumanID.ReadOnly = true;
            this.HumanID.Width = 35;
            // 
            // name
            // 
            this.name.Frozen = true;
            this.name.HeaderText = "ФИО";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // age
            // 
            this.age.Frozen = true;
            this.age.HeaderText = "Возраст";
            this.age.Name = "age";
            this.age.ReadOnly = true;
            this.age.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.age.Width = 55;
            // 
            // gender
            // 
            this.gender.Frozen = true;
            this.gender.HeaderText = "Пол";
            this.gender.Name = "gender";
            this.gender.ReadOnly = true;
            this.gender.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.gender.Width = 35;
            // 
            // music
            // 
            this.music.Frozen = true;
            this.music.HeaderText = "Музыка";
            this.music.Name = "music";
            this.music.ReadOnly = true;
            this.music.Width = 200;
            // 
            // PeopleAge
            // 
            this.PeopleAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PeopleAge.Location = new System.Drawing.Point(197, 45);
            this.PeopleAge.Multiline = true;
            this.PeopleAge.Name = "PeopleAge";
            this.PeopleAge.Size = new System.Drawing.Size(44, 28);
            this.PeopleAge.TabIndex = 2;
            // 
            // PeopleName
            // 
            this.PeopleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PeopleName.Location = new System.Drawing.Point(12, 45);
            this.PeopleName.Multiline = true;
            this.PeopleName.Name = "PeopleName";
            this.PeopleName.Size = new System.Drawing.Size(179, 28);
            this.PeopleName.TabIndex = 1;
            // 
            // PeopleGroupBox
            // 
            this.PeopleGroupBox.Controls.Add(this.PeopleMusicCheckedListBox);
            this.PeopleGroupBox.Controls.Add(this.AddPeopleButton);
            this.PeopleGroupBox.Controls.Add(this.label5);
            this.PeopleGroupBox.Controls.Add(this.PeopleName);
            this.PeopleGroupBox.Controls.Add(this.PeopleAge);
            this.PeopleGroupBox.Controls.Add(this.GenderRadioButtonM);
            this.PeopleGroupBox.Controls.Add(this.label3);
            this.PeopleGroupBox.Controls.Add(this.GenderRadioButtonF);
            this.PeopleGroupBox.Controls.Add(this.label2);
            this.PeopleGroupBox.Controls.Add(this.label1);
            this.PeopleGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PeopleGroupBox.Location = new System.Drawing.Point(12, 12);
            this.PeopleGroupBox.Name = "PeopleGroupBox";
            this.PeopleGroupBox.Size = new System.Drawing.Size(469, 127);
            this.PeopleGroupBox.TabIndex = 3;
            this.PeopleGroupBox.TabStop = false;
            this.PeopleGroupBox.Text = "Данные опрашиваемого";
            // 
            // PeopleMusicCheckedListBox
            // 
            this.PeopleMusicCheckedListBox.FormattingEnabled = true;
            this.PeopleMusicCheckedListBox.Items.AddRange(new object[] {
            "1 - Барбарик",
            "2 - Чинчопка",
            "3 - Тыры пыры",
            "4 - Кольщик",
            "5 - Владимирский централ"});
            this.PeopleMusicCheckedListBox.Location = new System.Drawing.Point(309, 45);
            this.PeopleMusicCheckedListBox.Name = "PeopleMusicCheckedListBox";
            this.PeopleMusicCheckedListBox.Size = new System.Drawing.Size(154, 34);
            this.PeopleMusicCheckedListBox.TabIndex = 15;
            // 
            // AddPeopleButton
            // 
            this.AddPeopleButton.Location = new System.Drawing.Point(12, 98);
            this.AddPeopleButton.Name = "AddPeopleButton";
            this.AddPeopleButton.Size = new System.Drawing.Size(451, 23);
            this.AddPeopleButton.TabIndex = 13;
            this.AddPeopleButton.Text = "Добавить";
            this.AddPeopleButton.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(307, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Любимые песни";
            // 
            // GenderRadioButtonM
            // 
            this.GenderRadioButtonM.AutoSize = true;
            this.GenderRadioButtonM.Location = new System.Drawing.Point(252, 45);
            this.GenderRadioButtonM.Name = "GenderRadioButtonM";
            this.GenderRadioButtonM.Size = new System.Drawing.Size(34, 17);
            this.GenderRadioButtonM.TabIndex = 5;
            this.GenderRadioButtonM.TabStop = true;
            this.GenderRadioButtonM.Text = "М";
            this.GenderRadioButtonM.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(249, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Пол";
            // 
            // GenderRadioButtonF
            // 
            this.GenderRadioButtonF.AutoSize = true;
            this.GenderRadioButtonF.Location = new System.Drawing.Point(252, 68);
            this.GenderRadioButtonF.Name = "GenderRadioButtonF";
            this.GenderRadioButtonF.Size = new System.Drawing.Size(36, 17);
            this.GenderRadioButtonF.TabIndex = 6;
            this.GenderRadioButtonF.TabStop = true;
            this.GenderRadioButtonF.Text = "Ж";
            this.GenderRadioButtonF.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(194, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Возраст";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "ФИО";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Результаты опроса";
            // 
            // MusicGroupBox
            // 
            this.MusicGroupBox.Controls.Add(this.MusciOwnerTextBox);
            this.MusicGroupBox.Controls.Add(this.label7);
            this.MusicGroupBox.Controls.Add(this.label6);
            this.MusicGroupBox.Controls.Add(this.AddMusicButton);
            this.MusicGroupBox.Controls.Add(this.MusicNameTextBox);
            this.MusicGroupBox.Location = new System.Drawing.Point(516, 12);
            this.MusicGroupBox.Name = "MusicGroupBox";
            this.MusicGroupBox.Size = new System.Drawing.Size(304, 127);
            this.MusicGroupBox.TabIndex = 11;
            this.MusicGroupBox.TabStop = false;
            this.MusicGroupBox.Text = "Данные песни";
            // 
            // MusciOwnerTextBox
            // 
            this.MusciOwnerTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MusciOwnerTextBox.Location = new System.Drawing.Point(155, 42);
            this.MusciOwnerTextBox.Multiline = true;
            this.MusciOwnerTextBox.Name = "MusciOwnerTextBox";
            this.MusciOwnerTextBox.Size = new System.Drawing.Size(143, 28);
            this.MusciOwnerTextBox.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(152, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Исполнитель";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Название";
            // 
            // AddMusicButton
            // 
            this.AddMusicButton.Location = new System.Drawing.Point(6, 98);
            this.AddMusicButton.Name = "AddMusicButton";
            this.AddMusicButton.Size = new System.Drawing.Size(292, 23);
            this.AddMusicButton.TabIndex = 14;
            this.AddMusicButton.Text = "Добавить";
            this.AddMusicButton.UseVisualStyleBackColor = true;
            // 
            // MusicNameTextBox
            // 
            this.MusicNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MusicNameTextBox.Location = new System.Drawing.Point(6, 42);
            this.MusicNameTextBox.Multiline = true;
            this.MusicNameTextBox.Name = "MusicNameTextBox";
            this.MusicNameTextBox.Size = new System.Drawing.Size(143, 28);
            this.MusicNameTextBox.TabIndex = 14;
            // 
            // RatingFiltersGroupBox
            // 
            this.RatingFiltersGroupBox.Controls.Add(this.OtherFilterGroupBox);
            this.RatingFiltersGroupBox.Controls.Add(this.CreateRatingButton);
            this.RatingFiltersGroupBox.Controls.Add(this.GenderFilterGroupBox);
            this.RatingFiltersGroupBox.Controls.Add(this.AgeFilterGroupBox);
            this.RatingFiltersGroupBox.Location = new System.Drawing.Point(12, 430);
            this.RatingFiltersGroupBox.Name = "RatingFiltersGroupBox";
            this.RatingFiltersGroupBox.Size = new System.Drawing.Size(469, 187);
            this.RatingFiltersGroupBox.TabIndex = 12;
            this.RatingFiltersGroupBox.TabStop = false;
            this.RatingFiltersGroupBox.Text = "Критерии рейтинга";
            // 
            // OtherFilterGroupBox
            // 
            this.OtherFilterGroupBox.Controls.Add(this.NoneOtherFilterRadioButton);
            this.OtherFilterGroupBox.Controls.Add(this.VoteOtherFilterRadioButton);
            this.OtherFilterGroupBox.Controls.Add(this.PointsOtherFilterRadioButton);
            this.OtherFilterGroupBox.Location = new System.Drawing.Point(280, 19);
            this.OtherFilterGroupBox.Name = "OtherFilterGroupBox";
            this.OtherFilterGroupBox.Size = new System.Drawing.Size(174, 124);
            this.OtherFilterGroupBox.TabIndex = 17;
            this.OtherFilterGroupBox.TabStop = false;
            this.OtherFilterGroupBox.Text = "Другие критерии";
            // 
            // NoneOtherFilterRadioButton
            // 
            this.NoneOtherFilterRadioButton.AutoSize = true;
            this.NoneOtherFilterRadioButton.Location = new System.Drawing.Point(6, 66);
            this.NoneOtherFilterRadioButton.Name = "NoneOtherFilterRadioButton";
            this.NoneOtherFilterRadioButton.Size = new System.Drawing.Size(51, 17);
            this.NoneOtherFilterRadioButton.TabIndex = 2;
            this.NoneOtherFilterRadioButton.TabStop = true;
            this.NoneOtherFilterRadioButton.Text = "None";
            this.NoneOtherFilterRadioButton.UseVisualStyleBackColor = true;
            // 
            // VoteOtherFilterRadioButton
            // 
            this.VoteOtherFilterRadioButton.AutoSize = true;
            this.VoteOtherFilterRadioButton.Location = new System.Drawing.Point(6, 42);
            this.VoteOtherFilterRadioButton.Name = "VoteOtherFilterRadioButton";
            this.VoteOtherFilterRadioButton.Size = new System.Drawing.Size(143, 17);
            this.VoteOtherFilterRadioButton.TabIndex = 1;
            this.VoteOtherFilterRadioButton.TabStop = true;
            this.VoteOtherFilterRadioButton.Text = "По количеству голосов";
            this.VoteOtherFilterRadioButton.UseVisualStyleBackColor = true;
            // 
            // PointsOtherFilterRadioButton
            // 
            this.PointsOtherFilterRadioButton.AutoSize = true;
            this.PointsOtherFilterRadioButton.Location = new System.Drawing.Point(6, 19);
            this.PointsOtherFilterRadioButton.Name = "PointsOtherFilterRadioButton";
            this.PointsOtherFilterRadioButton.Size = new System.Drawing.Size(73, 17);
            this.PointsOtherFilterRadioButton.TabIndex = 0;
            this.PointsOtherFilterRadioButton.TabStop = true;
            this.PointsOtherFilterRadioButton.Text = "По очкам";
            this.PointsOtherFilterRadioButton.UseVisualStyleBackColor = true;
            // 
            // CreateRatingButton
            // 
            this.CreateRatingButton.Location = new System.Drawing.Point(17, 158);
            this.CreateRatingButton.Name = "CreateRatingButton";
            this.CreateRatingButton.Size = new System.Drawing.Size(437, 23);
            this.CreateRatingButton.TabIndex = 16;
            this.CreateRatingButton.Text = "Составить рейтинг";
            this.CreateRatingButton.UseVisualStyleBackColor = true;
            // 
            // GenderFilterGroupBox
            // 
            this.GenderFilterGroupBox.Controls.Add(this.NoneGenderFilterRadioButton);
            this.GenderFilterGroupBox.Controls.Add(this.FemaleGenderFilterRadioButton);
            this.GenderFilterGroupBox.Controls.Add(this.MaleGenderFilterRadioButton);
            this.GenderFilterGroupBox.Location = new System.Drawing.Point(188, 19);
            this.GenderFilterGroupBox.Name = "GenderFilterGroupBox";
            this.GenderFilterGroupBox.Size = new System.Drawing.Size(77, 124);
            this.GenderFilterGroupBox.TabIndex = 15;
            this.GenderFilterGroupBox.TabStop = false;
            this.GenderFilterGroupBox.Text = "По полу";
            // 
            // NoneGenderFilterRadioButton
            // 
            this.NoneGenderFilterRadioButton.AutoSize = true;
            this.NoneGenderFilterRadioButton.Location = new System.Drawing.Point(7, 66);
            this.NoneGenderFilterRadioButton.Name = "NoneGenderFilterRadioButton";
            this.NoneGenderFilterRadioButton.Size = new System.Drawing.Size(51, 17);
            this.NoneGenderFilterRadioButton.TabIndex = 2;
            this.NoneGenderFilterRadioButton.TabStop = true;
            this.NoneGenderFilterRadioButton.Text = "None";
            this.NoneGenderFilterRadioButton.UseVisualStyleBackColor = true;
            // 
            // FemaleGenderFilterRadioButton
            // 
            this.FemaleGenderFilterRadioButton.AutoSize = true;
            this.FemaleGenderFilterRadioButton.Location = new System.Drawing.Point(6, 42);
            this.FemaleGenderFilterRadioButton.Name = "FemaleGenderFilterRadioButton";
            this.FemaleGenderFilterRadioButton.Size = new System.Drawing.Size(36, 17);
            this.FemaleGenderFilterRadioButton.TabIndex = 1;
            this.FemaleGenderFilterRadioButton.TabStop = true;
            this.FemaleGenderFilterRadioButton.Text = "Ж";
            this.FemaleGenderFilterRadioButton.UseVisualStyleBackColor = true;
            // 
            // MaleGenderFilterRadioButton
            // 
            this.MaleGenderFilterRadioButton.AutoSize = true;
            this.MaleGenderFilterRadioButton.Location = new System.Drawing.Point(6, 19);
            this.MaleGenderFilterRadioButton.Name = "MaleGenderFilterRadioButton";
            this.MaleGenderFilterRadioButton.Size = new System.Drawing.Size(34, 17);
            this.MaleGenderFilterRadioButton.TabIndex = 0;
            this.MaleGenderFilterRadioButton.TabStop = true;
            this.MaleGenderFilterRadioButton.Text = "М";
            this.MaleGenderFilterRadioButton.UseVisualStyleBackColor = true;
            // 
            // AgeFilterGroupBox
            // 
            this.AgeFilterGroupBox.Controls.Add(this.NoneAgeFilterRadioButton);
            this.AgeFilterGroupBox.Controls.Add(this.AgeFilterTextBox);
            this.AgeFilterGroupBox.Controls.Add(this.LessAgeFilterRadioButton);
            this.AgeFilterGroupBox.Controls.Add(this.EqualsAgeFilterRadioButton);
            this.AgeFilterGroupBox.Controls.Add(this.MoreAgeFilterRadioButton);
            this.AgeFilterGroupBox.Location = new System.Drawing.Point(17, 19);
            this.AgeFilterGroupBox.Name = "AgeFilterGroupBox";
            this.AgeFilterGroupBox.Size = new System.Drawing.Size(155, 124);
            this.AgeFilterGroupBox.TabIndex = 15;
            this.AgeFilterGroupBox.TabStop = false;
            this.AgeFilterGroupBox.Text = "По возрасту";
            // 
            // NoneAgeFilterRadioButton
            // 
            this.NoneAgeFilterRadioButton.AutoSize = true;
            this.NoneAgeFilterRadioButton.Location = new System.Drawing.Point(9, 89);
            this.NoneAgeFilterRadioButton.Name = "NoneAgeFilterRadioButton";
            this.NoneAgeFilterRadioButton.Size = new System.Drawing.Size(51, 17);
            this.NoneAgeFilterRadioButton.TabIndex = 4;
            this.NoneAgeFilterRadioButton.TabStop = true;
            this.NoneAgeFilterRadioButton.Text = "None";
            this.NoneAgeFilterRadioButton.UseVisualStyleBackColor = true;
            // 
            // AgeFilterTextBox
            // 
            this.AgeFilterTextBox.Location = new System.Drawing.Point(86, 51);
            this.AgeFilterTextBox.Name = "AgeFilterTextBox";
            this.AgeFilterTextBox.Size = new System.Drawing.Size(57, 20);
            this.AgeFilterTextBox.TabIndex = 3;
            // 
            // LessAgeFilterRadioButton
            // 
            this.LessAgeFilterRadioButton.AutoSize = true;
            this.LessAgeFilterRadioButton.Location = new System.Drawing.Point(9, 66);
            this.LessAgeFilterRadioButton.Name = "LessAgeFilterRadioButton";
            this.LessAgeFilterRadioButton.Size = new System.Drawing.Size(66, 17);
            this.LessAgeFilterRadioButton.TabIndex = 2;
            this.LessAgeFilterRadioButton.TabStop = true;
            this.LessAgeFilterRadioButton.Text = "Меньше";
            this.LessAgeFilterRadioButton.UseVisualStyleBackColor = true;
            // 
            // EqualsAgeFilterRadioButton
            // 
            this.EqualsAgeFilterRadioButton.AutoSize = true;
            this.EqualsAgeFilterRadioButton.Location = new System.Drawing.Point(9, 42);
            this.EqualsAgeFilterRadioButton.Name = "EqualsAgeFilterRadioButton";
            this.EqualsAgeFilterRadioButton.Size = new System.Drawing.Size(56, 17);
            this.EqualsAgeFilterRadioButton.TabIndex = 1;
            this.EqualsAgeFilterRadioButton.TabStop = true;
            this.EqualsAgeFilterRadioButton.Text = "Равно";
            this.EqualsAgeFilterRadioButton.UseVisualStyleBackColor = true;
            // 
            // MoreAgeFilterRadioButton
            // 
            this.MoreAgeFilterRadioButton.AutoSize = true;
            this.MoreAgeFilterRadioButton.Location = new System.Drawing.Point(9, 18);
            this.MoreAgeFilterRadioButton.Name = "MoreAgeFilterRadioButton";
            this.MoreAgeFilterRadioButton.Size = new System.Drawing.Size(64, 17);
            this.MoreAgeFilterRadioButton.TabIndex = 0;
            this.MoreAgeFilterRadioButton.TabStop = true;
            this.MoreAgeFilterRadioButton.Text = "Больше";
            this.MoreAgeFilterRadioButton.UseVisualStyleBackColor = true;
            // 
            // RatingTable
            // 
            this.RatingTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RatingTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MusicId,
            this.MusicName,
            this.Owner,
            this.PeopleCount,
            this.Points});
            this.RatingTable.Location = new System.Drawing.Point(516, 172);
            this.RatingTable.Name = "RatingTable";
            this.RatingTable.Size = new System.Drawing.Size(518, 243);
            this.RatingTable.TabIndex = 13;
            // 
            // MusicId
            // 
            this.MusicId.HeaderText = "ID";
            this.MusicId.Name = "MusicId";
            this.MusicId.ReadOnly = true;
            this.MusicId.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.MusicId.Width = 35;
            // 
            // MusicName
            // 
            this.MusicName.HeaderText = "Название песни";
            this.MusicName.Name = "MusicName";
            this.MusicName.ReadOnly = true;
            this.MusicName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.MusicName.Width = 150;
            // 
            // Owner
            // 
            this.Owner.HeaderText = "Исполнитель";
            this.Owner.Name = "Owner";
            this.Owner.ReadOnly = true;
            this.Owner.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Owner.Width = 150;
            // 
            // PeopleCount
            // 
            this.PeopleCount.HeaderText = "Количество голосов";
            this.PeopleCount.Name = "PeopleCount";
            this.PeopleCount.ReadOnly = true;
            this.PeopleCount.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.PeopleCount.Width = 70;
            // 
            // Points
            // 
            this.Points.HeaderText = "Очки";
            this.Points.Name = "Points";
            this.Points.ReadOnly = true;
            this.Points.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Points.Width = 70;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(513, 156);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Рейтинг";
            // 
            // DeleteRowsGroupBox
            // 
            this.DeleteRowsGroupBox.Controls.Add(this.MusicIdCheckedListBox);
            this.DeleteRowsGroupBox.Controls.Add(this.PeopleIdCheckedListBox);
            this.DeleteRowsGroupBox.Controls.Add(this.DeleteMusicButton);
            this.DeleteRowsGroupBox.Controls.Add(this.DeletePeopleButton);
            this.DeleteRowsGroupBox.Location = new System.Drawing.Point(838, 12);
            this.DeleteRowsGroupBox.Name = "DeleteRowsGroupBox";
            this.DeleteRowsGroupBox.Size = new System.Drawing.Size(196, 127);
            this.DeleteRowsGroupBox.TabIndex = 13;
            this.DeleteRowsGroupBox.TabStop = false;
            // 
            // MusicIdCheckedListBox
            // 
            this.MusicIdCheckedListBox.FormattingEnabled = true;
            this.MusicIdCheckedListBox.Items.AddRange(new object[] {
            "1 - Барбарик",
            "2 - Чинчопка",
            "3 - Тыры пыры",
            "4 - Кольщик",
            "5 - Владимирский централ"});
            this.MusicIdCheckedListBox.Location = new System.Drawing.Point(6, 76);
            this.MusicIdCheckedListBox.Name = "MusicIdCheckedListBox";
            this.MusicIdCheckedListBox.Size = new System.Drawing.Size(47, 34);
            this.MusicIdCheckedListBox.TabIndex = 17;
            // 
            // PeopleIdCheckedListBox
            // 
            this.PeopleIdCheckedListBox.FormattingEnabled = true;
            this.PeopleIdCheckedListBox.Items.AddRange(new object[] {
            "1 - Барбарик",
            "2 - Чинчопка",
            "3 - Тыры пыры",
            "4 - Кольщик",
            "5 - Владимирский централ"});
            this.PeopleIdCheckedListBox.Location = new System.Drawing.Point(6, 27);
            this.PeopleIdCheckedListBox.Name = "PeopleIdCheckedListBox";
            this.PeopleIdCheckedListBox.Size = new System.Drawing.Size(47, 34);
            this.PeopleIdCheckedListBox.TabIndex = 16;
            // 
            // DeleteMusicButton
            // 
            this.DeleteMusicButton.Location = new System.Drawing.Point(69, 76);
            this.DeleteMusicButton.Name = "DeleteMusicButton";
            this.DeleteMusicButton.Size = new System.Drawing.Size(121, 34);
            this.DeleteMusicButton.TabIndex = 3;
            this.DeleteMusicButton.Text = "Удалить песню по ID";
            this.DeleteMusicButton.UseVisualStyleBackColor = true;
            // 
            // DeletePeopleButton
            // 
            this.DeletePeopleButton.Location = new System.Drawing.Point(69, 27);
            this.DeletePeopleButton.Name = "DeletePeopleButton";
            this.DeletePeopleButton.Size = new System.Drawing.Size(121, 34);
            this.DeletePeopleButton.TabIndex = 2;
            this.DeletePeopleButton.Text = "Удалить опрошенного по ID";
            this.DeletePeopleButton.UseVisualStyleBackColor = true;
            // 
            // AlbumTable
            // 
            this.AlbumTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AlbumTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AlbumID,
            this.AgeBench,
            this.GenderBench,
            this.PointBench,
            this.MusicList});
            this.AlbumTable.Location = new System.Drawing.Point(516, 449);
            this.AlbumTable.Name = "AlbumTable";
            this.AlbumTable.Size = new System.Drawing.Size(518, 133);
            this.AlbumTable.TabIndex = 15;
            // 
            // AlbumID
            // 
            this.AlbumID.Frozen = true;
            this.AlbumID.HeaderText = "ID";
            this.AlbumID.Name = "AlbumID";
            this.AlbumID.ReadOnly = true;
            this.AlbumID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.AlbumID.Width = 35;
            // 
            // AgeBench
            // 
            this.AgeBench.Frozen = true;
            this.AgeBench.HeaderText = "Возраст";
            this.AgeBench.Name = "AgeBench";
            this.AgeBench.ReadOnly = true;
            this.AgeBench.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.AgeBench.Width = 60;
            // 
            // GenderBench
            // 
            this.GenderBench.Frozen = true;
            this.GenderBench.HeaderText = "Пол";
            this.GenderBench.Name = "GenderBench";
            this.GenderBench.ReadOnly = true;
            this.GenderBench.Width = 35;
            // 
            // PointBench
            // 
            this.PointBench.Frozen = true;
            this.PointBench.HeaderText = "Другие критерии";
            this.PointBench.Name = "PointBench";
            this.PointBench.ReadOnly = true;
            this.PointBench.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // MusicList
            // 
            this.MusicList.Frozen = true;
            this.MusicList.HeaderText = "Музыка";
            this.MusicList.Name = "MusicList";
            this.MusicList.ReadOnly = true;
            this.MusicList.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.MusicList.Width = 250;
            // 
            // AddAlbumButton
            // 
            this.AddAlbumButton.Location = new System.Drawing.Point(516, 588);
            this.AddAlbumButton.Name = "AddAlbumButton";
            this.AddAlbumButton.Size = new System.Drawing.Size(518, 30);
            this.AddAlbumButton.TabIndex = 16;
            this.AddAlbumButton.Text = "Добавить пластинку";
            this.AddAlbumButton.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(513, 430);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Пластинки";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 629);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.AddAlbumButton);
            this.Controls.Add(this.AlbumTable);
            this.Controls.Add(this.DeleteRowsGroupBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.RatingTable);
            this.Controls.Add(this.RatingFiltersGroupBox);
            this.Controls.Add(this.MusicGroupBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PeopleGroupBox);
            this.Controls.Add(this.PeopleTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainWindow";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.PeopleTable)).EndInit();
            this.PeopleGroupBox.ResumeLayout(false);
            this.PeopleGroupBox.PerformLayout();
            this.MusicGroupBox.ResumeLayout(false);
            this.MusicGroupBox.PerformLayout();
            this.RatingFiltersGroupBox.ResumeLayout(false);
            this.OtherFilterGroupBox.ResumeLayout(false);
            this.OtherFilterGroupBox.PerformLayout();
            this.GenderFilterGroupBox.ResumeLayout(false);
            this.GenderFilterGroupBox.PerformLayout();
            this.AgeFilterGroupBox.ResumeLayout(false);
            this.AgeFilterGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RatingTable)).EndInit();
            this.DeleteRowsGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AlbumTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView PeopleTable;
        private System.Windows.Forms.TextBox PeopleAge;
        private System.Windows.Forms.TextBox PeopleName;
        private System.Windows.Forms.GroupBox PeopleGroupBox;
        private System.Windows.Forms.RadioButton GenderRadioButtonM;
        private System.Windows.Forms.RadioButton GenderRadioButtonF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button AddPeopleButton;
        private System.Windows.Forms.GroupBox MusicGroupBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button AddMusicButton;
        private System.Windows.Forms.TextBox MusicNameTextBox;
        private System.Windows.Forms.GroupBox RatingFiltersGroupBox;
        private System.Windows.Forms.DataGridView RatingTable;
        private System.Windows.Forms.TextBox MusciOwnerTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn HumanID;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn age;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn music;
        private System.Windows.Forms.DataGridViewTextBoxColumn MusicId;
        private System.Windows.Forms.DataGridViewTextBoxColumn MusicName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Owner;
        private System.Windows.Forms.DataGridViewTextBoxColumn PeopleCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Points;
        private System.Windows.Forms.GroupBox DeleteRowsGroupBox;
        private System.Windows.Forms.Button CreateRatingButton;
        private System.Windows.Forms.GroupBox GenderFilterGroupBox;
        private System.Windows.Forms.RadioButton FemaleGenderFilterRadioButton;
        private System.Windows.Forms.RadioButton MaleGenderFilterRadioButton;
        private System.Windows.Forms.GroupBox AgeFilterGroupBox;
        private System.Windows.Forms.TextBox AgeFilterTextBox;
        private System.Windows.Forms.RadioButton LessAgeFilterRadioButton;
        private System.Windows.Forms.RadioButton EqualsAgeFilterRadioButton;
        private System.Windows.Forms.RadioButton MoreAgeFilterRadioButton;
        private System.Windows.Forms.GroupBox OtherFilterGroupBox;
        private System.Windows.Forms.RadioButton NoneOtherFilterRadioButton;
        private System.Windows.Forms.RadioButton VoteOtherFilterRadioButton;
        private System.Windows.Forms.RadioButton PointsOtherFilterRadioButton;
        private System.Windows.Forms.RadioButton NoneGenderFilterRadioButton;
        private System.Windows.Forms.RadioButton NoneAgeFilterRadioButton;
        private System.Windows.Forms.Button DeleteMusicButton;
        private System.Windows.Forms.Button DeletePeopleButton;
        private System.Windows.Forms.CheckedListBox PeopleMusicCheckedListBox;
        private System.Windows.Forms.CheckedListBox MusicIdCheckedListBox;
        private System.Windows.Forms.CheckedListBox PeopleIdCheckedListBox;
        private System.Windows.Forms.DataGridView AlbumTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn AlbumID;
        private System.Windows.Forms.DataGridViewTextBoxColumn AgeBench;
        private System.Windows.Forms.DataGridViewTextBoxColumn GenderBench;
        private System.Windows.Forms.DataGridViewTextBoxColumn PointBench;
        private System.Windows.Forms.DataGridViewTextBoxColumn MusicList;
        private System.Windows.Forms.Button AddAlbumButton;
        private System.Windows.Forms.Label label9;
    }
}