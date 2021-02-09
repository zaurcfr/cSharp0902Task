using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharp0902Task
{
    abstract class Entity
    {
        public Guid guid { get; set; } = Guid.NewGuid();
    }
}
