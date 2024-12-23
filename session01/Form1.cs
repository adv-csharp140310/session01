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
             *   object
             *   value: 
             *      int, bool, ...
             *      stack
             *   refrence type
             *      `new`             *      
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


            //Boxing
            var name = "Ali";
            object obj = name;
            
            //Unboxing
            var name2 = (string)obj;
            /*
             * Runtime-error
             * Readabily
             */

            var name3 = Convert.ToString(obj);
            /*
             * Readabily
             * Performance
             */

            /* function(int/string/bool a){
             * }
             * 
             * function(objet a){
             * 
             * }
             * 
             * 
             * Generic <>
             * */
            var x = new List<int>();


            var p1 = new Product();
            p1.Name = "monitr";
            p1.Price = 100;

            var p2 = new Product("keyboard", 200);


            //Object Initializer
            var p3 = new Product
            {
                Name = "Keyboard",
                Price = 100,
                Rate = 5,
            };

            Product p4 = new()
            {
                Name = "Keyboard",
                Price = 100,
                Rate = 5,
            };

            var y = new { };
        }
    }

}
