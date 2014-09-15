﻿using System;

namespace AutoConfiguration.TestClient
{
    public interface IConfiguration
    {
        string TestString { get; set; }
        string TestString2 { get; set; }
    }

    public interface IAnotherConfiguration
    {
        //int TestInt { get; }
        int TestInt { get; set; }
    }

    public interface IDoubleDecimalConfiguration
    {
        //decimal TestDecimal { get; }
        double TestDouble { get; }
    }

    public interface IBoolConfiguration
    {
        bool TestBoolT { get; }
        //bool TestBoolF { get; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            /*var configuration = ConfigurationReader.Read<IConfiguration>();

            Console.WriteLine(configuration.TestString);
            Console.WriteLine(configuration.TestString2);
            configuration.TestString = "modified";

            Console.WriteLine(configuration.TestString);
            */
          /*  var configuration2 = ConfigurationReader.Read<IAnotherConfiguration>();
            Console.WriteLine(configuration2.TestInt);
            */
            /*var configuration3 = ConfigurationReader.Read<IDoubleDecimalConfiguration>();
            //Console.WriteLine(configuration3.TestDecimal);
            Console.WriteLine(configuration3.TestDouble);*/

            var configuration3 = ConfigurationReader.Read<IBoolConfiguration>();
            Console.WriteLine(configuration3.TestBoolT);
            //Console.WriteLine(configuration3.TestBoolF);
            
            Console.ReadKey();
        }
    }
}
