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
            //se crea la instancia para desplegar el dialogo de insertar departmaneto
            Insert_department insert_deparment = new Insert_department();
            insert_deparment.ShowDialog();
        }
    }
}
