using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClassesDemo {
    public class Person {
        public string Name { get; set; }

    }

    public partial class Person {
        public string GetName() {
            return Name;
        }
    }
}
