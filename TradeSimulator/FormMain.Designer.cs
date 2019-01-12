namespace TradeSimulator
{
    partial class FormMain
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.buttonDo = new System.Windows.Forms.Button();
            this.groupBoxEntry = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBoxExit = new System.Windows.Forms.GroupBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.groupBoxStop = new System.Windows.Forms.GroupBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.groupBoxFilter = new System.Windows.Forms.GroupBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBoxAllDate = new System.Windows.Forms.CheckBox();
            this.groupBoxEntry.SuspendLayout();
            this.groupBoxExit.SuspendLayout();
            this.groupBoxStop.SuspendLayout();
            this.groupBoxFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(198, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "To";
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.Location = new System.Drawing.Point(47, 26);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(145, 19);
            this.dateTimePickerFrom.TabIndex = 4;
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.Location = new System.Drawing.Point(222, 26);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(145, 19);
            this.dateTimePickerTo.TabIndex = 5;
            // 
            // buttonDo
            // 
            this.buttonDo.Location = new System.Drawing.Point(395, 24);
            this.buttonDo.Name = "buttonDo";
            this.buttonDo.Size = new System.Drawing.Size(75, 23);
            this.buttonDo.TabIndex = 6;
            this.buttonDo.Text = "実行";
            this.buttonDo.UseVisualStyleBackColor = true;
            this.buttonDo.Click += new System.EventHandler(this.buttonDo_Click);
            // 
            // groupBoxEntry
            // 
            this.groupBoxEntry.Controls.Add(this.checkBox1);
            this.groupBoxEntry.Location = new System.Drawing.Point(12, 53);
            this.groupBoxEntry.Name = "groupBoxEntry";
            this.groupBoxEntry.Size = new System.Drawing.Size(460, 50);
            this.groupBoxEntry.TabIndex = 7;
            this.groupBoxEntry.TabStop = false;
            this.groupBoxEntry.Text = "Entry";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(6, 18);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 16);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // groupBoxExit
            // 
            this.groupBoxExit.Controls.Add(this.checkBox2);
            this.groupBoxExit.Location = new System.Drawing.Point(14, 109);
            this.groupBoxExit.Name = "groupBoxExit";
            this.groupBoxExit.Size = new System.Drawing.Size(460, 50);
            this.groupBoxExit.TabIndex = 8;
            this.groupBoxExit.TabStop = false;
            this.groupBoxExit.Text = "Exit";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(6, 18);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(80, 16);
            this.checkBox2.TabIndex = 0;
            this.checkBox2.Text = "checkBox2";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // groupBoxStop
            // 
            this.groupBoxStop.Controls.Add(this.checkBox3);
            this.groupBoxStop.Location = new System.Drawing.Point(12, 165);
            this.groupBoxStop.Name = "groupBoxStop";
            this.groupBoxStop.Size = new System.Drawing.Size(460, 50);
            this.groupBoxStop.TabIndex = 8;
            this.groupBoxStop.TabStop = false;
            this.groupBoxStop.Text = "Stop";
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(6, 18);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(80, 16);
            this.checkBox3.TabIndex = 0;
            this.checkBox3.Text = "checkBox3";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // groupBoxFilter
            // 
            this.groupBoxFilter.Controls.Add(this.checkBox4);
            this.groupBoxFilter.Location = new System.Drawing.Point(12, 221);
            this.groupBoxFilter.Name = "groupBoxFilter";
            this.groupBoxFilter.Size = new System.Drawing.Size(460, 50);
            this.groupBoxFilter.TabIndex = 8;
            this.groupBoxFilter.TabStop = false;
            this.groupBoxFilter.Text = "Filter";
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(6, 18);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(80, 16);
            this.checkBox4.TabIndex = 0;
            this.checkBox4.Text = "checkBox4";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBoxAllDate
            // 
            this.checkBoxAllDate.AutoSize = true;
            this.checkBoxAllDate.Checked = true;
            this.checkBoxAllDate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAllDate.Location = new System.Drawing.Point(12, 10);
            this.checkBoxAllDate.Name = "checkBoxAllDate";
            this.checkBoxAllDate.Size = new System.Drawing.Size(131, 16);
            this.checkBoxAllDate.TabIndex = 1;
            this.checkBoxAllDate.Text = "全ての日付を使用する";
            this.checkBoxAllDate.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 450);
            this.Controls.Add(this.checkBoxAllDate);
            this.Controls.Add(this.groupBoxFilter);
            this.Controls.Add(this.groupBoxStop);
            this.Controls.Add(this.groupBoxExit);
            this.Controls.Add(this.groupBoxEntry);
            this.Controls.Add(this.buttonDo);
            this.Controls.Add(this.dateTimePickerTo);
            this.Controls.Add(this.dateTimePickerFrom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.groupBoxEntry.ResumeLayout(false);
            this.groupBoxEntry.PerformLayout();
            this.groupBoxExit.ResumeLayout(false);
            this.groupBoxExit.PerformLayout();
            this.groupBoxStop.ResumeLayout(false);
            this.groupBoxStop.PerformLayout();
            this.groupBoxFilter.ResumeLayout(false);
            this.groupBoxFilter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
        private System.Windows.Forms.DateTimePicker dateTimePickerTo;
        private System.Windows.Forms.Button buttonDo;
        private System.Windows.Forms.GroupBox groupBoxEntry;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox groupBoxExit;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.GroupBox groupBoxStop;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.GroupBox groupBoxFilter;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBoxAllDate;
    }
}

