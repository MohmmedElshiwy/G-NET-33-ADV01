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
   
   
    }
    
}