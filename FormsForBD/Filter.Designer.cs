namespace FormsForBD
{
    partial class Filter
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
            this.FilterDgw = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.FilterDgw)).BeginInit();
            this.SuspendLayout();
            // 
            // FilterDgw
            // 
            this.FilterDgw.AllowUserToAddRows = false;
            this.FilterDgw.AllowUserToDeleteRows = false;
            this.FilterDgw.AllowUserToResizeColumns = false;
            this.FilterDgw.AllowUserToResizeRows = false;
            this.FilterDgw.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.FilterDgw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FilterDgw.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.btn});
            this.FilterDgw.Location = new System.Drawing.Point(25, 12);
            this.FilterDgw.Name = "FilterDgw";
            this.FilterDgw.Size = new System.Drawing.Size(636, 464);
            this.FilterDgw.TabIndex = 0;
            this.FilterDgw.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.FilterDgw_CellContentClick);
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // name
            // 
            this.name.FillWeight = 128.934F;
            this.name.HeaderText = "Исполнитель/название жанра";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // btn
            // 
            this.btn.FillWeight = 71.06599F;
            this.btn.HeaderText = "";
            this.btn.Name = "btn";
            this.btn.ReadOnly = true;
            // 
            // Filter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 499);
            this.Controls.Add(this.FilterDgw);
            this.Name = "Filter";
            this.Text = "Filter";
            ((System.ComponentModel.ISupportInitialize)(this.FilterDgw)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView FilterDgw;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewButtonColumn btn;
    }
}