using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Filtr_koloru
{
    public partial class Window : Form
    {

        delegate void Filter_color(ref int rp, ref int gp, ref int bp, int number);
        [DllImport("kernel32.dll")]
        public static extern IntPtr LoadLibrary(string dllToLoad);

        [DllImport("kernel32.dll")]
        public static extern IntPtr GetProcAddress(IntPtr hModule, string procedureName);

        [DllImport("kernel32.dll")]
        public static extern bool FreeLibrary(IntPtr hModule);


        public Bitmap photoToChange;
        public Bitmap ChangedPhoto;
        string Chosencolor = "None";
        int colorNumber = 0;
        public Window()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void Przycisk_Click(object sender, EventArgs e)
        {
            string dllChoice;


            if (asemblerDLL.Checked)
            {
                dllChoice = "filtr_asembler.dll";
            }
            else
            {
                dllChoice = "Filtr_c++.dll";
            }

            if (photoToChange != null)
            {
                if (Chosencolor != "None")
                {
                    var dllHandle = LoadLibrary(dllChoice);
                    if (dllHandle != IntPtr.Zero)
                    {
                        //MessageBox.Show("Załadowano bibliotekę");
                        //początek mierzenia czasu
                        //int start, stop;
                        //start = Environment.TickCount & Int32.MaxValue;
                        DateTime startTime = DateTime.Now;
                        var procAddress = GetProcAddress(dllHandle, "Filtr_color"); //EXPORTS Filtr_color ,nazwa funkcji

                        if (procAddress != IntPtr.Zero)
                        {
                            Filter_color filter_color = (Filter_color)Marshal.GetDelegateForFunctionPointer(procAddress, typeof(Filter_color));
                            //-----------------
                            int w = photoToChange.Width;
                            int h = photoToChange.Height;
                            ChangedPhoto = new Bitmap(photoToChange);
                            Color pixel;

                            for (int i = 0; i < h; i++)
                            {
                                for (int j = 0; j < w; j++)
                                {
                                    pixel = ChangedPhoto.GetPixel(j, i);
                                    int ap = pixel.A;
                                    int rp = pixel.R;
                                    int gp = pixel.G;
                                    int bp = pixel.B;
                                    filter_color(ref rp, ref gp, ref bp, colorNumber);

                                    ChangedPhoto.SetPixel(j, i, Color.FromArgb(ap, rp, gp, bp));


                                    SecondPhoto.Image = ChangedPhoto;
                                }
                            }
                        }
                       // MessageBox.Show("koniec");
                        FreeLibrary(dllHandle);
                        //koniec mierzenia czasu
                        //stop = Environment.TickCount & Int32.MaxValue;
                        // MessageBox.Show("Czas pracy: " + (stop - start));
                        DateTime stopTime = DateTime.Now;
                        TimeSpan roznica = stopTime - startTime;
                        MessageBox.Show("Czas pracy: " + roznica.TotalSeconds+ " sec");
                    }
                    else
                    {
                        MessageBox.Show("Nie znaleziono biblioteki");
                    }
                }
                else
                    MessageBox.Show("Nie wybrano koloru");
            }
            else MessageBox.Show("Nie wybrano zdjęcia");
        }


        OpenFileDialog obj = new OpenFileDialog();
        SaveFileDialog saveFileDialog = new SaveFileDialog();
        private void photo_Click(object sender, EventArgs e)
        {
            if (obj.ShowDialog() == DialogResult.OK)
            {
                photoToChange = new Bitmap(obj.FileName);
                FirstPhoto.Image = new Bitmap(obj.FileName);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) //red color
        {
            Chosencolor = "red";
            ColorChoice.Text = Chosencolor;
            colorNumber = 1;
            ColorChoice.Refresh();
        }

        private void button2_Click(object sender, EventArgs e) //blue color
        {
            Chosencolor = "blue";
            ColorChoice.Text = Chosencolor;
            colorNumber = 2;
            ColorChoice.Refresh();
            // SecondPhoto.Refresh();
        }

        private void button3_Click(object sender, EventArgs e)//green color
        {
            Chosencolor = "green";
            ColorChoice.Text = Chosencolor;
            colorNumber = 3;
            ColorChoice.Refresh();
            //SecondPhoto.Refresh();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


        private void button4_Click(object sender, EventArgs e) //histogram pierwszego zdjęcia
        {
            if (photoToChange != null)
            {

                Bitmap histogram = photoToChange;
                long red = 0;
                long green = 0;
                long blue = 0;
                for (int i = 0; i < histogram.Width; i++)
                {
                    for (int j = 0; j < histogram.Height; j++)
                    {
                        Color pixelColor = histogram.GetPixel(i, j);
                        red = red + pixelColor.R;//(pixelColor.R/100)
                        green = green + pixelColor.G;//(pixelColor.G / 100)
                        blue = blue + pixelColor.B;//(pixelColor.B / 100)
                    }
                }
                Form2 form2 = new Form2(red, green, blue);
                form2.Show();
            }
            else MessageBox.Show("Brak załadowanego zdjęcia");
        }

        private void button5_Click(object sender, EventArgs e) //histogram zdjęcia po zmianie
        {
            if (ChangedPhoto != null)
            {
                Bitmap histogram = ChangedPhoto;
                long red = 0;
                long green = 0;
                long blue = 0;
                for (int i = 0; i < histogram.Width; i++)
                {
                    for (int j = 0; j < histogram.Height; j++)
                    {
                        Color pixelColor = histogram.GetPixel(i, j);
                        red = red + pixelColor.R;
                        green = green + pixelColor.G;
                        blue = blue + pixelColor.B;
                    }
                }
                Form2 form2 = new Form2(red, green, blue);
                form2.Show();

            }
            else MessageBox.Show("Brak zmienionego zdjęcia");
        }

        private void button6_Click(object sender, EventArgs e)//zapis zdjęcia
        {
            if (ChangedPhoto != null)
            {
                saveFileDialog.Filter = "Pliki obrazów (*.png)|*.png|Wszystkie pliki (*.*)|*.*";
                saveFileDialog.FilterIndex = 1;
                saveFileDialog.Title = "Zapisz obraz";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string fileName = saveFileDialog.FileName;
                    ChangedPhoto.Save(fileName);
                }
            }
            else MessageBox.Show("Brak wygenerowanego zdjęcia do zapisu");
        }

    }
}
