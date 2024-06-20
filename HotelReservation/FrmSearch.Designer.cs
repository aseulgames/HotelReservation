namespace HotelReservation
{
    partial class FrmSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSearch));
            this.txtBoxSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.guestInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelReservationDataSet = new HotelReservation.HotelReservationDataSet();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.referenceIDDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentMethodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkInDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkOutDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guestStatusBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.hotelReservationDataSet6 = new HotelReservation.HotelReservationDataSet6();
            this.guestStatusBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.hotelReservationDataSet5 = new HotelReservation.HotelReservationDataSet5();
            this.guestStatusBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.hotelReservationDataSet4 = new HotelReservation.HotelReservationDataSet4();
            this.guestStatusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelReservationDataSet2 = new HotelReservation.HotelReservationDataSet2();
            this.guestInfoTableAdapter = new HotelReservation.HotelReservationDataSetTableAdapters.GuestInfoTableAdapter();
            this.hotelReservationDataSet1 = new HotelReservation.HotelReservationDataSet1();
            this.rateInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rateInfoTableAdapter = new HotelReservation.HotelReservationDataSet1TableAdapters.RateInfoTableAdapter();
            this.guestStatusTableAdapter = new HotelReservation.HotelReservationDataSet2TableAdapters.GuestStatusTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.hotelReservationDataSet3 = new HotelReservation.HotelReservationDataSet3();
            this.guestStatusBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.guestStatusTableAdapter1 = new HotelReservation.HotelReservationDataSet3TableAdapters.GuestStatusTableAdapter();
            this.guestStatusTableAdapter2 = new HotelReservation.HotelReservationDataSet4TableAdapters.GuestStatusTableAdapter();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.guestStatusTableAdapter3 = new HotelReservation.HotelReservationDataSet5TableAdapters.GuestStatusTableAdapter();
            this.guestStatusTableAdapter4 = new HotelReservation.HotelReservationDataSet6TableAdapters.GuestStatusTableAdapter();
            this.hotelReservationDataSet7 = new HotelReservation.HotelReservationDataSet7();
            this.guestStatusBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.guestStatusTableAdapter5 = new HotelReservation.HotelReservationDataSet7TableAdapters.GuestStatusTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.guestInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelReservationDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guestStatusBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelReservationDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guestStatusBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelReservationDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guestStatusBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelReservationDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guestStatusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelReservationDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelReservationDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rateInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelReservationDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guestStatusBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelReservationDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guestStatusBindingSource5)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBoxSearch
            // 
            this.txtBoxSearch.Location = new System.Drawing.Point(282, 59);
            this.txtBoxSearch.Multiline = true;
            this.txtBoxSearch.Name = "txtBoxSearch";
            this.txtBoxSearch.Size = new System.Drawing.Size(220, 38);
            this.txtBoxSearch.TabIndex = 0;
            this.txtBoxSearch.TextChanged += new System.EventHandler(this.txtBoxSearch_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(356, 116);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 25);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Marcellus SC", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(321, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter Reference ID:";
            // 
            // guestInfoBindingSource
            // 
            this.guestInfoBindingSource.DataMember = "GuestInfo";
            this.guestInfoBindingSource.DataSource = this.hotelReservationDataSet;
            // 
            // hotelReservationDataSet
            // 
            this.hotelReservationDataSet.DataSetName = "HotelReservationDataSet";
            this.hotelReservationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.referenceIDDataGridViewTextBoxColumn2,
            this.fullNameDataGridViewTextBoxColumn1,
            this.paymentAmountDataGridViewTextBoxColumn,
            this.paymentMethodDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.checkInDataGridViewTextBoxColumn1,
            this.checkOutDataGridViewTextBoxColumn1});
            this.dataGridView3.DataSource = this.guestStatusBindingSource5;
            this.dataGridView3.Location = new System.Drawing.Point(24, 167);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(742, 85);
            this.dataGridView3.TabIndex = 5;
            // 
            // referenceIDDataGridViewTextBoxColumn2
            // 
            this.referenceIDDataGridViewTextBoxColumn2.DataPropertyName = "ReferenceID";
            this.referenceIDDataGridViewTextBoxColumn2.HeaderText = "ReferenceID";
            this.referenceIDDataGridViewTextBoxColumn2.Name = "referenceIDDataGridViewTextBoxColumn2";
            // 
            // fullNameDataGridViewTextBoxColumn1
            // 
            this.fullNameDataGridViewTextBoxColumn1.DataPropertyName = "FullName";
            this.fullNameDataGridViewTextBoxColumn1.HeaderText = "FullName";
            this.fullNameDataGridViewTextBoxColumn1.Name = "fullNameDataGridViewTextBoxColumn1";
            // 
            // paymentAmountDataGridViewTextBoxColumn
            // 
            this.paymentAmountDataGridViewTextBoxColumn.DataPropertyName = "PaymentAmount";
            this.paymentAmountDataGridViewTextBoxColumn.HeaderText = "PaymentAmount";
            this.paymentAmountDataGridViewTextBoxColumn.Name = "paymentAmountDataGridViewTextBoxColumn";
            // 
            // paymentMethodDataGridViewTextBoxColumn
            // 
            this.paymentMethodDataGridViewTextBoxColumn.DataPropertyName = "PaymentMethod";
            this.paymentMethodDataGridViewTextBoxColumn.HeaderText = "PaymentMethod";
            this.paymentMethodDataGridViewTextBoxColumn.Name = "paymentMethodDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // checkInDataGridViewTextBoxColumn1
            // 
            this.checkInDataGridViewTextBoxColumn1.DataPropertyName = "CheckIn";
            this.checkInDataGridViewTextBoxColumn1.HeaderText = "CheckIn";
            this.checkInDataGridViewTextBoxColumn1.Name = "checkInDataGridViewTextBoxColumn1";
            // 
            // checkOutDataGridViewTextBoxColumn1
            // 
            this.checkOutDataGridViewTextBoxColumn1.DataPropertyName = "CheckOut";
            this.checkOutDataGridViewTextBoxColumn1.HeaderText = "CheckOut";
            this.checkOutDataGridViewTextBoxColumn1.Name = "checkOutDataGridViewTextBoxColumn1";
            // 
            // guestStatusBindingSource4
            // 
            this.guestStatusBindingSource4.DataMember = "GuestStatus";
            this.guestStatusBindingSource4.DataSource = this.hotelReservationDataSet6;
            // 
            // hotelReservationDataSet6
            // 
            this.hotelReservationDataSet6.DataSetName = "HotelReservationDataSet6";
            this.hotelReservationDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // guestStatusBindingSource3
            // 
            this.guestStatusBindingSource3.DataMember = "GuestStatus";
            this.guestStatusBindingSource3.DataSource = this.hotelReservationDataSet5;
            // 
            // hotelReservationDataSet5
            // 
            this.hotelReservationDataSet5.DataSetName = "HotelReservationDataSet5";
            this.hotelReservationDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // guestStatusBindingSource2
            // 
            this.guestStatusBindingSource2.DataMember = "GuestStatus";
            this.guestStatusBindingSource2.DataSource = this.hotelReservationDataSet4;
            // 
            // hotelReservationDataSet4
            // 
            this.hotelReservationDataSet4.DataSetName = "HotelReservationDataSet4";
            this.hotelReservationDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // guestStatusBindingSource
            // 
            this.guestStatusBindingSource.DataMember = "GuestStatus";
            this.guestStatusBindingSource.DataSource = this.hotelReservationDataSet2;
            // 
            // hotelReservationDataSet2
            // 
            this.hotelReservationDataSet2.DataSetName = "HotelReservationDataSet2";
            this.hotelReservationDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // guestInfoTableAdapter
            // 
            this.guestInfoTableAdapter.ClearBeforeFill = true;
            // 
            // hotelReservationDataSet1
            // 
            this.hotelReservationDataSet1.DataSetName = "HotelReservationDataSet1";
            this.hotelReservationDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rateInfoBindingSource
            // 
            this.rateInfoBindingSource.DataMember = "RateInfo";
            this.rateInfoBindingSource.DataSource = this.hotelReservationDataSet1;
            // 
            // rateInfoTableAdapter
            // 
            this.rateInfoTableAdapter.ClearBeforeFill = true;
            // 
            // guestStatusTableAdapter
            // 
            this.guestStatusTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(335, 284);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 25);
            this.button1.TabIndex = 6;
            this.button1.Text = "View Receipt";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // hotelReservationDataSet3
            // 
            this.hotelReservationDataSet3.DataSetName = "HotelReservationDataSet3";
            this.hotelReservationDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // guestStatusBindingSource1
            // 
            this.guestStatusBindingSource1.DataMember = "GuestStatus";
            this.guestStatusBindingSource1.DataSource = this.hotelReservationDataSet3;
            // 
            // guestStatusTableAdapter1
            // 
            this.guestStatusTableAdapter1.ClearBeforeFill = true;
            // 
            // guestStatusTableAdapter2
            // 
            this.guestStatusTableAdapter2.ClearBeforeFill = true;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(21, 30);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(32, 13);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Back";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // guestStatusTableAdapter3
            // 
            this.guestStatusTableAdapter3.ClearBeforeFill = true;
            // 
            // guestStatusTableAdapter4
            // 
            this.guestStatusTableAdapter4.ClearBeforeFill = true;
            // 
            // hotelReservationDataSet7
            // 
            this.hotelReservationDataSet7.DataSetName = "HotelReservationDataSet7";
            this.hotelReservationDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // guestStatusBindingSource5
            // 
            this.guestStatusBindingSource5.DataMember = "GuestStatus";
            this.guestStatusBindingSource5.DataSource = this.hotelReservationDataSet7;
            // 
            // guestStatusTableAdapter5
            // 
            this.guestStatusTableAdapter5.ClearBeforeFill = true;
            // 
            // FrmSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.ClientSize = new System.Drawing.Size(788, 325);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtBoxSearch);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmSearch";
            this.Text = "Search Status";
            this.Load += new System.EventHandler(this.FrmSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guestInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelReservationDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guestStatusBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelReservationDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guestStatusBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelReservationDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guestStatusBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelReservationDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guestStatusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelReservationDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelReservationDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rateInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelReservationDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guestStatusBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelReservationDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guestStatusBindingSource5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView3;
        private HotelReservationDataSet hotelReservationDataSet;
        private System.Windows.Forms.BindingSource guestInfoBindingSource;
        private HotelReservationDataSetTableAdapters.GuestInfoTableAdapter guestInfoTableAdapter;
        private HotelReservationDataSet1 hotelReservationDataSet1;
        private System.Windows.Forms.BindingSource rateInfoBindingSource;
        private HotelReservationDataSet1TableAdapters.RateInfoTableAdapter rateInfoTableAdapter;
        private HotelReservationDataSet2 hotelReservationDataSet2;
        private System.Windows.Forms.BindingSource guestStatusBindingSource;
        private HotelReservationDataSet2TableAdapters.GuestStatusTableAdapter guestStatusTableAdapter;
        private System.Windows.Forms.Button button1;
        private HotelReservationDataSet3 hotelReservationDataSet3;
        private System.Windows.Forms.BindingSource guestStatusBindingSource1;
        private HotelReservationDataSet3TableAdapters.GuestStatusTableAdapter guestStatusTableAdapter1;
        private HotelReservationDataSet4 hotelReservationDataSet4;
        private System.Windows.Forms.BindingSource guestStatusBindingSource2;
        private HotelReservationDataSet4TableAdapters.GuestStatusTableAdapter guestStatusTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn referenceIDDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentMethodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkInDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkOutDataGridViewTextBoxColumn1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private HotelReservationDataSet5 hotelReservationDataSet5;
        private System.Windows.Forms.BindingSource guestStatusBindingSource3;
        private HotelReservationDataSet5TableAdapters.GuestStatusTableAdapter guestStatusTableAdapter3;
        private HotelReservationDataSet6 hotelReservationDataSet6;
        private System.Windows.Forms.BindingSource guestStatusBindingSource4;
        private HotelReservationDataSet6TableAdapters.GuestStatusTableAdapter guestStatusTableAdapter4;
        private HotelReservationDataSet7 hotelReservationDataSet7;
        private System.Windows.Forms.BindingSource guestStatusBindingSource5;
        private HotelReservationDataSet7TableAdapters.GuestStatusTableAdapter guestStatusTableAdapter5;
    }
}