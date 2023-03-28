using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chain
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var train = new Train();
            train.AddWagon(5, "пасажирський");
            train.AddWagon(3, "грузовий");
            train.AddWagon(10, "Елітні");
            textBox1.Text = train.GetAllWagons();

        }

        private void button2_Click(object sender, EventArgs e)
        {
           // var train = new Train();
            //train.AddWagon(10, "Елітні");


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
