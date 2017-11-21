namespace UnivMng
{
    partial class Classroom
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
            this.Insert = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.classroomnumbertbx = new System.Windows.Forms.TextBox();
            this.seatnumbertbx = new System.Windows.Forms.TextBox();
            this.projectortbx = new System.Windows.Forms.TextBox();
            this.buildingtbx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Insert
            // 
            this.Insert.Location = new System.Drawing.Point(257, 53);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(118, 38);
            this.Insert.TabIndex = 0;
            this.Insert.Text = "Insert";
            this.Insert.UseVisualStyleBackColor = true;
            this.Insert.Click += new System.EventHandler(this.Insert_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(257, 137);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(118, 38);
            this.Cancel.TabIndex = 1;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // classroomnumbertbx
            // 
            this.classroomnumbertbx.Location = new System.Drawing.Point(12, 53);
            this.classroomnumbertbx.Name = "classroomnumbertbx";
            this.classroomnumbertbx.Size = new System.Drawing.Size(196, 20);
            this.classroomnumbertbx.TabIndex = 2;
            // 
            // seatnumbertbx
            // 
            this.seatnumbertbx.Location = new System.Drawing.Point(12, 97);
            this.seatnumbertbx.Name = "seatnumbertbx";
            this.seatnumbertbx.Size = new System.Drawing.Size(196, 20);
            this.seatnumbertbx.TabIndex = 3;
            // 
            // projectortbx
            // 
            this.projectortbx.Location = new System.Drawing.Point(12, 147);
            this.projectortbx.Name = "projectortbx";
            this.projectortbx.Size = new System.Drawing.Size(196, 20);
            this.projectortbx.TabIndex = 4;
            // 
            // buildingtbx
            // 
            this.buildingtbx.Location = new System.Drawing.Point(12, 196);
            this.buildingtbx.Name = "buildingtbx";
            this.buildingtbx.Size = new System.Drawing.Size(196, 20);
            this.buildingtbx.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Classroom number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Seat number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Projector (True Or False)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Building";
            // 
            // Classroom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 290);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buildingtbx);
            this.Controls.Add(this.projectortbx);
            this.Controls.Add(this.seatnumbertbx);
            this.Controls.Add(this.classroomnumbertbx);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Insert);
            this.Name = "Classroom";
            this.Text = "Classroom";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Insert;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.TextBox classroomnumbertbx;
        private System.Windows.Forms.TextBox seatnumbertbx;
        private System.Windows.Forms.TextBox projectortbx;
        private System.Windows.Forms.TextBox buildingtbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}