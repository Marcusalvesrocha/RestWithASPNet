using System;
using RestWithASPNet.Data.VO;
using RestWithASPNet.Models;

namespace RestWithASPNet.Repository
{
    public interface IUserRepository
    {
        User ValidateCredentials(UserVO user);
    }
}
