using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExerciseDiceRolling
{
    public partial class DiceResult : Form
    {
        int randomnumba;
        public DiceResult()
        {
            InitializeComponent();
        }
        public DiceResult(int numba)
        {
            this.randomnumba = numba;
        }
        public void DiceImageChanger()
        {
            if (this.randomnumba == 0)
            {
                BackgroundImage = 
            }
        }
    }
}
