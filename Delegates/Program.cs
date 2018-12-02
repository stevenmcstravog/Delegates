using System;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            var processor = new PhotoProcessor();
            var snapchatfilters = new SnapchatFilters();
            Action<Photo> filterHandler = snapchatfilters.ApplyDogFacialParts;
            filterHandler += snapchatfilters.ApplyFlowerCrown;
            filterHandler += HighContrastFilter;

            processor.Process("photo.png", filterHandler);
        }

        static void HighContrastFilter(Photo photo)
        {
            Console.WriteLine("Apply High Contrast");
        }
    }
}
