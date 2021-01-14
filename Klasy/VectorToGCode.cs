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
using System.Security.Cryptography;
using System.Numerics;

namespace GCodeFromImage
{
    class VectorToGcode
    {
        static double temp_x = 0;
        static double temp_y = 0;
        static double temp_X1 = 0;
        static double temp_Y2 = 0;
        static double temp_XQ = 0;
        static double temp_YQ = 0;
        static char temp = ' ';
        static double globalMaxX = 0 ;
        static double globalMinX = 0 ;
        static double globalMaxY = 0;
        static double globalMinY = 0;
        static double cX = 0;
        static double cY = 0;
        static List<double> x = new List<double>();
        static List<double> y = new List<double>();
        static double startPathX = 0;
        static double startPathY = 0;
        static double global_width = 0;
        static double global_height = 0;
        private static double one_pix = 0.26;


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
            string argSeparators = @"[\s,]|(?=(?<!e)-)"; ;
            string argSeparatorsE = @"[\s,]|(?=-)";

            XElement svgElement = svgFile.Root;
            StringBuilder sb = new StringBuilder();

            XElement s = svgFile.Root;
            var height = " ";
            var width = " ";
            var attributes = s.Attributes();

            if(s.Attribute("height") != null)
            {
                height = s.Attribute("height").Value;
            }
            if (s.Attribute("width") != null)
            {
                width = s.Attribute("width").Value;
            }
            var charsToRemove = new string[] { "p", "x", "t" };

            foreach (var c in charsToRemove)
            {
                height = height.Replace(c, string.Empty);
            }
            foreach (var c in charsToRemove)
            {
                width = width.Replace(c, string.Empty);
            }

            if(height != " ")
            {
                global_height = Convert.ToDouble(height);
            }
            if(width != " ")
            {
                global_width = Convert.ToDouble(width);
            }
            



            IEnumerable < XElement > path_el = from el1 in svgElement.Descendants("{http://www.w3.org/2000/svg}path")
                                               select el1;

            IEnumerable<XElement> circle_el = from el_c in svgElement.Descendants("{http://www.w3.org/2000/svg}circle")
                                            select el_c;

            IEnumerable<XElement> ellipse_el = from el_e in svgElement.Descendants("{http://www.w3.org/2000/svg}ellipse")
                                            select el_e;

            IEnumerable<XElement> line_el = from el_l in svgElement.Descendants("{http://www.w3.org/2000/svg}line")
                                            select el_l;

            IEnumerable<XElement> polyline_el = from el_pl in svgElement.Descendants("{http://www.w3.org/2000/svg}polyline")
                                            select el_pl;

            IEnumerable<XElement> polygon_el = from el_pg in svgElement.Descendants("{http://www.w3.org/2000/svg}polygon")
                                            select el_pg;

            IEnumerable<XElement> rectangle_el = from el_r in svgElement.Descendants("{http://www.w3.org/2000/svg}rect")
                                            select el_r;

            x.Add(69439);
            y.Add(69439);

            if(circle_el.Count() != 0)
            {
                circle(writer, circle_el);
            }

            if (ellipse_el.Count() != 0)
            {
                ellipse(writer, ellipse_el);
            }

            if (line_el.Count() != 0)
            {
                line(writer, line_el);
            }

            if (polyline_el.Count() != 0)
            {
                polyline(writer, polyline_el);
            }

            if (polygon_el.Count() != 0)
            {
                polygon(writer, polygon_el);
            }

            if (rectangle_el.Count() != 0)
            {
                rectangle(writer, rectangle_el);
            }

