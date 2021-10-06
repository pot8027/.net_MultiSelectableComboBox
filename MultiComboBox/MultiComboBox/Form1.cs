using MultiComboBox.CustomCombo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var aa = new StatusList();
            for (var i = 0; i < 100; i++)
            {
                aa.Add(new Status(i, $"{i}番目"));
            }
            checkBoxComboBox1.SetStatusList(aa);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var aa = checkBoxComboBox1.GetSelectedKeyList();
            textBox1.Text = string.Join(",", aa);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var aa = textBox1.Text.Split(',').Select(r => int.Parse(r)).ToList();
            checkBoxComboBox1.SetSelected(aa);
        }
    }
}
