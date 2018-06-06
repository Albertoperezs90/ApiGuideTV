using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;

namespace ApiGuideTV.BC
{
    public class TokenSecureCreator
    {
        private static TokenSecureCreator instance;

        private TokenSecureCreator() { }

        public static TokenSecureCreator Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new TokenSecureCreator();
                }

                return instance;
            }
        }

        public string GenerateToken()
        {
            string key = @"gNXfdsvbGgfFCc096wYCf4Qb6IKrnOk2PxX3vzi7lp57PAgy3QzSBmO7wwxVT6i6q
                                         1VGSKw7F9DNqGSOt0cCLU0RkUjo6aKq90JNoQOJbWO1RMBFMQkQwyMp
                                         cOyC3gi56Lihwf8Yxb9T
                                         gGKH14QA1BzxsxpXxr9Y
                                         FaqXIfRzXZ5lOWJmt87K
                                         WNeewkbtWktn1PiTinyB";

            var secret = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(key));
            var credentials = new SigningCredentials(secret, SecurityAlgorithms.HmacSha256Signature);
            var header = new JwtHeader(credentials);
            var payload = new JwtPayload
                    {
                        { "developer", "Alberto Perez" },
                        { "github", "https://github.com/Albertoperezs90" },
                    };

            var secToken = new JwtSecurityToken(header, payload);
            var handler = new JwtSecurityTokenHandler();
            
            return handler.WriteToken(secToken);   
        }
    }
}