using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ARRAY
{
    public partial class Array : Form
    {
        public Array()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int storlek = 6;
            int [] minArray = new int[storlek];
            minArray[0] = 1;
            minArray[1] = 2;
            minArray[2] = 3;
            minArray[3] = 4;
            minArray[4] = 5;
            minArray[5] = 6;

            Console.WriteLine(minArray[0] + minArray[1] + minArray[2] + minArray[3] + minArray[4] + minArray[5]);
            

        }
    }
}
