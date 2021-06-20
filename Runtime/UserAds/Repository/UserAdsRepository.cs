
namespace RealbizGames.UPD.Ads
{
    public class UserAdsRepository : GenericPlayerPrefRepository<UserAdsEntity>
    {
        public static string KEY_IN_PLAYERPREF = "UserAdsRepository";
        public UserAdsRepository() : base(KEY_IN_PLAYERPREF) {

        }
    }
}