using System.Collections.Generic;
using System.Threading.Tasks;
using ConnectApp.API.Helpers;
using ConnectApp.API.Models;

namespace ConnectApp.API.Data
{
    public interface IConnectRepository
    {
         void Add<T>(T entity) where T: class;
         void Delete<T>(T entity) where T: class;
         Task<bool> SaveAll();
         Task<PagedList<User>> GetUsers(UserParams userParams);
         Task<User> GetUser(int id);
         Task<Photo> GetPhoto(int id);
         Task<Photo> GetMainPhotoForUser(int userId);
    }
}