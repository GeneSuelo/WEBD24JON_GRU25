string fileName = "mytest.txt";
try
{
    if (File.Exists(fileName))
    {
        File.Delete(fileName);
    }
    Console.WriteLine("\n\n Create a file with text and read the file: \n");
    Console.Write("-------------------------------------------------------\n");

    // Create a file with text
    using (StreamWriter fileStr = File.CreateText(fileName))
    {
        fileStr.WriteLine("Hello and welcome");
        fileStr.WriteLine("It is the first content");
        fileStr.WriteLine("of the text file mytest.txt");
    }

    // Read the file
    using (StreamReader sr = File.OpenText(fileName))
    {
        string s = "";
        Console.WriteLine("Here is the content of the file mytest.txt: ");
        while ((s = sr.ReadLine()) != null)
        {
            Console.WriteLine(s);
        }
    }
}
catch (Exception MyExcep)
{
    Console.WriteLine(MyExcep.ToString());
}



