namespace UnivMng
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Insert = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Edit = new System.Windows.Forms.Button();
            this.Print = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.Export = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Department = new System.Windows.Forms.TabPage();
            this.DGVdeparment = new System.Windows.Forms.DataGridView();
            this.department_idDVG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descr_dvg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Professor = new System.Windows.Forms.TabPage();
            this.DGVprof = new System.Windows.Forms.DataGridView();
            this.professor_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.last_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.first_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.department_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Is_administrator = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Courses = new System.Windows.Forms.TabPage();
            this.DGVCourse = new System.Windows.Forms.DataGridView();
            this.course_id_dgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descr_dgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Periods = new System.Windows.Forms.TabPage();
            this.DGVperiods = new System.Windows.Forms.DataGridView();
            this.period_id_dgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descrperiod_dgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.begin_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.end_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeBlocks = new System.Windows.Forms.TabPage();
            this.DGVTimeblocks = new System.Windows.Forms.DataGridView();
            this.time_block_id_dvg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.begin_date_dgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.end_date_dgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descrtb_DGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tuesday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wednesday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thursday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.friday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saturday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Classroom = new System.Windows.Forms.TabPage();
            this.DGVclassroom = new System.Windows.Forms.DataGridView();
            this.classroom_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descr_cr_dgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seat_count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.has_projector = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.building = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Schedule = new System.Windows.Forms.TabPage();
            this.DGVschedule = new System.Windows.Forms.DataGridView();
            this.schedule_gvr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.professor_id_sch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Course_id_sch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.period_id_sch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time_block_id_sch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classroom_id_sch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.Department.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVdeparment)).BeginInit();
            this.Professor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVprof)).BeginInit();
            this.Courses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCourse)).BeginInit();
            this.Periods.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVperiods)).BeginInit();
            this.TimeBlocks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVTimeblocks)).BeginInit();
            this.Classroom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVclassroom)).BeginInit();
            this.Schedule.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVschedule)).BeginInit();
            this.SuspendLayout();
            // 
            // Insert
            // 
            this.Insert.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Insert.BackgroundImage")));
            this.Insert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Insert.Image = ((System.Drawing.Image)(resources.GetObject("Insert.Image")));
            this.Insert.Location = new System.Drawing.Point(63, 12);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(67, 62);
            this.Insert.TabIndex = 5;
            this.Insert.Text = "Insertar";
            this.Insert.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Insert.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Insert.UseVisualStyleBackColor = true;
            this.Insert.Click += new System.EventHandler(this.Insert_Click);
            // 
            // Delete
            // 
            this.Delete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Delete.BackgroundImage")));
            this.Delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Delete.Location = new System.Drawing.Point(136, 12);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(67, 62);
            this.Delete.TabIndex = 6;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            // 
            // Edit
            // 
            this.Edit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Edit.BackgroundImage")));
            this.Edit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Edit.Location = new System.Drawing.Point(209, 12);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(67, 62);
            this.Edit.TabIndex = 7;
            this.Edit.Text = "Edit";
            this.Edit.UseVisualStyleBackColor = true;
            // 
            // Print
            // 
            this.Print.BackColor = System.Drawing.Color.Silver;
            this.Print.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Print.BackgroundImage")));
            this.Print.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Print.Location = new System.Drawing.Point(556, 12);
            this.Print.Name = "Print";
            this.Print.Size = new System.Drawing.Size(67, 62);
            this.Print.TabIndex = 8;
            this.Print.Text = "Print";
            this.Print.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5.BackgroundImage")));
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.Location = new System.Drawing.Point(629, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(67, 62);
            this.button5.TabIndex = 10;
            this.button5.Text = "Copy";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // Export
            // 
            this.Export.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Export.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Export.BackgroundImage")));
            this.Export.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Export.Location = new System.Drawing.Point(483, 12);
            this.Export.Name = "Export";
            this.Export.Size = new System.Drawing.Size(67, 62);
            this.Export.TabIndex = 9;
            this.Export.Text = "Excel";
            this.Export.UseVisualStyleBackColor = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Department);
            this.tabControl1.Controls.Add(this.Professor);
            this.tabControl1.Controls.Add(this.Courses);
            this.tabControl1.Controls.Add(this.Periods);
            this.tabControl1.Controls.Add(this.TimeBlocks);
            this.tabControl1.Controls.Add(this.Classroom);
            this.tabControl1.Controls.Add(this.Schedule);
            this.tabControl1.Location = new System.Drawing.Point(47, 92);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(669, 295);
            this.tabControl1.TabIndex = 11;
            // 
            // Department
            // 
            this.Department.Controls.Add(this.DGVdeparment);
            this.Department.Location = new System.Drawing.Point(4, 22);
            this.Department.Name = "Department";
            this.Department.Padding = new System.Windows.Forms.Padding(3);
            this.Department.Size = new System.Drawing.Size(661, 269);
            this.Department.TabIndex = 0;
            this.Department.Text = "Department";
            this.Department.UseVisualStyleBackColor = true;
            // 
            // DGVdeparment
            // 
            this.DGVdeparment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVdeparment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.department_idDVG,
            this.descr_dvg});
            this.DGVdeparment.Location = new System.Drawing.Point(-1, -3);
            this.DGVdeparment.Name = "DGVdeparment";
            this.DGVdeparment.Size = new System.Drawing.Size(666, 276);
            this.DGVdeparment.TabIndex = 19;
            // 
            // department_idDVG
            // 
            this.department_idDVG.HeaderText = "Department_id";
            this.department_idDVG.Name = "department_idDVG";
            // 
            // descr_dvg
            // 
            this.descr_dvg.HeaderText = "Descr";
            this.descr_dvg.Name = "descr_dvg";
            // 
            // Professor
            // 
            this.Professor.Controls.Add(this.DGVprof);
            this.Professor.Location = new System.Drawing.Point(4, 22);
            this.Professor.Name = "Professor";
            this.Professor.Padding = new System.Windows.Forms.Padding(3);
            this.Professor.Size = new System.Drawing.Size(661, 269);
            this.Professor.TabIndex = 1;
            this.Professor.Text = "Professor";
            this.Professor.UseVisualStyleBackColor = true;
            // 
            // DGVprof
            // 
            this.DGVprof.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVprof.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.professor_id,
            this.last_name,
            this.first_name,
            this.department_id,
            this.username,
            this.password,
            this.Is_administrator});
            this.DGVprof.Location = new System.Drawing.Point(-3, -4);
            this.DGVprof.Name = "DGVprof";
            this.DGVprof.Size = new System.Drawing.Size(666, 276);
            this.DGVprof.TabIndex = 14;
            // 
            // professor_id
            // 
            this.professor_id.HeaderText = "Professor Id";
            this.professor_id.Name = "professor_id";
            // 
            // last_name
            // 
            this.last_name.HeaderText = "Lastname";
            this.last_name.Name = "last_name";
            // 
            // first_name
            // 
            this.first_name.HeaderText = "Firstname";
            this.first_name.Name = "first_name";
            // 
            // department_id
            // 
            this.department_id.HeaderText = "Department id";
            this.department_id.Name = "department_id";
            // 
            // username
            // 
            this.username.HeaderText = "Username";
            this.username.Name = "username";
            this.username.Visible = false;
            // 
            // password
            // 
            this.password.HeaderText = "password";
            this.password.Name = "password";
            this.password.Visible = false;
            // 
            // Is_administrator
            // 
            this.Is_administrator.HeaderText = "Administrador";
            this.Is_administrator.Name = "Is_administrator";
            // 
            // Courses
            // 
            this.Courses.Controls.Add(this.DGVCourse);
            this.Courses.Location = new System.Drawing.Point(4, 22);
            this.Courses.Name = "Courses";
            this.Courses.Size = new System.Drawing.Size(661, 269);
            this.Courses.TabIndex = 2;
            this.Courses.Text = "Courses";
            this.Courses.UseVisualStyleBackColor = true;
            // 
            // DGVCourse
            // 
            this.DGVCourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVCourse.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.course_id_dgv,
            this.code,
            this.descr_dgv});
            this.DGVCourse.Location = new System.Drawing.Point(0, 0);
            this.DGVCourse.Name = "DGVCourse";
            this.DGVCourse.Size = new System.Drawing.Size(665, 273);
            this.DGVCourse.TabIndex = 14;
            // 
            // course_id_dgv
            // 
            this.course_id_dgv.HeaderText = "Course id";
            this.course_id_dgv.Name = "course_id_dgv";
            // 
            // code
            // 
            this.code.HeaderText = "Code";
            this.code.Name = "code";
            // 
            // descr_dgv
            // 
            this.descr_dgv.HeaderText = "Description";
            this.descr_dgv.Name = "descr_dgv";
            // 
            // Periods
            // 
            this.Periods.Controls.Add(this.DGVperiods);
            this.Periods.Location = new System.Drawing.Point(4, 22);
            this.Periods.Name = "Periods";
            this.Periods.Size = new System.Drawing.Size(661, 269);
            this.Periods.TabIndex = 3;
            this.Periods.Text = "Periods";
            this.Periods.UseVisualStyleBackColor = true;
            // 
            // DGVperiods
            // 
            this.DGVperiods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVperiods.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.period_id_dgv,
            this.descrperiod_dgv,
            this.begin_date,
            this.end_date});
            this.DGVperiods.Location = new System.Drawing.Point(-4, 0);
            this.DGVperiods.Name = "DGVperiods";
            this.DGVperiods.Size = new System.Drawing.Size(662, 266);
            this.DGVperiods.TabIndex = 15;
            // 
            // period_id_dgv
            // 
            this.period_id_dgv.HeaderText = "Period id";
            this.period_id_dgv.Name = "period_id_dgv";
            // 
            // descrperiod_dgv
            // 
            this.descrperiod_dgv.HeaderText = "Description";
            this.descrperiod_dgv.Name = "descrperiod_dgv";
            // 
            // begin_date
            // 
            this.begin_date.HeaderText = "Begin date";
            this.begin_date.Name = "begin_date";
            // 
            // end_date
            // 
            this.end_date.HeaderText = "End date";
            this.end_date.Name = "end_date";
            // 
            // TimeBlocks
            // 
            this.TimeBlocks.Controls.Add(this.DGVTimeblocks);
            this.TimeBlocks.Location = new System.Drawing.Point(4, 22);
            this.TimeBlocks.Name = "TimeBlocks";
            this.TimeBlocks.Size = new System.Drawing.Size(661, 269);
            this.TimeBlocks.TabIndex = 4;
            this.TimeBlocks.Text = "TimeBlocks";
            this.TimeBlocks.UseVisualStyleBackColor = true;
            // 
            // DGVTimeblocks
            // 
            this.DGVTimeblocks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVTimeblocks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.time_block_id_dvg,
            this.begin_date_dgv,
            this.end_date_dgv,
            this.descrtb_DGV,
            this.moday,
            this.tuesday,
            this.wednesday,
            this.thursday,
            this.friday,
            this.saturday});
            this.DGVTimeblocks.Location = new System.Drawing.Point(-4, 0);
            this.DGVTimeblocks.Name = "DGVTimeblocks";
            this.DGVTimeblocks.Size = new System.Drawing.Size(666, 269);
            this.DGVTimeblocks.TabIndex = 17;
            // 
            // time_block_id_dvg
            // 
            this.time_block_id_dvg.HeaderText = "Time Block id";
            this.time_block_id_dvg.Name = "time_block_id_dvg";
            // 
            // begin_date_dgv
            // 
            this.begin_date_dgv.HeaderText = "Begin date";
            this.begin_date_dgv.Name = "begin_date_dgv";
            // 
            // end_date_dgv
            // 
            this.end_date_dgv.HeaderText = "End date";
            this.end_date_dgv.Name = "end_date_dgv";
            // 
            // descrtb_DGV
            // 
            this.descrtb_DGV.HeaderText = "Description";
            this.descrtb_DGV.Name = "descrtb_DGV";
            // 
            // moday
            // 
            this.moday.HeaderText = "Monday";
            this.moday.Name = "moday";
            // 
            // tuesday
            // 
            this.tuesday.HeaderText = "Tuesday";
            this.tuesday.Name = "tuesday";
            // 
            // wednesday
            // 
            this.wednesday.HeaderText = "Wednesday";
            this.wednesday.Name = "wednesday";
            // 
            // thursday
            // 
            this.thursday.HeaderText = "Thursday";
            this.thursday.Name = "thursday";
            // 
            // friday
            // 
            this.friday.HeaderText = "Friday";
            this.friday.Name = "friday";
            // 
            // saturday
            // 
            this.saturday.HeaderText = "Saturday";
            this.saturday.Name = "saturday";
            // 
            // Classroom
            // 
            this.Classroom.Controls.Add(this.DGVclassroom);
            this.Classroom.Location = new System.Drawing.Point(4, 22);
            this.Classroom.Name = "Classroom";
            this.Classroom.Size = new System.Drawing.Size(661, 269);
            this.Classroom.TabIndex = 5;
            this.Classroom.Text = "Classroom";
            this.Classroom.UseVisualStyleBackColor = true;
            // 
            // DGVclassroom
            // 
            this.DGVclassroom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVclassroom.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.classroom_id,
            this.descr_cr_dgv,
            this.seat_count,
            this.has_projector,
            this.building});
            this.DGVclassroom.Location = new System.Drawing.Point(-3, -4);
            this.DGVclassroom.Name = "DGVclassroom";
            this.DGVclassroom.Size = new System.Drawing.Size(666, 276);
            this.DGVclassroom.TabIndex = 18;
            // 
            // classroom_id
            // 
            this.classroom_id.HeaderText = "Classroom id";
            this.classroom_id.Name = "classroom_id";
            // 
            // descr_cr_dgv
            // 
            this.descr_cr_dgv.HeaderText = "Description";
            this.descr_cr_dgv.Name = "descr_cr_dgv";
            // 
            // seat_count
            // 
            this.seat_count.HeaderText = "Seat Count";
            this.seat_count.Name = "seat_count";
            // 
            // has_projector
            // 
            this.has_projector.HeaderText = "Projector";
            this.has_projector.Name = "has_projector";
            // 
            // building
            // 
            this.building.HeaderText = "Building";
            this.building.Name = "building";
            // 
            // Schedule
            // 
            this.Schedule.Controls.Add(this.DGVschedule);
            this.Schedule.Location = new System.Drawing.Point(4, 22);
            this.Schedule.Name = "Schedule";
            this.Schedule.Size = new System.Drawing.Size(661, 269);
            this.Schedule.TabIndex = 6;
            this.Schedule.Text = "Schedule";
            this.Schedule.UseVisualStyleBackColor = true;
            // 
            // DGVschedule
            // 
            this.DGVschedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVschedule.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.schedule_gvr,
            this.professor_id_sch,
            this.Course_id_sch,
            this.period_id_sch,
            this.time_block_id_sch,
            this.classroom_id_sch});
            this.DGVschedule.Location = new System.Drawing.Point(3, 0);
            this.DGVschedule.Name = "DGVschedule";
            this.DGVschedule.Size = new System.Drawing.Size(655, 266);
            this.DGVschedule.TabIndex = 19;
            // 
            // schedule_gvr
            // 
            this.schedule_gvr.HeaderText = "Schedule";
            this.schedule_gvr.Name = "schedule_gvr";
            // 
            // professor_id_sch
            // 
            this.professor_id_sch.HeaderText = "Professor ID";
            this.professor_id_sch.Name = "professor_id_sch";
            // 
            // Course_id_sch
            // 
            this.Course_id_sch.HeaderText = "Course ID";
            this.Course_id_sch.Name = "Course_id_sch";
            // 
            // period_id_sch
            // 
            this.period_id_sch.HeaderText = "Period";
            this.period_id_sch.Name = "period_id_sch";
            // 
            // time_block_id_sch
            // 
            this.time_block_id_sch.HeaderText = "Timbe Block ID";
            this.time_block_id_sch.Name = "time_block_id_sch";
            // 
            // classroom_id_sch
            // 
            this.classroom_id_sch.HeaderText = "Classroom ID";
            this.classroom_id_sch.Name = "classroom_id_sch";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 427);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.Export);
            this.Controls.Add(this.Print);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Insert);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.Department.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVdeparment)).EndInit();
            this.Professor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVprof)).EndInit();
            this.Courses.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVCourse)).EndInit();
            this.Periods.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVperiods)).EndInit();
            this.TimeBlocks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVTimeblocks)).EndInit();
            this.Classroom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVclassroom)).EndInit();
            this.Schedule.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVschedule)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Insert;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.Button Print;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button Export;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Department;
        private System.Windows.Forms.TabPage Professor;
        private System.Windows.Forms.TabPage Courses;
        private System.Windows.Forms.TabPage Periods;
        private System.Windows.Forms.TabPage TimeBlocks;
        private System.Windows.Forms.TabPage Classroom;
        private System.Windows.Forms.TabPage Schedule;
        private System.Windows.Forms.DataGridView DGVCourse;
        private System.Windows.Forms.DataGridView DGVperiods;
        private System.Windows.Forms.DataGridViewTextBoxColumn course_id_dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn code;
        private System.Windows.Forms.DataGridViewTextBoxColumn descr_dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn period_id_dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn descrperiod_dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn begin_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn end_date;
        private System.Windows.Forms.DataGridView DGVdeparment;
        private System.Windows.Forms.DataGridViewTextBoxColumn department_idDVG;
        private System.Windows.Forms.DataGridViewTextBoxColumn descr_dvg;
        private System.Windows.Forms.DataGridView DGVprof;
        private System.Windows.Forms.DataGridViewTextBoxColumn professor_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn last_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn first_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn department_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
        private System.Windows.Forms.DataGridViewTextBoxColumn password;
        private System.Windows.Forms.DataGridViewTextBoxColumn Is_administrator;
        private System.Windows.Forms.DataGridView DGVTimeblocks;
        private System.Windows.Forms.DataGridViewTextBoxColumn time_block_id_dvg;
        private System.Windows.Forms.DataGridViewTextBoxColumn begin_date_dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn end_date_dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn descrtb_DGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn moday;
        private System.Windows.Forms.DataGridViewTextBoxColumn tuesday;
        private System.Windows.Forms.DataGridViewTextBoxColumn wednesday;
        private System.Windows.Forms.DataGridViewTextBoxColumn thursday;
        private System.Windows.Forms.DataGridViewTextBoxColumn friday;
        private System.Windows.Forms.DataGridViewTextBoxColumn saturday;
        private System.Windows.Forms.DataGridView DGVclassroom;
        private System.Windows.Forms.DataGridViewTextBoxColumn classroom_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn descr_cr_dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn seat_count;
        private System.Windows.Forms.DataGridViewTextBoxColumn has_projector;
        private System.Windows.Forms.DataGridViewTextBoxColumn building;
        private System.Windows.Forms.DataGridView DGVschedule;
        private System.Windows.Forms.DataGridViewTextBoxColumn schedule_gvr;
        private System.Windows.Forms.DataGridViewTextBoxColumn professor_id_sch;
        private System.Windows.Forms.DataGridViewTextBoxColumn Course_id_sch;
        private System.Windows.Forms.DataGridViewTextBoxColumn period_id_sch;
        private System.Windows.Forms.DataGridViewTextBoxColumn time_block_id_sch;
        private System.Windows.Forms.DataGridViewTextBoxColumn classroom_id_sch;
    }
}

