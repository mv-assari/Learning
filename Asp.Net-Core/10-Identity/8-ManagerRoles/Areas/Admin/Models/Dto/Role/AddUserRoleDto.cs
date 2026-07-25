using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace RunIdentity.Areas.Admin.Models.Dto.Role
{
    public class AddUserRoleDto
    {
        public string Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
        public List<SelectListItem> Roles { get; set; }
    }
}
