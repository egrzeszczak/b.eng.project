using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Xml;
using System.Xml.Linq;


// 1px == 0.2645833333 mm
// 1mm == 3.779527559 px
// horizontal, vertical, diagonal

namespace GCodeFromImage
{
    class RasterToGCode
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
                XDocument svgFile = XDocument.Load(@"C:\\Users\\Bohdan\\Desktop\\praca\\method-draw-image.svg");
                bmp = new Bitmap("C:\\Users\\Bohdan\\Desktop\\praca\\pepe.jpg"); //path to image
                String file = @"C:\\Users\\Bohdan\\Desktop\\praca\\test1.gcode"; //path to new gcode file


                using (var stream = new FileStream(file, FileMode.CreateNew)) //creation gcode file
                { }
                using var writer = new StreamWriter(file);

                //image to grayscale
                Bitmap d = new Bitmap(bmp.Width, bmp.Height);

                writer.WriteLine(bmp.Height);
                writer.WriteLine(bmp.Width);

                for (int i = 0; i < bmp.Width; i++)
                {
                    for (int x = 0; x < bmp.Height; x++)
                    {
                        Color oc = bmp.GetPixel(i, x);
                        int grayScale = (int)((oc.R * 0.3) + (oc.G * 0.59) + (oc.B * 0.11));
                        Color nc = Color.FromArgb(oc.A, grayScale, grayScale, grayScale);
                        d.SetPixel(i, x, nc);
                    }
                }

                d.Save(@"C:\\Users\\Bohdan\\Desktop\\test1.bmp");




                // 1-horizontal
                // 2-vertical
                // 3-only black
                expression = 3;
                switch(expression)
                {
                    case 1:
                        horizontal(writer, d);
                        break;
                    case 2:
                        vertical(writer, d);
                        break;
                    case 3:
                        only_black(writer, d);
                        break;
                    default:
                        Console.WriteLine("ERROR");
                        break;
                }

               // VectorToGcode.svg_parser(writer, svgFile);

            }
            catch (FileNotFoundException e)
            {

            }

        }

        static void horizontal(StreamWriter writer, Bitmap bmp)
        {
            bool first = true;
            bool start_line = true;
            start(writer);

            for(int y = bmp.Height - 1; y >= 0; y--)
            {
                //startline
                for(int x = 0; x < bmp.Width; x++)
                {
                    Color color = bmp.GetPixel(x, y);
                    float colour = (color.R + color.G + color.B);
                    float col = colour / 3;
                    double coefficient = Math.Round(col, MidpointRounding.AwayFromZero);
                    double power = Math.Round(min_power + (255 - coefficient) * power_inc, 2);
                    if (first)
                    {
                        writer.WriteLine("G01 X" + x * one_pix + " Y" + (bmp.Height - y - 1) * one_pix + " F200");
                        writer.WriteLine("G4 P0");
                        writer.WriteLine("M03 S" + power);
                        writer.WriteLine("G4 P0");
                        writer.WriteLine("G1 F750.000000");
                        first = false;
                        continue;
                    }

                    if (start_line)
                    {
                        writer.WriteLine("G01 X" + x * one_pix + " Y" + (bmp.Height - y - 1) * one_pix + " F200");
                        writer.WriteLine("M03 S" + power);
                        start_line = false;
                    }
                    else
                    {
                        writer.WriteLine("M03 S" + power);
                        writer.WriteLine("G01 X" + x * one_pix + " Y" + (bmp.Height - y - 1) * one_pix + " F200");
                    }

                }

                writer.WriteLine("M03 S0");
                start_line = true;
                //endline
            }

            end(writer);
        }

        static void vertical(StreamWriter writer, Bitmap bmp)
        {
            bool first = true;
            bool start_line = true;
            start(writer);

            for (int x = 0; x < bmp.Width; x++)
            {
                //startline
                for (int y = bmp.Height - 1; y >= 0; y--)
                {
                    Color color = bmp.GetPixel(x, y);
                    float colour = (color.R + color.G + color.B);
                    float col = colour / 3;
                    double coefficient = Math.Round(col, MidpointRounding.AwayFromZero);
                    double power = Math.Round(min_power + (255 - coefficient) * power_inc, 2);
                    if (first)
                    {
                        writer.WriteLine("G01 X" + x * one_pix + " Y" + (bmp.Height - y - 1) * one_pix + " F200");
                        writer.WriteLine("G4 P0");
                        writer.WriteLine("M03 S" + power);
                        writer.WriteLine("G4 P0");
                        writer.WriteLine("G1 F750.000000");
                        first = false;
                        continue;
                    }

                    if (start_line)
                    {
                        writer.WriteLine("G01 X" + x * one_pix + " Y" + (bmp.Height - y - 1) * one_pix + " F200");
                        writer.WriteLine("M03 S" + power);
                        start_line = false;
                    }
                    else
                    {
                        writer.WriteLine("M03 S" + power);
                        writer.WriteLine("G01 X" + x * one_pix + " Y" + (bmp.Height - y - 1) * one_pix + " F200");
                    }

                }

                writer.WriteLine("M03 S0");
                start_line = true;
                //endline
            }

            end(writer);
        }



        static void only_black(StreamWriter writer, Bitmap bmp)
        {
            bool first = true;
            bool first_white = true;
            bool first_black = true;
            bool start_line = false;
            bool white = false;
            //startfile
            start(writer);
            for(int y = bmp.Height - 1; y >= 0; y--)
            {
                //startline
                for(int x = 0; x<bmp.Width; x++)
                {
                    Color color = bmp.GetPixel(x, y);
                    if(Convert.ToInt32(color.R) < 40) 
                    {
                        if (first)
                        {
                            writer.WriteLine("G01 X" + x * one_pix + " Y" + (bmp.Height - y - 1) * one_pix + " F200");
                            writer.WriteLine("G4 P0");
                            writer.WriteLine("M03 S255");
                            writer.WriteLine("G4 P0");
                            writer.WriteLine("G1 F750.000000");
                            first = false;
                            first_black = false;
                            continue;
                        }
                        else
                        {
                            if (first_black)
                            {
                                writer.WriteLine("M03 S255");
                                first_black = false;
                                first_white = true;
                                writer.WriteLine("G01 X" + x * one_pix + " Y" + (bmp.Height - y - 1) * one_pix + " F200");
                            }
                            else
                            {
                                if (start_line)
                                {
                                    writer.WriteLine("G01 X" + x * one_pix + " Y" + (bmp.Height - y - 1) * one_pix + " F200");
                                    writer.WriteLine("M03 S255");
                                    start_line = false;
                                }
                                else
                                {
                                    writer.WriteLine("G01 X" + x * one_pix + " Y" + (bmp.Height - y - 1) * one_pix + " F200");
                                }
                            }
                        }
                    }
                    else
                    {
                        if (first_white && !first)
                        {
                            writer.WriteLine("M03 S0");
                            
                            first_white = false;
                            first_black = true;
                            white = true;
                        }
                    }
                }
                if (white)
                {

                }
                else
                {
                    writer.WriteLine("M03 S0");
                }
                start_line = true;
                //endline
            }
            end(writer);
            //endfile
        }



        /*static void vector(StreamWriter writer, Bitmap bmp)
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
        }*/

        static private void start(StreamWriter writer)
        {
            writer.WriteLine("M05 S0");
            writer.WriteLine("G90");
            writer.WriteLine("G21");
            writer.WriteLine("G1 F3000");
        }

        static private void end(StreamWriter writer)
        {
            writer.WriteLine("G4 P0");
            writer.WriteLine("M05 S0");
            writer.WriteLine("G1 F3000");
        }
    }
}
