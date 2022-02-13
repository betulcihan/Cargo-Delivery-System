
namespace yazlab1_1
{
    partial class KargoTakip
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
            this.txtAddress = new System.Windows.Forms.RichTextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.btnDeleteCargo = new System.Windows.Forms.Button();
            this.txtSelectedCargoInfo = new System.Windows.Forms.TextBox();
            this.addCargoPoint = new System.Windows.Forms.Button();
            this.kargoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.btnDeliverCargo = new System.Windows.Forms.Button();
            this.dataGridViewKargo = new System.Windows.Forms.DataGridView();
            this.kargoIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musteriAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kargoLokasyonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kargoTeslimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kargoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dbCargoAppDataSet = new yazlab1_1.dbCargoAppDataSet();
            this.kargoTableAdapter = new yazlab1_1.dbCargoAppDataSetTableAdapters.kargoTableAdapter();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.kargoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKargo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kargoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbCargoAppDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(32, 622);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(405, 64);
            this.txtAddress.TabIndex = 0;
            this.txtAddress.Text = "";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(29, 595);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(45, 17);
            this.lblAddress.TabIndex = 2;
            this.lblAddress.Text = "Adres";
            // 
            // btnDeleteCargo
            // 
            this.btnDeleteCargo.Location = new System.Drawing.Point(275, 717);
            this.btnDeleteCargo.Name = "btnDeleteCargo";
            this.btnDeleteCargo.Size = new System.Drawing.Size(81, 34);
            this.btnDeleteCargo.TabIndex = 4;
            this.btnDeleteCargo.Text = "Sil";
            this.btnDeleteCargo.UseVisualStyleBackColor = true;
            this.btnDeleteCargo.Click += new System.EventHandler(this.btnDeleteCargo_Click);
            // 
            // txtSelectedCargoInfo
            // 
            this.txtSelectedCargoInfo.Location = new System.Drawing.Point(131, 723);
            this.txtSelectedCargoInfo.Name = "txtSelectedCargoInfo";
            this.txtSelectedCargoInfo.Size = new System.Drawing.Size(84, 22);
            this.txtSelectedCargoInfo.TabIndex = 5;
            // 
            // addCargoPoint
            // 
            this.addCargoPoint.Location = new System.Drawing.Point(715, 623);
            this.addCargoPoint.Name = "addCargoPoint";
            this.addCargoPoint.Size = new System.Drawing.Size(156, 37);
            this.addCargoPoint.TabIndex = 13;
            this.addCargoPoint.Text = "Kargo Noktası Ekle";
            this.addCargoPoint.UseVisualStyleBackColor = true;
            this.addCargoPoint.Click += new System.EventHandler(this.addCargoPoint_Click);
            // 
            // kargoBindingSource
            // 
            this.kargoBindingSource.DataMember = "kargo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 723);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Seçilen Kargo:";
            // 
            // btnDeliverCargo
            // 
            this.btnDeliverCargo.Location = new System.Drawing.Point(731, 706);
            this.btnDeliverCargo.Name = "btnDeliverCargo";
            this.btnDeliverCargo.Size = new System.Drawing.Size(140, 34);
            this.btnDeliverCargo.TabIndex = 17;
            this.btnDeliverCargo.Text = "Teslim Et";
            this.btnDeliverCargo.UseVisualStyleBackColor = true;
            this.btnDeliverCargo.Click += new System.EventHandler(this.btnDeliverCargo_Click);
            // 
            // dataGridViewKargo
            // 
            this.dataGridViewKargo.AutoGenerateColumns = false;
            this.dataGridViewKargo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKargo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kargoIdDataGridViewTextBoxColumn,
            this.musteriAdDataGridViewTextBoxColumn,
            this.kargoLokasyonDataGridViewTextBoxColumn,
            this.kargoTeslimDataGridViewTextBoxColumn});
            this.dataGridViewKargo.DataSource = this.kargoBindingSource1;
            this.dataGridViewKargo.Location = new System.Drawing.Point(32, 31);
            this.dataGridViewKargo.Name = "dataGridViewKargo";
            this.dataGridViewKargo.RowHeadersWidth = 51;
            this.dataGridViewKargo.RowTemplate.Height = 24;
            this.dataGridViewKargo.Size = new System.Drawing.Size(839, 537);
            this.dataGridViewKargo.TabIndex = 18;
            this.dataGridViewKargo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewKargo_CellClick);
            // 
            // kargoIdDataGridViewTextBoxColumn
            // 
            this.kargoIdDataGridViewTextBoxColumn.DataPropertyName = "kargoId";
            this.kargoIdDataGridViewTextBoxColumn.HeaderText = "kargoId";
            this.kargoIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kargoIdDataGridViewTextBoxColumn.Name = "kargoIdDataGridViewTextBoxColumn";
            this.kargoIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.kargoIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // musteriAdDataGridViewTextBoxColumn
            // 
            this.musteriAdDataGridViewTextBoxColumn.DataPropertyName = "musteriAd";
            this.musteriAdDataGridViewTextBoxColumn.HeaderText = "musteriAd";
            this.musteriAdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.musteriAdDataGridViewTextBoxColumn.Name = "musteriAdDataGridViewTextBoxColumn";
            this.musteriAdDataGridViewTextBoxColumn.Width = 125;
            // 
            // kargoLokasyonDataGridViewTextBoxColumn
            // 
            this.kargoLokasyonDataGridViewTextBoxColumn.DataPropertyName = "kargoLokasyon";
            this.kargoLokasyonDataGridViewTextBoxColumn.HeaderText = "kargoLokasyon";
            this.kargoLokasyonDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kargoLokasyonDataGridViewTextBoxColumn.Name = "kargoLokasyonDataGridViewTextBoxColumn";
            this.kargoLokasyonDataGridViewTextBoxColumn.Width = 125;
            // 
            // kargoTeslimDataGridViewTextBoxColumn
            // 
            this.kargoTeslimDataGridViewTextBoxColumn.DataPropertyName = "kargoTeslim";
            this.kargoTeslimDataGridViewTextBoxColumn.HeaderText = "kargoTeslim";
            this.kargoTeslimDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kargoTeslimDataGridViewTextBoxColumn.Name = "kargoTeslimDataGridViewTextBoxColumn";
            this.kargoTeslimDataGridViewTextBoxColumn.Width = 125;
            // 
            // kargoBindingSource1
            // 
            this.kargoBindingSource1.DataMember = "kargo";
            this.kargoBindingSource1.DataSource = this.dbCargoAppDataSet;
            // 
            // dbCargoAppDataSet
            // 
            this.dbCargoAppDataSet.DataSetName = "dbCargoAppDataSet";
            this.dbCargoAppDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kargoTableAdapter
            // 
            this.kargoTableAdapter.ClearBeforeFill = true;
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Location = new System.Drawing.Point(515, 595);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(78, 17);
            this.lblCustomerName.TabIndex = 19;
            this.lblCustomerName.Text = "Müşteri Adı";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(518, 638);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(142, 22);
            this.txtCustomerName.TabIndex = 20;
            // 
            // KargoTakip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 783);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.dataGridViewKargo);
            this.Controls.Add(this.btnDeliverCargo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addCargoPoint);
            this.Controls.Add(this.txtSelectedCargoInfo);
            this.Controls.Add(this.btnDeleteCargo);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.txtAddress);
            this.Name = "KargoTakip";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Kargo Takip";
            this.Load += new System.EventHandler(this.KargoTakip_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kargoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKargo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kargoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbCargoAppDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Button btnDeleteCargo;
        private System.Windows.Forms.TextBox txtSelectedCargoInfo;
        private System.Windows.Forms.Button addCargoPoint;
        private System.Windows.Forms.BindingSource kargoBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDeliverCargo;
        private System.Windows.Forms.DataGridView dataGridViewKargo;
        private dbCargoAppDataSet dbCargoAppDataSet;
        private System.Windows.Forms.BindingSource kargoBindingSource1;
        private dbCargoAppDataSetTableAdapters.kargoTableAdapter kargoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn kargoIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteriAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kargoLokasyonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kargoTeslimDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.TextBox txtCustomerName;
    }
}