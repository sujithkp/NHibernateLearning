﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FluentNhibernateLearning.Entities
{
    public class Student
    {
        public virtual int PKey { get; set; }

        public virtual string Name { get; set; }

        public virtual ClassRoom ClassRoom { get; set; }
    }
}
