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
        double result = 0;
        switch (op)
        {
            case CalcOp.ADD:
                result = a + b;
                break;
            case CalcOp.SUB:
                result = a - b;
                break;
            case CalcOp.MUL:
                result = a * b;
                break;
            case CalcOp.DIV:
                result = a / b;
                break;
            default:
                MessageBox.Show("Op is not defined");
                throw new Exception();

        }
        return result;
    }
}


enum CalcOp
{
    ADD,
    SUB, 
    MUL,
    DIV
}