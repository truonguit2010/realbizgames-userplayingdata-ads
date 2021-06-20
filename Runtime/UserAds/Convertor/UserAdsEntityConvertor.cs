
namespace RealbizGames.UPD.Ads
{
    public class UserAdsEntityConvertor
    {
        public static UserAdsEntity From(UserAdsDTO dto) {
            UserAdsEntity entity = new UserAdsEntity();

            entity.noAds = dto.NoAds;
            entity.noBanners = dto.NoBanners;
            entity.noVideos = dto.NoVideos;

            return entity;
        }
    }
}