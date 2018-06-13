using System.Collections.Generic;

namespace ResiliationPacifica.App_Start
{
    public class EnvConfig
    {
        // Ajoute des rôles sur notre application
        public static List<string> Roles
        {
            get
            {
                List<string> roles = new List<string>();

                roles.Add("User");
                roles.Add("Admin");

                return roles;
            }
            set { }
        }    
    }
}