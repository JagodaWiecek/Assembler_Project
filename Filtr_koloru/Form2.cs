using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Filtr_koloru
{
    public partial class Form2 : Form
    {
        long colorR;
        long colorG;
        long colorB;

        public Form2(long red, long green, long blue)
        {
            InitializeComponent();
            colorR= red;
            colorG= green;  
            colorB= blue;
        }

        
        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            long average = (colorR+ colorG+ colorB);

            chart1.Series["color"].Points.AddXY("red", (colorR*100)/average);
            chart1.Series["color"].Points[0].Color = Color.Red;

            chart1.Series["color"].Points.AddXY("green", (colorG * 100) / average);
            chart1.Series["color"].Points[1].Color  = Color.Green;

            chart1.Series["color"].Points.AddXY("blue", (colorB * 100) / average);
            chart1.Series["color"].Points[2].Color = Color.Blue;

        }

    }
}
