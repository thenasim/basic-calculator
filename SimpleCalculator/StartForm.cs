using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class StartForm : Form
    {
        private string current = "0";
        private string operation = "";
        private bool hasShownAns = false;

        public StartForm()
        {
            InitializeComponent();
            this.txtIO.Text = this.current;
        }

        private char GetLastCharIo()
        {
            return this.txtIO.Text[this.txtIO.Text.Length-1];
        }

        private char GetFirstCharIo()
        {
            return this.txtIO.Text[0];
        }

        private void ChangeTxtOpLastChar(string symbol)
        {
            char[] c = this.txtOperation.Text.ToCharArray();
            c[c.Length - 1] = symbol.ToCharArray()[0];
            this.txtOperation.Text = new string(c);
        }

        private void SetTxtIo(string value)
        {
            if (this.hasShownAns) {
                this.txtIO.Text = "0";
                this.hasShownAns = false;
            }

            if (this.GetLastCharIo() == '.' && value == ".")
                return;

            if (this.txtIO.Text == "0" && value != ".")
                this.txtIO.Text = value;
            else
                this.txtIO.Text += value;

        }

        private void SetTxtOp(string op)
        {
            this.txtOperation.Text += (this.txtIO.Text + op);
        }

        private void SetCurrent()
        {
            this.current = this.txtIO.Text;
        }

        private void ClearCurrent()
        {
            this.txtIO.Text = "0";
            this.hasShownAns = false;
        }
        
        private void ClearAll()
        {
            this.ClearCurrent();
            this.operation = "";
            this.current = "0";
            this.txtOperation.Text = "";
        }

        private void Calculate(string op)
        {
            if (this.operation == "") {
                this.SetCurrent();
                this.txtIO.Text = this.current;
                this.hasShownAns = true;
                this.operation = op;
                return;
            }

            if (op != this.operation) {
                this.Calculate(this.operation);
                this.operation = op;
                return;
            }

            if (op == "+") {
                this.current = Convert.ToString(Convert.ToDouble(this.current) + Convert.ToDouble(this.txtIO.Text));
            }
            else if (op == "-") {
                this.current = Convert.ToString(Convert.ToDouble(this.current) - Convert.ToDouble(this.txtIO.Text));
            }
            else if (op == "x") {
                this.current = Convert.ToString(Convert.ToDouble(this.current) * Convert.ToDouble(this.txtIO.Text));
            }
            else if (op == "/") {
                this.current = Convert.ToString(Convert.ToDouble(this.current) / Convert.ToDouble(this.txtIO.Text));
            }

            this.txtIO.Text = this.current;
            this.hasShownAns = true;
            this.operation = op;
        }

        private void DoMath(string op)
        {
            if (this.hasShownAns && !String.IsNullOrEmpty(this.txtOperation.Text)) {
                this.ChangeTxtOpLastChar(op);
                this.operation = (op);
                return;
            }

            this.SetTxtOp(op);
            this.Calculate(op);
        }

        private void btnNumberClick(object sender, EventArgs e)
        {
            Button numericBtn = sender as Button;
            this.SetTxtIo(numericBtn.Text);
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            string[] dots = this.txtIO.Text.Split('.');

            if (dots.Length > 1)
                return;

            this.SetTxtIo(this.btnDot.Text);
        }

        private void btnOperationPerform(object sender, EventArgs e)
        {
            Button opBtn = sender as Button;
            this.DoMath(opBtn.Text);
        }

        private void btnDeleteDigit_Click(object sender, EventArgs e)
        {
            if (this.txtIO.Text.Length == 1) {
                this.txtIO.Text = "0";
                return;
            }

            string str = this.txtIO.Text.Remove(this.txtIO.Text.Length - 1);
            this.txtIO.Text = str;
        }

        private void btnClearCurrent_Click(object sender, EventArgs e)
        {
            this.ClearCurrent();
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            this.ClearAll();
        }

        private void btnAns_Click(object sender, EventArgs e)
        {
            this.txtOperation.Text = "";
            this.Calculate(this.operation);
            this.operation = "";
            this.current = "0";
            this.hasShownAns = true;
        }

        private void btnPlusMinus_Click(object sender, EventArgs e)
        {
            if (this.GetFirstCharIo() == '-') {
                this.txtIO.Text = this.txtIO.Text.TrimStart('-');
            } else {
                this.txtIO.Text = ("-" + this.txtIO.Text);
            }
        }
    }
}
