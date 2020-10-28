using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Linq;
using System.Text.RegularExpressions;
using System.CodeDom.Compiler;

namespace GCodeFromImage
{
    class VectorToGcode
    {
        static double temp_x = 0;
        static double temp_y = 0;
        static string temp = "";
        static void main(String[] args)
        {
            try
            {
                XDocument svgFile = XDocument.Load(@"C:\\Users\\Bohdan\\Desktop\\politechnika-lubelska_gray.svg");
                String file = @"C:\\Users\\Bohdan\\Desktop\\test.gcode"; //path to new gcode file


                using (var stream = new FileStream(file, FileMode.CreateNew)) //creation gcode file
                { }
                using var writer = new StreamWriter(file);

                svg_parser(writer, svgFile);


            }
            catch (FileNotFoundException e)
            {

            }

        }

        public static void svg_parser(StreamWriter writer, XDocument svgFile)
        {

            string separators = @"(?=[MZLHVCSQTAmzlhvcsqta])";
            XElement svgElement = svgFile.Root;
            StringBuilder sb = new StringBuilder();
            IEnumerable<XElement> path_el = from el1 in svgElement.Elements("{http://www.w3.org/2000/svg}g")
                                            select el1;

            foreach(XElement el1 in path_el)
            {
                IEnumerable<XElement> path_el1 = from el2 in el1.Elements("{http://www.w3.org/2000/svg}path")
                                                 select el2;
                foreach(XElement el2 in path_el1)
                {
                    var tokens = Regex.Split(el2.Attribute("d").Value, separators).Where(t => !string.IsNullOrEmpty(t));
                    foreach (string token in tokens)
                    {

                        List<string> path = new List<string>();
                        path = token.Split(' ').ToList();
                        if(temp is "Z" || temp is "z")
                        {
                            temp = path[0];
                            continue;
                        }
                        else
                        {
                            temp = path[0];
                            commands(path, writer);
                        }
                        
                    }
                }
            }

            

        }

        private static void commands(List<string> path, StreamWriter writer)
        {

            if(path[0] is "M" || path[0] is "m")
            {
                writer.WriteLine("G01 X" + path[1] + " Y" + path[2] + " F200");
                writer.WriteLine("G4 P0");
                writer.WriteLine("M03 S255");
                writer.WriteLine("G4 P0");
                writer.WriteLine("G1 F750.000000");

                temp_x = Convert.ToDouble(path[1]);
                temp_y = Convert.ToDouble(path[2]);
            }

            if (path[0] is "C" || path[0] is "c")
            {
                bezier_curve(writer, temp_x, temp_y, Convert.ToDouble(path[1]), Convert.ToDouble(path[2]), Convert.ToDouble(path[3]), Convert.ToDouble(path[4]), Convert.ToDouble(path[5]), Convert.ToDouble(path[6]));
                temp_x = Convert.ToDouble(path[5]);
                temp_y = Convert.ToDouble(path[6]);
            }

            if (path[0] is "Z" || path[0] is "z")
            {
                writer.WriteLine("G4 P0");
                writer.WriteLine("M05 S0");
                writer.WriteLine("G1 F3000");
            }

            if (path[0] is "L" || path[0] is "l")
            {
                writer.WriteLine("G01 X" + path[1] + " Y" + path[2] + " F200");
            }
        }

        private static void bezier_curve(StreamWriter writer, double p0x, double p0y, double p1x, double p1y, double p2x, double p2y, double p3x, double p3y)
        {
            int subdivides = 10;
            double t = 0.0;
            //double p0x = 175.664062, p0y = 0, p1x = 198.660156, p1y = 0, p2x = 221.644531, p2y = 4.570312, p3x = 242.890625, p3y = 13.371094;

            /*writer.WriteLine("M05 S0");
            writer.WriteLine("G90");
            writer.WriteLine("G21");
            writer.WriteLine("G1 F3000");*/
            writer.WriteLine("G01 X" + p0x + " Y" + p0y + " F200");
            /*writer.WriteLine("G4 P0");
            writer.WriteLine("M03 S255");
            writer.WriteLine("G4 P0");
            writer.WriteLine("G1 F750.000000");*/

            for (float i=1; i<=subdivides; i++)
            {
                t = 1.0 * (i / subdivides);
                var points = Bt(t, p0x, p0y, p1x, p1y, p2x, p2y, p3x, p3y, writer);

                writer.WriteLine("G01 X" + points[0] + " Y" + points[1] + " F200");
            }
            /*writer.WriteLine("G4 P0");
            writer.WriteLine("M05 S0");
            writer.WriteLine("G1 F3000");
            writer.WriteLine("G1 X0 Y0");*/
        }

        private static double[] Bt(double t, double p0x, double p0y, double p1x, double p1y, double p2x, double p2y, double p3x, double p3y, StreamWriter writer)
        {
            double btx = 0;
            double bty = 0;
            var btp0 = Btp0(t, p0x, p0y);
            var btp1 = Btp1(t, p1x, p1y);
            var btp2 = Btp2(t, p2x, p2y);
            var btp3 = Btp3(t, p3x, p3y);

            btx = btp0[0] + btp1[0] + btp2[0] + btp3[0];
            bty = btp0[1] + btp1[1] + btp2[1] + btp3[1];

            double[] points = new double[2] { btx, bty };
            return points;

        }

        private static double[] Btp0(double t, double p0x, double p0y)
        {
            double btp0x = 0;
            double btp0y = 0;

            var k = 1 - t;

            //btp0x = Math.Pow((1 - t), 3) * p0x;
            //btp0y = Math.Pow((1 - t), 3) * p0y;
            btp0x = k * k * k * p0x;
            btp0y = k * k * k * p0y;

            double[] btp0 = new double[2] { btp0x, btp0y };
            return btp0;
        }
        
        private static double[] Btp1(double t, double p1x, double p1y)
        {
            double btp1x = 0;
            double btp1y = 0;

            var k = 1 - t;

            //btp1x = 3 * t * Math.Pow((1 - t), 2) * p1x;
            //btp1y = 3 * t * Math.Pow((1 - t), 2) * p1y;

            btp1x = 3 * t * k * k * p1x;
            btp1y = 3 * t * k * k * p1y;

            double[] btp1 = new double[2] { btp1x, btp1y };
            return btp1;
        }

        private static double[] Btp2(double t, double p2x, double p2y)
        {
            double btp2x = 0;
            double btp2y = 0;

            var k = 1 - t;

            //btp2x = Math.Pow((3 * t), 2) * (1 - t) * p2x;
            //btp2y = Math.Pow((3 * t), 2) * (1 - t) * p2y;

            btp2x = 3 * t * t * k * p2x;
            btp2y = 3 * t * t * k * p2y;

            double[] btp2 = new double[2] { btp2x, btp2y };
            return btp2;
        }

        private static double[] Btp3(double t, double p3x, double p3y)
        {
            double btp3x = 0;
            double btp3y = 0;

            var k = 1 - t;

            //btp3x = Math.Pow(t, 3) * p3x;
            //btp3y = Math.Pow(t, 3) * p3y;

            btp3x = t * t * t * p3x;
            btp3y = t * t * t * p3y;

            double[] btp3 = new double[2] { btp3x, btp3y };
            return btp3;
        }
    }
}
