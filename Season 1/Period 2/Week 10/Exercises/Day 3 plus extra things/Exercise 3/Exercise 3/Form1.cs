
using System.Diagnostics;

namespace Exercise_3
{
    public partial class Form1 : Form //
    {
        //you cannot create a car class object inside another class but you can create this thing below it
        private Car myCar = new Car("Toyoda"); //this is a field type car. can be initialized here too

        public Form1() //this is a constructor
        {
            
            //myCar = new Car("Toyoda"); //making instance car. the car is initialized here
            myCar.SetMaxSpeed(200);
            myCar.SetSpeed(0);
            InitializeComponent();
        } 
         
        private void Form1_Load(object sender, EventArgs e)
        {

            displayer.Text = "This " + myCar.brand + " is going at " + myCar.GetSpeed() + " km/hr";
            
        }
        
        private void slowDOWN_Click(object sender, EventArgs e)
        {
            myCar.SlowDown();
            displayer.Text = "This " + myCar.brand + " is going at " + myCar.GetSpeed() + " km/hr";
            
        }

        private void speedUP_Click(object sender, EventArgs e)
        {
           
            myCar.SpeedUp();
            displayer.Text = "This " + myCar.brand + " is going at " + myCar.GetSpeed() + " km/hr";
            
        }
    }
}
