namespace FormsForBD
{
    partial class RaitingFilterForm
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.MaleRadio = new System.Windows.Forms.RadioButton();
            this.FemaleRadio = new System.Windows.Forms.RadioButton();
            this.NoneRadio = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.EqualsRadio = new System.Windows.Forms.RadioButton();
            this.LessRadio = new System.Windows.Forms.RadioButton();
            this.MoreRadio = new System.Windows.Forms.RadioButton();
            this.AgeTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SendButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.AgeTextBox);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(443, 137);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.NoneRadio);
            this.groupBox2.Controls.Add(this.FemaleRadio);
            this.groupBox2.Controls.Add(this.MaleRadio);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(6, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(145, 100);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Пол";
            // 
            // MaleRadio
            // 
            this.MaleRadio.AutoSize = true;
            this.MaleRadio.Location = new System.Drawing.Point(6, 21);
            this.MaleRadio.Name = "MaleRadio";
            this.MaleRadio.Size = new System.Drawing.Size(37, 20);
            this.MaleRadio.TabIndex = 0;
            this.MaleRadio.TabStop = true;
            this.MaleRadio.Text = "М";
            this.MaleRadio.UseVisualStyleBackColor = true;
            // 
            // FemaleRadio
            // 
            this.FemaleRadio.AutoSize = true;
            this.FemaleRadio.Location = new System.Drawing.Point(6, 47);
            this.FemaleRadio.Name = "FemaleRadio";
            this.FemaleRadio.Size = new System.Drawing.Size(39, 20);
            this.FemaleRadio.TabIndex = 1;
            this.FemaleRadio.TabStop = true;
            this.FemaleRadio.Text = "Ж";
            this.FemaleRadio.UseVisualStyleBackColor = true;
            // 
            // NoneRadio
            // 
            this.NoneRadio.AutoSize = true;
            this.NoneRadio.Location = new System.Drawing.Point(6, 73);
            this.NoneRadio.Name = "NoneRadio";
            this.NoneRadio.Size = new System.Drawing.Size(14, 13);
            this.NoneRadio.TabIndex = 2;
            this.NoneRadio.TabStop = true;
            this.NoneRadio.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.EqualsRadio);
            this.groupBox3.Controls.Add(this.LessRadio);
            this.groupBox3.Controls.Add(this.MoreRadio);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.Location = new System.Drawing.Point(167, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(145, 100);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Знак";
            // 
            // EqualsRadio
            // 
            this.EqualsRadio.AutoSize = true;
            this.EqualsRadio.Location = new System.Drawing.Point(6, 73);
            this.EqualsRadio.Name = "EqualsRadio";
            this.EqualsRadio.Size = new System.Drawing.Size(33, 20);
            this.EqualsRadio.TabIndex = 2;
            this.EqualsRadio.TabStop = true;
            this.EqualsRadio.Text = "=";
            this.EqualsRadio.UseVisualStyleBackColor = true;
            // 
            // LessRadio
            // 
            this.LessRadio.AutoSize = true;
            this.LessRadio.Location = new System.Drawing.Point(6, 47);
            this.LessRadio.Name = "LessRadio";
            this.LessRadio.Size = new System.Drawing.Size(33, 20);
            this.LessRadio.TabIndex = 1;
            this.LessRadio.TabStop = true;
            this.LessRadio.Text = "<";
            this.LessRadio.UseVisualStyleBackColor = true;
            // 
            // MoreRadio
            // 
            this.MoreRadio.AutoSize = true;
            this.MoreRadio.Location = new System.Drawing.Point(6, 21);
            this.MoreRadio.Name = "MoreRadio";
            this.MoreRadio.Size = new System.Drawing.Size(33, 20);
            this.MoreRadio.TabIndex = 0;
            this.MoreRadio.TabStop = true;
            this.MoreRadio.Text = ">";
            this.MoreRadio.UseVisualStyleBackColor = true;
            // 
            // AgeTextBox
            // 
            this.AgeTextBox.Location = new System.Drawing.Point(329, 66);
            this.AgeTextBox.Name = "AgeTextBox";
            this.AgeTextBox.Size = new System.Drawing.Size(100, 20);
            this.AgeTextBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(326, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Возраст";
            // 
            // SendButton
            // 
            this.SendButton.Location = new System.Drawing.Point(12, 155);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(443, 38);
            this.SendButton.TabIndex = 1;
            this.SendButton.Text = "Выбрать";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // RaitingFilterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 205);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "RaitingFilterForm";
            this.Text = "RaitingFilterForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AgeTextBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton EqualsRadio;
        private System.Windows.Forms.RadioButton LessRadio;
        private System.Windows.Forms.RadioButton MoreRadio;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton NoneRadio;
        private System.Windows.Forms.RadioButton FemaleRadio;
        private System.Windows.Forms.RadioButton MaleRadio;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button SendButton;
    }
}