using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3
{
    internal class Car
    {
        public string brand { get; private set; } // this way is the neo way of doing get and set and private set prevents other classes from changing this

        public Car(string brand) //all cars have brands so this is a constructor ty
        {
            this.brand = brand;
        }

        private double currentSpeedo;
        private double maxSpeedo;

        //public void SetBrand(string brandName)
        //{
        //    this.brand = brandName;
        //}

        public double GetMaxSpeed()
        {
            return this.maxSpeedo;
        }
        //public string GetBrand()
        //{
        //    return this.brand;
        //}

        public void SetMaxSpeed(double maxSpeed)
        {
            this.maxSpeedo = maxSpeed;
        }

        public void SpeedUp()
        {
            
            this.currentSpeedo = this.currentSpeedo + 7;
            if (this.currentSpeedo > this.maxSpeedo)
            {
                this.currentSpeedo = this.maxSpeedo;
            }
        }

        public void SlowDown()
        {
            this.currentSpeedo = this.currentSpeedo - 10;
            if (this.currentSpeedo < 0)
            {
                this.currentSpeedo = 0;
            }
        }
        public double GetSpeed()
        {
            return this.currentSpeedo;
        }
        public void SetSpeed(double speed)
        {
            this.currentSpeedo = speed;
        }
    }
}
