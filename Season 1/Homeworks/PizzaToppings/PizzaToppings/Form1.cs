namespace PizzaToppings
{
    public partial class Form1 : Form
    {
        PizzaOrder pizzaiolo;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pizzaiolo = new PizzaOrder(5, 0.5);
            
            toppingsList.DataSource = Enum.GetValues(typeof(PizzaOrder.Toppings))
;
        }

        private void addToPizza_Click(object sender, EventArgs e)
        {
            List<Enum> thing = pizzaiolo.AddTopping((Enum)toppingsList.SelectedItem);
            toppingsAdder.Text = thing.ToString();
            
        }

        private void RemoveFromPizza_Click(object sender, EventArgs e)
        {

        }
    }
}
