using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hw_wf_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.MouseClick += Form1_MouseClick;
            this.MouseMove += Form1_MouseMove;
        }


        private void WhatTheNumber(object sender, EventArgs e)
        {
            DialogResult result;

            int numDialog = 1;
            while (true)
            {
                result = MessageBox.Show($"{new Random().Next(1, 2000)}", "Вы загадали число", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    MessageBox.Show($"Количество запросов {numDialog}", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    numDialog = 0;
                    result = MessageBox.Show($"Хотите продолжить?", "Выход", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.No) this.Close();
                }
                numDialog++;

            }
        }
        private void showRezum(object sender, EventArgs e)
        {
            string[] array =
            { 
                "Студент: Муслимов Денис",
                "Предмет: Windows Forms",
                "Группа: /РПО/2023/" 
            };
            int numSymbol = 0;
            string caption;

            for (int i = 0; i < array.Length; i++)
            {
                numSymbol += array[i].Length;
                caption = (array.Length - 1 == i) ? $"MessageBox {i + 1}. Среднее число символов - {numSymbol / array.Length}" : $"MessageBox {i + 1}";
                MessageBox.Show(array[i], caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button==MouseButtons.Left)
            {
                if (ModifierKeys == Keys.Control)
                {
                    Close();
                }

                if (e.X<400||e.X>810||e.Y>440||e.Y<10)
                {
                    MessageBox.Show("Клик за пределами границы!");
                }
                else if(e.X == 420 && e.Y <= 420 || e.X <= 420 && e.Y == 420)
                {
                    MessageBox.Show("Клик на границе!");
                }
                else if(e.X<400&&e.Y<400)
                {
                    MessageBox.Show("Клик внутри границ!");
                }
            }

        }
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            Text = $"X {e.X} - Y {e.Y}";
        }
        private void button1_Click(object sender, EventArgs e)
        {
             showRezum(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WhatTheNumber(sender, e);
        }

    }
}
