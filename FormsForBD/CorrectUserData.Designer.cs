namespace FormsForBD
{
    partial class CorrectUserData
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
            this.confirm_password_button = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.AgeTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SendFormButton = new System.Windows.Forms.Button();
            this.PatronymicTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.SurnameTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.FemaleRadio = new System.Windows.Forms.RadioButton();
            this.MaleRadio = new System.Windows.Forms.RadioButton();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.PasswordIcon = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.confirm_password_button);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.AgeTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.SendFormButton);
            this.groupBox1.Controls.Add(this.PatronymicTextBox);
            this.groupBox1.Controls.Add(this.NameTextBox);
            this.groupBox1.Controls.Add(this.SurnameTextBox);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.PasswordTextBox);
            this.groupBox1.Controls.Add(this.PasswordIcon);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(448, 436);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // confirm_password_button
            // 
            this.confirm_password_button.Location = new System.Drawing.Point(96, 68);
            this.confirm_password_button.Name = "confirm_password_button";
            this.confirm_password_button.Size = new System.Drawing.Size(198, 23);
            this.confirm_password_button.TabIndex = 19;
            this.confirm_password_button.Text = "Подтвердить пароль";
            this.confirm_password_button.UseVisualStyleBackColor = true;
            this.confirm_password_button.Click += new System.EventHandler(this.confirm_password_button_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(39, 316);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 24);
            this.label4.TabIndex = 18;
            this.label4.Text = "Ваш возраст:";
            // 
            // AgeTextBox
            // 
            this.AgeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AgeTextBox.Location = new System.Drawing.Point(205, 316);
            this.AgeTextBox.MaxLength = 3;
            this.AgeTextBox.Multiline = true;
            this.AgeTextBox.Name = "AgeTextBox";
            this.AgeTextBox.Size = new System.Drawing.Size(198, 34);
            this.AgeTextBox.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(39, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 24);
            this.label3.TabIndex = 16;
            this.label3.Text = "Ваше отчество:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(39, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 24);
            this.label2.TabIndex = 15;
            this.label2.Text = "Ваше имя:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(39, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 24);
            this.label1.TabIndex = 14;
            this.label1.Text = "Ваша фамилия:";
            // 
            // SendFormButton
            // 
            this.SendFormButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SendFormButton.Location = new System.Drawing.Point(39, 376);
            this.SendFormButton.Name = "SendFormButton";
            this.SendFormButton.Size = new System.Drawing.Size(364, 35);
            this.SendFormButton.TabIndex = 13;
            this.SendFormButton.Text = "Отправить форму";
            this.SendFormButton.UseVisualStyleBackColor = true;
            this.SendFormButton.Click += new System.EventHandler(this.SendFormButton_Click);
            // 
            // PatronymicTextBox
            // 
            this.PatronymicTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PatronymicTextBox.Location = new System.Drawing.Point(205, 265);
            this.PatronymicTextBox.MaxLength = 30;
            this.PatronymicTextBox.Multiline = true;
            this.PatronymicTextBox.Name = "PatronymicTextBox";
            this.PatronymicTextBox.Size = new System.Drawing.Size(198, 34);
            this.PatronymicTextBox.TabIndex = 12;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameTextBox.Location = new System.Drawing.Point(205, 214);
            this.NameTextBox.MaxLength = 30;
            this.NameTextBox.Multiline = true;
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(198, 34);
            this.NameTextBox.TabIndex = 11;
            // 
            // SurnameTextBox
            // 
            this.SurnameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SurnameTextBox.Location = new System.Drawing.Point(205, 162);
            this.SurnameTextBox.MaxLength = 30;
            this.SurnameTextBox.Multiline = true;
            this.SurnameTextBox.Name = "SurnameTextBox";
            this.SurnameTextBox.Size = new System.Drawing.Size(198, 34);
            this.SurnameTextBox.TabIndex = 10;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.FemaleRadio);
            this.groupBox2.Controls.Add(this.MaleRadio);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(316, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(87, 99);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ваш пол";
            // 
            // FemaleRadio
            // 
            this.FemaleRadio.AutoSize = true;
            this.FemaleRadio.Location = new System.Drawing.Point(17, 66);
            this.FemaleRadio.Name = "FemaleRadio";
            this.FemaleRadio.Size = new System.Drawing.Size(39, 20);
            this.FemaleRadio.TabIndex = 1;
            this.FemaleRadio.TabStop = true;
            this.FemaleRadio.Text = "Ж";
            this.FemaleRadio.UseVisualStyleBackColor = true;
            // 
            // MaleRadio
            // 
            this.MaleRadio.AutoSize = true;
            this.MaleRadio.Location = new System.Drawing.Point(17, 33);
            this.MaleRadio.Name = "MaleRadio";
            this.MaleRadio.Size = new System.Drawing.Size(37, 20);
            this.MaleRadio.TabIndex = 0;
            this.MaleRadio.TabStop = true;
            this.MaleRadio.Text = "М";
            this.MaleRadio.UseVisualStyleBackColor = true;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordTextBox.Location = new System.Drawing.Point(96, 28);
            this.PasswordTextBox.MaxLength = 30;
            this.PasswordTextBox.Multiline = true;
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '•';
            this.PasswordTextBox.Size = new System.Drawing.Size(198, 34);
            this.PasswordTextBox.TabIndex = 8;
            // 
            // PasswordIcon
            // 
            this.PasswordIcon.Image = global::FormsForBD.Properties.Resources.pas1;
            this.PasswordIcon.Location = new System.Drawing.Point(39, 28);
            this.PasswordIcon.Name = "PasswordIcon";
            this.PasswordIcon.Size = new System.Drawing.Size(34, 34);
            this.PasswordIcon.TabIndex = 6;
            this.PasswordIcon.TabStop = false;
            this.PasswordIcon.Click += new System.EventHandler(this.PasswordIcon_Click);
            // 
            // CorrectUserData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 460);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CorrectUserData";
            this.Text = "Ваша личная информация";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox AgeTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SendFormButton;
        private System.Windows.Forms.TextBox PatronymicTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox SurnameTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton FemaleRadio;
        private System.Windows.Forms.RadioButton MaleRadio;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.PictureBox PasswordIcon;
        private System.Windows.Forms.Button confirm_password_button;
    }
}