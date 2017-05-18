using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace artigoUni
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            //var frm = new Login();
            //frm.ShowDialog();
            

            //if (frm.logado)
                //frm.Hide();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            var cadastrar = new Cadastrar();
            cadastrar.Show();
        }
    }
}
