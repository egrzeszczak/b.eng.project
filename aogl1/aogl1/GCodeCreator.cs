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

namespace AOGL
{
    class GCodeCreator
    {
        public enum EngravingDirection { Horizontal, Vertical, Vector }

        private static Bitmap image;
        private static EngravingDirection engravingDirection;
        private static int feedRate;
        private static float maxPower;
        private static float minPower;
        private static double powerIncrement;
        private static double one_pix = 0.26;

        public GCodeCreator(
                string __absolutePathToImage,
                EngravingDirection __engravingDirection,
                int __feedRate,
                float __minPower,
                float __maxPower
            )
        {
            image = new Bitmap(__absolutePathToImage);
            engravingDirection = __engravingDirection;
            feedRate = __feedRate;
            maxPower = __maxPower;
            minPower = __minPower;
            powerIncrement = (maxPower - minPower) / 255;
        }

        public List<string> toGCode()
        {
            List<string> gcode = new List<string>();
            switch (engravingDirection)
            {
                case EngravingDirection.Horizontal:
                    {
                        horizontal(gcode, image);
                        break;
                    }
                case EngravingDirection.Vertical:
                    {
                        vertical(gcode, image);
                        break;
                    }
                case EngravingDirection.Vector:
                    {
                        vector(gcode, image);
                        break;
                    }
            }

            return gcode;
        }

        static void horizontal(List<string> gcode, Bitmap bmp)
        {
            for(int y = 0; y < bmp.Height; y++)
            {
                for(int x = 0; x < bmp.Width; x++)
                {
                    Color color = bmp.GetPixel(x, y);
                    float colour = (color.R + color.G + color.B);
                    float col = colour / 3;
                    double coefficient = Math.Round(col, MidpointRounding.AwayFromZero);
                    double power = Math.Round(minPower + (255 - coefficient) * powerIncrement, 2);

                    gcode.Add("M03 S" + power);
                    gcode.Add("G01 X" + x * one_pix + " Y" + y * one_pix + $" F{feedRate}");
                }
            }
        }

        static void vertical(List<string> gcode, Bitmap bmp)
        {
            for (int x = 0; x < bmp.Width; x++)
            {
                for (int y = 0; y < bmp.Height; y++)
                {
                    Color color = bmp.GetPixel(x, y);
                    float colour = (color.R + color.G + color.B);
                    float col = colour / 3;
                    double coefficient = Math.Round(col, MidpointRounding.AwayFromZero);
                    double power = Math.Round(minPower + (255 - coefficient) * powerIncrement, 2);

                    gcode.Add("M03 S" + power);
                    gcode.Add("G01 X" + x * one_pix + " Y" + y * one_pix + $" F{feedRate}");
                }
            }
        }

        static void vector(List<string> gcode, Bitmap bmp)
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
                        lower_pixels.Add("G01 X" + x * one_pix  + " Y" + y * one_pix  + $" F{feedRate}");
                        first_black_pixel_in_column = false;
                    }
                    if (y < bmp.Height - 1)
                    {
                        if (bmp.GetPixel(x, y + 1) == Color.FromArgb(255, Color.White) && bmp.GetPixel(x, y) == Color.FromArgb(255, Color.Black))
                        {
                            //Console.WriteLine("Upper");
                            gcode.Add("G01 X" + x * one_pix  + " Y" + y * one_pix  + $" F{feedRate}");
                            first_black_pixel_in_column = true;
                            if (first)
                            {
                                first_pixel_coordinates = "G01 X" + x * one_pix + " Y" + y * one_pix + $" F{feedRate}";
                                first = false;
                            }
                        }
                    }
                }
            }
            for(int i = lower_pixels.Count - 1; i >= 0; i--)
            {
                gcode.Add(lower_pixels[i]);
            }
            gcode.Add(first_pixel_coordinates);
        }
    }
}
