using System.Collections.Generic;
using System.Drawing;
using System.Globalization;

namespace AOGL
{
    internal class GCodeGenerator
    {
        private readonly double _Width;
        private readonly double _Height;
        private readonly double _LineStep;
        private readonly double _PointStep = 0.1;
        private readonly double _Freezone;
        private readonly double _Feed;

        private const int MAX_Intencity = 400;

        public GCodeGenerator(double width, double height, double lineStep, double freezone, double feed)
        {
            _Width = width;
            _Height = height;
            _LineStep = lineStep;
            _Freezone = freezone;
            _Feed = feed;
        }

        private const string feedMove = "G1 X{0:0.###} M3 S{1:0.###}";
        private const string fastMove = "G0 X{0:0.###} Y{1:0.###} M3 S{2:0.###}";

        public IEnumerable<string> Generate(Bitmap image)
        {
            NumberFormatInfo nfi = new NumberFormatInfo();
            nfi.NumberDecimalSeparator = ".";

            int iWidth = image.Width;
            int iHeight = image.Height;
            double pixelWidth = _Width / iWidth;
            if (pixelWidth < _PointStep)
                pixelWidth = _PointStep;

            int xPixelSteps = 1;
            if (pixelWidth < _LineStep)
                xPixelSteps = (int)(_LineStep / pixelWidth);

            int linesCount = (int)(_Height / _LineStep);
            double linesPerPixel = (double)linesCount / (double)iHeight;

            List<string> gCode = new List<string>();
            gCode.Add(string.Format(nfi, "F{0:0.###}", _Feed));
            for (int y = 0; y < linesCount; y++)
            {
                int yPixelCursor = (int)(y / linesPerPixel);

                int lastLaserState = 0;
                double lastX = 0.0;

                int firstDarkX = -1;
                for (int x = 0; x < iWidth; x++)
                {
                    if (image.GetPixel(x, yPixelCursor).GetBrightness() < 1.0)
                    {
                        firstDarkX = x;
                        break;
                    }
                }
                if (firstDarkX == -1)
                    continue;

                gCode.Add(string.Format(nfi, fastMove, firstDarkX * pixelWidth - _Freezone, -y * _LineStep, 0.0));

                float brightnessSum = 0;

                for (int x = firstDarkX; x < iWidth; x++)
                {
                    if (x % xPixelSteps != 0)
                    {
                        brightnessSum += image.GetPixel(x, yPixelCursor).GetBrightness();
                        continue;
                    }

                    brightnessSum += image.GetPixel(x, yPixelCursor).GetBrightness();

                    int curLaserState = (int)(MAX_Intencity * (1.0 - brightnessSum / (double)xPixelSteps));
                    brightnessSum = 0;

                    if (lastLaserState == curLaserState)
                        continue;

                    lastX = x * pixelWidth;

                    gCode.Add(string.Format(nfi, feedMove, lastX, lastLaserState));

                    lastLaserState = curLaserState;
                }

                if (lastLaserState > 0.0)
                {
                    lastX = _Width;
                    gCode.Add(string.Format(nfi, feedMove, _Width, lastLaserState));
                }

                if (_Freezone > 0.0)
                    gCode.Add(string.Format(nfi, feedMove, lastX + _Freezone, 0));
            }
            return gCode;
        }
    }
}