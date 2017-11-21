namespace UnivMng
{
    partial class insert_timeblock
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
            this.cb_monday = new System.Windows.Forms.CheckBox();
            this.cb_tuesday = new System.Windows.Forms.CheckBox();
            this.cb_wednesday = new System.Windows.Forms.CheckBox();
            this.cb_friday = new System.Windows.Forms.CheckBox();
            this.cb_thursday = new System.Windows.Forms.CheckBox();
            this.cb_saturday = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DTP_enddate = new System.Windows.Forms.DateTimePicker();
            this.DTP_Begindate = new System.Windows.Forms.DateTimePicker();
            this.tbx_descr = new System.Windows.Forms.TextBox();
            this.tbx_time_block_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Ok = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cb_monday
            // 
            this.cb_monday.AutoSize = true;
            this.cb_monday.Location = new System.Drawing.Point(18, 31);
            this.cb_monday.Name = "cb_monday";
            this.cb_monday.Size = new System.Drawing.Size(64, 17);
            this.cb_monday.TabIndex = 0;
            this.cb_monday.Text = "Monday";
            this.cb_monday.UseVisualStyleBackColor = true;
            // 
            // cb_tuesday
            // 
            this.cb_tuesday.AutoSize = true;
            this.cb_tuesday.Location = new System.Drawing.Point(18, 54);
            this.cb_tuesday.Name = "cb_tuesday";
            this.cb_tuesday.Size = new System.Drawing.Size(67, 17);
            this.cb_tuesday.TabIndex = 1;
            this.cb_tuesday.Text = "Tuesday";
            this.cb_tuesday.UseVisualStyleBackColor = true;
            this.cb_tuesday.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // cb_wednesday
            // 
            this.cb_wednesday.AutoSize = true;
            this.cb_wednesday.Location = new System.Drawing.Point(18, 77);
            this.cb_wednesday.Name = "cb_wednesday";
            this.cb_wednesday.Size = new System.Drawing.Size(83, 17);
            this.cb_wednesday.TabIndex = 2;
            this.cb_wednesday.Text = "Wednesday";
            this.cb_wednesday.UseVisualStyleBackColor = true;
            // 
            // cb_friday
            // 
            this.cb_friday.AutoSize = true;
            this.cb_friday.Location = new System.Drawing.Point(104, 54);
            this.cb_friday.Name = "cb_friday";
            this.cb_friday.Size = new System.Drawing.Size(54, 17);
            this.cb_friday.TabIndex = 3;
            this.cb_friday.Text = "Friday";
            this.cb_friday.UseVisualStyleBackColor = true;
            // 
            // cb_thursday
            // 
            this.cb_thursday.AutoSize = true;
            this.cb_thursday.Location = new System.Drawing.Point(104, 31);
            this.cb_thursday.Name = "cb_thursday";
            this.cb_thursday.Size = new System.Drawing.Size(76, 17);
            this.cb_thursday.TabIndex = 4;
            this.cb_thursday.Text = "Thuersday";
            this.cb_thursday.UseVisualStyleBackColor = true;
            // 
            // cb_saturday
            // 
            this.cb_saturday.AutoSize = true;
            this.cb_saturday.Location = new System.Drawing.Point(104, 77);
            this.cb_saturday.Name = "cb_saturday";
            this.cb_saturday.Size = new System.Drawing.Size(68, 17);
            this.cb_saturday.TabIndex = 5;
            this.cb_saturday.Text = "Saturday";
            this.cb_saturday.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_saturday);
            this.groupBox1.Controls.Add(this.cb_thursday);
            this.groupBox1.Controls.Add(this.cb_friday);
            this.groupBox1.Controls.Add(this.cb_wednesday);
            this.groupBox1.Controls.Add(this.cb_tuesday);
            this.groupBox1.Controls.Add(this.cb_monday);
            this.groupBox1.Location = new System.Drawing.Point(12, 155);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 97);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Days";
            // 
            // DTP_enddate
            // 
            this.DTP_enddate.Location = new System.Drawing.Point(92, 110);
            this.DTP_enddate.Name = "DTP_enddate";
            this.DTP_enddate.Size = new System.Drawing.Size(198, 20);
            this.DTP_enddate.TabIndex = 7;
            // 
            // DTP_Begindate
            // 
            this.DTP_Begindate.Location = new System.Drawing.Point(92, 84);
            this.DTP_Begindate.Name = "DTP_Begindate";
            this.DTP_Begindate.Size = new System.Drawing.Size(198, 20);
            this.DTP_Begindate.TabIndex = 8;
            // 
            // tbx_descr
            // 
            this.tbx_descr.Location = new System.Drawing.Point(92, 58);
            this.tbx_descr.Name = "tbx_descr";
            this.tbx_descr.Size = new System.Drawing.Size(197, 20);
            this.tbx_descr.TabIndex = 9;
            // 
            // tbx_time_block_id
            // 
            this.tbx_time_block_id.Location = new System.Drawing.Point(92, 32);
            this.tbx_time_block_id.Name = "tbx_time_block_id";
            this.tbx_time_block_id.Size = new System.Drawing.Size(197, 20);
            this.tbx_time_block_id.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Time Block ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Description:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Begin date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "End date:";
            // 
            // Ok
            // 
            this.Ok.Location = new System.Drawing.Point(242, 166);
            this.Ok.Name = "Ok";
            this.Ok.Size = new System.Drawing.Size(100, 34);
            this.Ok.TabIndex = 15;
            this.Ok.Text = "OK";
            this.Ok.UseVisualStyleBackColor = true;
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(242, 209);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(100, 30);
            this.cancel.TabIndex = 16;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // insert_timeblock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 264);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.Ok);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbx_time_block_id);
            this.Controls.Add(this.tbx_descr);
            this.Controls.Add(this.DTP_Begindate);
            this.Controls.Add(this.DTP_enddate);
            this.Controls.Add(this.groupBox1);
            this.Name = "insert_timeblock";
            this.Text = "Insert Time Block";
            this.Load += new System.EventHandler(this.insert_timeblock_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cb_monday;
        private System.Windows.Forms.CheckBox cb_tuesday;
        private System.Windows.Forms.CheckBox cb_wednesday;
        private System.Windows.Forms.CheckBox cb_friday;
        private System.Windows.Forms.CheckBox cb_thursday;
        private System.Windows.Forms.CheckBox cb_saturday;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker DTP_enddate;
        private System.Windows.Forms.DateTimePicker DTP_Begindate;
        private System.Windows.Forms.TextBox tbx_descr;
        private System.Windows.Forms.TextBox tbx_time_block_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Ok;
        private System.Windows.Forms.Button cancel;
    }
}