            if(path_el.Count() != 0)
            {
                foreach (XElement el1 in path_el)
                {

                    var tokens = Regex.Split(el1.Attribute("d").Value, separators).Where(t => !string.IsNullOrEmpty(t));


                    foreach (string token in tokens)
                    {
                        
                        var cmd = ' ';
                        List<double> path = new List<double>();

                        try
                        {
                            cmd = token.Take(1).Single();
                            string remainingargs = token.Substring(1);
                            var splitArgs = Regex
                                .Split(remainingargs, argSeparators)
                                .Where(t => !string.IsNullOrEmpty(t));


                            path = splitArgs.Select(arg => double.Parse(arg)).ToList();
                        }
                        catch
                        {

                            /*cmd = token.Take(1).Single();
                            string remainingargs = token.Substring(1);
                            var splitArgs = Regex
                                .Split(remainingargs, argSeparatorsE)
                                .Where(t => !string.IsNullOrEmpty(t));

                            List<string> arguments = new List<string>();
                            arguments = splitArgs.ToList();
                            List<string> argumentsAll = new List<string>();
                            string temp = " ";

                            foreach(string arg in arguments)
                            {
                                if(arg.Last() == 'e')
                                {
                                    temp = arg;
                                }
                                else
                                {
                                    if(temp.Last() == 'e')
                                    {
                                        argumentsAll.Add(temp + arg);
                                        temp = " ";
                                    }
                                    else
                                    {
                                        argumentsAll.Add(arg);
                                    }
                                }
                                
                            }

                            path = argumentsAll.Select(arg => double.Parse(arg)).ToList();*/
                            writer.WriteLine("ERROR");
                        }


                        
                        /*if (temp is 'Z' || temp is 'z')
                        {
                            temp = cmd;
                            continue;
                        }
                        else
                        {
                            temp = cmd;
                            commands(path, writer, cmd);
                        }*/
                        commands(path, writer, cmd);

                      

                    }
                    startPathX = 0;
                    startPathY = 0;
                    x.Add(69420);
                    y.Add(69420);
                    temp_x = 0;
                    temp_y = 0;


                }
                
            }
            code(writer);
        }

