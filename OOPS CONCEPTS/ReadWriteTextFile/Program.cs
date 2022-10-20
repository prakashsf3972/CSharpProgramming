using System;
using System.IO;
namespace SysteTextFile;
class Program{
    public static void Main(string[] args)
    {
        if(!Directory.Exists("TestFolder"))
        {
            Directory.CreateDirectory("TestFolder");
            System.Console.WriteLine("Folder Created");
        }
        else
        {
            System.Console.WriteLine("Folder Exists");
        }
        if(!File.Exists("TestFolder/Test.txt"))
        {
            File.Create("TestFolder/Test.txt");
            System.Console.WriteLine("File Created");
        }
        else
        {
            System.Console.WriteLine("File Found");
        }
        System.Console.WriteLine("Select Option 1.ReadFile Info 2.Write File Info");
        int option=int.Parse(Console.ReadLine());
        switch(option)
        {
            case 1:
            {
                String line;
                StreamReader sr=null;
                try
                {
                    //Pass the File Path and File Name to the StreamReader Constructor

                    sr=new StreamReader("TestFolder/Test.txt");
                    line=sr.ReadLine(); //Read the First Line Of Text
                    while(line != null)
                    {
                        System.Console.WriteLine(line); //Write the line to Console Window
                        line=sr.ReadLine(); //Read the First Line of the Text
                    }
                }catch(Exception e) 
                {Console.WriteLine("Exception :"+e.Message);}
                finally
                {
                    if(sr!=null){System.Console.WriteLine("Executing Finally Block."); sr.Close();}}
                    break;
                }
                case 2:
                StreamReader sw=null;
                try
                {
                        string [] old=File.ReadAllLines("TestFolder/Test.txt");
                        //pass the FilePath and FileName to the StreamWriter Constructor to Open File
                        sw=new StreamReader("TestFolder/Test.txt");
                        System.Console.WriteLine("Enter a new content to Placed In file");
                        string info=Console.ReadLine();
                        string old1="";
                        foreach(string text in old)
                        {
                            old1=old1+"\n"+text;//Append Old text in File to make it as a single string
                        }
                        old1=old1+"\n"+info; //Append our new user input to Old Text
                        sw.WriteLine(old1); //write to File
                }
                        catch (System.Exception)
                        {
                            
                            throw;
                        }
            }
        }
    }

