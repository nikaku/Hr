﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Hr.BL.Dtos.Position
{
    public class UpdatePositionDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<int> DepartmentIds { get; set; }
    }
}
