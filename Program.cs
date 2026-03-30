using System.Numerics;

namespace G_NET_33_ADV01;

internal class Program
{
    static void Main(string[] args)
    {

        //Q1: What is a generic class? Why use generics?

        /*
         A) Generic Class is a class That Can work with any Data Type Without THe Need TO Create Multiple Classes For Each Data Type

        B) We Use Genereic Classes TO Avoid Code Duplication, Increase Code Reusability, And Provide Type Safety At Compile Time
        */

       
   
     // Q2: Write a generic class Container<T> with Add and Get methods.

        /*
        
        public class GenericClass<T>
        {
        
            private T Value;

            public void Add (T vlaue) => Value = vlaue;
            public T Get() => Value;
        }
        
        
        */


        // Q3:What are multiple type parameters? Write Pair<TKey, TValue>.

        /*
        
            Multiple Type Parameters Allow Us To Define A Generic Class Or Method That Can Work With More Than One Type. This Is Useful When We Need To Associate Two Or More Types Together.

        
          public class Pair<TKey, TValue>(TKey key, TValue value)
            {
                public TKey Key{get; init;}= key;
                public TValue Value{get;init;} = value;

         
            }        
        
        */

    
        // Q4: How to constrain type parameters in generics? Give an example.
        /*
        
            A generic method is a method that works with any data type using a type parameter.

            public static void Swap<T>(ref T a, ref T b)
            {
                T temp = a;
                a = b;
                b = temp;
            }
        
        
        */
   
   
        // Q5: Write a generic method FindMax<T> that finds maximum value
        /*
        
        public static T FindMax<T>(T a, T b) where T : IComparable<T>
            {
                return a.CompareTo(b) > 0 ? a : b;
            }
        public static T FindMax<T>(T a, T b) where T : INumber<T>
            {
                return a > b ? a : b;
            }
        
        
        */



        // Q6: What is a generic interface? Write IRepository<T>.

        /*
        
        A generic interface works with any type.
        public interface IRepository<T>
        {
            void Add(T item);
            void Remove(T item);
            IEnumerable<T> GetAll();
        }
        
        */

       
     //Q7: What is the 'struct' constraint? Write an example.

        /*
        
        
        Requires a Value type.


        public class MyClass<T> where T : struct
        {
            public T Value { get; set; }
        }
        
        */


        // Q8: What is the 'class' constraint? Write an example.

        /*
        
        
        Requires a reference type.

        public class Example<T> where T : class
        {
            public T Value;
        }
        */


        
        // Q9: What is the 'new()' constraint? Write an example.

        /*
        
        Requires a parameterless constructor.

        public class Factory<T> where T : new()
        {
            public T Create() => new T();
        }
        */

        // Q10:  What is the interface constraint? Write an example.
        /*
        
        An interface constraint means that the generic type T must implement a specific interface.

        public interface IPrintable
        {
            void Print();
        }

        public class Printer<T> where T : IPrintable
        {
            public void PrintItem(T item)
            {
                item.Print();
            }
        }
        
        */
    
    
        // Q11: What is the base class constraint? Write an example.

        /*
        
        It ensures that the generic type inherits from a specific base class.

        public class Animal
            {
                public void Eat() => Console.WriteLine("Eating...");
            }

            public class Zoo<T> where T : Animal
            {
                public void Feed(T animal)
                {
                    animal.Eat();
                }
            }
        
        
        */
    
    
        // Q12: How do you apply multiple constraints? Write an example. 

        /*
        
        public class Example<T> where T : class, IPrintable, new()
            {
                public T Create()
                {
                    return new T();
                }
            }
        
        
        */
    
    
        // Q13: What does the 'default' keyword do in generics?

        /*
        
        
            Returns the default value of a type:

            int => 0
            bool => false
            reference => null

            T value = default;

        
        */
    
        // Q14: Write a SafeList<T> that returns default when the index is invalid.
        /*
        
        public class SafeList<T>
        {
            private List<T> items = new();

            public void Add(T item) => items.Add(item);

            public T Get(int index)
            {
                if (index < 0 || index >= items.Count)
                    return default;

                return items[index];
            }
        }
        */
    
    
        // Q15: What is covariance? Explain the 'out' keyword.

        /*
        
        Covariance allows you to use a more derived type where a base type is expected.
        interface IProducer<out T>
            {
                T GetItem();
            }

            class Animal {}
            class Dog : Animal {}

            class DogProducer : IProducer<Dog>
            {
                public Dog GetItem() => new Dog();
            }
            IProducer<Dog> dogProducer = new DogProducer();


            IProducer<Animal> animalProducer = dogProducer;
        
        */
   
        // Q16: What is contravariance? Explain the 'in' keyword.
        /*
        
        Contravariance allows you to use a less derived type where a more derived type is expected.
        interface IConsumer<in T>
            {
                void Consume(T item);
            }

            class Animal {}
            class Dog : Animal {}

            class AnimalConsumer : IConsumer<Animal>
            {
                public void Consume(Animal item) => Console.WriteLine("Consuming an animal");
            }

            IConsumer<Animal> animalConsumer = new AnimalConsumer();
            IConsumer<Dog> dogConsumer = animalConsumer;
        
        
        */
   
    
        // Q17: What is the difference between covariance and contravariance?

        /*
        
        covariance read => out 

        contravariance  write => in

         covariance allows you to use a more derived type where a base type is expected, while contravariance allows you to use a less derived type where a more derived type is expected.  
        */
   

        // Q18: How do static members work in generic types?
        /*
        
        Static members in generic types are created separately for each closed generic type.        

        MyClass<int> has its own static members
        MyClass<string> has completely different static members
        
        They do NOT share the same static data.
        
        
        */


 }
    
}