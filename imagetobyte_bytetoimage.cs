public static byte[] ImageToByte(Image img)
{            
    ImageConverter converter = new ImageConverter();            
    return (byte[])converter.ConvertTo(img, typeof(byte[]));
}

public static byte[] ImageToByte2(Image img)
{
    byte[] byteArray = new byte[0];
    using (MemoryStream stream = new MemoryStream())
    {
        img.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
        stream.Close();

        byteArray = stream.ToArray();
    }
    return byteArray;
}
