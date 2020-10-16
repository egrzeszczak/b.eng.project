using System;
using System.IO;
using System.Drawing;

namespace Laser
{
    class ImgToGcode
    {
        private static Bitmap bmp;

        /*
        


        */

        static void Main(string[] args)
        {
            try
            {
                bmp = new Bitmap("C:\\Users\\gribi\\Downloads\\earth.png"); //path to image
                String file = @"C:\\Users\\gribi\\Downloads\\test.gcode"; //path to new gcode file


                using (var stream = new FileStream(file, FileMode.CreateNew)) //creation gcode file
                { }
                using var writer = new StreamWriter(file);

                writer.WriteLine("M05 S0");
                writer.WriteLine("G90");
                writer.WriteLine("G21");
                writer.WriteLine("G1 F3000");


                int x, y;
                bool firstLine = true;
                bool firstWhiteLine = true;
                bool firstPixel = true;

                Console.WriteLine("Hello");
                Console.WriteLine(bmp.Width);
                Console.WriteLine(bmp.Height);

                for (x = 0; x < bmp.Width; x++)
                {
                    for (y = 0; y < bmp.Height; y++)
                    {

                        if ((bmp.GetPixel(x, y)) == Color.FromArgb(255, Color.Black))
                        {
                            if (firstLine)
                            {
                                writer.WriteLine("G1 X" + x + " Y" + y);
                                writer.WriteLine("G4 P0");
                                writer.WriteLine("M03 S255");
                                writer.WriteLine("G4 P0");
                                writer.WriteLine("G1 F750.000000");
                                firstLine = false;
                                firstWhiteLine = true;
                                firstPixel = false;
                                continue;
                            }

                            if((bmp.GetPixel(x, y + 1)) != Color.FromArgb(255, Color.Black) || x+1 == bmp.Width || y+1 == bmp.Height)
                            {
                                writer.WriteLine("G1 X" + x + " Y" + y);
                            }
                        }

                        if (!firstPixel)
                        {
                            if ((bmp.GetPixel(x, y)) != Color.FromArgb(255, Color.Black))
                            {
                                if (firstWhiteLine)
                                {
                                    writer.WriteLine("G4 P0");
                                    writer.WriteLine("M05 S0");
                                    writer.WriteLine("G1 F3000");
                                    writer.WriteLine("G1 X" + x + " Y" + y);
                                    firstLine = true;
                                    firstWhiteLine = false;
                                    continue;
                                }

                                try
                                {
                                    if ((bmp.GetPixel(x, y + 1)) == Color.FromArgb(255, Color.Black))
                                    {
                                        writer.WriteLine("G1 X" + x + " Y" + y);
                                    }
                                }
                                catch { }

                            }
                        }
                    }
                }
                writer.WriteLine("G4 P0");
                writer.WriteLine("M05 S0");
                writer.WriteLine("G1 F3000");
                writer.WriteLine("G1 X0 Y0");
            }
            catch (System.IO.FileNotFoundException e)
            {
                
            }
        }
    }
}
