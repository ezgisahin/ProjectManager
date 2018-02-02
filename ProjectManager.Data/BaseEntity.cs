﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectManager.Data
{
    public class BaseEntity
    {
        public string Id { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime UpdateDate { get; set; }
        public string UpdatedBy { get; set; }
        public string IPAddress { get; set; }
    }
}
