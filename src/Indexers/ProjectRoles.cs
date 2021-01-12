using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers
{
    class ProjectRoles
    {
        readonly Dictionary<int, string> roles = new Dictionary<int, string>();
        public string this[int projectId]
        {
            get
            {
                if (!roles.TryGetValue(projectId, out string role))
                {
                    throw new Exception("Project ID not found!");
                }
                return role;
            }
            set
            {
                roles[projectId] = value;
            }
        }
    }
}
