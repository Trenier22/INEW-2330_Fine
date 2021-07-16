namespace INEW2330_FineDining
{
    partial class frmMenu
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
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.merchandiseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inew2330su21DataSet = new INEW2330_FineDining.inew2330su21DataSet();
            this.merchandiseTableAdapter = new INEW2330_FineDining.inew2330su21DataSetTableAdapters.MerchandiseTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.merchIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.merchNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.merchDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.merchCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.merchandiseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inew2330su21DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Kunstler Script", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label2.Location = new System.Drawing.Point(354, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 79);
            this.label2.TabIndex = 5;
            this.label2.Text = "G";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Baskerville Old Face", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label1.Location = new System.Drawing.Point(348, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 45);
            this.label1.TabIndex = 4;
            this.label1.Text = "MENU";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Baskerville Old Face", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnExit.Location = new System.Drawing.Point(365, 855);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(89, 32);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::INEW2330_FineDining.Properties.Resources.Menu;
            this.pictureBox1.Location = new System.Drawing.Point(-8, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(837, 914);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // merchandiseBindingSource
            // 
            this.merchandiseBindingSource.DataMember = "Merchandise";
            this.merchandiseBindingSource.DataSource = this.inew2330su21DataSet;
            // 
            // inew2330su21DataSet
            // 
            this.inew2330su21DataSet.DataSetName = "inew2330su21DataSet";
            this.inew2330su21DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // merchandiseTableAdapter
            // 
            this.merchandiseTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.merchIDDataGridViewTextBoxColumn,
            this.merchNameDataGridViewTextBoxColumn,
            this.merchDescriptionDataGridViewTextBoxColumn,
            this.merchCostDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.merchandiseBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(45, 175);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(741, 652);
            this.dataGridView1.TabIndex = 13;
            // 
            // merchIDDataGridViewTextBoxColumn
            // 
            this.merchIDDataGridViewTextBoxColumn.DataPropertyName = "MerchID";
            this.merchIDDataGridViewTextBoxColumn.HeaderText = "MerchID";
            this.merchIDDataGridViewTextBoxColumn.Name = "merchIDDataGridViewTextBoxColumn";
            // 
            // merchNameDataGridViewTextBoxColumn
            // 
            this.merchNameDataGridViewTextBoxColumn.DataPropertyName = "MerchName";
            this.merchNameDataGridViewTextBoxColumn.HeaderText = "MerchName";
            this.merchNameDataGridViewTextBoxColumn.Name = "merchNameDataGridViewTextBoxColumn";
            // 
            // merchDescriptionDataGridViewTextBoxColumn
            // 
            this.merchDescriptionDataGridViewTextBoxColumn.DataPropertyName = "MerchDescription";
            this.merchDescriptionDataGridViewTextBoxColumn.HeaderText = "MerchDescription";
            this.merchDescriptionDataGridViewTextBoxColumn.Name = "merchDescriptionDataGridViewTextBoxColumn";
            // 
            // merchCostDataGridViewTextBoxColumn
            // 
            this.merchCostDataGridViewTextBoxColumn.DataPropertyName = "MerchCost";
            this.merchCostDataGridViewTextBoxColumn.HeaderText = "MerchCost";
            this.merchCostDataGridViewTextBoxColumn.Name = "merchCostDataGridViewTextBoxColumn";
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(849, 934);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmMenu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.merchandiseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inew2330su21DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
        private inew2330su21DataSet inew2330su21DataSet;
        private System.Windows.Forms.BindingSource merchandiseBindingSource;
        private inew2330su21DataSetTableAdapters.MerchandiseTableAdapter merchandiseTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn merchIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn merchNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn merchDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn merchCostDataGridViewTextBoxColumn;
    }
}