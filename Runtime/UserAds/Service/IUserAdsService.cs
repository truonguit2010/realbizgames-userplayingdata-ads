
namespace RealbizGames.UPD.Ads
{
    public interface IUserAdsService : IService
    {
        void Save(UserAdsDTO dto);

        UserAdsDTO Get();
    }
}