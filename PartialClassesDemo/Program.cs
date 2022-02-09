using System;

namespace PartialClassesDemo {
    /// <summary>
    /// This is an example of an XML comment, it adds a summary of the following Class
    /// (hover over 'Program' to see)
    /// </summary>
    class Program {
        /// <summary>
        /// this covers the Method 'Main'
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args) {
            var person = new Person();
            var name = person.GetName();
        }
        /// <summary>
        /// discription of the method
        /// </summary>
        /// <returns>messages about what should print or be seen when run</returns>
        public string ToPrint(string message) {
            return message;
        }
    }
}
