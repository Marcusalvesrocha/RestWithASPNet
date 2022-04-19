using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using RestWithASPNet.Data.VO;
using RestWithASPNet.Models;
using RestWithASPNet.Models.Context;

namespace RestWithASPNet.Repository
{
    public class UserRepository : IUserRepository
    {

        private readonly MySQLContext _context;

        public UserRepository(MySQLContext context)
        {
            _context = context;
        }

        public User ValidateCredentials(UserVO user)
        {
            var pass = ComputeHash(user.Password, new SHA256CryptoServiceProvider());

            return _context.Users.FirstOrDefault(u => (u.UserName == user.UserName) && (u.Password == pass));
        }

        public User RefreshUserInfo(User user)
        {
            if(!_context.Users.Any(u => u.Id.Equals(user.Id))) return null;
            
            var userRefresh = _context.Users.FirstOrDefault(u => u.Id.Equals(user.Id));

            if (userRefresh != null)
            {
                try
                {
                    _context.Entry(userRefresh).CurrentValues.SetValues(user);
                    _context.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw;
                }
            }
            return userRefresh;
        }

        private string ComputeHash(string input, SHA256CryptoServiceProvider algorithm)
        {
            Byte[] inputBytes = Encoding.UTF8.GetBytes(input);
            Byte[] hashedBytes = algorithm.ComputeHash(inputBytes);
            return BitConverter.ToString(hashedBytes);
        }
    }
}
