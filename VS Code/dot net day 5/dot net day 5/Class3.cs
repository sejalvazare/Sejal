﻿using System

    namespace dot_net_day_5

public class PhotoBook
{
    protected int numPages;
    public PhotoBook()
    {
        numPages = 16;
    }
    public PhotoBook(int numPages)
    {
        this.numPages = numPages;
    }
    public int GetNumberPages()
    {
        return numPages;
    }
}
public class Bigphotobook : PhotoBook
{
    public Bigphotobook()
    {
        numPages = 64;
    }
}
class Class3
{
    public static void Main()
    {
        PhotoBook pb = new PhotoBook();
        Console.WriteLine(pb.GetNumberPages());

        PhotoBook pb1 = new PhotoBook(24);
        Console.WriteLine(pb1.GetNumberPages());

        Bigphotobook bpb = new Bigphotobook();
        Console.WriteLine(bpb.GetNumberPages());
    }
}