using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace session01.UI;
public partial class FormCalc : Form
{
    public FormCalc()
    {
        InitializeComponent();
    }

    private void buttonAdd_Click(object sender, EventArgs e)
    {
        textBoxResult.Text = Calc(Convert.ToDouble(textBoxA.Text), Convert.ToDouble(textBoxB.Text), "+").ToString();
    }

    private void buttonSub_Click(object sender, EventArgs e)
    {
        textBoxResult.Text = Calc(Convert.ToDouble(textBoxA.Text), Convert.ToDouble(textBoxB.Text), "-").ToString();
    }

    private void buttonMul_Click(object sender, EventArgs e)
    {
        textBoxResult.Text = Calc(Convert.ToDouble(textBoxA.Text), Convert.ToDouble(textBoxB.Text), "*").ToString();
    }

    private void buttonDiv_Click(object sender, EventArgs e)
    {
        textBoxResult.Text = Calc(Convert.ToDouble(textBoxA.Text), Convert.ToDouble(textBoxB.Text), "/").ToString();
    }

    private double Calc(double a, double b, string op)
    {
        double result = 0;
        switch (op) {
            case "+":
                result = a + b;
                break;
            case "-":
                result = a - b;
                break;
            case "*":
                result = a * b;
                break;
            case "/":
                result = a / b;
                break;
            default:
                MessageBox.Show("Op is not defined");
                throw new Exception();

        }
        return result;
    }
}
