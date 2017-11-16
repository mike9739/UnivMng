namespace UnivMng
{
    partial class Insert_department
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
            this.button1 = new System.Windows.Forms.Button();
            this.Departmenttbx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Insert
            // 
            this.Insert.Location = new System.Drawing.Point(193, 12);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(147, 20);
            this.Insert.TabIndex = 0;
            this.Insert.Text = "Insertar";
            this.Insert.UseVisualStyleBackColor = true;
            this.Insert.Click += new System.EventHandler(this.Insert_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(193, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 20);
            this.button1.TabIndex = 1;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Departmenttbx
            // 
            this.Departmenttbx.Location = new System.Drawing.Point(10, 49);
            this.Departmenttbx.Name = "Departmenttbx";
            this.Departmenttbx.Size = new System.Drawing.Size(172, 20);
            this.Departmenttbx.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre del departamento";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Insert_department
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 99);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Departmenttbx);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Insert);
            this.Name = "Insert_department";
            this.Text = "Insertar Departamento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Insert;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Departmenttbx;
        private System.Windows.Forms.Label label1;
    }
}