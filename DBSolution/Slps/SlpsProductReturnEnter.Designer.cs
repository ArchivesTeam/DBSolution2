﻿namespace DBSolution
{
    partial class SlpsProductReturnEnter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SlpsProductReturnEnter));
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.labelTitle = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.toolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonQuit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonEdit = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.textBoxGross = new System.Windows.Forms.TextBox();
            this.labelTare = new System.Windows.Forms.Label();
            this.groupBoxStep3 = new System.Windows.Forms.GroupBox();
            this.dataGridViewDetails = new System.Windows.Forms.DataGridView();
            this.textBoxWeighMan = new System.Windows.Forms.TextBox();
            this.labelWeighMan = new System.Windows.Forms.Label();
            this.groupBoxStep1 = new System.Windows.Forms.GroupBox();
            this.textBoxDbnum = new System.Windows.Forms.TextBox();
            this.labelVBELN = new System.Windows.Forms.Label();
            this.textBoxFactory = new System.Windows.Forms.TextBox();
            this.labelFactory = new System.Windows.Forms.Label();
            this.textBoxCar = new System.Windows.Forms.TextBox();
            this.labelCar = new System.Windows.Forms.Label();
            this.groupBoxManual = new System.Windows.Forms.GroupBox();
            this.dataGridViewHistory = new System.Windows.Forms.DataGridView();
            this.TARE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WERKS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIMEFLAG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxPrompt = new System.Windows.Forms.TextBox();
            this.groupBoxWeight = new System.Windows.Forms.GroupBox();
            this.textBoxWeight = new System.Windows.Forms.TextBox();
            this.panel0 = new System.Windows.Forms.Panel();
            this.qrcodeScanResult = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sapOrderNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lineItemNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.skuCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.skuName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.beforeSendTonQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sfimg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.groupBoxStep3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetails)).BeginInit();
            this.groupBoxStep1.SuspendLayout();
            this.groupBoxManual.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHistory)).BeginInit();
            this.groupBoxWeight.SuspendLayout();
            this.panel0.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Interval = 500;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("宋体", 11.5F, System.Drawing.FontStyle.Bold);
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(104)))), ((int)(((byte)(151)))));
            this.labelTitle.Location = new System.Drawing.Point(16, 6);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(212, 16);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "史丹利公司产成品退货入厂";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.labelTitle);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1004, 30);
            this.panel2.TabIndex = 9;
            // 
            // toolStripButton
            // 
            this.toolStripButton.Image = global::DBSolution2.Properties.Resources.Lock;
            this.toolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton.Name = "toolStripButton";
            this.toolStripButton.Size = new System.Drawing.Size(52, 22);
            this.toolStripButton.Text = "锁定";
            this.toolStripButton.Click += new System.EventHandler(this.toolStripButton_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonSave
            // 
            this.toolStripButtonSave.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSave.Image")));
            this.toolStripButtonSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSave.Name = "toolStripButtonSave";
            this.toolStripButtonSave.Size = new System.Drawing.Size(52, 22);
            this.toolStripButtonSave.Text = "保存";
            this.toolStripButtonSave.Click += new System.EventHandler(this.toolStripButtonSave_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonQuit
            // 
            this.toolStripButtonQuit.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonQuit.Image")));
            this.toolStripButtonQuit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonQuit.Name = "toolStripButtonQuit";
            this.toolStripButtonQuit.Size = new System.Drawing.Size(52, 22);
            this.toolStripButtonQuit.Text = "退出";
            this.toolStripButtonQuit.Click += new System.EventHandler(this.toolStripButtonQuit_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonEdit
            // 
            this.toolStripButtonEdit.Enabled = false;
            this.toolStripButtonEdit.Image = global::DBSolution2.Properties.Resources.修改;
            this.toolStripButtonEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEdit.Name = "toolStripButtonEdit";
            this.toolStripButtonEdit.Size = new System.Drawing.Size(52, 22);
            this.toolStripButtonEdit.Text = "编辑";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(193)))), ((int)(((byte)(226)))));
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton,
            this.toolStripSeparator3,
            this.toolStripButtonSave,
            this.toolStripSeparator1,
            this.toolStripButtonQuit,
            this.toolStripSeparator2,
            this.toolStripButtonEdit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 30);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(1004, 25);
            this.toolStrip1.TabIndex = 10;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // panelBottom
            // 
            this.panelBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(219)))), ((int)(((byte)(234)))));
            this.panelBottom.Controls.Add(this.textBoxGross);
            this.panelBottom.Controls.Add(this.labelTare);
            this.panelBottom.Controls.Add(this.groupBoxStep3);
            this.panelBottom.Controls.Add(this.textBoxWeighMan);
            this.panelBottom.Controls.Add(this.labelWeighMan);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBottom.Location = new System.Drawing.Point(0, 340);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(1004, 207);
            this.panelBottom.TabIndex = 12;
            // 
            // textBoxGross
            // 
            this.textBoxGross.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxGross.Location = new System.Drawing.Point(280, 177);
            this.textBoxGross.Name = "textBoxGross";
            this.textBoxGross.Size = new System.Drawing.Size(104, 21);
            this.textBoxGross.TabIndex = 10;
            // 
            // labelTare
            // 
            this.labelTare.AutoSize = true;
            this.labelTare.Location = new System.Drawing.Point(220, 181);
            this.labelTare.Name = "labelTare";
            this.labelTare.Size = new System.Drawing.Size(29, 12);
            this.labelTare.TabIndex = 9;
            this.labelTare.Text = "毛重";
            // 
            // groupBoxStep3
            // 
            this.groupBoxStep3.Controls.Add(this.dataGridViewDetails);
            this.groupBoxStep3.Location = new System.Drawing.Point(12, 12);
            this.groupBoxStep3.Name = "groupBoxStep3";
            this.groupBoxStep3.Size = new System.Drawing.Size(980, 155);
            this.groupBoxStep3.TabIndex = 8;
            this.groupBoxStep3.TabStop = false;
            this.groupBoxStep3.Text = "退货订单明细";
            // 
            // dataGridViewDetails
            // 
            this.dataGridViewDetails.AllowUserToAddRows = false;
            this.dataGridViewDetails.AllowUserToDeleteRows = false;
            this.dataGridViewDetails.AllowUserToOrderColumns = true;
            this.dataGridViewDetails.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(209)))), ((int)(((byte)(234)))));
            this.dataGridViewDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.qrcodeScanResult,
            this.sapOrderNo,
            this.lineItemNo,
            this.skuCode,
            this.skuName,
            this.beforeSendTonQuantity,
            this.sfimg});
            this.dataGridViewDetails.Location = new System.Drawing.Point(25, 17);
            this.dataGridViewDetails.Name = "dataGridViewDetails";
            this.dataGridViewDetails.ReadOnly = true;
            this.dataGridViewDetails.RowTemplate.Height = 23;
            this.dataGridViewDetails.Size = new System.Drawing.Size(930, 132);
            this.dataGridViewDetails.TabIndex = 1;
            // 
            // textBoxWeighMan
            // 
            this.textBoxWeighMan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxWeighMan.Location = new System.Drawing.Point(80, 177);
            this.textBoxWeighMan.Name = "textBoxWeighMan";
            this.textBoxWeighMan.ReadOnly = true;
            this.textBoxWeighMan.Size = new System.Drawing.Size(104, 21);
            this.textBoxWeighMan.TabIndex = 7;
            // 
            // labelWeighMan
            // 
            this.labelWeighMan.AutoSize = true;
            this.labelWeighMan.Location = new System.Drawing.Point(22, 181);
            this.labelWeighMan.Name = "labelWeighMan";
            this.labelWeighMan.Size = new System.Drawing.Size(41, 12);
            this.labelWeighMan.TabIndex = 6;
            this.labelWeighMan.Text = "司磅员";
            // 
            // groupBoxStep1
            // 
            this.groupBoxStep1.Controls.Add(this.textBoxDbnum);
            this.groupBoxStep1.Controls.Add(this.labelVBELN);
            this.groupBoxStep1.Controls.Add(this.textBoxFactory);
            this.groupBoxStep1.Controls.Add(this.labelFactory);
            this.groupBoxStep1.Controls.Add(this.textBoxCar);
            this.groupBoxStep1.Controls.Add(this.labelCar);
            this.groupBoxStep1.Location = new System.Drawing.Point(11, 17);
            this.groupBoxStep1.Name = "groupBoxStep1";
            this.groupBoxStep1.Size = new System.Drawing.Size(678, 251);
            this.groupBoxStep1.TabIndex = 1;
            this.groupBoxStep1.TabStop = false;
            this.groupBoxStep1.Text = "出入厂信息";
            // 
            // textBoxDbnum
            // 
            this.textBoxDbnum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxDbnum.Font = new System.Drawing.Font("宋体", 11F);
            this.textBoxDbnum.Location = new System.Drawing.Point(526, 60);
            this.textBoxDbnum.Name = "textBoxDbnum";
            this.textBoxDbnum.ReadOnly = true;
            this.textBoxDbnum.Size = new System.Drawing.Size(124, 24);
            this.textBoxDbnum.TabIndex = 14;
            // 
            // labelVBELN
            // 
            this.labelVBELN.AutoSize = true;
            this.labelVBELN.Font = new System.Drawing.Font("宋体", 11F);
            this.labelVBELN.Location = new System.Drawing.Point(443, 65);
            this.labelVBELN.Name = "labelVBELN";
            this.labelVBELN.Size = new System.Drawing.Size(67, 15);
            this.labelVBELN.TabIndex = 15;
            this.labelVBELN.Text = "地磅编号";
            // 
            // textBoxFactory
            // 
            this.textBoxFactory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxFactory.Font = new System.Drawing.Font("宋体", 11F);
            this.textBoxFactory.Location = new System.Drawing.Point(292, 60);
            this.textBoxFactory.Name = "textBoxFactory";
            this.textBoxFactory.ReadOnly = true;
            this.textBoxFactory.Size = new System.Drawing.Size(115, 24);
            this.textBoxFactory.TabIndex = 5;
            // 
            // labelFactory
            // 
            this.labelFactory.AutoSize = true;
            this.labelFactory.Font = new System.Drawing.Font("宋体", 11F);
            this.labelFactory.Location = new System.Drawing.Point(243, 65);
            this.labelFactory.Name = "labelFactory";
            this.labelFactory.Size = new System.Drawing.Size(37, 15);
            this.labelFactory.TabIndex = 4;
            this.labelFactory.Text = "工厂";
            // 
            // textBoxCar
            // 
            this.textBoxCar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxCar.Font = new System.Drawing.Font("宋体", 11F);
            this.textBoxCar.Location = new System.Drawing.Point(86, 60);
            this.textBoxCar.Name = "textBoxCar";
            this.textBoxCar.ReadOnly = true;
            this.textBoxCar.Size = new System.Drawing.Size(115, 24);
            this.textBoxCar.TabIndex = 1;
            // 
            // labelCar
            // 
            this.labelCar.AutoSize = true;
            this.labelCar.Font = new System.Drawing.Font("宋体", 11F);
            this.labelCar.Location = new System.Drawing.Point(19, 65);
            this.labelCar.Name = "labelCar";
            this.labelCar.Size = new System.Drawing.Size(52, 15);
            this.labelCar.TabIndex = 0;
            this.labelCar.Text = "车牌号";
            // 
            // groupBoxManual
            // 
            this.groupBoxManual.Controls.Add(this.dataGridViewHistory);
            this.groupBoxManual.Controls.Add(this.textBoxPrompt);
            this.groupBoxManual.Location = new System.Drawing.Point(702, 90);
            this.groupBoxManual.Name = "groupBoxManual";
            this.groupBoxManual.Size = new System.Drawing.Size(288, 178);
            this.groupBoxManual.TabIndex = 5;
            this.groupBoxManual.TabStop = false;
            this.groupBoxManual.Text = "车辆皮重历史";
            // 
            // dataGridViewHistory
            // 
            this.dataGridViewHistory.AllowUserToAddRows = false;
            this.dataGridViewHistory.AllowUserToDeleteRows = false;
            this.dataGridViewHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TARE,
            this.WERKS,
            this.TIMEFLAG});
            this.dataGridViewHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewHistory.Location = new System.Drawing.Point(3, 17);
            this.dataGridViewHistory.Name = "dataGridViewHistory";
            this.dataGridViewHistory.ReadOnly = true;
            this.dataGridViewHistory.RowHeadersVisible = false;
            this.dataGridViewHistory.RowHeadersWidth = 4;
            this.dataGridViewHistory.RowTemplate.Height = 23;
            this.dataGridViewHistory.Size = new System.Drawing.Size(282, 158);
            this.dataGridViewHistory.TabIndex = 3;
            // 
            // TARE
            // 
            this.TARE.DataPropertyName = "TARE";
            this.TARE.HeaderText = "皮重";
            this.TARE.Name = "TARE";
            this.TARE.ReadOnly = true;
            this.TARE.Width = 60;
            // 
            // WERKS
            // 
            this.WERKS.DataPropertyName = "WERKS";
            this.WERKS.HeaderText = "工厂";
            this.WERKS.Name = "WERKS";
            this.WERKS.ReadOnly = true;
            this.WERKS.Width = 60;
            // 
            // TIMEFLAG
            // 
            this.TIMEFLAG.DataPropertyName = "TIMEFLAG";
            this.TIMEFLAG.HeaderText = "入厂时间";
            this.TIMEFLAG.Name = "TIMEFLAG";
            this.TIMEFLAG.ReadOnly = true;
            this.TIMEFLAG.Width = 158;
            // 
            // textBoxPrompt
            // 
            this.textBoxPrompt.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxPrompt.Location = new System.Drawing.Point(20, 22);
            this.textBoxPrompt.Multiline = true;
            this.textBoxPrompt.Name = "textBoxPrompt";
            this.textBoxPrompt.Size = new System.Drawing.Size(248, 140);
            this.textBoxPrompt.TabIndex = 1;
            // 
            // groupBoxWeight
            // 
            this.groupBoxWeight.Controls.Add(this.textBoxWeight);
            this.groupBoxWeight.Location = new System.Drawing.Point(702, 17);
            this.groupBoxWeight.Name = "groupBoxWeight";
            this.groupBoxWeight.Size = new System.Drawing.Size(288, 62);
            this.groupBoxWeight.TabIndex = 6;
            this.groupBoxWeight.TabStop = false;
            this.groupBoxWeight.Text = "地磅控制器重量显示";
            // 
            // textBoxWeight
            // 
            this.textBoxWeight.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxWeight.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxWeight.ForeColor = System.Drawing.Color.Red;
            this.textBoxWeight.Location = new System.Drawing.Point(20, 22);
            this.textBoxWeight.Multiline = true;
            this.textBoxWeight.Name = "textBoxWeight";
            this.textBoxWeight.Size = new System.Drawing.Size(248, 25);
            this.textBoxWeight.TabIndex = 1;
            this.textBoxWeight.Text = "12345";
            this.textBoxWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel0
            // 
            this.panel0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.panel0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel0.Controls.Add(this.groupBoxWeight);
            this.panel0.Controls.Add(this.groupBoxManual);
            this.panel0.Controls.Add(this.groupBoxStep1);
            this.panel0.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel0.Location = new System.Drawing.Point(0, 55);
            this.panel0.Name = "panel0";
            this.panel0.Size = new System.Drawing.Size(1004, 285);
            this.panel0.TabIndex = 11;
            // 
            // qrcodeScanResult
            // 
            this.qrcodeScanResult.DataPropertyName = "qrcodeScanResult";
            this.qrcodeScanResult.HeaderText = "二维码";
            this.qrcodeScanResult.Name = "qrcodeScanResult";
            this.qrcodeScanResult.ReadOnly = true;
            // 
            // sapOrderNo
            // 
            this.sapOrderNo.DataPropertyName = "sapOrderNo";
            this.sapOrderNo.HeaderText = "退货单号";
            this.sapOrderNo.Name = "sapOrderNo";
            this.sapOrderNo.ReadOnly = true;
            // 
            // lineItemNo
            // 
            this.lineItemNo.DataPropertyName = "lineItemNo";
            this.lineItemNo.HeaderText = "项目号";
            this.lineItemNo.Name = "lineItemNo";
            this.lineItemNo.ReadOnly = true;
            this.lineItemNo.Width = 60;
            // 
            // skuCode
            // 
            this.skuCode.DataPropertyName = "skuCode";
            this.skuCode.HeaderText = "物料编码";
            this.skuCode.Name = "skuCode";
            this.skuCode.ReadOnly = true;
            // 
            // skuName
            // 
            this.skuName.DataPropertyName = "skuName";
            this.skuName.HeaderText = "物料描述";
            this.skuName.Name = "skuName";
            this.skuName.ReadOnly = true;
            this.skuName.Width = 200;
            // 
            // beforeSendTonQuantity
            // 
            this.beforeSendTonQuantity.DataPropertyName = "beforeSendTonQuantity";
            this.beforeSendTonQuantity.HeaderText = "订单数量";
            this.beforeSendTonQuantity.Name = "beforeSendTonQuantity";
            this.beforeSendTonQuantity.ReadOnly = true;
            this.beforeSendTonQuantity.Width = 60;
            // 
            // sfimg
            // 
            this.sfimg.DataPropertyName = "sfimg";
            this.sfimg.HeaderText = "实退数量";
            this.sfimg.Name = "sfimg";
            this.sfimg.ReadOnly = true;
            this.sfimg.Width = 60;
            // 
            // SlpsProductReturnEnter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 547);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panel0);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel2);
            this.Name = "SlpsProductReturnEnter";
            this.Text = "史丹利公司产成品退货入厂";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panelBottom.ResumeLayout(false);
            this.panelBottom.PerformLayout();
            this.groupBoxStep3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetails)).EndInit();
            this.groupBoxStep1.ResumeLayout(false);
            this.groupBoxStep1.PerformLayout();
            this.groupBoxManual.ResumeLayout(false);
            this.groupBoxManual.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHistory)).EndInit();
            this.groupBoxWeight.ResumeLayout(false);
            this.groupBoxWeight.PerformLayout();
            this.panel0.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStripButton toolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButtonSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButtonQuit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButtonEdit;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.TextBox textBoxGross;
        private System.Windows.Forms.Label labelTare;
        private System.Windows.Forms.GroupBox groupBoxStep3;
        private System.Windows.Forms.DataGridView dataGridViewDetails;
        private System.Windows.Forms.TextBox textBoxWeighMan;
        private System.Windows.Forms.Label labelWeighMan;
        private System.Windows.Forms.GroupBox groupBoxStep1;
        private System.Windows.Forms.GroupBox groupBoxManual;
        private System.Windows.Forms.DataGridView dataGridViewHistory;
        private System.Windows.Forms.DataGridViewTextBoxColumn TARE;
        private System.Windows.Forms.DataGridViewTextBoxColumn WERKS;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIMEFLAG;
        private System.Windows.Forms.TextBox textBoxPrompt;
        private System.Windows.Forms.GroupBox groupBoxWeight;
        private System.Windows.Forms.TextBox textBoxWeight;
        private System.Windows.Forms.Panel panel0;
        private System.Windows.Forms.TextBox textBoxFactory;
        private System.Windows.Forms.Label labelFactory;
        private System.Windows.Forms.TextBox textBoxCar;
        private System.Windows.Forms.Label labelCar;
        private System.Windows.Forms.TextBox textBoxDbnum;
        private System.Windows.Forms.Label labelVBELN;
        private System.Windows.Forms.DataGridViewTextBoxColumn qrcodeScanResult;
        private System.Windows.Forms.DataGridViewTextBoxColumn sapOrderNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn lineItemNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn skuCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn skuName;
        private System.Windows.Forms.DataGridViewTextBoxColumn beforeSendTonQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn sfimg;
    }
}