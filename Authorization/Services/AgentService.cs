using Authorization.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Authorization.Provider
{
    public class AgentService : IAgentService
    {
        private static List<Login> AgentList = new List<Login>()
        {
            new Login{ Username = "Admin", Password = "Password"},
            new Login{ Username = "Admin1", Password = "Password1"}
        };
        public List<Login> GetList()
        {
            return AgentList;
        }

        public Login GetAgent(Login cred)
        {
            List<Login> AgentList = GetList();
            Login agentDetails = AgentList.FirstOrDefault(user => user.Username == cred.Username && user.Password == cred.Password);

            return agentDetails;
        }
    }
}
