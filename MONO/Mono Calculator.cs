﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MONO
{
    public partial class Mono : Form
    {
        public Mono()
        {
            InitializeComponent();
        }

        private void m_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Addition_Button_Click(object sender, EventArgs e)
        {

        }

        private void Subtraction_Button_Click(object sender, EventArgs e)
        {

        }

        private void Multiplication_Button_Click(object sender, EventArgs e)
        {

        }

        private void Division_Button_Click(object sender, EventArgs e)
        {

        }

        private void Equal_Button_Click(object sender, EventArgs e)
        {

        }

        private void Point_Button_Click(object sender, EventArgs e)
        {

        }

        private void Clear_Button_Click(object sender, EventArgs e)
        {

        }

        private void Pi_Button_Click(object sender, EventArgs e)
        {

        }

        private void Text_Output_Screen(object sender, EventArgs e)
        {

        }

        private void NumberButton(object sender, EventArgs e)
        {
            if (Text_Output.Text == "0") 
            {
                Text_Output.Clear();
            }
            Button button = (Button)sender;
            Text_Output.Text = Text_Output.Text + button.Text;

        }
    }
}
