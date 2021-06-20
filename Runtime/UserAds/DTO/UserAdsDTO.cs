
namespace RealbizGames.UPD.Ads
{
    public class UserAdsDTO
    {
        private bool noAds;

        private bool noVideos;

        private bool noBanners;

        public bool NoAds { get => noAds; set => noAds = value; }
        public bool NoVideos { get => noVideos; set => noVideos = value; }
        public bool NoBanners { get => noBanners; set => noBanners = value; }
    }
}