        private static void commands(List<double> path, StreamWriter writer, char cmd)
        {

            if (cmd is 'M')
            {

                if(path.Count() > 2)
                {
                    for(int i = 0; i < path.Count(); i += 2)
                    {
                        if(i == 0)
                        {
                            x.Add((path[i]));
                            y.Add(mirror(path[i + 1]));
                            x.Add(69421);
                            y.Add(69421);

                            temp_x = Convert.ToDouble(path[i]) - cX;
                            temp_y = mirror(path[i + 1]) - cY;
                            startPathX = path[i];
                            startPathY = mirror(path[i + 1]);
                        }
                        else
                        {
                            x.Add((path[i]));
                            y.Add(mirror(path[i + 1]));


                            temp_x = Convert.ToDouble(path[i]) - cX;
                            temp_y = mirror(path[i + 1]) - cY;
                            startPathX = path[i];
                            startPathY = mirror(path[i + 1]);
                        }
                    }
                }
                else
                {
                    x.Add((path[0]));
                    y.Add(mirror(path[1]));
                    x.Add(69421);
                    y.Add(69421);

                    temp_x = Convert.ToDouble(path[0]) - cX;
                    temp_y = mirror(path[1]) - cY;
                    startPathX = path[0];
                    startPathY = mirror(path[1]);
                }
            } //start

            if(cmd is 'm')
            {

                if (path.Count() > 2)
                {
                    for (int i = 0; i < path.Count(); i += 2)
                    {
                        if (i == 0)
                        {
                            x.Add(temp_x + path[i]);
                            y.Add(temp_y + mirror(path[i + 1]));
                            x.Add(69421);
                            y.Add(69421);
                            temp_x = temp_x + Convert.ToDouble(path[i]) - cX;
                            temp_y = temp_y + mirror(path[i + 1]) - cY;
                            startPathX = temp_x + path[i];
                            startPathY = temp_y + mirror(path[i + 1]);
                        }
                        else
                        {
                            x.Add(temp_x + path[i]);
                            y.Add(temp_y + mirror(path[i + 1]));

                            temp_x = temp_x + Convert.ToDouble(path[i]) - cX;
                            temp_y = temp_y + mirror(path[i + 1]) - cY;
                            startPathX = temp_x + path[i];
                            startPathY = temp_y + mirror(path[i + 1]);
                        }
                    }
                }
                else
                {
                    x.Add(temp_x + path[0]);
                    y.Add(temp_y + mirror(path[1]));
                    x.Add(69421);
                    y.Add(69421);
                    temp_x = temp_x + Convert.ToDouble(path[0]) - cX;
                    temp_y = temp_y + mirror(path[1]) - cY;
                    startPathX = temp_x + path[0];
                    startPathY = temp_y + mirror(path[1]);
                }

            }

            if (cmd is 'C')
            {
                if(path.Count() > 6)
                {
                    for (int i = 0; i < path.Count(); i += 6)
                    {
                        bezier_curve(writer, temp_x, temp_y, Convert.ToDouble(path[i]) - cX, mirror(path[i+1]) - cY, Convert.ToDouble(path[i+2]) - cX, mirror(path[i + 3]) - cY, Convert.ToDouble(path[i+4]) - cX, mirror(path[i+5]) - cY);
                        temp_x = (Convert.ToDouble(path[i+4])) - cX;
                        temp_y = mirror(path[i+5]) - cY;
                        temp_X1 = Convert.ToDouble(path[i+2]) - cX;
                        temp_Y2 = mirror(path[i+3]) - cY;
                    }
                }
                else
                {
                    bezier_curve(writer, temp_x, temp_y, Convert.ToDouble(path[0]) - cX, mirror(path[1]) - cY, Convert.ToDouble(path[2]) - cX, mirror(path[3]) - cY, Convert.ToDouble(path[4]) - cX, mirror(path[5]) - cY);
                    temp_x = (Convert.ToDouble(path[4])) - cX;
                    temp_y = mirror(path[5]) - cY;
                    temp_X1 = Convert.ToDouble(path[2]) - cX;
                    temp_Y2 = mirror(path[3]) - cY;
                }
                
            } // cubic bezier curve

            if (cmd is 'c')
            {
                if (path.Count() > 6)
                {
                    for (int i = 0; i < path.Count(); i += 6)
                    {
                        bezier_curve(writer, temp_x, temp_y, temp_x + Convert.ToDouble(path[i]), temp_y + mirror(path[i+1]), temp_x + Convert.ToDouble(path[i+2]), temp_y + mirror(path[i+3]), temp_x + Convert.ToDouble(path[i+4]), temp_y + mirror(path[i+5]));
                        temp_X1 = temp_x + Convert.ToDouble(path[i+2]);
                        temp_Y2 = temp_y + mirror(path[i+3]);
                        temp_x = temp_x + Convert.ToDouble(path[i+4]);
                        temp_y = temp_y + mirror(path[i+5]);
                    }
                }
                else
                {
                    bezier_curve(writer, temp_x, temp_y, temp_x + Convert.ToDouble(path[0]), temp_y + mirror(path[1]), temp_x + Convert.ToDouble(path[2]), temp_y + mirror(path[3]), temp_x + Convert.ToDouble(path[4]), temp_y + mirror(path[5]));
                    temp_X1 = temp_x + Convert.ToDouble(path[2]);
                    temp_Y2 = temp_y + mirror(path[3]);
                    temp_x = temp_x + Convert.ToDouble(path[4]);
                    temp_y = temp_y + mirror(path[5]);
                }

                

            }

            if (cmd is 'Z' || cmd is 'z')
            {
                //x.Add(startPathX);
                //y.Add(startPathY);
                x.Add(69420);
                y.Add(69420);
            } //stop

            if (cmd is 'L')
            {
                if(path.Count() > 2)
                {
                    for(int i=0; i<path.Count(); i += 2)
                    {
                        x.Add((path[i] - cX));
                        y.Add((mirror(path[i+1]) - cY));
                        temp_x = path[i] - cX;
                        temp_y = mirror(path[i+1]) - cY;
                    }
                }
                else
                {
                    x.Add((path[0] - cX));
                    y.Add((mirror(path[1]) - cY));
                    temp_x = path[0] - cX;
                    temp_y = mirror(path[1]) - cY;
                }

            } //line

            if (cmd is 'l')
            {
                if (path.Count() > 2)
                {
                    for (int i = 0; i < path.Count(); i += 2)
                    {
                        temp_x = temp_x + Convert.ToDouble(path[i]);
                        temp_y = temp_y + mirror(path[i+1]);

                        x.Add((temp_x));
                        y.Add((temp_y));
                    }
                }
                else
                {
                    temp_x = temp_x + Convert.ToDouble(path[0]);
                    temp_y = temp_y + mirror(path[1]);

                    x.Add((temp_x));
                    y.Add((temp_y));
                }

            }

            if (cmd is 'S')
            {
                bezier_curve(writer, temp_x, temp_y, temp_x + (temp_x - temp_X1), temp_y + (temp_y - temp_Y2), Convert.ToDouble(path[0]) - cX, mirror(path[1]) - cY, Convert.ToDouble(path[2]) - cX, mirror(path[3]) - cY);
                temp_x = Convert.ToDouble(path[2]) - cX;
                temp_y = mirror(path[3]) - cY;
            } //smoth cubic bezier curve

            if (cmd is 's')
            {
                ///writer.WriteLine("SX:" + temp_x + "; Y:" + temp_y + "; X1:" + temp_X1 + "; Y1:" + temp_Y2 + "; X2:" + (temp_x + Convert.ToDouble(path[0])) + "; Y2:" + (temp_y + mirror(path[1])) + "; X3:" + (temp_x + Convert.ToDouble(path[2])) + "; Y3:" + (temp_y + mirror(path[3])));
                bezier_curve(writer, temp_x, temp_y, temp_x + (temp_x - temp_X1), temp_y + (temp_y - temp_Y2), temp_x + Convert.ToDouble(path[0]), temp_y + mirror(path[1]) , temp_x + Convert.ToDouble(path[2]) , temp_y + mirror(path[3]) );
                temp_x = temp_x + Convert.ToDouble(path[2]) ;
                temp_y = temp_y + mirror(path[3]) ;
            }

            if(cmd is 'Q')
            {
                if(path.Count() > 4)
                {
                    for (int i = 0; i < path.Count(); i += 4)
                    {
                        quadratic_bezier_curve(writer, temp_x, temp_y, path[i], mirror(path[i+1]), path[i+2], mirror(path[i+3]));
                        temp_x = path[i+2];
                        temp_y = mirror(path[i+3]);
                        temp_XQ = path[i];
                        temp_YQ = mirror(path[i+1]);
                    }
                }
                else
                {
                    quadratic_bezier_curve(writer, temp_x, temp_y, path[0], mirror(path[1]), path[2], mirror(path[3]));
                    temp_x = path[2];
                    temp_y = mirror(path[3]);
                    temp_XQ = path[0];
                    temp_YQ = mirror(path[1]);
                }

            } // qudratic bezier curve
            if(cmd is 'q')
            {
                if (path.Count() > 4)
                {
                    for (int i = 0; i < path.Count(); i += 4)
                    {
                        quadratic_bezier_curve(writer, temp_x, temp_y, temp_x + path[i], temp_y + mirror(path[i+1]), temp_x + path[i+2], temp_y + mirror(path[i+3]));
                        temp_x = temp_x + path[i+2];
                        temp_y = temp_y + mirror(path[i+3]);
                        temp_XQ = temp_x + path[i];
                        temp_YQ = temp_y + mirror(path[i+1]);
                    }
                }
                else
                {
                    quadratic_bezier_curve(writer, temp_x, temp_y, temp_x + path[0], temp_y + mirror(path[1]), temp_x + path[2], temp_y + mirror(path[3]));
                    temp_x = temp_x + path[2];
                    temp_y = temp_y + mirror(path[3]);
                    temp_XQ = temp_x + path[0];
                    temp_YQ = temp_y + mirror(path[1]);
                }
                
            }

            if(cmd is 'T')
            {
                quadratic_bezier_curve(writer, temp_x, temp_y, temp_x + (temp_x - temp_XQ), temp_y + (temp_y - temp_YQ),  path[0], mirror(path[1]));
                temp_x = temp_x + path[0];
                temp_y = temp_y + mirror(path[1]);

            } //smoth quadratic bezier curve
            if(cmd is 't')
            {
                quadratic_bezier_curve(writer, temp_x, temp_y, temp_x + (temp_x - temp_XQ), temp_y + (temp_y - temp_YQ), temp_x + path[0], temp_y + mirror(path[1]));
                temp_x = temp_x + path[0];
                temp_y = temp_y + mirror(path[1]);

            }

            if (cmd is 'H')
            {
                if(path.Count() > 1)
                {
                    for(int i = 0; i<path.Count(); i++)
                    {
                        x.Add((path[i] - cX));
                        y.Add(temp_y);
                        temp_x = path[i] - cX;
                    }
                }
                else
                {
                    x.Add((path[0] - cX));
                    y.Add(temp_y);
                    temp_x = path[0] - cX;
                }
            } // horizontal line

            if (cmd is 'h')
            {
                if (path.Count() > 1)
                {
                    for (int i = 0; i < path.Count(); i++)
                    {
                        double xx = temp_x + Convert.ToDouble(path[i]);

                        x.Add(xx);
                        y.Add(temp_y);

                        temp_x = xx;
                    }
                }
                else
                {
                    double xx = temp_x + Convert.ToDouble(path[0]);

                    x.Add(xx);
                    y.Add(temp_y);

                    temp_x = xx;
                }

            }

            if (cmd is 'V')
            {
                if (path.Count() > 1)
                {
                    for (int i = 0; i < path.Count(); i++)
                    {
                        x.Add(temp_x);
                        y.Add((mirror(path[i]) - cY));
                        temp_y = (mirror(path[i]) - cY);
                    }
                }
                else
                {
                    x.Add(temp_x);
                    y.Add((mirror(path[0]) - cY));
                    temp_y = (mirror(path[0]) - cY);
                }

            } //vertical line

            if (cmd is 'v')
            {
                if (path.Count() > 1)
                {
                    for (int i = 0; i < path.Count(); i++)
                    {
                        double yy = temp_y + mirror(Convert.ToDouble(path[i]));

                        x.Add(temp_x);
                        y.Add(yy);

                        temp_y = yy;
                    }
                }
                else
                {
                    double yy = temp_y + mirror(Convert.ToDouble(path[0]));

                    x.Add(temp_x);
                    y.Add(yy);

                    temp_y = yy;
                }

            }

            if(cmd is 'A')
            {
                elliptical_arcs(writer, temp_x, temp_y, path[0] * (-1), path[1], path[2] * (-1), path[3], path[4], path[5], mirror(path[6]));
                temp_x = path[5];
                temp_y = mirror(path[6]);
            } // elliptical arcs
            if(cmd is 'a')
            {
                elliptical_arcs(writer, temp_x, temp_y, path[0] * (-1), path[1], path[2] * (-1), path[3], path[4], temp_x + path[5], temp_y + mirror(path[6]));
                temp_x = temp_x + path[5];
                temp_y = temp_y + mirror(path[6]);

            }
        }

