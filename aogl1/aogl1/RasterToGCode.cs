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
        private int FeedRate;
        private static float MaxPower;
        private static float MinPower;
        private static double PowerInc;
        private static Bitmap Image;

        private const double PixDim = 0.26;

        public enum Style { Vertical, Horizontal, OnlyBlack }
        private static Style _Style;

        public List<string> FinalGCode { get; }



        public RasterToGCode(
            int ctorArg_FeedRate, 
            float ctorArg_MinPower,
            float ctorArg_MaxPower,
            Bitmap ctorArg_Bitmap,
            Style ctorArg_Style
            )
        {
            FeedRate = ctorArg_FeedRate;
            MaxPower = ctorArg_MaxPower;
            MinPower = ctorArg_MinPower;
            PowerInc = (MaxPower - MinPower) / 255;
            _Style = ctorArg_Style;

            Bitmap ColorImage = ctorArg_Bitmap;
            Bitmap GrayScale = new Bitmap(ColorImage.Width, ColorImage.Height);
            for (int i = 0; i < ColorImage.Width; i++)
            {
                for (int x = 0; x < ColorImage.Height; x++)
                {
                    Color oc = ColorImage.GetPixel(i, x);
                    int grayScale = (int)((oc.R * 0.3) + (oc.G * 0.59) + (oc.B * 0.11));
                    Color nc = Color.FromArgb(oc.A, grayScale, grayScale, grayScale);
                    GrayScale.SetPixel(i, x, nc);
                }
            }
            Image = GrayScale;

            FinalGCode = new List<string>();
            switch (_Style)
            {
                case Style.Horizontal: {
                        FinalGCode = this.Horizontal(new List<string>());
                        break; }
                case Style.Vertical: {
                        FinalGCode = this.Vertical(new List<string>());
                        break; }
                case Style.OnlyBlack: {
                        FinalGCode = this.OnlyBlack(new List<string>());
                        break; }
                default:
                    {
                        FinalGCode = this.Horizontal(new List<string>());
                        break;
                    }
            }
        }
        public static Style ParseStyle(string _Style)
        {
            switch (_Style)
            {
                case "Horizontal": { return Style.Horizontal; break; }
                case "Vertical": { return Style.Vertical; break; }
                case "OnlyBlack": { return Style.OnlyBlack; break; }
                default: { return Style.Horizontal; break; }
            }
        }

        private List<string> Horizontal(List<string> GCode)
        {
            GCode.Add("M05 S0");
            GCode.Add("G90");
            GCode.Add("G21");

            bool first = true;
            bool start_line = true;

            for(int y = Image.Height - 1; y >= 0; y--)
            {
                for(int x = 0; x < Image.Width; x++)
                {
                    Color color = Image.GetPixel(x, y);
                    float colour = (color.R + color.G + color.B);
                    float col = colour / 3;
                    double coefficient = Math.Round(col, MidpointRounding.AwayFromZero);
                    double power = Math.Round(MinPower + (255 - coefficient) * PowerInc, 2);
                    if (first)
                    {
                        GCode.Add(
                            String.Format(
                                "G01 X{0} Y{1} M3 S{2} F{3}",
                                x * PixDim,
                                (Image.Height - y - 1),
                                power,
                                FeedRate
                                )
                            );

                        first = false;
                        continue;
                    }

                    if (start_line)
                    {
                        GCode.Add(
                            String.Format(
                                "G01 X{0} Y{1} M3 S{2} F{3}",
                                x * PixDim,
                                (Image.Height - y - 1),
                                power,
                                FeedRate
                                )
                            );
                        start_line = false;
                    }
                    else
                    {
                        GCode.Add(
                            String.Format(
                                "G01 X{0} Y{1} M3 S{2} F{3}",
                                x * PixDim,
                                (Image.Height - y - 1),
                                power,
                                FeedRate
                                )
                            );
                    }
                }
                GCode.Add("M05 S0");
                GCode.Add("G0 X0 Y0");
                start_line = true;
            }

            return GCode;
        }

        private List<string> Vertical(List<string> GCode)
        {
            GCode.Add("M05 S0");
            GCode.Add("G90");
            GCode.Add("G21");

            bool first = true;
            bool start_line = true;

            for (int x = 0; x < Image.Width; x++)
            {
                //startline
                for (int y = Image.Height - 1; y >= 0; y--)
                {
                    Color color = Image.GetPixel(x, y);
                    float colour = (color.R + color.G + color.B);
                    float col = colour / 3;
                    double coefficient = Math.Round(col, MidpointRounding.AwayFromZero);
                    double power = Math.Round(MinPower + (255 - coefficient) * PowerInc, 2);
                    if (first)
                    {
                        GCode.Add(
                            String.Format(
                                "G01 X{0} Y{1} M3 S{2} F{3}",
                                x * PixDim,
                                (Image.Height - y - 1),
                                power,
                                FeedRate
                                )
                            );
                        first = false;
                        continue;
                    }

                    if (start_line)
                    {
                        GCode.Add(
                            String.Format(
                                "G01 X{0} Y{1} M3 S{2} F{3}",
                                x * PixDim,
                                (Image.Height - y - 1),
                                power,
                                FeedRate
                                )
                            );
                        start_line = false;
                    }
                    else
                    {
                        GCode.Add(
                            String.Format(
                                "G01 X{0} Y{1} M3 S{2} F{3}",
                                x * PixDim,
                                (Image.Height - y - 1),
                                power,
                                FeedRate
                                )
                            );
                    }

                }
                GCode.Add("M05 S0");
                GCode.Add("G0 X0 Y0");
                start_line = true;
            }

            return GCode;
        }



        private List<string> OnlyBlack(List<string> GCode)
        {
            GCode.Add("M05 S0");
            GCode.Add("G90");
            GCode.Add("G21");

            bool first = true;
            bool first_white = true;
            bool first_black = true;
            bool start_line = false;
            bool white = false;

            for(int y = Image.Height - 1; y >= 0; y--)
            {
                //startline
                for(int x = 0; x< Image.Width; x++)
                {
                    Color color = Image.GetPixel(x, y);
                    if(Convert.ToInt32(color.R) < 40) 
                    {
                        if (first)
                        {
                            GCode.Add(
                                String.Format(
                                    "G01 X{0} Y{1} M3 S{2} F{3}",
                                    x * PixDim,
                                    (Image.Height - y - 1),
                                    MaxPower,
                                    FeedRate
                                    )
                                );
                            first = false;
                            first_black = false;
                            continue;
                        }
                        else
                        {
                            if (first_black)
                            {
                                first_black = false;
                                first_white = true;
                                GCode.Add(
                                String.Format(
                                    "G01 X{0} Y{1} M3 S{2} F{3}",
                                    x * PixDim,
                                    (Image.Height - y - 1),
                                    MaxPower,
                                    FeedRate
                                    )
                                );
                            }
                            else
                            {
                                if (start_line)
                                {
                                    GCode.Add(
                                        String.Format(
                                            "G01 X{0} Y{1} M3 S{2} F{3}",
                                            x * PixDim,
                                            (Image.Height - y - 1),
                                            MaxPower,
                                            FeedRate
                                            )
                                        );
                                    start_line = false;
                                }
                                else
                                {
                                    GCode.Add(
                                        String.Format(
                                            "G01 X{0} Y{1} M3 S{2} F{3}",
                                            x * PixDim,
                                            (Image.Height - y - 1),
                                            MaxPower,
                                            FeedRate
                                            )
                                        );
                                }
                            }
                        }
                    }
                    else
                    {
                        if (first_white && !first)
                        {
                            GCode.Add("M05 S0");
                            
                            first_white = false;
                            first_black = true;
                            white = true;
                        }
                    }
                }
                if (white)
                {
                    //...
                }
                else
                {
                    GCode.Add("M05 S0");
                }
                start_line = true;
            }

            return GCode;
        }

    }
}
