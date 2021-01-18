using System;
namespace CS_133_Projects.GenericClasses
{
    public class MyGenericClass<T, X>
    {
        public MyGenericClass()
        {
        }

        public T myProperty { get; set; }
        public X myProperty2 { get; set; }

        public T GetMyProperty()
        {
            return myProperty;
        }

        public void GetMyProperty(T newParameter)
        {
            Console.WriteLine("The property is: " + newParameter);
        }

        public void GetMyProperties()
        {
            Console.WriteLine("The properties are going to be: " + myProperty
                + " and the other property is " + myProperty2);
        }

    }
}
