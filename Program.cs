// See https://aka.ms/new-console-template for more information
using System.IO;

string writeText = "File content :: Hello World!";
Console.WriteLine("Hello, World!");

File.WriteAllText("test.txt", writeText);

string readText = File.ReadAllText("test.txt");
Console.WriteLine(readText);


// if (File.Exists("test1.txt"))
// {
//     string readText = File.ReadAllText("test1.txt");
//     Console.WriteLine(readText);
// }

if (File.Exists("test1.txt"))
{
    File.Delete("test.txt");
    if (File.Exists("test.txt") == false)
        Console.WriteLine("File deleted...");

}
else
    Console.WriteLine("File test1.txt does not yet exist!");


if (Directory.Exists("testdir"))
{
    Directory.Delete("testdir");
    if (Directory.Exists("testdir") == false)
        Console.WriteLine("Directory deleted...");
}
else
    Console.WriteLine("Directory testdir does not yet exist!");




if (File.Exists("test.txt"))
{
    Console.WriteLine("Please enter a new name for this file:");
    string newFilename = Console.ReadLine();
    if (newFilename != String.Empty)
    {
        File.Move("test.txt", newFilename);
        if (File.Exists(newFilename))
        {
            Console.WriteLine("The file was renamed to " + newFilename);
            Console.ReadKey();
        }
    }
}



if (Directory.Exists("testdir"))
{
    Console.WriteLine("Please enter a new name for this directory:");
    string newDirName = Console.ReadLine();
    if (newDirName != String.Empty)
    {
        Directory.Move("testdir", newDirName);
        if (Directory.Exists(newDirName))
        {
            Console.WriteLine("The directory was renamed to " + newDirName);
            Console.ReadKey();
        }
    }
}


Console.WriteLine("Please enter a name for the new directory:");
string newDirName1 = Console.ReadLine();
if (newDirName1 != String.Empty)
{
    Directory.CreateDirectory(newDirName1);
    if (Directory.Exists(newDirName1))
    {
        Console.WriteLine("The directory was created!");
        string fileContents = "John Doe & Jane Doe sitting in a tree...";
        File.WriteAllText($"{newDirName1}/test.txt", fileContents);
    }
}

// FileStream f1 = new FileStream("file.txt", FileMode.OpenOrCreate);  
//        StreamWriter s1 = new StreamWriter(f1);  
//        s1.WriteLine("File Handling in C#");  
//        s1.Close();  
//        f1.Close();  
//        FileStream f2 = new FileStream("e:\\file.txt", FileMode.OpenOrCreate);  
//        StreamReader s2 = new StreamReader(f2);  
//        string data = s2.ReadLine();  
//        Console.WriteLine("The data in the file is as follows:");  
//        Console.WriteLine(data);  
//        s2.Close();  
//        f2.Close();  


// AppendText()	Appends text at the end of an existing file
// Copy()	Copies a file
// Create()	Creates or overwrites a file
// Delete()	Deletes a file
// Exists()	Tests whether the file exists
// ReadAllText()	Reads the contents of a file
// Replace()	Replaces the contents of a file with the contents of another file
// WriteAllText()	Creates a new file and writes the contents to it. If the file already exists, it will be overwritten.


