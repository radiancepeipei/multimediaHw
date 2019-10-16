using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FractualTree
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DomainUpDown.DomainUpDownItemCollection collection = this.domainUpDown1.Items;
            collection.Add("1");
            collection.Add("2");
            collection.Add("3");
            collection.Add("4");
            collection.Add("5");
            collection.Add("6");
            collection.Add("7");
            collection.Add("8");
            collection.Add("9");
            collection.Add("10");

            //set default in DomainUpDown
            this.domainUpDown1.Text = "1";
        }
    }
}
