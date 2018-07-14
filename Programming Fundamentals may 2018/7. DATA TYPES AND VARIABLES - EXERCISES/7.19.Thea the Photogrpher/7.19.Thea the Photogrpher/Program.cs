using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._19.Thea_the_Photogrpher
{
    class Program
    {
        static void Main(string[] args)
        {
            long takenPhotos = long.Parse(Console.ReadLine());
            long filterTimeSecs = long.Parse(Console.ReadLine());
            long filterFactor = long.Parse(Console.ReadLine());
            long uploadTime = long.Parse(Console.ReadLine());

            long filterPictures = (long)Math.Ceiling(takenPhotos * filterFactor / 100.0);
            long totalTimeAllpics = takenPhotos * filterTimeSecs;
            long filterPicsTime = filterPictures * uploadTime;

            long TotalTime = totalTimeAllpics + filterPicsTime;

            TimeSpan result = TimeSpan.FromSeconds(TotalTime);
            String format = result.ToString(@"d\:hh\:mm\:ss");
            Console.WriteLine(format);
        }
    }
}