        private static void bezier_curve(StreamWriter writer, double p0x, double p0y, double p1x, double p1y, double p2x, double p2y, double p3x, double p3y)
        {
            int subdivides = 10;
            double t = 0.0;


            for (float i=1; i<=subdivides; i++)
            {
                t = 1.0 * (i / subdivides);
                var points = Bt(t, p0x, p0y, p1x, p1y, p2x, p2y, p3x, p3y);


                x.Add(points[0]);
                y.Add(points[1]);
            }

        }

        private static double[] Bt(double t, double p0x, double p0y, double p1x, double p1y, double p2x, double p2y, double p3x, double p3y)
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

            btp3x = t * t * t * p3x;
            btp3y = t * t * t * p3y;

            double[] btp3 = new double[2] { btp3x, btp3y };
            return btp3;
        }

        private static void quadratic_bezier_curve(StreamWriter writer, double p0x, double p0y, double p1x, double p1y, double p2x, double p2y)
        {
            int subdivides = 10;
            double t = 0.0;

            for (float i = 1; i <= subdivides; i++)
            {
                t = 1.0 * (i / subdivides);
                var points = BtQ(t, p0x, p0y, p1x, p1y, p2x, p2y);

                x.Add(points[0]);
                y.Add(points[1]);
            }
        }

        private static double[] BtQ(double t, double p0x, double p0y, double p1x, double p1y, double p2x, double p2y)
        {
            double btqx = 0.0;
            double btqy = 0.0;
            var btpq0 = BtpQ0(t, p0x, p0y);
            var btpq1 = BtpQ1(t, p1x, p1y);
            var btpq2 = BtpQ2(t, p2x, p2y);

            btqx = btpq0[0] + btpq1[0] + btpq2[0];
            btqy = btpq0[1] + btpq1[1] + btpq2[1];

            double[] points = new double[2] { btqx, btqy };
            return points;

        } // Point for quadraticbezier curve

        private static double[] BtpQ0(double t, double p0x, double p0y)
        {
            double btpq0x = 0.0;
            double btpq0y = 0.0;

            var k = 1 - t;

            btpq0x = k * k * p0x;
            btpq0y = k * k * p0y;

            double[] btpq0 = new double[2] { btpq0x, btpq0y };
            return btpq0;
        } 

        private static double[] BtpQ1(double t, double p1x, double p1y)
        {
            double btpq1x = 0.0;
            double btpq1y = 0.0;

            var k = 1 - t;

            btpq1x = 2 * t * k * p1x;
            btpq1y = 2 * t * k * p1y;

            double[] btpq1 = new double[2] { btpq1x, btpq1y };
            return btpq1;
        }

        private static double[] BtpQ2(double t, double p2x, double p2y)
        {
            double btpq2x = 0.0;
            double btpq2y = 0.0;

            btpq2x = t * t * p2x;
            btpq2y = t * t * p2x;

            double[] btpq2 = new double[2] { btpq2x, btpq2y };
            return btpq2;
        }

        private static double mirror(double k)
        {
            return (0 - (k - 0));
        }

        private static void code(StreamWriter writer)
        {
            for(int i=0; i<x.Count(); i++)
            {
                if(x[i] == 69420 && y[i] == 69420)
                {
                    writer.WriteLine("G4 P0");
                    writer.WriteLine("M05 S0");
                    writer.WriteLine("G1 F3000");
                }
                else if(x[i] == 69439 && y[i] == 69439)
                {
                    writer.WriteLine("M05 S0");
                    writer.WriteLine("G90");
                    writer.WriteLine("G21");
                    writer.WriteLine("G1 F3000");
                }
                else if (x[i] == 69421 && y[i] == 69421)
                {
                    writer.WriteLine("G4 P0");
                    writer.WriteLine("M03 S255");
                    writer.WriteLine("G4 P0");
                    writer.WriteLine("G1 F750.000000");
                }
                else
                {
                    writer.WriteLine("G01 X" + (x[i] - x.Min() ) * one_pix + " Y" + (y[i] - y.Min()) * one_pix + " F200");
                   // writer.WriteLine("G01 X" + (x[i] )  + " Y" + (y[i] ) + " F200");

                }

                
            }


        }

        private static void circle(StreamWriter writer, IEnumerable<XElement> circle_el)
        {
            foreach(XElement circle in circle_el)
            {
                double cx = 0;
                double cy = 0;
                if(circle.Attribute("cx") == null)
                {

                }
                else
                {
                    cx = Convert.ToDouble(circle.Attribute("cx").Value);
                }
                if (circle.Attribute("cy") == null)
                {

                }
                else
                {
                    cy = mirror(Convert.ToDouble(circle.Attribute("cy").Value));
                }
                double r = Convert.ToDouble(circle.Attribute("r").Value);
                double xx, yy, c, s;
                double startPointX = r * Math.Cos(0);
                double startPointY = r * Math.Sin(0);
                double rx = startPointX - cx;
                double ry = startPointY - cy;

                x.Add(startPointX);
                y.Add(startPointY);

                for (double i = 0.1; i < 6.2; i += 0.1)
                {
                    c = Math.Cos(i);
                    s = Math.Sin(i);
                    xx = cx + rx * c - ry * s;
                    yy = cy + rx * s + ry * c;
                    x.Add(xx);
                    y.Add(yy);
                }

                x.Add(startPointX);
                y.Add(startPointY);
                x.Add(69420);
                y.Add(69420);
            }
        }

        private static void ellipse(StreamWriter writer, IEnumerable<XElement> ellipse_el)
        {
            foreach (XElement ellipse in ellipse_el)
            {
                double cx = 0;
                double cy = 0;
                if (ellipse.Attribute("cx") == null)
                {

                }
                else
                {
                    cx = Convert.ToDouble(ellipse.Attribute("cx").Value);
                }
                if (ellipse.Attribute("cy") == null)
                {

                }
                else
                {
                    cy = mirror(Convert.ToDouble(ellipse.Attribute("cy").Value));
                }
                double rx = Convert.ToDouble(ellipse.Attribute("rx").Value);
                double ry = Convert.ToDouble(ellipse.Attribute("ry").Value);

                for (int i = 0; i < 360; i++)
                {
                    double psi = (i * 3.14159f / 180.0f);
                    double fi = Math.Atan2(rx * Math.Sin(psi), ry * Math.Cos(psi));
                    double xx = cx + (double)((rx * Math.Cos(fi)));
                    double yy = cy + (double)(ry * Math.Sin(fi));

                    x.Add(xx);
                    y.Add(yy);
                }

                x.Add(69420);
                y.Add(69420);
            }
        }

        private static void rectangle(StreamWriter writer, IEnumerable<XElement> rectangle_el)
        {
            double xx = 0;
            double yy = 0;
            double width;
            double height;

            foreach (XElement rectangle in rectangle_el)
            {
                if(rectangle.Attribute("x") != null)
                {
                    xx = Convert.ToDouble(rectangle.Attribute("x").Value);
                }
                if (rectangle.Attribute("y") != null)
                {
                    yy = Convert.ToDouble(rectangle.Attribute("y").Value);
                }


                width = Convert.ToDouble(rectangle.Attribute("width").Value);
                height = Convert.ToDouble(rectangle.Attribute("height").Value);

                double startPointx = xx;
                double startPointy = yy;
                double secondPointx = xx + width;
                double secondPointy = startPointy;
                double thirdPointx = secondPointx;
                double thirdPointy = secondPointy + height;
                double fourthPointx = startPointx;
                double fourthPointy = startPointy + height;

                if(rectangle.Attribute("transform") != null)
                {
                    transform(writer, rectangle.Attribute("transform").Value, startPointx, startPointy, secondPointx, secondPointy, thirdPointx, thirdPointy, fourthPointx, fourthPointy);
                }
                else
                {
                    x.Add(startPointx);
                    y.Add(mirror(startPointy));
                    x.Add(secondPointx);
                    y.Add(mirror(secondPointy));
                    x.Add(thirdPointx);
                    y.Add(mirror(thirdPointy));
                    x.Add(fourthPointx);
                    y.Add(mirror(fourthPointy));
                    x.Add(startPointx);
                    y.Add(mirror(startPointy));
                }

            }
        }

        private static void line(StreamWriter writer, IEnumerable<XElement> line_el)
        {
            foreach (XElement line in line_el)
            {
                double x1 = Convert.ToDouble(line.Attribute("x1").Value);
                double y1 = Convert.ToDouble(line.Attribute("y1").Value);
                double x2 = Convert.ToDouble(line.Attribute("x2").Value);
                double y2 = Convert.ToDouble(line.Attribute("y2").Value);

                x.Add(x1);
                y.Add(mirror(y1));
                x.Add(x2);
                y.Add(mirror(y2));
                x.Add(69420);
                y.Add(69420);
            }

        }

        private static void polygon(StreamWriter writer, IEnumerable<XElement> polygon_el)
        {
            string argSeparators = @"[\s,]|(?=(?<!e)-)";
            foreach (XElement polygon in polygon_el)
            {
                var splitArgs = Regex.Split(polygon.Attribute("points").Value, argSeparators).Where(t => !string.IsNullOrEmpty(t));
                List<double> points = new List<double>();
                points = splitArgs.Select(arg => double.Parse(arg)).ToList();
                double startX = 0;
                double startY = 0;
                
                for(int i=0; i<points.Count; i += 2)
                {
                    if(i == 0)
                    {
                        startX = points[i];
                        startY = mirror(points[i + 1]);
                    }
                    x.Add(points[i]);
                    y.Add(mirror(points[i+1]));
                }

                x.Add(startX);
                y.Add(startY);
                x.Add(69420);
                y.Add(69420);
            }
        }

        private static void elliptical_arcs(StreamWriter writer, double x1, double y1, double rx, double ry, double x_axis_rotation, double large_arc_flag, double sweep_flag, double x2, double y2)
        {
            
            double root;
            double sinPhi = Math.Sin(x_axis_rotation * Math.PI / 180.0);
            double cosPhi = Math.Cos(x_axis_rotation * Math.PI / 180.0);
            double x1Prime = cosPhi * (x1 - x2) / 2.0 + sinPhi * (y1 - y2) / 2.0;
            double y1Prime = -sinPhi * (x1 - x2) / 2.0 + cosPhi * (y1 - y2) / 2.0;
            double numerator = rx * rx * ry * ry - rx * rx * y1Prime * y1Prime - ry * ry * x1Prime * x1Prime;
            double radiusX = rx;
            double radiusY = ry;

            if(numerator < 0.0)
            {
                double s = Math.Sqrt(1.0 - numerator / (rx * rx * ry * ry));

                radiusX *= s;
                radiusY *= s;
                root = 0.0;
            }
            else
            {
                root = ((large_arc_flag == 1 && sweep_flag == 1) || (large_arc_flag == 0 && sweep_flag == 0) ? -1.0 : 1.0) * Math.Sqrt(numerator / (rx * rx * y1Prime * y1Prime + ry * ry * x1Prime * x1Prime));

            }

            double cXprime = root * radiusX * y1Prime / radiusY;
            double cYprime = -root * radiusY * x1Prime / radiusX;
            double cx = cosPhi * cXprime - sinPhi * cYprime + (x1 + x2) / 2.0;
            double cy = sinPhi * cXprime + cosPhi * cYprime + (y1 + y2) / 2.0;
            double theta1 = vectorAngle(1.0, 0.0, (x1Prime - cXprime) / radiusX, (y1Prime - cYprime) / radiusY);
            double dtheta = vectorAngle((x1Prime - cXprime) / radiusX, (y1Prime - cYprime) / radiusY, (-x1Prime - cXprime) / radiusX, (-y1Prime - cYprime) / radiusY);

            
            if(sweep_flag == 0 && dtheta > 0)
            {
                dtheta -= 2.0 * Math.PI;
            }
            else if(sweep_flag == 1 && dtheta < 0)
            {
                dtheta += 2.0 * Math.PI;
            }

            int segments = (int)Math.Ceiling((double)Math.Abs(dtheta / (Math.PI / 2.0)));
            
            double delta = dtheta / segments;
            double t = 8.0 / 3.0 * Math.Sin(delta / 4.0) * Math.Sin(delta / 4.0) / Math.Sin(delta / 2.0);

            double startX = x1;
            double startY = y1;

            for(int i = 0; i < segments; i++)
            {
                double cosTheta1 = Math.Cos(theta1);
                double sinTheta1 = Math.Sin(theta1);
                double theta2 = theta1 + delta;
                double cosTheta2 = Math.Cos(theta2);
                double sinTheta2 = Math.Sin(theta2);

                double endpointX = cosPhi * radiusX * cosTheta2 - sinPhi * radiusY * sinTheta2 + cx;
                double endpointY = sinPhi * radiusX * cosTheta2 + cosPhi * radiusY * sinTheta2 + cy;

                double dx1 = t * (-cosPhi * radiusX * sinTheta1 - sinPhi * radiusY * cosTheta1);
                double dy1 = t * (-sinPhi * radiusX * sinTheta1 + cosPhi * radiusY * cosTheta1);

                double dx2 = t * (cosPhi * radiusX * sinTheta2 + sinPhi * radiusY * cosTheta2);
                double dy2 = t * (sinPhi * radiusX * sinTheta2 - cosPhi * radiusY * cosTheta2);

                bezier_curve(writer, startX, startY, (startX + dx1), (startY + dy1), (endpointX + dx2), (endpointY + dy2), endpointX, endpointY);

                theta1 = theta2;
                startX = endpointX;
                startY = endpointY;
            }



        }

        private static double vectorAngle(double ux, double uy, double vx, double vy)
        {
            double ta = Math.Atan2(uy, ux);
            double tb = Math.Atan2(vy, vx);
            if(tb >= ta)
            {
                return tb - ta;
            }
            return Math.PI * 2 - (ta - tb);
        }

        private static void polyline(StreamWriter writer, IEnumerable<XElement> polyline_el)
        {
            string argSeparators = @"[\s,]|(?=(?<!e)-)";
            foreach (XElement polyline in polyline_el)
            {
                var splitArgs = Regex.Split(polyline.Attribute("points").Value, argSeparators).Where(t => !string.IsNullOrEmpty(t));
                List<double> points = new List<double>();
                points = splitArgs.Select(arg => double.Parse(arg)).ToList();

                for (int i = 0; i < points.Count; i += 2)
                {
                    x.Add(points[i]);
                    y.Add(mirror(points[i + 1]));
                }
                x.Add(69420);
                y.Add(69420);

            }
        }

        private static void transform(StreamWriter writer, string attr, double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)
        {
            attr = attr.Replace(")", " ").Replace("(", " ");
            string argSeparators = @"[\s,]|(?=(?<!e)-)";
            var splitArgs = Regex.Split(attr, argSeparators).Where(t => !string.IsNullOrEmpty(t));
            var type = splitArgs.First();
            List<string> args = new List<string>();
            args = splitArgs.ToList();
            if(type == "matrix")
            {

                double newX1 = Convert.ToDouble(args[1]) * x1 + Convert.ToDouble(args[3]) * y1 + Convert.ToDouble(args[5]);
                double newY1 = Convert.ToDouble(args[2]) * x1 + Convert.ToDouble(args[4]) * y1 + Convert.ToDouble(args[6]);
                double newX2 = Convert.ToDouble(args[1]) * x2 + Convert.ToDouble(args[3]) * y2 + Convert.ToDouble(args[5]);
                double newY2 = Convert.ToDouble(args[2]) * x2 + Convert.ToDouble(args[4]) * y2 + Convert.ToDouble(args[6]);
                double newX3 = Convert.ToDouble(args[1]) * x3 + Convert.ToDouble(args[3]) * y3 + Convert.ToDouble(args[5]);
                double newY3 = Convert.ToDouble(args[2]) * x3 + Convert.ToDouble(args[4]) * y3 + Convert.ToDouble(args[6]);
                double newX4 = Convert.ToDouble(args[1]) * x4 + Convert.ToDouble(args[3]) * y4 + Convert.ToDouble(args[5]);
                double newY4 = Convert.ToDouble(args[2]) * x4 + Convert.ToDouble(args[4]) * y4 + Convert.ToDouble(args[6]);
                x.Add(newX1);
                y.Add(mirror(newY1));
                x.Add(newX2);
                y.Add(mirror(newY2));
                x.Add(newX3);
                y.Add(mirror(newY3));
                x.Add(newX4);
                y.Add(mirror(newY4));
                x.Add(newX1);
                y.Add(mirror(newY1));
            }
        }
    }
}
