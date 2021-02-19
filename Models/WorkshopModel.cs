using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace workshop_api.Models
{
    public class WorkshopModel
    {
        public string id;
        public string name;
        public WorkshopStatesEnum status;
    //    (Id, Name, Status(Scheduled/Postponed/Cancelled)) - 
    }
}
