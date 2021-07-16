namespace INEW2330_FineDining
{
    partial class frmOrder
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
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.merchIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.merchNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.merchDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.merchCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.merchandiseBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.inew2330su21DataSet = new INEW2330_FineDining.inew2330su21DataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.merchandiseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.merchandiseTableAdapter = new INEW2330_FineDining.inew2330su21DataSetTableAdapters.MerchandiseTableAdapter();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.merchandiseBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inew2330su21DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.merchandiseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOrders
            // 
            this.dgvOrders.AutoGenerateColumns = false;
            this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.merchIDDataGridViewTextBoxColumn,
            this.merchNameDataGridViewTextBoxColumn,
            this.merchDescriptionDataGridViewTextBoxColumn,
            this.merchCostDataGridViewTextBoxColumn});
            this.dgvOrders.DataSource = this.merchandiseBindingSource1;
            this.dgvOrders.Location = new System.Drawing.Point(45, 146);
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.RowHeadersWidth = 51;
            this.dgvOrders.Size = new System.Drawing.Size(750, 356);
            this.dgvOrders.TabIndex = 30;
            // 
            // merchIDDataGridViewTextBoxColumn
            // 
            this.merchIDDataGridViewTextBoxColumn.DataPropertyName = "MerchID";
            this.merchIDDataGridViewTextBoxColumn.HeaderText = "MerchID";
            this.merchIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.merchIDDataGridViewTextBoxColumn.Name = "merchIDDataGridViewTextBoxColumn";
            this.merchIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // merchNameDataGridViewTextBoxColumn
            // 
            this.merchNameDataGridViewTextBoxColumn.DataPropertyName = "MerchName";
            this.merchNameDataGridViewTextBoxColumn.HeaderText = "MerchName";
            this.merchNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.merchNameDataGridViewTextBoxColumn.Name = "merchNameDataGridViewTextBoxColumn";
            this.merchNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // merchDescriptionDataGridViewTextBoxColumn
            // 
            this.merchDescriptionDataGridViewTextBoxColumn.DataPropertyName = "MerchDescription";
            this.merchDescriptionDataGridViewTextBoxColumn.HeaderText = "MerchDescription";
            this.merchDescriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.merchDescriptionDataGridViewTextBoxColumn.Name = "merchDescriptionDataGridViewTextBoxColumn";
            this.merchDescriptionDataGridViewTextBoxColumn.Width = 125;
            // 
            // merchCostDataGridViewTextBoxColumn
            // 
            this.merchCostDataGridViewTextBoxColumn.DataPropertyName = "MerchCost";
            this.merchCostDataGridViewTextBoxColumn.HeaderText = "MerchCost";
            this.merchCostDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.merchCostDataGridViewTextBoxColumn.Name = "merchCostDataGridViewTextBoxColumn";
            this.merchCostDataGridViewTextBoxColumn.Width = 125;
            // 
            // merchandiseBindingSource1
            // 
            this.merchandiseBindingSource1.DataMember = "Merchandise";
            this.merchandiseBindingSource1.DataSource = this.inew2330su21DataSet;
            // 
            // inew2330su21DataSet
            // 
            this.inew2330su21DataSet.DataSetName = "inew2330su21DataSet";
            this.inew2330su21DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Kunstler Script", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label2.Location = new System.Drawing.Point(354, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 79);
            this.label2.TabIndex = 25;
            this.label2.Text = "G";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Baskerville Old Face", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label1.Location = new System.Drawing.Point(334, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 45);
            this.label1.TabIndex = 24;
            this.label1.Text = "ORDER";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::INEW2330_FineDining.Properties.Resources.Menu;
            this.pictureBox1.Location = new System.Drawing.Point(-6, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(837, 703);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // merchandiseBindingSource
            // 
            this.merchandiseBindingSource.DataMember = "Merchandise";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Baskerville Old Face", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.button1.Location = new System.Drawing.Point(457, 623);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 54);
            this.button1.TabIndex = 29;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Baskerville Old Face", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.button2.Location = new System.Drawing.Point(306, 623);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 54);
            this.button2.TabIndex = 28;
            this.button2.Text = "View Cart";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // merchandiseTableAdapter
            // 
            this.merchandiseTableAdapter.ClearBeforeFill = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Baskerville Old Face", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnAdd.Location = new System.Drawing.Point(381, 559);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(89, 54);
            this.btnAdd.TabIndex = 27;
            this.btnAdd.Text = "Add to Cart";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Baskerville Old Face", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label3.Location = new System.Drawing.Point(362, 505);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 52);
            this.label3.TabIndex = 26;
            this.label3.Text = "Click on Item in list above";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(829, 704);
            this.Controls.Add(this.dgvOrders);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmOrder";
            this.Text = "Order";
            this.Load += new System.EventHandler(this.frmOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.merchandiseBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inew2330su21DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.merchandiseBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.DataGridViewTextBoxColumn merchIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn merchNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn merchDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn merchCostDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource merchandiseBindingSource1;
        private inew2330su21DataSet inew2330su21DataSet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.BindingSource merchandiseBindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private inew2330su21DataSetTableAdapters.MerchandiseTableAdapter merchandiseTableAdapter;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label3;
    }
}