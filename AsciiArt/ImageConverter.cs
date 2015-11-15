using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Text;
using AsiiArt;

namespace AsciiArt
{
    public static class ImageConverter
    {
        private const int ColumnWidth = 1;
        private const int RowHeight = 2;

        public static string ConvertImage(Bitmap image)
        {
            var matrix = CreateGrayscaleMatrix();
            var attributes = new ImageAttributes();
            attributes.SetColorMatrix(matrix);
            int TallBrightness = 0;

            var asciiart = new StringBuilder();

            using (var gphGrey = Graphics.FromImage(image))
            {
                var bounds = new Rectangle(0, 0, image.Width, image.Height);
                gphGrey.DrawImage(image, bounds, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, attributes);
            }

            for (int Th = 0; Th < image.Height; Th++)
            {
                for (int Tw = 0; Tw < image.Width; Tw++)
                {
                    var TpixelColor = image.GetPixel(Tw, Th);
                    var TpixelBrightness = (int)(Brightness(TpixelColor));

                    TallBrightness += TpixelBrightness;
                }

            }

            TallBrightness = TallBrightness / (image.Width * image.Height);

            //int h = 0;
            for (int h = 0; h < (int)(image.Height / RowHeight); h ++) 
            // h := for each row int image, by image.Height and RowHeight
            {
                //int w = 0;
                for (int w = 0; w < (int)image.Width / ColumnWidth; w ++)
                // w := for each column in image, by image.Width and ColumnWidth
                {
                    var blockBrightness = GetBlockBrightness(image, h, w);

                    var symbol = SymbolSelector.ChooseSymbol(blockBrightness, TallBrightness);
                    asciiart.Append(symbol);
                }

                asciiart.Append("\r\n");
                
            }

            return asciiart.ToString();
        }

        private static int GetBlockBrightness(Bitmap image, int rowIndex, int columnIndex)
        {
            var startY = (int)(rowIndex*RowHeight);
            var startX = (int)(columnIndex*ColumnWidth);
            int allBrightness = 0;

            //int y = 0;
            for (int y = 0; y < RowHeight; y++)
            // y := for each pixel in row [0..RowHeight)
            {
                for (int x = 0; x < ColumnWidth; x++)
                // x := for each pixel in column [0..ColumnWidth)
                {
                    int cY = (int)(y + startY);
                    int cX = (int)(x + startX);

                    var pixelColor = image.GetPixel(cX, cY);


                    var pixelBrightness = (int)(Brightness(pixelColor));
                    //var pixelBrightness = (int)(pixelColor.GetBrightness());
                    //var pixelBrightness = (int) (pixelColor.GetSaturation());
                    
                    allBrightness += pixelBrightness;
                }
            }

            return allBrightness;
            
        }

        private static ColorMatrix CreateGrayscaleMatrix()
        {
            var matrix = new ColorMatrix();

            matrix[0, 0] = 1/3f;
            matrix[0, 1] = 1/3f;
            matrix[0, 2] = 1/3f;
            matrix[1, 0] = 1/3f;
            matrix[1, 1] = 1/3f;
            matrix[1, 2] = 1/3f;
            matrix[2, 0] = 1/3f;
            matrix[2, 1] = 1/3f;
            matrix[2, 2] = 1/3f;
            return matrix;
        }

        private static int Brightness(Color c)
        {
            return (int)Math.Sqrt(
               c.R * c.R * .241 +
               c.G * c.G * .691 +
               c.B * c.B * .068);
        }
    }
}