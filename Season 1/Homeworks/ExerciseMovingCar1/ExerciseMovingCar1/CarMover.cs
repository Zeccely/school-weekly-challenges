namespace ExerciseMovingCar1
{
    internal class CarMover
    {
        private PictureBox vroom;
        public int index = 0;
        public List<Point> Positions = new List<Point>();
        private int start = 50;
        private int increment = 10;
        private int howmanymove = 50;


        public CarMover(PictureBox vroom)
        {
            this.vroom = vroom;
        }
        
        public void CarControl()
        {
            for (int x; index < howmanymove ; index++)
            {

            }
            vroom.Location = Positions[index];
            index++;

        }
    }
}
