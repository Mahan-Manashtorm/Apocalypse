using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace da
{
    public abstract class Component
    {
        private string _name;
        public Component(string name)
        {
            _name = name;
        }
        public abstract string Operation();
        public virtual void SetName(string name)
        {
            _name = name;
        }
        public virtual string GetName()
        {
            return _name;
        }
        public virtual void Add(Component component)
        {
            throw new NotImplementedException();
        }
        public virtual void Remove(Component component)
        {
            throw new NotImplementedException();
        }

        public virtual bool IsComposite()
        {
            return true;
        }
    }
    public class Leaf : Component
    {
        public Leaf(string name) : base(name) { }

        public override string Operation()
        {
            return GetName();
        }
        public override bool IsComposite()
        {
            return false;
        }
    }
    public class Composite : Component
    {
        public Composite(string name) : base(name) { }

        protected List<Component> _children = new List<Component>();

        public override void Add(Component component)
        {
            this._children.Add(component);
        }
        public override void Remove(Component component)
        {
            this._children.Remove(component);
        }
        public override string Operation()
        {
            int i = 0;
            string result = "\nComposite " + GetName() + " have: ";

            foreach (Component component in this._children)
            {
                result += component.Operation();
                if (i != this._children.Count - 1)
                {
                    result += " + ";
                }
                i++;
            }

            return result;
        }
    }
    public class Client
    {
        public void ClientCode(Component leaf)
        {
            Console.WriteLine($"RESULT: {leaf.Operation()}\n");
        }
        void ClientCode2(Component component1, Component component2)
        {
            if (component1.IsComposite())
            {
                component1.Add(component2);
            }

            Console.WriteLine($"RESULT: {component1.Operation()}");
        }
    }
}

    
