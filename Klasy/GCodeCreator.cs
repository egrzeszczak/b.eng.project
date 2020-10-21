using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;


// 1px == 0.2645833333 mm
// 1mm == 3.779527559 px
// horizontal, vertical, diagonal 

namespace GCodeFromImage
{
    class ImgToGCode
    {
        public int feed_rate = 1000;
        private static Bitmap bmp;
        private static int expression;
        private static float max_power = 300;
        private static float min_power = 200;
        private static double power_inc = (max_power - min_power) / 255;
        private static double one_pix = 0.26;
        static void Main(string[] args)
        {
            try
            {
                bmp = new Bitmap("C:\\Users\\Bohdan\\Desktop\\krug.png"); //path to image
                String file = @"C:\\Users\\Bohdan\\Desktop\\test.gcode"; //path to new gcode file


                using (var stream = new FileStream(file, FileMode.CreateNew)) //creation gcode file
                { }
                using var writer = new StreamWriter(file);
           

                // 1-horizontal
                // 2-vertical
                // 3-diagonal
                expression = 4;
                switch(expression)
                {
                    case 1:
                        horizontal(writer, bmp);
                        break;
                    case 2:
                        vertical(writer, bmp);
                        break;
                    case 3:
                        diagonal(writer, bmp);
                        break;
                    case 4:
                        vector(writer, bmp);
                        break;
                    default:
                        Console.WriteLine("ERROR");
                        break;
                }

            }
            catch (FileNotFoundException e)
            {

            }
        }

        static void horizontal(StreamWriter writer, Bitmap bmp)
        {
            for(int y = 0; y < bmp.Height; y++)
            {
                for(int x = 0; x < bmp.Width; x++)
                {
                    Color color = bmp.GetPixel(x, y);
                    float colour = (color.R + color.G + color.B);
                    float col = colour / 3;
                    double coefficient = Math.Round(col, MidpointRounding.AwayFromZero);
                    double power = Math.Round(min_power + (255 - coefficient) * power_inc, 2);

                    //writer.WriteLine(power);
                    writer.WriteLine("M03 S" + power);
                    writer.WriteLine("G01 X" + x * one_pix + " Y" + y * one_pix + " F200");

                }
            }
        }

        static void vertical(StreamWriter writer, Bitmap bmp)
        {
            for (int x = 0; x < bmp.Width; x++)
            {
                for (int y = 0; y < bmp.Height; y++)
                {
                    Color color = bmp.GetPixel(x, y);
                    float colour = (color.R + color.G + color.B);
                    float col = colour / 3;
                    double coefficient = Math.Round(col, MidpointRounding.AwayFromZero);
                    double power = Math.Round(min_power + (255 - coefficient) * power_inc, 2);

                    //writer.WriteLine(power);
                    writer.WriteLine("M03 S" + power);
                    writer.WriteLine("G01 X" + x * one_pix + " Y" + y * one_pix + " F200");

                }
            }
        }

        static void diagonal(StreamWriter writer, Bitmap bmp)
        {

        }

        static void vector(StreamWriter writer, Bitmap bmp)
        {
            Boolean first_black_pixel_in_column = true;
            List<string> upper_pixels = new List<string>();
            List<string> lower_pixels = new List<string>();
            String first_pixel_coordinates = "";
            Boolean first = true;
            for (int x = 0; x < bmp.Width; x++)
            {
                //Console.WriteLine("X");
                for(int y = 0; y < bmp.Height; y++)
                {
                    //Console.WriteLine("Y");
                    if(bmp.GetPixel(x, y) == Color.FromArgb(255, Color.Black) && first_black_pixel_in_column)
                    {
                        //Console.WriteLine("Lower");
                        lower_pixels.Add("G01 X" + x * one_pix  + " Y" + y * one_pix  + " F200");
                        first_black_pixel_in_column = false;
                    }
                    if (y < bmp.Height - 1)
                    {
                        if (bmp.GetPixel(x, y + 1) == Color.FromArgb(255, Color.White) && bmp.GetPixel(x, y) == Color.FromArgb(255, Color.Black))
                        {
                            //Console.WriteLine("Upper");
                            writer.WriteLine("G01 X" + x * one_pix  + " Y" + y * one_pix  + " F200");
                            first_black_pixel_in_column = true;
                            if (first)
                            {
                                first_pixel_coordinates = "G01 X" + x * one_pix + " Y" + y * one_pix + " F200";
                                first = false;
                            }
                        }
                    }
                }
            }
            for(int i = lower_pixels.Count - 1; i >= 0; i--)
            {
                writer.WriteLine(lower_pixels[i]);
            }
            writer.WriteLine(first_pixel_coordinates);
        }
    }
}
