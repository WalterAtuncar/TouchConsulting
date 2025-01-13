using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.IdentityModel.Tokens.Jwt;

namespace Infrastructure.RoleAuthorization
{
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Class, Inherited = true, AllowMultiple = true)]
    public class TouchAuthorizationAttribute : Attribute, IAuthorizationFilter
    {
        private readonly string[] _requiredRoles;

        public TouchAuthorizationAttribute(params string[] requiredRoles)
        {
            _requiredRoles = requiredRoles;
        }

        public void OnAuthorization(AuthorizationFilterContext context)
        {
            var token = context.HttpContext.Request.Headers["Authorization"].FirstOrDefault()?.Split(" ").Last();

            if (string.IsNullOrEmpty(token))
            {
                context.Result = new UnauthorizedResult();
                return;
            }

            try
            {
                var jwtToken = new JwtSecurityTokenHandler().ReadToken(token) as JwtSecurityToken;

                // Extraer el rol del token
                var role = jwtToken?.Claims.FirstOrDefault(c => c.Type.Contains("role"))?.Value;

                if (string.IsNullOrEmpty(role) || !_requiredRoles.Contains(role))
                {
                    context.Result = new ForbidResult();
                    return;
                }
            }
            catch
            {
                context.Result = new UnauthorizedResult();
                return;
            }
        }
    }
} 