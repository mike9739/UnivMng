namespace UnivMng
{
    partial class Login
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
            this.usernametbx = new System.Windows.Forms.TextBox();
            this.passwdtbx = new System.Windows.Forms.TextBox();
            this.Username = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Log_in = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.Admincheck = new System.Windows.Forms.CheckBox();
            this.Propiedades = new System.Windows.Forms.CheckBox();
            this.Alumno = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // usernametbx
            // 
            this.usernametbx.Location = new System.Drawing.Point(84, 28);
            this.usernametbx.Name = "usernametbx";
            this.usernametbx.Size = new System.Drawing.Size(222, 20);
            this.usernametbx.TabIndex = 0;
            this.usernametbx.TextChanged += new System.EventHandler(this.usernametbx_TextChanged);
            // 
            // passwdtbx
            // 
            this.passwdtbx.Location = new System.Drawing.Point(84, 57);
            this.passwdtbx.Name = "passwdtbx";
            this.passwdtbx.Size = new System.Drawing.Size(222, 20);
            this.passwdtbx.TabIndex = 1;
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Location = new System.Drawing.Point(12, 28);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(55, 13);
            this.Username.TabIndex = 2;
            this.Username.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Password";
            // 
            // Log_in
            // 
            this.Log_in.Location = new System.Drawing.Point(43, 124);
            this.Log_in.Name = "Log_in";
            this.Log_in.Size = new System.Drawing.Size(103, 32);
            this.Log_in.TabIndex = 4;
            this.Log_in.Text = "Login";
            this.Log_in.UseVisualStyleBackColor = true;
            this.Log_in.Click += new System.EventHandler(this.Log_in_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(177, 124);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(103, 32);
            this.Exit.TabIndex = 5;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Admincheck
            // 
            this.Admincheck.AutoSize = true;
            this.Admincheck.Location = new System.Drawing.Point(43, 92);
            this.Admincheck.Name = "Admincheck";
            this.Admincheck.Size = new System.Drawing.Size(89, 17);
            this.Admincheck.TabIndex = 6;
            this.Admincheck.Text = "Administrador";
            this.Admincheck.UseVisualStyleBackColor = true;
            // 
            // Propiedades
            // 
            this.Propiedades.AutoSize = true;
            this.Propiedades.Location = new System.Drawing.Point(145, 92);
            this.Propiedades.Name = "Propiedades";
            this.Propiedades.Size = new System.Drawing.Size(65, 17);
            this.Propiedades.TabIndex = 7;
            this.Propiedades.Text = "Profesor";
            this.Propiedades.UseVisualStyleBackColor = true;
            // 
            // Alumno
            // 
            this.Alumno.AutoSize = true;
            this.Alumno.Location = new System.Drawing.Point(233, 92);
            this.Alumno.Name = "Alumno";
            this.Alumno.Size = new System.Drawing.Size(61, 17);
            this.Alumno.TabIndex = 8;
            this.Alumno.Text = "Alumno";
            this.Alumno.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 168);
            this.Controls.Add(this.Alumno);
            this.Controls.Add(this.Propiedades);
            this.Controls.Add(this.Admincheck);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Log_in);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.passwdtbx);
            this.Controls.Add(this.usernametbx);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox usernametbx;
        private System.Windows.Forms.TextBox passwdtbx;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Log_in;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.CheckBox Admincheck;
        private System.Windows.Forms.CheckBox Propiedades;
        private System.Windows.Forms.CheckBox Alumno;
    }
}