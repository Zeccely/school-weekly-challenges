using System;
using System.Reflection;
using System.Windows.Forms;

namespace ExerciseMovingCar1
{
    public partial class Form1 : Form
    {
        private CarMover carMovery;
        

        public Form1()
        {
            InitializeComponent();
            carMovery = new CarMover(pinkCar);

        }

        private void startButton_Click(object sender, EventArgs e)
        {
            
            timer1.Start();
            

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (carMovery.index < carMovery.Positions.Length)
            {
               carMovery.CarControl();
               
            }
            else
            {
                timer1.Stop();
            }
            
        }
    }
}
