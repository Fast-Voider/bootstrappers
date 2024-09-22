using System.Diagnostics;
using System.IO.Compression;

class BootStrapper
{
    static async Task Main(string[] args)
    {
        // VARIABLES
        string downloadUrl = "https://github.com/Fast-Voider/Bootstrapper-testing/raw/main/test.zip"; // Replace with your actual URL
        string zip = "test.zip";
        string file = "FemboyExec.exe";
        // VARIABLES

        Console.Write("$$$$$$$\\                       $$\\      $$$$$$\\    $$\\                                                                 \n");
        Console.Write("$$  __$$\\                      $$ |    $$  __$$\\   $$ |                                                                \n");
        Console.Write("$$ |  $$ | $$$$$$\\   $$$$$$\\ $$$$$$\\   $$ /  \\__|$$$$$$\\    $$$$$$\\  $$$$$$\\   $$$$$$\\   $$$$$$\\   $$$$$$\\   $$$$$$\\  \n");
        Console.Write("$$$$$$$\\ |$$  __$$\\ $$  __$$\\_$$  _|  \\$$$$$$\\  \\_$$  _|  $$  __$$\\ \\____$$\\ $$  __$$\\ $$  __$$\\ $$  __$$\\ $$  __$$\\ \n");
        Console.Write("$$  __$$\\ $$ /  $$ |$$ /  $$ | $$ |     \\____$$\\   $$ |    $$ |  \\__|$$$$$$$ |$$ /  $$ |$$ /  $$ |$$$$$$$$ |$$ |  \\__|\n");
        Console.Write("$$ |  $$ |$$ |  $$ |$$ |  $$ | $$ |$$\\ $$\\   $$ |  $$ |$$\\ $$ |     $$  __$$ |$$ |  $$ |$$ |  $$ |$$   ____|$$ |      \n");
        Console.Write("$$$$$$$  |\\$$$$$$  |\\$$$$$$  | \\$$$$  |\\$$$$$$  |  \\$$$$  |$$ |     \\$$$$$$$ |$$$$$$$  |$$$$$$$  |\\$$$$$$$\\ $$ |      \n");
        Console.Write("\\_______/  \\______/  \\______/   \\____/  \\______/    \\____/ \\__|      \\_______|$$  ____/ $$  ____/  \\_______|\\__|      \n");
        Console.Write("                                                                              $$ |      $$ |                          \n");
        Console.Write("                                                                              $$ |      $$ |                          \n");
        Console.Write("                                                                              \\__|      \\__|                          \n");



        // DO NOT EDIT BELOW THIS IF YOU DONT KNOW WHAT YOUR DOING!!
        // DO NOT EDIT BELOW THIS IF YOU DONT KNOW WHAT YOUR DOING!!
        // DO NOT EDIT BELOW THIS IF YOU DONT KNOW WHAT YOUR DOING!!
        // DO NOT EDIT BELOW THIS IF YOU DONT KNOW WHAT YOUR DOING!!
        // DO NOT EDIT BELOW THIS IF YOU DONT KNOW WHAT YOUR DOING!!
        // DO NOT EDIT BELOW THIS IF YOU DONT KNOW WHAT YOUR DOING!!
        // DO NOT EDIT BELOW THIS IF YOU DONT KNOW WHAT YOUR DOING!!
        // DO NOT EDIT BELOW THIS IF YOU DONT KNOW WHAT YOUR DOING!!
        // DO NOT EDIT BELOW THIS IF YOU DONT KNOW WHAT YOUR DOING!!
        // DO NOT EDIT BELOW THIS IF YOU DONT KNOW WHAT YOUR DOING!!


        string tempPath = Path.GetTempPath();
        string zipFilePath = Path.Combine(tempPath, zip);
        string extractPath = Path.Combine(tempPath, Path.GetFileNameWithoutExtension(zip));


        using (HttpClient client = new HttpClient())
        {
            byte[] fileBytes = await client.GetByteArrayAsync(downloadUrl);
            await File.WriteAllBytesAsync(zipFilePath, fileBytes);
        }



        if (Directory.Exists(extractPath))
        {
            Directory.Delete(extractPath, true);
        }
        ZipFile.ExtractToDirectory(zipFilePath, extractPath);


        string exeFilePath = Path.Combine(extractPath, file);
        if (File.Exists(exeFilePath))
        {
            Process.Start(exeFilePath);
        }



        if (File.Exists(zipFilePath))
        {
            File.Delete(zipFilePath);
        }

    }
}
