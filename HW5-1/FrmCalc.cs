using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW_5_1
{

    public partial class frmCalc : Form
    {
        private readonly Calculator _calc;
        
        public frmCalc()
        {
            InitializeComponent();

            _calc = new Calculator(new TextBoxLogger(tbLog));
        }

        private void BtnNum_Click(object sender, EventArgs e)
        {

            string num = (sender as Button).Text;

            if (tbOperand.Text == "0") 
            {
                tbOperand.Text = "";
            }
            if (num == "," && tbOperand.Text.Contains(","))
            {
                return;
            }
            
            tbOperand.Text += num;
        }

        private void BtnResult_Click(object sender, EventArgs e)
        {
            if(_calc.Operation == "")
            {
                return;
            }
            double operand = Convert.ToDouble(tbOperand.Text);
            _calc.SetOperand(operand);  
            tbResult.Text = Convert.ToString(_calc.GetResult());
            tbOperand.Text = "0";
        }

        private void BtnOperator_Click(object sender, EventArgs e)
        {
            string op = (sender as Button).Text;
            double operand = Convert.ToDouble(tbOperand.Text);
            _calc.SetOperand(operand);
            _calc.SetOperation(op);
            tbResult.Text = Convert.ToString(_calc.Operand1) + " " + op;
            tbOperand.Text = "0";
        }

        private void BtnAC_Click(object sender, EventArgs e)
        {
            _calc.Clear();
            tbResult.Text = "";
            tbOperand.Text = "0";

        }

        private void TbLog_TextChanged(object sender, EventArgs e)
        {
            tbLog.SelectionStart = tbLog.Text.Length;
            tbLog.ScrollToCaret();
        }

        private void BtnBackspace_Click(object sender, EventArgs e)
        {
            tbOperand.Text = tbOperand.Text.Substring(0, tbOperand.Text.Length - 1);
            if (tbOperand.Text.Length == 0)
            {
                tbOperand.Text = "0";
            }
        }
    }
}
