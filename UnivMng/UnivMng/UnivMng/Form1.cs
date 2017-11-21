using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnivMng
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
            
               


        }

        private void Insert_Click(object sender, EventArgs e)
        {
            //se se
            if (tabControl1.SelectedTab == Department)
            {
                Insert_department insert_deparment = new Insert_department();
                insert_deparment.ShowDialog();
            }
            else if (tabControl1.SelectedTab == Professor)
            {
                insert_professor insert_Professor = new insert_professor();
                insert_Professor.ShowDialog();
            }
            else if (tabControl1.SelectedTab == Courses)
            {
                insertcourse insertcourse = new insertcourse();
                insertcourse.ShowDialog();
            }
            else if (tabControl1.SelectedTab == Periods)
            {
                Insert_periods insert_Periods = new Insert_periods();
                insert_Periods.ShowDialog();

            }
            else if (tabControl1.SelectedTab == TimeBlocks)
            {
                insert_timeblock insert_Timeblock = new insert_timeblock();
                insert_Timeblock.ShowDialog();

            }
            else if (tabControl1.SelectedTab == Classroom)
            {

            }
       
    
               
            
                   
        }

        
       
        private void filldataview()
        {

        }

        private void DGVschedule_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
