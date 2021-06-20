
namespace RealbizGames.UPD.Ads
{
    public class UserAdsDTOConvertor
    {
        public static UserAdsDTO From(UserAdsEntity entity)
        {
            UserAdsDTO dto = new UserAdsDTO();

            dto.NoAds = entity.noAds;
            dto.NoBanners = entity.noBanners;
            dto.NoVideos = entity.noVideos;

            return dto;
        }
    }
}