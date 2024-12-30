namespace session01.UI;
public partial class FormCalc : Form
{
    public FormCalc()
    {
        InitializeComponent();
        buttonAdd.Click += buttonCalcHandler;
        buttonSub.Click += buttonCalcHandler;
        buttonMul.Click += buttonCalcHandler;
        buttonDiv.Click += buttonCalcHandler;
        buttonAdd.Tag = CalcOp.ADD;
        buttonSub.Tag = CalcOp.SUB;
        buttonMul.Tag = CalcOp.MUL;
        buttonDiv.Tag = CalcOp.DIV; 
    }

    private void buttonCalcHandler(object? sender, EventArgs e)
    {
        if(sender is Button btn && btn.Tag is CalcOp op)
        {
            textBoxResult.Text = CalcPattern(Convert.ToDouble(textBoxA.Text), Convert.ToDouble(textBoxB.Text), op).ToString();
        }

        //if(sender != null)
        //{
        //    if(sender is Button)
        //    {
        //        var btn = (Button)sender;                
        //        textBoxResult.Text = CalcPattern(Convert.ToDouble(textBoxA.Text), Convert.ToDouble(textBoxB.Text), (CalcOp)btn.Tag).ToString();
        //    }
        //}
        
    }

    //private void buttonAdd_Click(object sender, EventArgs e)
    //{
    //    textBoxResult.Text = CalcPattern(Convert.ToDouble(textBoxA.Text), Convert.ToDouble(textBoxB.Text), CalcOp.ADD).ToString();
    //}

    //private void buttonSub_Click(object sender, EventArgs e)
    //{
    //    textBoxResult.Text = CalcPattern(Convert.ToDouble(textBoxA.Text), Convert.ToDouble(textBoxB.Text), CalcOp.SUB).ToString();
    //}

    //private void buttonMul_Click(object sender, EventArgs e)
    //{
    //    textBoxResult.Text = CalcPattern(Convert.ToDouble(textBoxA.Text), Convert.ToDouble(textBoxB.Text), CalcOp.MUL).ToString();
    //}

    //private void buttonDiv_Click(object sender, EventArgs e)
    //{
    //    textBoxResult.Text = CalcPattern(Convert.ToDouble(textBoxA.Text), Convert.ToDouble(textBoxB.Text), CalcOp.DIV).ToString();
    //}

    //Refactoring
    //بهینه کردن ساختار کد بدون تغییر در رفتار

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

    private double CalcPattern(double a, double b, CalcOp op)
    {
        var result = op switch
        {
            CalcOp.ADD => a + b,
            CalcOp.SUB => a - b,
            CalcOp.MUL => a * b,
            CalcOp.DIV when b == 0 => throw new DivideByZeroException(),
            CalcOp.DIV => a / b,
            _ => throw new Exception()
        };
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