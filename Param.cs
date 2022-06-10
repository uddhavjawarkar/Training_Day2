using System;
//In this example, we are using object type params that allow entering any number of inputs of any type.
namespace Training_Day2
{
    public class ParamKey
    {
        public void show(params object[] items) //Param Parameter
        {
            for(int i=0;i<items.Length;i++)
            {
                Console.WriteLine(items[i]);
            }
        }
        static void Main(string[] args)
        {
            ParamKey paramkey = new ParamKey();
            paramkey.show("Ram Acharya","Ramesh",101,102,20.50,"Peter","A");
            
        }
    }
}
