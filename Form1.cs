using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sorting_algorithm
{
    public partial class Form1 : Form
    {
        Random R_ran = new Random();
        int number = 0;
        int[] ai_sorting_list;
        int list_count = 10;
        string display_list = null;
        int check1 = 0;
        int check2 = 0;
        int total_sorted = 0;
        int total_comparosins = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_random_list_Click(object sender, EventArgs e)
        {
            ai_sorting_list = new int[list_count];
            for (int count = 1; count <= list_count; count ++)
            {
                startpoint:
                number = R_ran.Next(0, list_count);
                if (ai_sorting_list[number] == 0)
                {
                    ai_sorting_list[number] = count;
                }
                else { goto startpoint; }
            }
            display();
        }
        private void display()
        {
            display_list = null;
            for (int count = 1; count <= list_count; count++)
            {
                display_list += Convert.ToString(ai_sorting_list[count - 1]) + Environment.NewLine;
            }
            lb_list.Text = display_list;

        }

        private void btn_bubble_sort_Click(object sender, EventArgs e)
        {
            check1 = 0;
            check2 = 0;
            total_sorted = 0;
            total_comparosins = 0;
            Start:
            for (int comparisons = 0; comparisons <= list_count - total_sorted - 2; comparisons++)
            {
                check1 = ai_sorting_list[comparisons];
                check2 = ai_sorting_list[comparisons + 1];

                if (check1 > check2)
                {
                    ai_sorting_list[comparisons] = check2;
                    ai_sorting_list[comparisons + 1] = check1;
                }
                total_comparosins += 1;
            }
            total_sorted += 1;
            if (total_sorted != 9) { goto Start; }
            else { display(); }
        }
    }
}
