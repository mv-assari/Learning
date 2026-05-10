using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UserServices
{
    public interface IGetListUserService
    {
        List<UserDto> Execute();
    }
    public class GetListUserService:IGetListUserService
    {
        private readonly IDataBaseContext _context;
        public GetListUserService(IDataBaseContext context)
        {
            _context=context;
        }

        public List<UserDto> Execute()
        {
            var users = _context.Users.Select(u => new UserDto
            {
                Id = u.Id,
                UserName = u.UserName,
            }).ToList();

            return users;
        }
    }

    public class UserDto
    {
        public int Id { get; set; }
        public string UserName { get; set; }
    }
}
