﻿namespace DBSolution
{
    partial class AccessoryAllotTranferOutSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccessoryAllotTranferOutSearch));
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonQuit = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBoxCondition = new System.Windows.Forms.GroupBox();
            this.cbWerks = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textWeighMan = new System.Windows.Forms.TextBox();
            this.TimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.TimePickerBegin = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textEbeln = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textTruckNum = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridViewRawReturn = new System.Windows.Forms.DataGridView();
            this.VIEW = new System.Windows.Forms.DataGridViewImageColumn();
            this.RESWK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TRUCKNUM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EBELN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GROSS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TARE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DEDUCTNUM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ENTERWEIGHMAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EXITWEIGHMAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ENTERTIME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EXITTIME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIMEFLAG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EXITFLAG = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pager = new SdlDB.Utility.PageNavigator();
            this.btnOutExcel = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBoxCondition.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRawReturn)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.labelTitle);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(979, 30);
            this.panel2.TabIndex = 10;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("宋体", 11.5F, System.Drawing.FontStyle.Bold);
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(104)))), ((int)(((byte)(151)))));
            this.labelTitle.Location = new System.Drawing.Point(16, 6);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(213, 16);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "史丹利配件调拨(调出)查询";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(193)))), ((int)(((byte)(226)))));
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.toolStripButtonQuit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 30);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(979, 25);
            this.toolStrip1.TabIndex = 11;
            this.toolStrip1.Text = "toolStrip1";
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
            this.toolStripButtonQuit.Size = new System.Drawing.Size(51, 22);
            this.toolStripButtonQuit.Text = "退出";
            this.toolStripButtonQuit.Click += new System.EventHandler(this.toolStripButtonQuit_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.groupBoxCondition);
            this.panel1.Location = new System.Drawing.Point(12, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(955, 58);
            this.panel1.TabIndex = 12;
            // 
            // groupBoxCondition
            // 
            this.groupBoxCondition.Controls.Add(this.cbWerks);
            this.groupBoxCondition.Controls.Add(this.label6);
            this.groupBoxCondition.Controls.Add(this.buttonSearch);
            this.groupBoxCondition.Controls.Add(this.label5);
            this.groupBoxCondition.Controls.Add(this.textWeighMan);
            this.groupBoxCondition.Controls.Add(this.TimePickerEnd);
            this.groupBoxCondition.Controls.Add(this.TimePickerBegin);
            this.groupBoxCondition.Controls.Add(this.label4);
            this.groupBoxCondition.Controls.Add(this.label3);
            this.groupBoxCondition.Controls.Add(this.label2);
            this.groupBoxCondition.Controls.Add(this.textEbeln);
            this.groupBoxCondition.Controls.Add(this.label1);
            this.groupBoxCondition.Controls.Add(this.textTruckNum);
            this.groupBoxCondition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxCondition.Location = new System.Drawing.Point(0, 0);
            this.groupBoxCondition.Name = "groupBoxCondition";
            this.groupBoxCondition.Size = new System.Drawing.Size(955, 58);
            this.groupBoxCondition.TabIndex = 0;
            this.groupBoxCondition.TabStop = false;
            this.groupBoxCondition.Text = "查询条件";
            // 
            // cbWerks
            // 
            this.cbWerks.AllowDrop = true;
            this.cbWerks.FormattingEnabled = true;
            this.cbWerks.Location = new System.Drawing.Point(45, 23);
            this.cbWerks.Name = "cbWerks";
            this.cbWerks.Size = new System.Drawing.Size(72, 20);
            this.cbWerks.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 12);
            this.label6.TabIndex = 24;
            this.label6.Text = "工厂:";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(866, 20);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 18;
            this.buttonSearch.Text = "查 询";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(411, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 12);
            this.label5.TabIndex = 17;
            this.label5.Text = "司榜员:";
            // 
            // textWeighMan
            // 
            this.textWeighMan.Location = new System.Drawing.Point(462, 23);
            this.textWeighMan.Name = "textWeighMan";
            this.textWeighMan.Size = new System.Drawing.Size(70, 21);
            this.textWeighMan.TabIndex = 16;
            // 
            // TimePickerEnd
            // 
            this.TimePickerEnd.Location = new System.Drawing.Point(746, 22);
            this.TimePickerEnd.Name = "TimePickerEnd";
            this.TimePickerEnd.Size = new System.Drawing.Size(91, 21);
            this.TimePickerEnd.TabIndex = 15;
            this.TimePickerEnd.ValueChanged += new System.EventHandler(this.TimePickerEnd_ValueChanged);
            // 
            // TimePickerBegin
            // 
            this.TimePickerBegin.Location = new System.Drawing.Point(603, 23);
            this.TimePickerBegin.Name = "TimePickerBegin";
            this.TimePickerBegin.Size = new System.Drawing.Size(99, 21);
            this.TimePickerBegin.TabIndex = 14;
            this.TimePickerBegin.ValueChanged += new System.EventHandler(this.TimePickerBegin_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(723, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 12);
            this.label4.TabIndex = 13;
            this.label4.Text = "到";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(538, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 11;
            this.label3.Text = "进厂时间:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(266, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 10;
            this.label2.Text = "调拨单号:";
            // 
            // textEbeln
            // 
            this.textEbeln.Location = new System.Drawing.Point(331, 24);
            this.textEbeln.Name = "textEbeln";
            this.textEbeln.Size = new System.Drawing.Size(78, 21);
            this.textEbeln.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(131, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "车牌号:";
            // 
            // textTruckNum
            // 
            this.textTruckNum.Location = new System.Drawing.Point(180, 23);
            this.textTruckNum.Name = "textTruckNum";
            this.textTruckNum.Size = new System.Drawing.Size(85, 21);
            this.textTruckNum.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.dataGridViewRawReturn);
            this.panel3.Location = new System.Drawing.Point(12, 147);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(955, 335);
            this.panel3.TabIndex = 14;
            // 
            // dataGridViewRawReturn
            // 
            this.dataGridViewRawReturn.AllowUserToAddRows = false;
            this.dataGridViewRawReturn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRawReturn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.VIEW,
            this.RESWK,
            this.TRUCKNUM,
            this.EBELN,
            this.GROSS,
            this.TARE,
            this.DEDUCTNUM,
            this.ENTERWEIGHMAN,
            this.EXITWEIGHMAN,
            this.ENTERTIME,
            this.EXITTIME,
            this.TIMEFLAG,
            this.EXITFLAG});
            this.dataGridViewRawReturn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewRawReturn.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewRawReturn.Name = "dataGridViewRawReturn";
            this.dataGridViewRawReturn.RowTemplate.Height = 23;
            this.dataGridViewRawReturn.Size = new System.Drawing.Size(955, 335);
            this.dataGridViewRawReturn.TabIndex = 11;
            this.dataGridViewRawReturn.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRawReturn_CellContentClick);
            // 
            // VIEW
            // 
            this.VIEW.HeaderText = "查看详细信息";
            this.VIEW.Image = global::DBSolution2.Properties.Resources.修改;
            this.VIEW.Name = "VIEW";
            // 
            // RESWK
            // 
            this.RESWK.DataPropertyName = "RESWK";
            this.RESWK.HeaderText = "工厂";
            this.RESWK.Name = "RESWK";
            // 
            // TRUCKNUM
            // 
            this.TRUCKNUM.DataPropertyName = "TRUCKNUM";
            this.TRUCKNUM.HeaderText = "车牌号";
            this.TRUCKNUM.Name = "TRUCKNUM";
            // 
            // EBELN
            // 
            this.EBELN.DataPropertyName = "EBELN";
            this.EBELN.HeaderText = "调拨单号";
            this.EBELN.Name = "EBELN";
            // 
            // GROSS
            // 
            this.GROSS.DataPropertyName = "GROSS";
            this.GROSS.HeaderText = "毛重";
            this.GROSS.Name = "GROSS";
            // 
            // TARE
            // 
            this.TARE.DataPropertyName = "TARE";
            this.TARE.HeaderText = "皮重";
            this.TARE.Name = "TARE";
            // 
            // DEDUCTNUM
            // 
            this.DEDUCTNUM.DataPropertyName = "DEDUCTNUM";
            this.DEDUCTNUM.HeaderText = "差异";
            this.DEDUCTNUM.Name = "DEDUCTNUM";
            // 
            // ENTERWEIGHMAN
            // 
            this.ENTERWEIGHMAN.DataPropertyName = "ENTERWEIGHMAN";
            this.ENTERWEIGHMAN.HeaderText = "入厂司磅员";
            this.ENTERWEIGHMAN.Name = "ENTERWEIGHMAN";
            // 
            // EXITWEIGHMAN
            // 
            this.EXITWEIGHMAN.DataPropertyName = "EXITWEIGHMAN";
            this.EXITWEIGHMAN.HeaderText = "出厂司磅员";
            this.EXITWEIGHMAN.Name = "EXITWEIGHMAN";
            // 
            // ENTERTIME
            // 
            this.ENTERTIME.DataPropertyName = "ENTERTIME";
            this.ENTERTIME.HeaderText = "进厂时间";
            this.ENTERTIME.Name = "ENTERTIME";
            // 
            // EXITTIME
            // 
            this.EXITTIME.DataPropertyName = "EXITTIME";
            this.EXITTIME.HeaderText = "出厂时间";
            this.EXITTIME.Name = "EXITTIME";
            // 
            // TIMEFLAG
            // 
            this.TIMEFLAG.DataPropertyName = "TIMEFLAG";
            this.TIMEFLAG.HeaderText = "时间标识";
            this.TIMEFLAG.Name = "TIMEFLAG";
            this.TIMEFLAG.Visible = false;
            // 
            // EXITFLAG
            // 
            this.EXITFLAG.DataPropertyName = "EXITFLAG";
            this.EXITFLAG.FalseValue = "0";
            this.EXITFLAG.HeaderText = "空车出厂";
            this.EXITFLAG.Name = "EXITFLAG";
            this.EXITFLAG.ReadOnly = true;
            this.EXITFLAG.TrueValue = "1";
            // 
            // pager
            // 
            this.pager.DataSourceCount = 0;
            this.pager.Dock = System.Windows.Forms.DockStyle.None;
            this.pager.Location = new System.Drawing.Point(12, 119);
            this.pager.Name = "pager";
            this.pager.PageIndex = 1;
            this.pager.PageSize = 0;
            this.pager.Size = new System.Drawing.Size(377, 25);
            this.pager.TabIndex = 15;
            this.pager.Text = "pageNavigator1";
            this.pager.PageChanged += new System.EventHandler(this.pager_PageChanged);
            // 
            // btnOutExcel
            // 
            this.btnOutExcel.Location = new System.Drawing.Point(404, 121);
            this.btnOutExcel.Name = "btnOutExcel";
            this.btnOutExcel.Size = new System.Drawing.Size(75, 23);
            this.btnOutExcel.TabIndex = 20;
            this.btnOutExcel.Text = "导出Excel";
            this.btnOutExcel.UseVisualStyleBackColor = true;
            this.btnOutExcel.Click += new System.EventHandler(this.btnOutExcel_Click);
            // 
            // AccessoryAllotTranferOutSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(979, 494);
            this.Controls.Add(this.btnOutExcel);
            this.Controls.Add(this.pager);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel2);
            this.Name = "AccessoryAllotTranferOutSearch";
            this.Text = "配件调拨(调出)查询";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBoxCondition.ResumeLayout(false);
            this.groupBoxCondition.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRawReturn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButtonQuit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBoxCondition;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textWeighMan;
        private System.Windows.Forms.DateTimePicker TimePickerEnd;
        private System.Windows.Forms.DateTimePicker TimePickerBegin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textEbeln;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textTruckNum;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridViewRawReturn;
        private SdlDB.Utility.PageNavigator pager;
        private System.Windows.Forms.DataGridViewImageColumn VIEW;
        private System.Windows.Forms.DataGridViewTextBoxColumn RESWK;
        private System.Windows.Forms.DataGridViewTextBoxColumn TRUCKNUM;
        private System.Windows.Forms.DataGridViewTextBoxColumn EBELN;
        private System.Windows.Forms.DataGridViewTextBoxColumn GROSS;
        private System.Windows.Forms.DataGridViewTextBoxColumn TARE;
        private System.Windows.Forms.DataGridViewTextBoxColumn DEDUCTNUM;
        private System.Windows.Forms.DataGridViewTextBoxColumn ENTERWEIGHMAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn EXITWEIGHMAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn ENTERTIME;
        private System.Windows.Forms.DataGridViewTextBoxColumn EXITTIME;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIMEFLAG;
        private System.Windows.Forms.DataGridViewCheckBoxColumn EXITFLAG;
        private System.Windows.Forms.ComboBox cbWerks;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnOutExcel;
    }
}