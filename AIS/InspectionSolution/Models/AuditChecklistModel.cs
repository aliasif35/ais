using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace InspectionSolution.Models
{
    public class AuditChecklistModel
    {        
        public int T_ID { get; set; }
        public string HEADING { get; set; }
        public int ENTITY_TYPE { get; set; }
        public string ENTITY_TYPE_NAME { get; set; }
        public string STATUS { get; set; }
    }
}
