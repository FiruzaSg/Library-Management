namespace LibrarySystem.Forms
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.BtnBookForm = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            this.BtnAllOrders = new System.Windows.Forms.Button();
            this.PnlNewOrder = new System.Windows.Forms.Panel();
            this.PnlOrderInfo = new System.Windows.Forms.Panel();
            this.BtnCancelOrder = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.DgvBasket = new System.Windows.Forms.DataGridView();
            this.Column18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnCreateOrder = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.RtbTotalPrice = new System.Windows.Forms.RichTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.BtnAddToCard = new System.Windows.Forms.Button();
            this.NupBookCount = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.DtpNewDeadline = new System.Windows.Forms.DateTimePicker();
            this.DtpNewTaken = new System.Windows.Forms.DateTimePicker();
            this.BtnBookSearch = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.TxbBookSearch = new System.Windows.Forms.TextBox();
            this.DgvBookSearch = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnCustomerSearch = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.TxbCustomerSearch = new System.Windows.Forms.TextBox();
            this.DgvCustomersSearch = new System.Windows.Forms.DataGridView();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.BtnAllReturns = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.BtnLateReturn = new System.Windows.Forms.Button();
            this.BtnOrder = new System.Windows.Forms.Button();
            this.PnlAllOrders = new System.Windows.Forms.Panel();
            this.GrbReportRange = new System.Windows.Forms.GroupBox();
            this.BtnReportSearch = new System.Windows.Forms.Button();
            this.BtnExcel = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.DtpReportTo = new System.Windows.Forms.DateTimePicker();
            this.DtpReportFrom = new System.Windows.Forms.DateTimePicker();
            this.PnlPaymentInfo = new System.Windows.Forms.Panel();
            this.BtnCancelReturn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnPayFine = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.RtbFinePrice = new System.Windows.Forms.RichTextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.DgvAllOrders = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnReturn = new System.Windows.Forms.Button();
            this.BtnNewOrder = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.GrpSearch = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.BtnOrderSearch = new System.Windows.Forms.Button();
            this.TxbOrderSearch = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.PnlNewOrder.SuspendLayout();
            this.PnlOrderInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvBasket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NupBookCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvBookSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCustomersSearch)).BeginInit();
            this.PnlAllOrders.SuspendLayout();
            this.GrbReportRange.SuspendLayout();
            this.PnlPaymentInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAllOrders)).BeginInit();
            this.GrpSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnBookForm,
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1333, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // BtnBookForm
            // 
            this.BtnBookForm.BackColor = System.Drawing.Color.LightSteelBlue;
            this.BtnBookForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnBookForm.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBookForm.Name = "BtnBookForm";
            this.BtnBookForm.Size = new System.Drawing.Size(82, 29);
            this.BtnBookForm.Text = "Books";
            this.BtnBookForm.Click += new System.EventHandler(this.BtnBookForm_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.toolStripMenuItem1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(80, 29);
            this.toolStripMenuItem1.Text = "Users";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.toolStripMenuItem2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolStripMenuItem2.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(127, 29);
            this.toolStripMenuItem2.Text = "Customers";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // entityCommand1
            // 
            this.entityCommand1.CommandTimeout = 0;
            this.entityCommand1.CommandTree = null;
            this.entityCommand1.Connection = null;
            this.entityCommand1.EnablePlanCaching = true;
            this.entityCommand1.Transaction = null;
            // 
            // BtnAllOrders
            // 
            this.BtnAllOrders.BackColor = System.Drawing.Color.CadetBlue;
            this.BtnAllOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAllOrders.Location = new System.Drawing.Point(12, 73);
            this.BtnAllOrders.Name = "BtnAllOrders";
            this.BtnAllOrders.Size = new System.Drawing.Size(185, 38);
            this.BtnAllOrders.TabIndex = 8;
            this.BtnAllOrders.Text = "All active orders";
            this.BtnAllOrders.UseVisualStyleBackColor = false;
            this.BtnAllOrders.Click += new System.EventHandler(this.BtnAllOrders_Click);
            // 
            // PnlNewOrder
            // 
            this.PnlNewOrder.BackColor = System.Drawing.Color.CadetBlue;
            this.PnlNewOrder.Controls.Add(this.PnlOrderInfo);
            this.PnlNewOrder.Controls.Add(this.BtnAddToCard);
            this.PnlNewOrder.Controls.Add(this.NupBookCount);
            this.PnlNewOrder.Controls.Add(this.label9);
            this.PnlNewOrder.Controls.Add(this.label8);
            this.PnlNewOrder.Controls.Add(this.label7);
            this.PnlNewOrder.Controls.Add(this.DtpNewDeadline);
            this.PnlNewOrder.Controls.Add(this.DtpNewTaken);
            this.PnlNewOrder.Controls.Add(this.BtnBookSearch);
            this.PnlNewOrder.Controls.Add(this.label5);
            this.PnlNewOrder.Controls.Add(this.TxbBookSearch);
            this.PnlNewOrder.Controls.Add(this.DgvBookSearch);
            this.PnlNewOrder.Controls.Add(this.label6);
            this.PnlNewOrder.Controls.Add(this.BtnCustomerSearch);
            this.PnlNewOrder.Controls.Add(this.label4);
            this.PnlNewOrder.Controls.Add(this.TxbCustomerSearch);
            this.PnlNewOrder.Controls.Add(this.DgvCustomersSearch);
            this.PnlNewOrder.Controls.Add(this.label3);
            this.PnlNewOrder.Controls.Add(this.label2);
            this.PnlNewOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PnlNewOrder.Location = new System.Drawing.Point(12, 128);
            this.PnlNewOrder.Name = "PnlNewOrder";
            this.PnlNewOrder.Size = new System.Drawing.Size(1326, 755);
            this.PnlNewOrder.TabIndex = 10;
            this.PnlNewOrder.Visible = false;
            // 
            // PnlOrderInfo
            // 
            this.PnlOrderInfo.BackColor = System.Drawing.Color.Khaki;
            this.PnlOrderInfo.Controls.Add(this.label12);
            this.PnlOrderInfo.Controls.Add(this.BtnCancelOrder);
            this.PnlOrderInfo.Controls.Add(this.label13);
            this.PnlOrderInfo.Controls.Add(this.DgvBasket);
            this.PnlOrderInfo.Controls.Add(this.BtnCreateOrder);
            this.PnlOrderInfo.Controls.Add(this.label11);
            this.PnlOrderInfo.Controls.Add(this.RtbTotalPrice);
            this.PnlOrderInfo.Controls.Add(this.label10);
            this.PnlOrderInfo.Location = new System.Drawing.Point(32, 342);
            this.PnlOrderInfo.Name = "PnlOrderInfo";
            this.PnlOrderInfo.Size = new System.Drawing.Size(622, 196);
            this.PnlOrderInfo.TabIndex = 25;
            this.PnlOrderInfo.Visible = false;
            // 
            // BtnCancelOrder
            // 
            this.BtnCancelOrder.BackColor = System.Drawing.Color.Gold;
            this.BtnCancelOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelOrder.Location = new System.Drawing.Point(413, 139);
            this.BtnCancelOrder.Name = "BtnCancelOrder";
            this.BtnCancelOrder.Size = new System.Drawing.Size(162, 39);
            this.BtnCancelOrder.TabIndex = 28;
            this.BtnCancelOrder.Text = "Cancel";
            this.BtnCancelOrder.UseVisualStyleBackColor = false;
            this.BtnCancelOrder.Click += new System.EventHandler(this.BtnCancelOrder_Click_1);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(581, 51);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(25, 25);
            this.label13.TabIndex = 27;
            this.label13.Text = "$";
            // 
            // DgvBasket
            // 
            this.DgvBasket.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvBasket.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvBasket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvBasket.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column18,
            this.Column19,
            this.Column21,
            this.Column22});
            this.DgvBasket.Location = new System.Drawing.Point(11, 88);
            this.DgvBasket.Name = "DgvBasket";
            this.DgvBasket.Size = new System.Drawing.Size(264, 45);
            this.DgvBasket.TabIndex = 26;
            // 
            // Column18
            // 
            this.Column18.HeaderText = "Id";
            this.Column18.Name = "Column18";
            this.Column18.Visible = false;
            // 
            // Column19
            // 
            this.Column19.HeaderText = "Book";
            this.Column19.Name = "Column19";
            // 
            // Column21
            // 
            this.Column21.HeaderText = "Count";
            this.Column21.Name = "Column21";
            // 
            // Column22
            // 
            this.Column22.HeaderText = "Price";
            this.Column22.Name = "Column22";
            // 
            // BtnCreateOrder
            // 
            this.BtnCreateOrder.BackColor = System.Drawing.Color.LightGreen;
            this.BtnCreateOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCreateOrder.Location = new System.Drawing.Point(413, 94);
            this.BtnCreateOrder.Name = "BtnCreateOrder";
            this.BtnCreateOrder.Size = new System.Drawing.Size(162, 39);
            this.BtnCreateOrder.TabIndex = 22;
            this.BtnCreateOrder.Text = "Submit";
            this.BtnCreateOrder.UseVisualStyleBackColor = false;
            this.BtnCreateOrder.Click += new System.EventHandler(this.BtnCreateOrder_Click_1);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(12, 11);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(141, 18);
            this.label11.TabIndex = 0;
            this.label11.Text = "Order Information";
            // 
            // RtbTotalPrice
            // 
            this.RtbTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RtbTotalPrice.Location = new System.Drawing.Point(413, 41);
            this.RtbTotalPrice.Name = "RtbTotalPrice";
            this.RtbTotalPrice.ReadOnly = true;
            this.RtbTotalPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RtbTotalPrice.Size = new System.Drawing.Size(162, 47);
            this.RtbTotalPrice.TabIndex = 24;
            this.RtbTotalPrice.Text = "";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(324, 57);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 16);
            this.label10.TabIndex = 23;
            this.label10.Text = "Total price";
            // 
            // BtnAddToCard
            // 
            this.BtnAddToCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddToCard.Location = new System.Drawing.Point(703, 342);
            this.BtnAddToCard.Name = "BtnAddToCard";
            this.BtnAddToCard.Size = new System.Drawing.Size(169, 39);
            this.BtnAddToCard.TabIndex = 21;
            this.BtnAddToCard.Text = "Add to card";
            this.BtnAddToCard.UseVisualStyleBackColor = true;
            this.BtnAddToCard.Click += new System.EventHandler(this.BtnAddToCard_Click_1);
            // 
            // NupBookCount
            // 
            this.NupBookCount.Location = new System.Drawing.Point(821, 297);
            this.NupBookCount.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.NupBookCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NupBookCount.Name = "NupBookCount";
            this.NupBookCount.ReadOnly = true;
            this.NupBookCount.Size = new System.Drawing.Size(120, 20);
            this.NupBookCount.TabIndex = 20;
            this.NupBookCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(696, 297);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(126, 16);
            this.label9.TabIndex = 19;
            this.label9.Text = "Number of books";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(302, 278);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 16);
            this.label8.TabIndex = 18;
            this.label8.Text = "Deadline";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(29, 278);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "Taken at";
            // 
            // DtpNewDeadline
            // 
            this.DtpNewDeadline.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpNewDeadline.Location = new System.Drawing.Point(305, 297);
            this.DtpNewDeadline.MinDate = new System.DateTime(2020, 2, 17, 0, 0, 0, 0);
            this.DtpNewDeadline.Name = "DtpNewDeadline";
            this.DtpNewDeadline.Size = new System.Drawing.Size(200, 20);
            this.DtpNewDeadline.TabIndex = 16;
            // 
            // DtpNewTaken
            // 
            this.DtpNewTaken.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpNewTaken.Location = new System.Drawing.Point(32, 297);
            this.DtpNewTaken.MaxDate = new System.DateTime(2020, 2, 17, 0, 0, 0, 0);
            this.DtpNewTaken.MinDate = new System.DateTime(2020, 2, 17, 0, 0, 0, 0);
            this.DtpNewTaken.Name = "DtpNewTaken";
            this.DtpNewTaken.Size = new System.Drawing.Size(200, 20);
            this.DtpNewTaken.TabIndex = 15;
            this.DtpNewTaken.Value = new System.DateTime(2020, 2, 17, 0, 0, 0, 0);
            // 
            // BtnBookSearch
            // 
            this.BtnBookSearch.Location = new System.Drawing.Point(878, 72);
            this.BtnBookSearch.Name = "BtnBookSearch";
            this.BtnBookSearch.Size = new System.Drawing.Size(75, 23);
            this.BtnBookSearch.TabIndex = 14;
            this.BtnBookSearch.Text = "Search";
            this.BtnBookSearch.UseVisualStyleBackColor = true;
            this.BtnBookSearch.Click += new System.EventHandler(this.BtnBookSearch_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(639, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Books";
            // 
            // TxbBookSearch
            // 
            this.TxbBookSearch.Location = new System.Drawing.Point(694, 73);
            this.TxbBookSearch.Name = "TxbBookSearch";
            this.TxbBookSearch.Size = new System.Drawing.Size(178, 20);
            this.TxbBookSearch.TabIndex = 12;
            // 
            // DgvBookSearch
            // 
            this.DgvBookSearch.AllowUserToAddRows = false;
            this.DgvBookSearch.AllowUserToDeleteRows = false;
            this.DgvBookSearch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvBookSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvBookSearch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.Column12,
            this.Column13,
            this.Column14,
            this.Column16,
            this.Column15});
            this.DgvBookSearch.Location = new System.Drawing.Point(694, 107);
            this.DgvBookSearch.Name = "DgvBookSearch";
            this.DgvBookSearch.Size = new System.Drawing.Size(579, 153);
            this.DgvBookSearch.TabIndex = 11;
            this.DgvBookSearch.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvBookSearch_CellClick_1);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // Column12
            // 
            this.Column12.HeaderText = "Title";
            this.Column12.Name = "Column12";
            // 
            // Column13
            // 
            this.Column13.HeaderText = "Author";
            this.Column13.Name = "Column13";
            // 
            // Column14
            // 
            this.Column14.HeaderText = "Genre";
            this.Column14.Name = "Column14";
            // 
            // Column16
            // 
            this.Column16.HeaderText = "Price";
            this.Column16.Name = "Column16";
            // 
            // Column15
            // 
            this.Column15.HeaderText = "Count";
            this.Column15.Name = "Column15";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(654, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 10;
            // 
            // BtnCustomerSearch
            // 
            this.BtnCustomerSearch.Location = new System.Drawing.Point(289, 73);
            this.BtnCustomerSearch.Name = "BtnCustomerSearch";
            this.BtnCustomerSearch.Size = new System.Drawing.Size(75, 23);
            this.BtnCustomerSearch.TabIndex = 9;
            this.BtnCustomerSearch.Text = "Search";
            this.BtnCustomerSearch.UseVisualStyleBackColor = true;
            this.BtnCustomerSearch.Click += new System.EventHandler(this.BtnCustomerSearch_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Customer";
            // 
            // TxbCustomerSearch
            // 
            this.TxbCustomerSearch.Location = new System.Drawing.Point(99, 74);
            this.TxbCustomerSearch.Name = "TxbCustomerSearch";
            this.TxbCustomerSearch.Size = new System.Drawing.Size(184, 20);
            this.TxbCustomerSearch.TabIndex = 7;
            // 
            // DgvCustomersSearch
            // 
            this.DgvCustomersSearch.AllowUserToAddRows = false;
            this.DgvCustomersSearch.AllowUserToDeleteRows = false;
            this.DgvCustomersSearch.AllowUserToOrderColumns = true;
            this.DgvCustomersSearch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvCustomersSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvCustomersSearch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column7,
            this.Column17,
            this.Column9,
            this.Column10,
            this.Column11});
            this.DgvCustomersSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DgvCustomersSearch.Location = new System.Drawing.Point(28, 107);
            this.DgvCustomersSearch.Name = "DgvCustomersSearch";
            this.DgvCustomersSearch.Size = new System.Drawing.Size(579, 153);
            this.DgvCustomersSearch.TabIndex = 6;
            this.DgvCustomersSearch.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvCustomersSearch_CellClick);
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Id";
            this.Column7.Name = "Column7";
            this.Column7.Visible = false;
            // 
            // Column17
            // 
            this.Column17.HeaderText = "Name";
            this.Column17.Name = "Column17";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Surname";
            this.Column9.Name = "Column9";
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Phone";
            this.Column10.Name = "Column10";
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Address";
            this.Column11.Name = "Column11";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "New order";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // BtnAllReturns
            // 
            this.BtnAllReturns.BackColor = System.Drawing.Color.CadetBlue;
            this.BtnAllReturns.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAllReturns.Location = new System.Drawing.Point(203, 73);
            this.BtnAllReturns.Name = "BtnAllReturns";
            this.BtnAllReturns.Size = new System.Drawing.Size(160, 38);
            this.BtnAllReturns.TabIndex = 12;
            this.BtnAllReturns.Text = "All returns";
            this.BtnAllReturns.UseVisualStyleBackColor = false;
            this.BtnAllReturns.Click += new System.EventHandler(this.BtnAllReturns_Click);
            // 
            // BtnLateReturn
            // 
            this.BtnLateReturn.BackColor = System.Drawing.Color.CadetBlue;
            this.BtnLateReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLateReturn.Location = new System.Drawing.Point(369, 73);
            this.BtnLateReturn.Name = "BtnLateReturn";
            this.BtnLateReturn.Size = new System.Drawing.Size(160, 38);
            this.BtnLateReturn.TabIndex = 13;
            this.BtnLateReturn.Text = "Late returns";
            this.BtnLateReturn.UseVisualStyleBackColor = false;
            this.BtnLateReturn.Click += new System.EventHandler(this.BtnLateReturn_Click);
            // 
            // BtnOrder
            // 
            this.BtnOrder.BackColor = System.Drawing.Color.CadetBlue;
            this.BtnOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOrder.Location = new System.Drawing.Point(543, 73);
            this.BtnOrder.Name = "BtnOrder";
            this.BtnOrder.Size = new System.Drawing.Size(160, 38);
            this.BtnOrder.TabIndex = 27;
            this.BtnOrder.Text = "Report";
            this.BtnOrder.UseVisualStyleBackColor = false;
            this.BtnOrder.Click += new System.EventHandler(this.BtnOrder_Click);
            // 
            // PnlAllOrders
            // 
            this.PnlAllOrders.BackColor = System.Drawing.Color.CadetBlue;
            this.PnlAllOrders.Controls.Add(this.GrpSearch);
            this.PnlAllOrders.Controls.Add(this.GrbReportRange);
            this.PnlAllOrders.Controls.Add(this.PnlPaymentInfo);
            this.PnlAllOrders.Controls.Add(this.DgvAllOrders);
            this.PnlAllOrders.Controls.Add(this.BtnReturn);
            this.PnlAllOrders.Controls.Add(this.BtnNewOrder);
            this.PnlAllOrders.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PnlAllOrders.Location = new System.Drawing.Point(12, 128);
            this.PnlAllOrders.Name = "PnlAllOrders";
            this.PnlAllOrders.Size = new System.Drawing.Size(1323, 673);
            this.PnlAllOrders.TabIndex = 26;
            // 
            // GrbReportRange
            // 
            this.GrbReportRange.Controls.Add(this.BtnReportSearch);
            this.GrbReportRange.Controls.Add(this.BtnExcel);
            this.GrbReportRange.Controls.Add(this.label18);
            this.GrbReportRange.Controls.Add(this.label15);
            this.GrbReportRange.Controls.Add(this.DtpReportTo);
            this.GrbReportRange.Controls.Add(this.DtpReportFrom);
            this.GrbReportRange.Location = new System.Drawing.Point(465, 0);
            this.GrbReportRange.Name = "GrbReportRange";
            this.GrbReportRange.Size = new System.Drawing.Size(676, 67);
            this.GrbReportRange.TabIndex = 28;
            this.GrbReportRange.TabStop = false;
            this.GrbReportRange.Text = "Date";
            this.GrbReportRange.Visible = false;
            // 
            // BtnReportSearch
            // 
            this.BtnReportSearch.Location = new System.Drawing.Point(534, 17);
            this.BtnReportSearch.Name = "BtnReportSearch";
            this.BtnReportSearch.Size = new System.Drawing.Size(75, 23);
            this.BtnReportSearch.TabIndex = 10;
            this.BtnReportSearch.Text = "Show";
            this.BtnReportSearch.UseVisualStyleBackColor = true;
            this.BtnReportSearch.Click += new System.EventHandler(this.BtnReportSearch_Click);
            // 
            // BtnExcel
            // 
            this.BtnExcel.BackColor = System.Drawing.Color.PaleGreen;
            this.BtnExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExcel.Image = ((System.Drawing.Image)(resources.GetObject("BtnExcel.Image")));
            this.BtnExcel.Location = new System.Drawing.Point(615, 9);
            this.BtnExcel.Name = "BtnExcel";
            this.BtnExcel.Size = new System.Drawing.Size(50, 50);
            this.BtnExcel.TabIndex = 27;
            this.BtnExcel.UseVisualStyleBackColor = false;
            this.BtnExcel.Click += new System.EventHandler(this.BtnExcel_Click_1);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(291, 24);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(27, 16);
            this.label18.TabIndex = 3;
            this.label18.Text = "To";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(17, 24);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(43, 16);
            this.label15.TabIndex = 2;
            this.label15.Text = "From";
            // 
            // DtpReportTo
            // 
            this.DtpReportTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpReportTo.Location = new System.Drawing.Point(328, 20);
            this.DtpReportTo.Name = "DtpReportTo";
            this.DtpReportTo.Size = new System.Drawing.Size(200, 20);
            this.DtpReportTo.TabIndex = 1;
            // 
            // DtpReportFrom
            // 
            this.DtpReportFrom.CustomFormat = "dd.MM.yyy";
            this.DtpReportFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpReportFrom.Location = new System.Drawing.Point(70, 22);
            this.DtpReportFrom.Name = "DtpReportFrom";
            this.DtpReportFrom.Size = new System.Drawing.Size(200, 20);
            this.DtpReportFrom.TabIndex = 0;
            // 
            // PnlPaymentInfo
            // 
            this.PnlPaymentInfo.BackColor = System.Drawing.Color.Khaki;
            this.PnlPaymentInfo.Controls.Add(this.BtnCancelReturn);
            this.PnlPaymentInfo.Controls.Add(this.label1);
            this.PnlPaymentInfo.Controls.Add(this.BtnPayFine);
            this.PnlPaymentInfo.Controls.Add(this.label16);
            this.PnlPaymentInfo.Controls.Add(this.RtbFinePrice);
            this.PnlPaymentInfo.Controls.Add(this.label17);
            this.PnlPaymentInfo.Location = new System.Drawing.Point(824, 203);
            this.PnlPaymentInfo.Name = "PnlPaymentInfo";
            this.PnlPaymentInfo.Size = new System.Drawing.Size(332, 215);
            this.PnlPaymentInfo.TabIndex = 26;
            this.PnlPaymentInfo.Visible = false;
            // 
            // BtnCancelReturn
            // 
            this.BtnCancelReturn.BackColor = System.Drawing.Color.Gold;
            this.BtnCancelReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelReturn.Location = new System.Drawing.Point(106, 150);
            this.BtnCancelReturn.Name = "BtnCancelReturn";
            this.BtnCancelReturn.Size = new System.Drawing.Size(162, 39);
            this.BtnCancelReturn.TabIndex = 28;
            this.BtnCancelReturn.Text = "Cancel";
            this.BtnCancelReturn.UseVisualStyleBackColor = false;
            this.BtnCancelReturn.Click += new System.EventHandler(this.BtnCancelReturn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(274, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 25);
            this.label1.TabIndex = 27;
            this.label1.Text = "$";
            // 
            // BtnPayFine
            // 
            this.BtnPayFine.BackColor = System.Drawing.Color.LightGreen;
            this.BtnPayFine.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPayFine.Location = new System.Drawing.Point(106, 105);
            this.BtnPayFine.Name = "BtnPayFine";
            this.BtnPayFine.Size = new System.Drawing.Size(162, 39);
            this.BtnPayFine.TabIndex = 22;
            this.BtnPayFine.Text = "Submit";
            this.BtnPayFine.UseVisualStyleBackColor = false;
            this.BtnPayFine.Click += new System.EventHandler(this.BtnPayFine_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(12, 11);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(163, 18);
            this.label16.TabIndex = 0;
            this.label16.Text = "Payment information";
            // 
            // RtbFinePrice
            // 
            this.RtbFinePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RtbFinePrice.Location = new System.Drawing.Point(106, 52);
            this.RtbFinePrice.Name = "RtbFinePrice";
            this.RtbFinePrice.ReadOnly = true;
            this.RtbFinePrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RtbFinePrice.Size = new System.Drawing.Size(162, 47);
            this.RtbFinePrice.TabIndex = 24;
            this.RtbFinePrice.Text = "";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(17, 68);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(77, 16);
            this.label17.TabIndex = 23;
            this.label17.Text = "Fine price";
            // 
            // DgvAllOrders
            // 
            this.DgvAllOrders.AllowUserToAddRows = false;
            this.DgvAllOrders.AllowUserToDeleteRows = false;
            this.DgvAllOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvAllOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvAllOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column24,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column8,
            this.Column20,
            this.Column23,
            this.Column25});
            this.DgvAllOrders.Location = new System.Drawing.Point(28, 73);
            this.DgvAllOrders.Name = "DgvAllOrders";
            this.DgvAllOrders.Size = new System.Drawing.Size(784, 448);
            this.DgvAllOrders.TabIndex = 5;
            this.DgvAllOrders.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvAllOrders_CellClick_1);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Name";
            this.Column2.Name = "Column2";
            // 
            // Column24
            // 
            this.Column24.HeaderText = "Surname";
            this.Column24.Name = "Column24";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Book";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Count";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Taken at";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Deadline";
            this.Column6.Name = "Column6";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Price";
            this.Column8.Name = "Column8";
            // 
            // Column20
            // 
            this.Column20.HeaderText = "Fine";
            this.Column20.Name = "Column20";
            // 
            // Column23
            // 
            this.Column23.HeaderText = "Status";
            this.Column23.Name = "Column23";
            // 
            // Column25
            // 
            this.Column25.HeaderText = "BookId";
            this.Column25.Name = "Column25";
            this.Column25.Visible = false;
            // 
            // BtnReturn
            // 
            this.BtnReturn.BackColor = System.Drawing.Color.Gold;
            this.BtnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReturn.Location = new System.Drawing.Point(824, 133);
            this.BtnReturn.Name = "BtnReturn";
            this.BtnReturn.Size = new System.Drawing.Size(160, 38);
            this.BtnReturn.TabIndex = 6;
            this.BtnReturn.Text = "Return book";
            this.BtnReturn.UseVisualStyleBackColor = false;
            this.BtnReturn.Click += new System.EventHandler(this.BtnReturn_Click_1);
            // 
            // BtnNewOrder
            // 
            this.BtnNewOrder.BackColor = System.Drawing.Color.PaleGreen;
            this.BtnNewOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNewOrder.Location = new System.Drawing.Point(824, 74);
            this.BtnNewOrder.Name = "BtnNewOrder";
            this.BtnNewOrder.Size = new System.Drawing.Size(160, 38);
            this.BtnNewOrder.TabIndex = 1;
            this.BtnNewOrder.Text = "New order";
            this.BtnNewOrder.UseVisualStyleBackColor = false;
            this.BtnNewOrder.Click += new System.EventHandler(this.BtnNewOrder_Click_2);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(12, 63);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 13);
            this.label12.TabIndex = 29;
            this.label12.Text = "Selected book";
            // 
            // GrpSearch
            // 
            this.GrpSearch.Controls.Add(this.TxbOrderSearch);
            this.GrpSearch.Controls.Add(this.BtnOrderSearch);
            this.GrpSearch.Controls.Add(this.label14);
            this.GrpSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GrpSearch.Location = new System.Drawing.Point(27, 0);
            this.GrpSearch.Name = "GrpSearch";
            this.GrpSearch.Size = new System.Drawing.Size(433, 67);
            this.GrpSearch.TabIndex = 29;
            this.GrpSearch.TabStop = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(5, 23);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(80, 13);
            this.label14.TabIndex = 10;
            this.label14.Text = "Customer name";
            // 
            // BtnOrderSearch
            // 
            this.BtnOrderSearch.Location = new System.Drawing.Point(344, 19);
            this.BtnOrderSearch.Name = "BtnOrderSearch";
            this.BtnOrderSearch.Size = new System.Drawing.Size(75, 23);
            this.BtnOrderSearch.TabIndex = 9;
            this.BtnOrderSearch.Text = "Search";
            this.BtnOrderSearch.UseVisualStyleBackColor = true;
            this.BtnOrderSearch.Click += new System.EventHandler(this.BtnOrderSearch_Click);
            // 
            // TxbOrderSearch
            // 
            this.TxbOrderSearch.Location = new System.Drawing.Point(88, 21);
            this.TxbOrderSearch.Name = "TxbOrderSearch";
            this.TxbOrderSearch.Size = new System.Drawing.Size(240, 20);
            this.TxbOrderSearch.TabIndex = 8;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(1333, 745);
            this.Controls.Add(this.PnlAllOrders);
            this.Controls.Add(this.BtnOrder);
            this.Controls.Add(this.BtnLateReturn);
            this.Controls.Add(this.BtnAllReturns);
            this.Controls.Add(this.PnlNewOrder);
            this.Controls.Add(this.BtnAllOrders);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.PnlNewOrder.ResumeLayout(false);
            this.PnlNewOrder.PerformLayout();
            this.PnlOrderInfo.ResumeLayout(false);
            this.PnlOrderInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvBasket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NupBookCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvBookSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCustomersSearch)).EndInit();
            this.PnlAllOrders.ResumeLayout(false);
            this.GrbReportRange.ResumeLayout(false);
            this.GrbReportRange.PerformLayout();
            this.PnlPaymentInfo.ResumeLayout(false);
            this.PnlPaymentInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAllOrders)).EndInit();
            this.GrpSearch.ResumeLayout(false);
            this.GrpSearch.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem BtnBookForm;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
        private System.Windows.Forms.Button BtnAllOrders;
        private System.Windows.Forms.Panel PnlNewOrder;
        private System.Windows.Forms.Panel PnlOrderInfo;
        private System.Windows.Forms.Button BtnCancelOrder;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView DgvBasket;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column18;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column19;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column21;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column22;
        private System.Windows.Forms.Button BtnCreateOrder;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RichTextBox RtbTotalPrice;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button BtnAddToCard;
        private System.Windows.Forms.NumericUpDown NupBookCount;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker DtpNewDeadline;
        private System.Windows.Forms.DateTimePicker DtpNewTaken;
        private System.Windows.Forms.Button BtnBookSearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxbBookSearch;
        private System.Windows.Forms.DataGridView DgvBookSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column16;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column15;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnCustomerSearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxbCustomerSearch;
        private System.Windows.Forms.DataGridView DgvCustomersSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column17;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button BtnAllReturns;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button BtnLateReturn;
        private System.Windows.Forms.Button BtnOrder;
        private System.Windows.Forms.Panel PnlAllOrders;
        private System.Windows.Forms.GroupBox GrbReportRange;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker DtpReportTo;
        private System.Windows.Forms.DateTimePicker DtpReportFrom;
        private System.Windows.Forms.Button BtnExcel;
        private System.Windows.Forms.Panel PnlPaymentInfo;
        private System.Windows.Forms.Button BtnCancelReturn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnPayFine;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.RichTextBox RtbFinePrice;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DataGridView DgvAllOrders;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column24;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column20;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column23;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column25;
        private System.Windows.Forms.Button BtnReturn;
        private System.Windows.Forms.Button BtnNewOrder;
        private System.Windows.Forms.Button BtnReportSearch;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox GrpSearch;
        private System.Windows.Forms.TextBox TxbOrderSearch;
        private System.Windows.Forms.Button BtnOrderSearch;
        private System.Windows.Forms.Label label14;
    }
}