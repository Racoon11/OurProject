using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using sweets;

namespace PresentWindow
{
    public partial class Form1 : Form
    {
        NYPresent present = PresentFactory.CreatePresent();
        public Form1()
        {
            InitializeComponent();
            
            showPresent(listBox, present, totalWeight, caloriesLabel);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (Form2.am >= 1)
            {
                return;
            }
            Form f = new Form2(present, listBox, totalWeight, caloriesLabel);
            f.Show();
        }
        static public void showPresent(ListBox listBox, NYPresent present, Label totalWeight, Label caloriesLabel)
        {
            listBox.Items.Clear();
            for (int i = 0; i<present.GetNumber(); i++)
            {
                WrappedSweet sw = present.GetSweet(i);
                listBox.Items.Add(sw.GetName());
            }
            totalWeight.Text = Counter.CountWeight(present).ToString();
            caloriesLabel.Text = Counter.CountCalories(present).ToString();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            int ind = listBox.SelectedIndex;
            WrappedSweet sw = present.GetSweet(ind);
            if (Form2.am >= 1)
            {
                return;
            }
            Form2 f = new Form2(present, listBox, totalWeight, caloriesLabel);
            f.Show();
            f.make_panel2_Visible(sw.GetWeight(), sw.GetCalories(), false, "None", sw.GetName(), ind);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            int ind = listBox.SelectedIndex;
            present.DeleteSweet(ind);
            showPresent(listBox, present, totalWeight, caloriesLabel);
        }
    }
}
