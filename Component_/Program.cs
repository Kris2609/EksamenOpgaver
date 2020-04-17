using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Component_
{
    class Program
    {
        static void Main(string[] args)
        {
            Composite root = new Composite("HeadLine");
            root.Add(new Leaf("Text"));

            Composite comp = new Composite("Button");
            comp.Add(new Leaf("Image"));
            comp.Add(new Leaf("ImageText"));

            root.Add(comp);
            root.Add(new Leaf("Image"));

            
            root.Display("");
            Console.WriteLine("---------------");
            root.Remove(comp);

            root.Display("");
            Console.ReadLine();
        }
    }

    abstract class Component
    {
        protected string name;
        protected Component(string name)
        {
            this.name = name;
        }

        public abstract void Add(Component c);
        public abstract void Remove(Component c);
        public abstract void Display(string prefix);
    }

    class Leaf : Component
    {
        public Leaf(string name) : base(name)
        {

        }

        public override void Add(Component c)
        {
            Console.WriteLine("Cant add to a leaf");
        }

        public override void Remove(Component c)
        {
            Console.WriteLine("Cant remove from a leaf");
        }

        public override void Display(string prefix)
        {
            Console.WriteLine($"{prefix}{name}");
        }
    }

    class Composite : Component
    {
        private List<Component> subComponents = new List<Component>();

        public Composite(string name) : base(name)
        {

        }

        public override void Add(Component component)
        {
            subComponents.Add(component);
        }

        public override void Remove(Component component)
        {
            subComponents.Remove(component);
        }

        public override void Display(string space)
        {
            Console.WriteLine($"{space}{name}");

            foreach (Component component in subComponents)
            {
                component.Display($"{space}-");
            }
        }
    }
}
