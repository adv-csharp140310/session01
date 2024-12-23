namespace session01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*
             * variable
             * <type> <name> = <init_value>
             * 
             * <type>:
             *   value: 
             *      int, bool, ...
             *      stack
             *   refrence type
             *      `new`
             *      object
             *      Heap
             *      
             *      
             *  Product p1 = new Product();
             *  p1.Price =  1000;
             *  
             *  
             *  Product p2 = p1;
             *  p2.Price = 2000;
             *  
             *  
             *  p1.Price = 2000
             *  p2.Price = 2000
             *  
             *  
             *  stack vs heap - https://www.youtube.com/watch?v=N3o5yHYLviQ
             * 
             * 
             * LOB - line of bussiness 
             * */

            //Explicit - صریح
            int a = 100;

            //Implicit - ضمنی
            var b = 100;
            //b = "sadfdsf"; 🐞


            var first_name = "ali";
            var firstName = "ali";
            /*
             * Naming Case
             *      PascalCase                  -> interface, class, method, property, struct, record, constractur
             *      camelCase                   -> varible, method private
             *      train_case, snake_case      -> varible*
             *      kebab-case                  -> css
             *      CONST_CASE                  ->
             * */




        }
    }
}
