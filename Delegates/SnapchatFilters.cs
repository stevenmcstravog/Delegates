using System;

namespace Delegates
{
    class SnapchatFilters
    {
        public void ApplyFlowerCrown(Photo photo)
        {
            Console.WriteLine("Apply Flower Crown");
        }

        public void ApplyDogFacialParts(Photo photo)
        {
            Console.WriteLine("Apply Dog Facial Parts");
        }

        public void ApplyMustache(Photo photo)
        {
            Console.WriteLine("Apply Mustache");
        }

        public void ApplyEyeMask(Photo photo)
        {
            Console.WriteLine("Apply Eye Mask");
        }

        public void ApplyBlackAndWhite(Photo photo)
        {
            Console.WriteLine("Apply Black and White");
        }
    }
}
