using Business.Abstract;
using Business.Constants;
using Core.Entities.Concrete;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        private readonly IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }
        
        public async Task<IDataResult<List<OperationClaim>>> GetClaimsAsync(User user)
        {
            var claims = await _userDal.GetClaimsAsync(user);
            if (claims.Count == 0)
                return new ErrorDataResult<List<OperationClaim>>(null, Messages.OperationClaimsNotFoundForUser);

            return new SuccessDataResult<List<OperationClaim>>(claims, Messages.OperationClaimsListedForUser);
        }

        public async Task<IResult> AddAsync(User user)
        {
            var addStatus = await _userDal.AddAsync(user);
            if (!addStatus)
                return new ErrorResult(Messages.UserNotAdded);

            return new SuccessResult(Messages.UserAdded);
        }

        public async Task<IDataResult<User>> GetByMailAsync(string email)
        {
            var foundUser = await _userDal.GetAsync(u => u.Email == email);
            if (foundUser == null)
                return new ErrorDataResult<User>(null, Messages.UserNotFound);

            return new SuccessDataResult<User>(foundUser, Messages.UserBrought);
        }
    }
}