namespace session01.UI;
public partial class FormCalc : Form
{
    public FormCalc()
    {
        InitializeComponent();
    }

    private void buttonAdd_Click(object sender, EventArgs e)
    {
        textBoxResult.Text = Calc(Convert.ToDouble(textBoxA.Text), Convert.ToDouble(textBoxB.Text), CalcOp.ADD).ToString();
    }

    private void buttonSub_Click(object sender, EventArgs e)
    {
        textBoxResult.Text = Calc(Convert.ToDouble(textBoxA.Text), Convert.ToDouble(textBoxB.Text), CalcOp.SUB).ToString();
    }

    private void buttonMul_Click(object sender, EventArgs e)
    {
        textBoxResult.Text = Calc(Convert.ToDouble(textBoxA.Text), Convert.ToDouble(textBoxB.Text), CalcOp.MUL).ToString();
    }

    private void buttonDiv_Click(object sender, EventArgs e)
    {
        textBoxResult.Text = Calc(Convert.ToDouble(textBoxA.Text), Convert.ToDouble(textBoxB.Text), CalcOp.DIV).ToString();
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

    private double Calc(double a, double b, CalcOp op)
    {
        switch (op)
        {
            case CalcOp.ADD: return a + b;
            case CalcOp.SUB: return a - b;
            case CalcOp.MUL: return a * b;
            case CalcOp.DIV: return a / b;
            default:
                MessageBox.Show("Op is not defined");
                throw new Exception();
        }
    }
}


enum CalcOp
{
    ADD,
    SUB, 
    MUL,
    DIV
}