///This code is written by https://github.com/hupo376787
///Please add this comment when you change my code
///Thanks, happy coding!!!

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Graphics.Imaging;
using Windows.Storage;
using Windows.Storage.FileProperties;
using Windows.Storage.Streams;

namespace TencentAI.Helpers
{
    public class ImageHelper
    {
        public async static Task<string> GetBase64(StorageFile imagefile)
        {
            string strbaser64 = "";
            try
            {
                IRandomAccessStream iras = await imagefile.OpenReadAsync();
                Stream stream = WindowsRuntimeStreamExtensions.AsStreamForRead(iras.GetInputStreamAt(0));
                MemoryStream ms = new MemoryStream();
                await stream.CopyToAsync(ms);
                byte[] arr = ms.ToArray();
                ms.Dispose();
                strbaser64 = Convert.ToBase64String(arr);
            }
            catch { }

            return strbaser64;
        }

        public static async Task<bool> ImageFileCompression(StorageFile inputFile, StorageFile outputFile, uint longSide)
        {
            try
            {
                Guid encoderId;
                switch (outputFile.FileType)
                {
                    case ".png":
                        encoderId = BitmapEncoder.PngEncoderId;
                        break;
                    case ".bmp":
                        encoderId = BitmapEncoder.BmpEncoderId;
                        break;
                    case ".gif":
                        encoderId = BitmapEncoder.GifEncoderId;
                        break;
                    case ".tif":
                    case ".tiff":
                        encoderId = BitmapEncoder.TiffEncoderId;
                        break;
                    case ".jpg":
                    case ".jpeg":
                    default:
                        encoderId = BitmapEncoder.JpegEncoderId;
                        break;
                }

                //图片处理部分  
                using (IRandomAccessStream inputStream = await inputFile.OpenAsync(FileAccessMode.Read),
                           outputStream = await outputFile.OpenAsync(FileAccessMode.ReadWrite))
                {
                    //BitmapEncoder需要一个空的输出流; 但是用户可能已经选择了预先存在的文件，所以清零。  
                    outputStream.Size = 0;

                    //从解码器获取像素数据。 我们对解码的像素应用用户请求的变换以利用解码器中的潜在优化。  
                    BitmapDecoder decoder = await BitmapDecoder.CreateAsync(inputStream);
                    BitmapTransform transform = new BitmapTransform();

                    //原图尺寸比转换尺寸更小  
                    if (decoder.PixelHeight < longSide && decoder.PixelWidth < longSide)
                    {
                        //throw new Exception("设置的尺寸大于原图尺寸！");
                        if (decoder.PixelHeight > decoder.PixelWidth)
                            longSide = decoder.PixelWidth;
                        else
                            longSide = decoder.PixelHeight;
                    }

                    // 判断长边并按原图比例确定另一条边的长度  
                    if (decoder.PixelHeight > decoder.PixelWidth)
                    {
                        transform.ScaledHeight = longSide;
                        transform.ScaledWidth = (uint)(decoder.PixelWidth * ((float)longSide / decoder.PixelHeight));
                    }
                    else
                    {
                        transform.ScaledHeight = (uint)(decoder.PixelHeight * ((float)longSide / decoder.PixelWidth));
                        transform.ScaledWidth = longSide;
                    }

                    // Fant是相对高质量的插值模式。  
                    transform.InterpolationMode = BitmapInterpolationMode.Fant;

                    // BitmapDecoder指示最佳匹配本地存储的图像数据的像素格式和alpha模式。 这可以提供高性能的与或质量增益。  
                    BitmapPixelFormat format = decoder.BitmapPixelFormat;
                    BitmapAlphaMode alpha = decoder.BitmapAlphaMode;

                    // PixelDataProvider提供对位图帧中像素数据的访问  
                    PixelDataProvider pixelProvider = await decoder.GetPixelDataAsync(
                        format,
                        alpha,
                        transform,
                        ExifOrientationMode.RespectExifOrientation,
                        ColorManagementMode.ColorManageToSRgb
                        );

                    byte[] pixels = pixelProvider.DetachPixelData();

                    //将像素数据写入编码器。  
                    BitmapEncoder encoder = await BitmapEncoder.CreateAsync(encoderId, outputStream);
                    //设置像素数据  
                    encoder.SetPixelData(
                        format,
                        alpha,
                        transform.ScaledWidth,
                        transform.ScaledHeight,
                        decoder.DpiX,
                        decoder.DpiY,
                        pixels
                        );

                    await encoder.FlushAsync(); //异步提交和刷新所有图像数据（这一步保存图片到文件）  
                    Console.WriteLine("保存成功：" + outputFile.Path);
                    return true;
                }
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return false;
            }
        }

        public static async Task<bool> CheckImageLegality(StorageFile imageFile)
        {
            ImageProperties mImageProperties = await imageFile.Properties.GetImagePropertiesAsync();

            if (mImageProperties.Height > 1000 || mImageProperties.Width > 1000)
                return false;
            var size = await imageFile.GetBasicPropertiesAsync();
            if (size.Size >= 1 * 1000 * 1000)
                return false;

            return true;
        }

    }
}
