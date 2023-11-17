using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FBAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UserValidationController : ControllerBase
    {
        ILogger _logger;
        IDataStore _dataStore;

        public UserValidationController(ILogger<UserValidationController> logger, IDataStore dataStore)
        {
            _logger = logger;
            _dataStore = dataStore;
        }

        //Post

        //Cache tax rates
        [HttpGet()]
        public async Task<IEnumerable<string>> GetUserRoles([FromBody] string token)
        {
            IEnumerable<AspNetRole> roles = await _dataStore.GetUserRolesAsync(token) as IEnumerable<AspNetRole>;

            List<string> strings = new List<string>();

            if (roles is null || roles.Count() == 0)
                return strings;

            foreach (var role in roles)
                strings.Add(role.Name);

            return strings;
        }
    }
}
