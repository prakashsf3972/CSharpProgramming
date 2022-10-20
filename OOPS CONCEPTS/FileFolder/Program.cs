using System;
using System.IO;
namespace FileFolder;
class Program{
    public static void Main(string[] args)
    {
        string path=@"C:\Users\PrakashKannan\OneDrive - Syncfusion\Desktop\MyFolder";

        string folderPath=path+"/Prakash";
        if(!Directory.Exists(folderPath))
        {
            System.Console.WriteLine("Folder not Found.So,Creating Folder");
            Directory.CreateDirectory(folderPath);
        }
        else
        {
            System.Console.WriteLine("Directory Found");
        }
        string filePath=path+"/newFile.txt";
        if(!File.Exists(filePath))
        {
            System.Console.WriteLine("File Not Found.creating File");
            File.Create(filePath);
        }
        else{
            System.Console.WriteLine("File Already Excists");
        }
        System.Console.WriteLine("Select Option 1.Create Folder 2.Create File 3.Delete Folder 4.Delete File");
        int num= int.Parse(Console.ReadLine());

        switch(num)
        {
            case 1:
            {
                System.Console.WriteLine("Enter Folder name you want to Create");
                string name1=Console.ReadLine();
                string newPath=path+"name1";
                if(!Directory.Exists(newPath))
                {
                    System.Console.WriteLine(newPath);
                }
                else{
                    System.Console.WriteLine("Directory Name Already Excits");
                }
                break;
            }
            case 2:
            {
                System.Console.WriteLine("Enter File name You Want to create");
                string fileName=Console.ReadLine();
                System.Console.WriteLine("Enter File Extension you want to Create");
                string extension=Console.ReadLine();
                string newPath=path+"\\"+fileName+"."+extension;
                if(!File.Exists(newPath))
                {
                    File.Create(newPath);
                }
                else{
                    System.Console.WriteLine("File Name Already Exsists");
                }
                break;
            }
            case 3:
            {
                foreach(string name in Directory.GetDirectories(path))//it is like File manager
                {
                    System.Console.WriteLine(name);
                }
                System.Console.WriteLine("Select folder you want to delete");
                string name1=Console.ReadLine();
                string newPath=path+"\\"+name1;
                  try{
                    foreach(string name in Directory.GetDirectories(path))
                    {
                        if(name==newPath)//check folder path
                        {
                            Directory.Delete(newPath);
                            System.Console.WriteLine("Folder Deleted");
                        }
                    }
                  }
                  catch(DirectoryNotFoundException e)
                  {
                    System.Console.WriteLine("Directory Not Found");
                  }
                break;
            }
            case 4:
            {
                foreach(string name in Directory.GetFiles(path))
                {
                    System.Console.WriteLine(name);
                }
                System.Console.WriteLine("Select File you want to Delete");
                string name1=Console.ReadLine();
                System.Console.WriteLine("Enter File Extension you want to Delete");
                string name2=Console.ReadLine();
                string newPath=path+"\\"+name1+"."+name2;
                foreach(string name in Directory.GetFiles(path))
                {
                    if(name==newPath)
                    {
                        File.Delete(newPath);
                        Console.WriteLine("File Deleted");
                    }
                }
                break;
            }
        }
    }
}
