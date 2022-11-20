using System;

namespace CSharpIntermediate
{
    public class PresentationObject
    {
        public int Height { get; set; }
        public int Width { get; set; }

        public void Copy()
        {
            Console.WriteLine("Object copied");
        }

        public void Duplicate()
        {
            Console.WriteLine("Object Duplicated");
        }
    }
}