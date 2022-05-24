namespace FormsForBD
{
    partial class AddSongMusicianForm
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
            this.ChoiceDgw = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ChoiceDgw)).BeginInit();
            this.SuspendLayout();
            // 
            // ChoiceDgw
            // 
            this.ChoiceDgw.AllowUserToAddRows = false;
            this.ChoiceDgw.AllowUserToDeleteRows = false;
            this.ChoiceDgw.AllowUserToResizeColumns = false;
            this.ChoiceDgw.AllowUserToResizeRows = false;
            this.ChoiceDgw.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ChoiceDgw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ChoiceDgw.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.btn});
            this.ChoiceDgw.Location = new System.Drawing.Point(27, 12);
            this.ChoiceDgw.Name = "ChoiceDgw";
            this.ChoiceDgw.Size = new System.Drawing.Size(636, 464);
            this.ChoiceDgw.TabIndex = 1;
            this.ChoiceDgw.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ChoiceDgw_CellContentClick);
            // 
            // id
            // 
            this.id.FillWeight = 45.68528F;
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // name
            // 
            this.name.FillWeight = 163.9491F;
            this.name.HeaderText = "Исполнитель/название трека";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // btn
            // 
            this.btn.FillWeight = 90.36563F;
            this.btn.HeaderText = "";
            this.btn.Name = "btn";
            this.btn.ReadOnly = true;
            // 
            // AddSongMusicianForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 499);
            this.Controls.Add(this.ChoiceDgw);
            this.Name = "AddSongMusicianForm";
            this.Text = "Добавить связь";
            ((System.ComponentModel.ISupportInitialize)(this.ChoiceDgw)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ChoiceDgw;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewButtonColumn btn;
    }
}