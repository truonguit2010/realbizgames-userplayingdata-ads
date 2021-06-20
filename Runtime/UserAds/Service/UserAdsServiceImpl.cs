
namespace RealbizGames.UPD.Ads
{
    public class UserAdsServiceImpl : IUserAdsService
    {
        private UserAdsRepository repository = new UserAdsRepository();
        
        public UserAdsDTO Get()
        {
            UserAdsEntity entity = repository.GetT();
            if (entity == null) {
                UserAdsDTO dto = new UserAdsDTO();

                dto.NoAds = false;
                dto.NoBanners = false;
                dto.NoVideos = false;

                return dto;
            } else {
                UserAdsDTO dto = UserAdsDTOConvertor.From(entity);
                return dto;
            }
            
        }

        public void init()
        {
            repository.init();
        }

        public void lazyInit()
        {
            repository.lazyInit();
        }

        public void refresh()
        {
            repository.refresh();
        }

        public void Save(UserAdsDTO dto)
        {
            UserAdsEntity entity = UserAdsEntityConvertor.From(dto);
            repository.Save(entity);
        }
    }
}