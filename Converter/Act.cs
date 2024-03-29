﻿using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Data;

namespace Converter
{
    class Act
    {
        private static ImageCodecInfo GetEncoder(ImageFormat format)
        {
            ImageCodecInfo[] codecs = ImageCodecInfo.GetImageEncoders();
            foreach (ImageCodecInfo codec in codecs)
            {
                if (codec.FormatID == format.Guid)
                {
                    return codec;
                }
            }
            return null;
        }
        public static Bitmap Getİmage()
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                Bitmap bmp1 = new Bitmap(open.FileName);
                return bmp1;
            }
            else return null;
            
        }

        public static Bitmap SetQualityJ(Int64 x,Bitmap y)
        {
            MemoryStream ms = new MemoryStream();
            ImageCodecInfo jpgEncoder = GetEncoder(ImageFormat.Jpeg);
            System.Drawing.Imaging.Encoder myEncoder =System.Drawing.Imaging.Encoder.Quality;
            EncoderParameters myEncoderParameters = new EncoderParameters(1);
            EncoderParameter myEncoderParameter = new EncoderParameter(myEncoder, x);
            myEncoderParameters.Param[0] = myEncoderParameter;
            y.Save(ms,jpgEncoder, myEncoderParameters);
            Bitmap bmp = new Bitmap(ms);
            return bmp;
        }

        public static Bitmap SetQualityT(Int64 x, Bitmap y)
        {
            MemoryStream ms = new MemoryStream();
            ImageCodecInfo jpgEncoder = GetEncoder(ImageFormat.Tiff);
            System.Drawing.Imaging.Encoder myEncoder = System.Drawing.Imaging.Encoder.Quality;
            EncoderParameters myEncoderParameters = new EncoderParameters(1);
            EncoderParameter myEncoderParameter = new EncoderParameter(myEncoder, x);
            myEncoderParameters.Param[0] = myEncoderParameter;
            y.Save(ms, jpgEncoder, myEncoderParameters);
            Bitmap bmp = new Bitmap(ms);
            return bmp;
        }
        public static void SaveImageJ(Image x)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "jpeg (*.jpeg)|*.jpeg";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                x.Save(dialog.FileName,ImageFormat.Jpeg);
            }
        }

        public static void SaveImageT(Image x)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "tiff (*.tiff)|*.tiff";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                x.Save(dialog.FileName, ImageFormat.Tiff);
            }
        }
    }
}
