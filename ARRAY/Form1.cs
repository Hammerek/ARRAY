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
            int[] minArray = new int[storlek];
            minArray[0] = 1;
            minArray[1] = 2;
            minArray[2] = 3;
            minArray[3] = 4;
            minArray[4] = 5;
            minArray[5] = 6;

            foreach (int times in minArray)
            {
                Console.Write(times);
            }

            /*
            for (int i = 0; i < minArray.Length; i++)
            {
               Console.WriteLine(minArray[i]);
            }
            */
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int storlek = 6;
            int[] minArray = new int[storlek];
            minArray[0] = 1;
            minArray[1] = 2;
            minArray[2] = 3;
            minArray[3] = 4;
            minArray[4] = 5;
            minArray[5] = 6;

            Console.WriteLine(minArray[0] + minArray[1] + minArray[2] + minArray[3] + minArray[4] + minArray[5]);
        }

        private void button3_Click(object sender, EventArgs e) //need fix
        {
            int storlek = 6;
            int[] nummer = new int[storlek];
            int[] tal = { 1, 2, 3, 4, 5, 6 };

            Console.WriteLine(tal[0]);
        }

        private void button4_Click(object sender, EventArgs e) //need fix
        {

            int[] minArray = new int[] { 1, 2, 3, 4, 5, 6 };
            Console.WriteLine(minArray);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int[] minaTal = new int[52];
            for (int i = 12; i != minaTal.Length; i++)
            {
                minaTal[i] = i + 1;
                listBox1.Items.Add(minaTal[i]);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int[] tal = new int[10];
            label1.Text = "Arrayen har " + tal.Length + " antal positioner.";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int[] tal1 = new int[2];
            tal1[0] = 1;
            tal1[1] = 2;

            for (int i = 0; i < tal1.Length; i++)
            {
                MessageBox.Show(tal1[i].ToString());
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int storlek = 3;
            int[] special = new int[storlek];
            special[0] = 1;
            special[1] = 2;
            special[2] = 3;

            for (int i = 0; i < special.Length; i++)
            {
                MessageBox.Show(special[i].ToString());
            }
        }
    }
}
