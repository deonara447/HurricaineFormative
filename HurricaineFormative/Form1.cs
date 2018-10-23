using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HurricaineFormative
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string category = catInput.Text;

            switch (category)
            {
                case "1":
                    outputLabel.Text = "number 1";
                    break;
                case "2":
                    outputLabel.Text = "number 2";
                    break;
                case "3":
                    outputLabel.Text = "number 3";
                    break;
                case "4":
                    outputLabel.Text = "number 4";
                    break;
                case "5":
                    outputLabel.Text = "number 5";
                    break;
            
                default:
                    outputLabel.Text = "default";
                    break;


                    //
            }

        }
    }
}
