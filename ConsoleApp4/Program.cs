using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
            //Named argumaents           //example 1
            //Named arguments free you from the need to remember the order of the parameters in a method call. Each argument can be specified by the matching parameter name.
            int re = Area(w: 5, h: 8);
            Console.WriteLine(re);
            */


            /*             //example 2
            //passing by output
            //Output parameters are similar to reference parameters, except that they transfer data out of the method rather than accept data in. They are defined using the out keyword.
            //The variable supplied for the output parameter need not be initialized since that value will not be used.Output parameters are particularly useful when you need to return multiple values from a method.
            int a, b;
            GetValues(out a, out b);
            Console.WriteLine(a + " " + b);
            */


            //you can not overload method declarations that differ only by return type


            /*
            //arrays
            //We can omit the size declaration when the number of elements are provided in the curly braces:
            //We can even omit the new operator. The following statements are identical to the ones above:
            string[] sd = { "jon", "ahmed", "malek" };
            */


            /*
            //jagged arrays
            //A jagged array is an array whose elements are arrays. So it is basically an array of arrays.
            //The following is a declaration of a single - dimensional array that has three elements, each of which is a single - dimensional array of integers
            int[][] m = new int[3][];
            //Each dimension is an array, so you can also initialize the array upon declaration like this
            int[][] n = new int[][]
            {
                new int[] {1,8,7,9},
            new int[] {2,4,6},
            new int[]{32,42}
            };
            //You can access individual array elements as shown in the example below:
            int x = n[2][1]; //42
            //A jagged array is an array-of-arrays, so an int[ ][ ] is an array of int[ ], each of which can be of different lengths and occupy their own block in memory. 
            //A multidimensional array(int[,]) is a single block of memory(essentially a matrix).It always has the same amount of columns for every row.
            */


            /*
            int[] arr = { 2, 4, 7 };
            Console.WriteLine(arr.Length);
            Console.WriteLine(arr.Rank);      //return the number of dimensions of the array
            */




            /*
            //string
            // It’s common to think of strings as arrays of characters. In reality, strings in C# are objects.
            //When you declare a string variable, you basically instantiate an object of type String.
            //String objects support a number of useful properties and methods:
            //Length returns the length of the string.
            //IndexOf(value) returns the index of the first occurrence of the value within the string.
            //Insert(index, value) inserts the value into the string starting from the specified index.
            //Remove(index) removes all characters in the string from the specified index.
            //Replace(oldValue, newValue) replaces the specified value in the string.
            //Substring(index, length) returns a substring of the specified length, starting from the specified index.If length is not specified, the operation continues to the end of the string.
            //Contains(value) returns true if the string contains the specified value.
            //Concat(string 1,string 2) combines the two strings
            string text = "this is some text about a dog. the word dog appeares in this text a number of times this is the end.";
            text = text.Replace("dog", "cat");
            text = text.Substring(0, text.IndexOf("." )+ 1);
            Console.WriteLine(text);
            */


            //constant variables are static variable by defualte


            /*                             //example 3
            //Static Constructors
            // Constructors can be declared static to initialize static members of the class.
            //The static constructor is automatically called once when we access a static member of the class.
            SomeClass A = new SomeClass();
            A.print();
            */


            //Another common use of this is for passing the current instance to a method as parameter: ShowPersonInfo(this)


            /*                     //example 4
           //readonly modifier
           //The readonly modifier prevents a member of a class from being modified after construction. It means that the field declared as readonly can be modified only when you declare it or from within a constructor.
           person a = new person("ahmed");
            */



            /*                  //example 5
            //indexer
            //arrays use integer indexers,but indexers can use any type of index,such as strings,characters,etc;
            //Declaration of an indexer is to some extent similar to a property. The difference is that indexer accessors require an index. 
            //Like a property, you use get and set accessors for defining an indexer.However, where properties return or set a specific data member, indexers return or set a particular value from the object instance.
            //Now, when we declare an object of class Clients, we use an index to refer to specific objects like the elements of an array:
            Clients c = new Clients();
            c[0] = "Dave";
            c[1] = "Bob";
            Console.WriteLine(c[1]);
            //You typically use an indexer if the class represents a list, collection, or array of objects.
            */



            /*                            //example 6
            //operator overloading
            //Most operators in C# can be overloaded, meaning they can be redefined for custom actions.
            //For example, you can redefine the action of the plus (+) operator in a custom class.
                Box b1 = new Box(14, 3);
                Box b2 = new Box(5, 7);
            //Overloaded operators are methods with special names, where the keyword operator is followed by the symbol for the operator being defined.
            //Similar to any other method, an overloaded operator has a return type and a parameter list.
            Box b3 = b1 + b2;
            Console.WriteLine(b3.Height);
            Console.WriteLine(b3.Width);
            */



            //It is not possible to modify an abstract class with the sealed modifier because the two modifiers have opposite meanings. The sealed modifier prevents a class from being inherited and the abstract modifier requires a class to be inherited.


            //Default implementation in interfaces allows to write an implementation of any method. This is useful when there is a need to provide a single implementation for common functionality.
            //Methods with default implementation can be freely overridden inside the class which implements that interface


            /*
                        Namespaces declare a scope that contains a set of related objects.
                            You can use a namespace to organize code elements.
                    You can define your own namespaces and use them in your program.
            The using keyword states that the program is using a given namespace.
            For example, we are using the System namespace in our programs, which is where the class Console is defined:
            //using.System ......Console.WriteLine();
            Without the using statement, we would have to specify the namespace wherever it is used
                    System.Console.WriteLine();
            */


            /*
             //structs
            // Unlike classes, structs can be instantiated without using a new operator.
            //example:Book a;
            //Structs do not support inheritance and cannot contain virtual methods.
            //Structs can contain methods, properties, indexers, and so on.
            //Structs cannot contain default constructors (a constructor without parameters), but they can have constructors that take parameters. In that case the new keyword is used to instantiate a struct object, similar to class objects.
            //example: Book a=new Book(10,11);
            //All standard C# types (int, double, bool, char, etc.) are actually structs.
            */



            /*            //example 7
            //enums                 
            //You can refer to the values in the Enum with the dot syntax.
           // In order to assign Enum values to int variables, you have to specify the type in parentheses:
            int x = (int)days.tue;
            Console.WriteLine(x);
            */



            /*
            //exeptions
            int[] arr = new int[] { 1, 2, 3, 4 };
            try
            {  
                Console.WriteLine(arr[1]/0);
            }
            
            catch (DivideByZeroException n)
            {
                Console.WriteLine("cannot divide by zero");
            }
            //A single try block can contain multiple catch blocks that handle different exceptions separately.
            //We use the general Exception type to handle all kinds of exceptions. We can also use the exception object e to access the exception details, such as the original error message (e.Message):
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("an error");
            }
            //The above code handles the DivideByZeroException separately. The last catch handles all the other exceptions that might occur. If multiple exceptions are handled, the Exception type must be defined last.
            //The following exception types are some of the most commonly used: FileNotFoundException, FormatException, IndexOutOfRangeException, InvalidOperationException, OutOfMemoryException.

            //An optional finally block can be used after the catch blocks.The finally block is used to execute a given set of statements, whether an exception is thrown or not.
            finally{
                Console.WriteLine(arr[0]);
            }
            */



            /*
            //files
            //writig to files
            //The System.IO namespace has various classes that are used for performing numerous operations with files, such as creating and deleting files, reading from or writing to a file, closing a file, and more.The File class is one of them.
            string str = "Hello world";
            File.WriteAllText("text.txt", str);
            //You can read the content of a file using the ReadAllText method of the File class:
            string txt = File.ReadAllText("text.txt");
            Console.WriteLine(txt);
            //This will output the content of the test.txt file.
            //The following methods are available in the File class:
            //AppendAllText() - appends text to the end of the file.
            //Create() - creates a file in the specified location.
            //Delete() - deletes the specified file.
            //Exists() - determines whether the specified file exists.
            //Copy() - copies a file to a new location.
            //Move() - moves a specified file to a new location

            //All methods automatically close the file after performing the operation.

            //example:
            //Q:Drag and drop from the options below to check if the file "names.txt" exists. If it does, add "David" to the end of the file.

            if(File.Exists("names.txt")) {
                File.AppendAllText("names.txt","Daivd" );
            }
            */



            /*                              //example 8         
            int x=5, y=6;
            swap<int>(ref x,ref y);
            Console.WriteLine("X={0} , Y={1}", x, y);
            string v = "hello",m="Hi";
            swap<string>(ref v, ref m);
            Console.WriteLine("V={0} , M={1}", v, m);
            //If you omit specifying the type when calling a generic method, the compiler will use the type based on the arguments passed to the method.
            //Multiple generic parameters can be used with a single method.
For example: //Func<T, U> takes1two different generic types.
            */



            /*                          //example 9
            //generic class
            Stack<int> intStack = new Stack<int>();
            Stack<string> strStack = new Stack<string>();
            //We can also use the generic class with custom types, such as the custom defined Person type.
            //Stack<Person> PersonStack = new Stack<Person>();
            intStack.Push(5);
            intStack.Push(6);
            intStack.Pop();
            intStack.Push(7);
            Console.WriteLine( intStack.Get(1));
            */



            /*
            The System.Collections.Generic namespace includes the following generic collections:
            - List<T>
            - Dictionary<TKey, TValue>
            - SortedList<TKey, TValue>
            - Stack<T>
            - Queue<T>
            - Hashset<T>


        Non-generic collections can store items that are of type Object.
        Since an Object data type can refer to any data type, you run the risk of unexpected outcomes.
            Non-generic collections may also be slower to access as well as execute.
            The System.Collections namespace includes the following non-generic collections:
            - ArrayList
            - SortedList
            - Stack
            - Queue
            - Hashtable
            - BitArray
        Because non-generic collections are error prone and less performant, it is recommended to always use generic collections from the System.Collections.Generic namespace if available and to avoid using legacy collections from the System.Collections namespace.
        */



            /*

               The C# generic collection List<T> class requires all elements be of the same type T.

   List<T> properties and methods include:
   Count A property that gets the number of elements contained in the list.
   Item[int i] Gets or sets the element in the list at the index i. Item is the indexer and is not required when accessing an element. You only need to use the brackets [] and the index value inside the brackets.
   Add(T t) Adds an element t to the end of the list.
   RemoveAt(int index) Removes the element at the specified position (index) from the list.
   Sort() Sorts elements in the list.
            Capacity - A property that gets the number of elements the list can hold before needing to be resized.

Clear() - Removes all the elements from the list.

TrimExcess() - Sets the capacity to the actual number of elements in the list. This is useful when trying to reduce memory overhead.

AddRange(IEnumerable coll) - Adds the elements of collection coll with elements of the same type as List<T> to the end of the list. IEnumerable is the collections interface that supports simple iteration over the collection.

Insert(int i, T t) - Inserts an element t at a specific index i in the list.

InsertRange(int i, IEnumerable coll) - Inserts the elements of a collection coll at a specified index i in the list. IEnumerable is the collections interface that supports simple iteration over the collection.

Remove(T t) - Removes the first occurrence of the object t from the list.

RemoveRange(int i, int count) - Removes a specified number of elements count from the list starting at a specified index i.

Contains(T t) - Returns true if the specified element t is present in the list.

IndexOf(T t) - Returns the index of the first occurrence of the element t in the list.

Reverse() - Reverses the order of the elements in the list.

ToArray() - Copies the elements of the list into a new array.
               */


            /*
            //sortedlist
            //A sorted list is a collection of key/value pairs that are sorted by key. A key can be used to access its corresponding value in the sorted list.
            //The C# generic collection SortedList<K, V> class requires all element key/value pairs to be of the same type K, V. Duplicate keys are not permitted, which ensures that every key/value pair is unique.
            SortedList<K, V> properties include:
            Count - Gets the number of key/ value pairs contained in the sorted list.
             Item[K key] - Gets or sets the value associated the specified key contained in the sorted list.Item is the indexer and is not required when accessing an element.You only need to use the brackets[] and the key, value.
            Keys - Gets a sorted and indexed collection containing only the keys in the sorted list.

            SortedList<K, V> methods include:
            Add(K key, V value) - Adds an element with a specific key, value pair into the sorted list.
            Remove(K key) - Removes the element with the specific key, value pair associated with the specified key from the sorted list.
            Values - Gets a sorted and indexed collection of the values in the sorted list.
            Clear() - Removes all the elements from the sorted list.
            ContainsKey(K key) - Returns true when the specified key is present in the sorted list.
            ContainsValue(V value) - Returns true when a specified value is present in the sorted list.
            IndexOfKey(K key) - Returns the index of the specified key within the sorted list.
            IndexOfValue(V value) - Returns the index of the specified value within the sorted list.
            */



            /*
            //example on sortedlist
            SortedList<string, int> a = new SortedList<string, int>();
            a.Add("ali", 2);
            a.Add("ahmed", 8);
            a.Add("asma", 3);
            foreach (string s in a.Keys)
                Console.WriteLine(a[s]);
            */


            /*
            //BitArray
            A bit array is a collection of bits. The value of a bit can be either 0(off / false) or 1(on / true).
            Bit arrays compactly store bits.Most commonly, they are used to represent a simple group of boolean flags or an ordered sequence of boolean values.

            BitArray properties include:
            Count - Gets the number of bits in the bit array.
            IsReadOnly - Gets a value indicating if the bit array is read only or not.

            BitArray methods include:
            Get(int i) - Gets the value of the bit at a specified position i in the bit array.
            Set(int i, bool value) - Sets the bit at a specified position i to a specified value in the bit array.
            SetAll(bool value) - Sets all the bits to a specified value in the bit array.
            And(BitArray ba) - Performs the bitwise AND operation on the elements of the bit array object with a specified bit array ba.
            Or(BitArray ba) - Performs the bitwise OR operation on the elements of the bit array and the specified bit array ba.
            Not() - Inverts the bit values of the bit array.
            Xor(BitArray ba) - Performs the bitwise XOR operation on the elements of the current bit array object and the elements in the specified bit array ba.
                */



            /*                 //exampele 10
            //example of Bitarray
            BitArray a = new BitArray(4);
            BitArray b = new BitArray(4);
            a.SetAll(true);
            b.SetAll(false);
            a.Set(2, false);
            b.Set(3, true);
            print("a", a);
            print("b", b);
            Console.WriteLine();
            print("a and b" , a.And(b));
            print("not a",a.Not());
            */



            /*
            BitArray ba1 = new BitArray(4);
            BitArray ba2 = new BitArray(4);
            ba1.SetAll(true);
            ba2.SetAll(false);
            ba1.Set(2, false);
            ba2.Set(3, true);
            Console.Write(ba1.And(ba2).Get(3));
            */


            /*
            Stack<T> properties include:
            Count - Returns the number of elements in the stack.

            Stack<T> methods include:
            Peek() - Returns the element at the top of the stack without removing it.
            Pop() - Returns the element at the top of the stack and removes it from the stack.
            Push(T t) - Inserts an element t at the top of the stack.
            Clear() - Removes all the elements from the stack.
            Contains(T t) - Returns true when the element t is present in the stack.
            ToArray() - Copies the stack into a new array.
            */



            /*
            Queue<T> properties include:
            Count - Gets the number of elements in the queue.
            And methods include:
            Dequeue() - Returns the object at the beginning of the queue and also removes it.
            Enqueue(T t) - Adds the object t to the end of the queue
            Clear() - Removes all objects from the queue.
            Contains(T t) - Returns true when the element t is present in the queue.
            Peek() - Returns the object at the beginning of the queue without removing it.
            ToArray() - Copies the queue into a new array.
                */


            /*
            //Dictionary<U, V>
            A dictionary is a collection of unique key / value pairs where a key is used to access the corresponding value.
                Dictionaries are used in database indexing, cache implementations, and so on.
             The C# generic collection Dictionary<K, V> class requires all key/value pairs be of the same type K, V.
             Duplicate keys are not permitted to ensure that every key/value pair is unique.
             Dictionary<K, V> properties include:
            Count - Gets the number of key/ value pairs contained in the dictionary.
            Item[K key] - Gets the value associated with the specified key in the dictionary. Item is the indexer and is not required when accessing an element.You only need to use the brackets[] and key value.
            Keys - Gets an indexed collection containing only the keys contained in the dictionary.
                Dictionary<K, V> methods include:
            Add(K key, V value) - Adds the key, value pair to the dictionary.
            Remove(K key) - Removes the key/ value pair related to the specified key from the dictionary
            Here are the additional Dictionary<K, V> properties and methods:
            Values - Gets an indexed collection containing only the values in the dictionary.
            Clear() - Removes all the key / value pairs from the dictionary.
            ContainsKey(K key) - Returns true if the specified key is present in the dictionary.
            ContainsValue(V value) - Returns true if the specified value is present in the dictionary
            */



            /*
            //example of dictionary
            Dictionary<string, int> a = new Dictionary<string, int>();
            a.Add("uo", 2);
            a.Add("on", 4);
            a.Add("ol", 2);
            a.Add("ow", 3);
            a.Remove("on");
            Console.WriteLine("Dictionary: ");
            foreach (string s in a.Keys)
                Console.WriteLine(s + " : " + a[s]);
            Console.WriteLine("\ncount: " + a.Count);
            */


            /*
            //HashSet<T>
            A hash set is a set of unique values where duplicates are not allowed.

            C# includes the HashSet<T> class in the generic collections namespace. All HashSet<T> elements are required to be of the same type T.
            Hash sets are different from other collections because they are simply a set of values. They do not have index positions and elements cannot be ordered.
            The HashSet<T> class provides high-performance set operations.
            HashSets allow fast lookup, addition, and removal of items, and can be used to implement either dynamic sets of items or lookup tables that allow finding an item by its key(e.g., finding the phone number of a person by the last name).

            HashSet<T> properties include:
            Count Returns the number of values in the hash set.

            And methods include:
            Add(T t) Adds a value(t) to the hash set.
            IsSubsetOf(ICollection c) Returns true if the hash set is a subset of the specified collection(c).
            Remove(T t) Removes the value(t) from the hash set.
            Clear() Removes all the elements form the hash set.
            Contains(T t) Returns true when a value(t) is present in the hash set.
            ToString() Creates a string from the hash set.
            IsSupersetOf(ICollection c) Returns true if the hash set is a superset of the specified collection.
            UnionWith(ICollection c) Applies set union operation on the hash set and the specified collection(c).
            IntersectWith(ICollection c) Applies set intersection operation on the hash set and the specified collection(c).
            ExceptWith(ICollection c) Applies set difference operation on the hash set and the specified collection(c).
            */


            /*
            //example on hashset
            HashSet<int> sh = new HashSet<int>();
            sh.Add(5);
            sh.Add(10);
            sh.Add(15);
            sh.Add(20);
            Console.WriteLine("HashSet:");
            foreach (int i in sh)
                Console.WriteLine(i + " ");
            HashSet<int> sh2 = new HashSet<int>();
            sh2.Add(5);
            sh2.Add(20);
            Console.WriteLine("is it subset?" + sh2.IsSubsetOf(sh));
            */



            /*
            int discount = Convert.ToInt32(Console.ReadLine());
            Dictionary<string, int> coffee = new Dictionary<string, int>();
            coffee.Add("Americano", 50);
            coffee.Add("Latte", 70);
            coffee.Add("Flat White", 60);
            coffee.Add("Espresso", 60);
            coffee.Add("Cappuccino", 80);
            coffee.Add("Mocha", 90);
            Dictionary<string, int> withdiscount = new Dictionary<string, int>();
            foreach(string s in coffee.Keys)
            {
                withdiscount[s] = coffee[s]-(coffee[s]*discount/100);
            }
            foreach(KeyValuePair<string,int> s in withdiscount)
            {
                Console.WriteLine(s.Key + ": " + s.Value);
            }
            */

            Console.ReadKey();
        }


        /*                       //example 1
         static int Area(int h, int w)
        {
            return w*2;
        }
        */


        /*           //example 2
        static void GetValues(out int x,out int y)
        {
            x = 5;
            y = 42;
        }
        */



            /*     //example 7
        enum days { sun, mon, tue, wen, thi, fri, sat };
        */



        /*                                             //example 8
        //generic
        static void swap<t>(ref t x,ref t y)
        {
            t temp = x;
            x = y;
            y = temp;
        }
        */


        /*                  //example 10
        static void print(string name,BitArray x)
        {
            Console.WriteLine(name + " : ");
            for (int i = 0; i < x.Length; i++)
                Console.WriteLine(x.Get(i)+" ");
            Console.WriteLine();
        }
        */
    }

    /*                          example 3
    class SomeClass
    {
        public static int X { get; set; }
        public static int Y { get; set; }
        static SomeClass()
        {
            X = 10;
            Y = 20;
        }
        ~SomeClass()            // destructor does not accept parameter
        {
            Console.WriteLine("hi");
        }
        public void print()
        {
            Console.WriteLine(X + "  " + Y);
        }
    }
    */


    /*                        //example 4
   class person
   {
       private readonly string name = "jhon";
   //There are three major differences between readonly and const fields. 
   //Second, a readonly field value can be changed in a constructor, but a constant value cannot.
   public person(string name)       //it can be modified only when you declare it or from within a constructor                                         
       {
           this.name = name;
       }
   //First, a constant field must be initialized when it is declared, whereas a readonly field can be declared without initialization, as in:
   readonly string id;
   const double ip = 3;   //we should give it a value
   //Third, the readonly field can be assigned a value that is a result of a calculation, but constants cannot, as in:
   readonly double a = Math.Sin(60);   //but we can not do it if it was constant
}
    */



    /*                   //example 5
    //Indexers are defined with the this keyword
    class Clients
    {
        private string[] name = new string[10];
        public string this[int index]
        {
            get { return name[index]; }
            set { name[index] = value; }
        }
        //As you can see, the indexer definition includes the this keyword and an index, which is used to get and set the appropriate value.
    }
    */

     /*                   //example 6
    class Box
    {
        public int Height { get; set; }
        public int Width { get; set; }
        public Box(int h, int w)
        {
            Height = h;
            Width = w;
        }
        public static Box operator +(Box a, Box b) //Additionally, the overloaded operator must be static.
        {
            int h = a.Height + b.Height;
            int w = a.Width + b.Width;
            Box res = new Box(h, w);
            return res;
        }
        //All arithmetic and comparison operators can be overloaded. For instance, you could define greater than and less than operators for the boxes that would compare the Boxes and return a boolean result. Just keep in mind that when overloading the greater than operator, the less than operator should also be defined.
        public static bool operator >(Box a,Box b) {
  if (a.Height*a.Width > b.Height*b.Width)
  return true;
  else
    return false;
}
        public static bool operator <(Box a, Box b)
        { 
            if (a.Height * a.Width < b.Height * b.Width)
                return true;
            else
                return false;
        }
    }  
     */

     
    /*                           //example 9
    class Stack<T>
    {
        int index = 0;
        T[] innerArray = new T[100];
        public void Push(T item)
        {
            innerArray[index++] = item;
        }
        public T Pop()
        {
            return innerArray[--index];
        }
        public T Get(int k) { return innerArray[k]; }
    }
    */



}
