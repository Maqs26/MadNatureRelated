namespace MadNature.Models
{
    public class PhotoPaths
    {

        //Carousel
        public const string FLOWERS = "img/flowerportraitinhand.png";
        public const string JEWELRY_HEADER = "img/JewelryHeaderImage.jpg";

        //About photo
        public const string PEOPLES = "img/peoples.jpg";

        //Photo Gallery
        public const string GALLERY_PF1 = "img/PF1.png";
        public const string GALLERY_PF2 = "img/PF2.png";

        //Upcoming Shows
        public const string UPCOMING_SHOWS_PHOTO = "img/Upcoming-shows-photo.png";

        //Contact
        public const string FACEBOOK_ICON = "img/facebook-icon-contact.png";
        public const string INSTAGRAM_ICON = "img/Instagram-logo-contact.png";


		public static List<string> GetCarouselImages()
        {
            return new List<string>
            {
                FLOWERS,
                JEWELRY_HEADER
            };
        }

        public static List<string> GetAboutImages()
        {
            return new List<string>
            {
                PEOPLES,
            };
        }

        public static List<string> GetPhotoGalleryImages()
        {
            List<string> result = new();
            for (int i = 0; i < 10; i++)
            {
                result.Add(GALLERY_PF1);
                result.Add(GALLERY_PF2);
            };
            return result;
        }
    }
}
