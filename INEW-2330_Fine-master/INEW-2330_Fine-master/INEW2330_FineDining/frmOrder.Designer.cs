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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnViewCart = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.merchIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.merchNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.merchDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.merchCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.merchandiseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inew2330su21DataSet1 = new INEW2330_FineDining.inew2330su21DataSet1();
            this.merchandiseTableAdapter = new INEW2330_FineDining.inew2330su21DataSet1TableAdapters.MerchandiseTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.merchandiseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inew2330su21DataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Baskerville Old Face", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label1.Location = new System.Drawing.Point(330, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 45);
            this.label1.TabIndex = 5;
            this.label1.Text = "ORDER";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Kunstler Script", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label2.Location = new System.Drawing.Point(354, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 79);
            this.label2.TabIndex = 6;
            this.label2.Text = "G";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Baskerville Old Face", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label3.Location = new System.Drawing.Point(357, 609);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 52);
            this.label3.TabIndex = 8;
            this.label3.Text = "Click on Item in list above";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Baskerville Old Face", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnAdd.Location = new System.Drawing.Point(377, 675);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(89, 54);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add to Cart";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnCart_Click);
            // 
            // btnViewCart
            // 
            this.btnViewCart.Font = new System.Drawing.Font("Baskerville Old Face", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewCart.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnViewCart.Location = new System.Drawing.Point(306, 762);
            this.btnViewCart.Margin = new System.Windows.Forms.Padding(2);
            this.btnViewCart.Name = "btnViewCart";
            this.btnViewCart.Size = new System.Drawing.Size(89, 54);
            this.btnViewCart.TabIndex = 10;
            this.btnViewCart.Text = "View Cart";
            this.btnViewCart.UseVisualStyleBackColor = true;
            this.btnViewCart.Click += new System.EventHandler(this.btnViewCart_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Baskerville Old Face", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnExit.Location = new System.Drawing.Point(457, 762);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(89, 54);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::INEW2330_FineDining.Properties.Resources.Menu;
            this.pictureBox1.Location = new System.Drawing.Point(-4, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(837, 914);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
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
            this.dgvOrders.DataSource = this.merchandiseBindingSource;
            this.dgvOrders.Location = new System.Drawing.Point(44, 172);
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.Size = new System.Drawing.Size(750, 414);
            this.dgvOrders.TabIndex = 14;
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
            // merchandiseBindingSource
            // 
            this.merchandiseBindingSource.DataMember = "Merchandise";
            this.merchandiseBindingSource.DataSource = this.inew2330su21DataSet1;
            // 
            // inew2330su21DataSet1
            // 
            this.inew2330su21DataSet1.DataSetName = "inew2330su21DataSet1";
            this.inew2330su21DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // merchandiseTableAdapter
            // 
            this.merchandiseTableAdapter.ClearBeforeFill = true;
            // 
            // frmOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(829, 862);
            this.Controls.Add(this.dgvOrders);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnViewCart);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmOrder";
            this.Text = "Order";
            this.Load += new System.EventHandler(this.frmOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.merchandiseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inew2330su21DataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnViewCart;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridView dgvOrders;
        private inew2330su21DataSet1 inew2330su21DataSet1;
        private System.Windows.Forms.BindingSource merchandiseBindingSource;
        private inew2330su21DataSet1TableAdapters.MerchandiseTableAdapter merchandiseTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn merchIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn merchNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn merchDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn merchCostDataGridViewTextBoxColumn;
    }
}