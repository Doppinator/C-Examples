using System.IO;

namespace CSFUndamentals
{
    class Program
    {
        static void Main(string[] args)
        {

            var defaultPath = @"G:\NET\Files";
            string workingPath;
            Console.WriteLine("The default base path is " + defaultPath + "\n");
            Console.WriteLine("Enter to accept or specify a new path\n");
            var pathSelect = Console.ReadLine();

            if (string.IsNullOrEmpty(pathSelect)) {
                workingPath = defaultPath;
                Console.WriteLine("Path is " +  workingPath + "\n");
                    }
            else
            {
                workingPath = pathSelect;
                Console.WriteLine("Path is " + workingPath + "\n");
            }

            Console.WriteLine("Available commands: \nList (List contents of current path)\nCopy <filename.ext, newfilename.ext> (Copy specified file)\nRead <filename.txt> (Read contents of a file)\n");
            var userInput = Console.ReadLine();

            if (string.IsNullOrEmpty(userInput))
            {
                Console.WriteLine("Please try again");
                userInput = Console.ReadLine();
            }

            else
            {
                string[] inputElements = userInput.Split(" ");
                // Console.WriteLine("Command: " + inputElements[0] + ", selected file: " + inputElements[1]);

                var userCommand = inputElements[0];

                if (userCommand == "List")
                {
                    var listDir = Directory.GetFiles(workingPath, "*.*", SearchOption.AllDirectories);
                    foreach (var file in listDir)
                    {
                        Console.WriteLine(file + "\n");
                    }

                }

                else if (!string.IsNullOrEmpty(inputElements[1]))
                {
                    var fileName = inputElements[1];

                    if (userCommand == "Read")
                    {
                        if (File.Exists(workingPath + @"\" + fileName))
                        {
                            var content = File.ReadAllText(workingPath + @"\" + fileName);
                            Console.WriteLine(content);
                        }
                        else
                        {
                            Console.WriteLine("File does not exist, try new filename\n");
                            fileName = Console.ReadLine();

                        }

                    }
                }

                else
                {
                    Console.WriteLine("Invalid Command");
                }
            }
            
            Console.ReadLine();
        }
    }
}

/*
              File.Copy(@"G:\NET\Files\FileToCopy.txt", @"G:\NET\Files\CopiedFile.txt");




            File.Delete(filePath + @"\FileToDelete.txt");
            Console.WriteLine("Deleted deletable file in" + filePath);

*/