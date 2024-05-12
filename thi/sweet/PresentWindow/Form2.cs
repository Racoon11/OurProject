using sweets;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace PresentWindow
{
    public partial class Form2 : Form
    {
        static public int am = 0;
        NYPresent pr;
        ListBox listBox;
        string chosen;
        Label totalWeight;
        Label caloriesLabel;
        bool edit = false;
        int i = -1;
        public Form2(NYPresent present, ListBox listBox1, Label l, Label l2)
        {
            am++;
            InitializeComponent();
            pr = present;
            listBox = listBox1;
            totalWeight = l;
            caloriesLabel = l2;
            edit = false;

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel1.Enabled = true;
            panel2.Visible = false;
            panel2.Enabled = false;
            panel2.Location = new Point(101, 90);
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            am--;
        }

        private void chooseButton_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel1.Enabled = false;
            if (candyRadio.Checked)
            {
                chosen = "Candy";
            } 
            else if (waffleRadio.Checked)
            {
                chosen = "Waffle";
            } 
            else if (chocolateRadio.Checked)
            {
                chosen = "Chocolate";
            }
            make_panel2_Visible();
        }

        public void make_panel2_Visible(int w = 0, int c = 0, bool choc = false, string f = "None", string type = null, int ind = -1)
        {
            panel1.Visible = false;
            panel1.Enabled = false;
            panel2.Visible = true;
            panel2.Enabled = true;
            weightTextBox.Text = w.ToString();
            caloriesTextBox.Text = c.ToString();
            chocolateCheckBox.Checked = choc;
            comboBox1.Text = f;
            if (ind != -1)
            {
                chosen = type.Split()[0];
                edit = true;
                i = ind;
            }
        }


        private void choose3Button_Click(object sender, EventArgs e)
        {
            int w = int.Parse(weightTextBox.Text);
            int c = int.Parse(caloriesTextBox.Text);
            string f = comboBox1.Text;
            bool choc = chocolateCheckBox.Checked;
            Filling fill = null;
            if (f == "Chocolate")
            {
                fill = new Filling(12, 50, 10, "chockolate filling");
            } else if (f == "Milk")
            {
                fill = new Filling(12, 40, 10, "milk");
            }
            addSweet(w, c, choc, fill);
        }

        public void addSweet(int w, int c, bool choc, Filling fill)
        {
            WrappedSweet wrapS = null;
            if (chosen == "Candy")
            {
                if (choc)
                {
                    Chocolate chock = new Chocolate(500, 1200, 100, "milk chocolate");
                    ChocolateCandy candy = new ChocolateCandy(c, 10, w, fill, chock);
                    wrapS = PresentFactory.makeWrappedSweet(candy);

                }
                else
                {
                    Candy candy = new Candy(c, 10, w, fill);
                    wrapS = PresentFactory.makeWrappedSweet(candy);
                }
            }
            else if (chosen == "Waffle")
            {
                if (choc)
                {
                    Chocolate chock = new Chocolate(500, 1200, 100, "milk chocolate");
                    WaffleCandy candy = new WaffleCandy(c, 10, w, "waffle", fill, chock);
                    wrapS = PresentFactory.makeWrappedSweet(candy);

                }
                else
                {
                    Waffle candy = new Waffle(c, 10, w, "waffle", fill);
                    wrapS = PresentFactory.makeWrappedSweet(candy);
                }

            }
            else if (chosen == "Chocolate")
            {
                Chocolate chock = new Chocolate(c, 10, w, "milk chocolate");
                wrapS = PresentFactory.makeWrappedSweet(chock);
            }
            if (edit)
            {
                pr.SetSweet(i, wrapS);
            }
            else pr.addCandy(wrapS);
            Form1.showPresent(listBox, pr, totalWeight, caloriesLabel);
        }
    }
}
