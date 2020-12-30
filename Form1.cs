using System;
using System.Windows.Forms;

namespace pivot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNumber_Click(object sender, EventArgs e)
        {
            Pivot("N");
        }
                
        private void btnString_Click(object sender, EventArgs e)
        {
            Pivot("S");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbxInput.Clear();
            tbxPivot.Clear();
            tbxInput.Focus();
        }


        private void Pivot(string characterType)
        {
            string resultPivot = "";

            if (characterType == "N")
            {
                for (int i = 0; i < tbxInput.Lines.Length; i++)
                {
                    if (tbxInput.Lines[i].Trim().Length > 0)
                    {
                        resultPivot += $"{tbxInput.Lines[i]},";
                    }
                }
            } 
            else
            {
                for (int i = 0; i < tbxInput.Lines.Length; i++)
                {
                    if (tbxInput.Lines[i].Trim().Length > 0)
                    {
                        resultPivot += $"'{tbxInput.Lines[i]}',";
                    }
                }
            }

            resultPivot = resultPivot.TrimEnd(',');

            tbxPivot.Focus();
            tbxPivot.Text = resultPivot;
            tbxPivot.SelectAll();
            tbxPivot.Copy();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ActiveControl = tbxInput;
        }
    }
}
