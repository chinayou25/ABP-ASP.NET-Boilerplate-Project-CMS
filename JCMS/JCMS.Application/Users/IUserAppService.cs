using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using JCMS.Roles.Dto;
using JCMS.Users.Dto;
using System.Collections.Generic;

namespace JCMS.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UpdateUserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();
        List<UserDto> GetAllList();
    }
}