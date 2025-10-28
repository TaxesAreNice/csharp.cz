using System;
using System.Linq;
using System.Collections.Generic;
using System.IO;

const string BaseFolder = @"C:\TestAppsC#";
Directory.CreateDirectory(BaseFolder); 
const string FileName = "apps.txt";
string FilePath = Path.Combine(BaseFolder, FileName);



List<string> Apps = new List<string>();

LoadApps();

int programRunning = 1;

while (programRunning == 1)
{
    string Option = Options();
    Action(Option);

    string Options()
    {
        Console.WriteLine("Pick from these: \n(1) Add an app\n(2) Show all the apps\n(3) Find the app from the name\n(4) Delete an app\n(5) End the program");
        string? option = Console.ReadLine();
        return option?.Trim() ?? "";
    }

    void Action(string option)
    {
        switch (option)
        {
            case "1":
                AddApp();
                break;
            case "2":
                ShowApps();
                break;
            case "3":
                FindApp();
                break;
            case "4":
                DeleteApp();
                break;
            case "5":
                EndProgram();
                break;
            default:
                Console.WriteLine("\nJust pick from 1–5, bro\n-------------");
                break;
        }
    }

    void AddApp()
    {
        Console.WriteLine("\nWhat app do you wanna add?\nTyping 'back' will send you back");
        string? raw = Console.ReadLine();
        string appApp = raw?.Trim() ?? "";

        if (appApp.Equals("back", StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine();
            return;
        }

        if (string.IsNullOrWhiteSpace(appApp))
        {
            Console.WriteLine("Nothing was added");
            return;
        }

        if (Apps.Any(a => a.Equals(appApp, StringComparison.OrdinalIgnoreCase)))
        {
            Console.WriteLine("It's already there");
            return;
        }

        Apps.Add(appApp);
        SaveApps();
        Console.WriteLine($"You added {appApp} to the apps list\n-------------");
    }

    void ShowApps()
    {
        if (Apps.Count == 0)
        {
            Console.WriteLine("\nNo apps added yet\n-------------");
            return;
        }

        Console.WriteLine("\nHere are all the apps:");
        foreach (string app in Apps.OrderBy(a => a, StringComparer.OrdinalIgnoreCase))
        {
            Console.WriteLine($"- {app}");
        }
        Console.WriteLine("-------------");
    }

    void FindApp()
    {
        if (Apps.Count == 0)
        {
            Console.WriteLine("\nNo apps added yet\n-------------");
            return;
        }

        Console.WriteLine("\nType the name of the app you want to find:\nTyping 'back' will send you back");
        string? raw = Console.ReadLine();
        string appName = raw?.Trim() ?? "";

        if (string.IsNullOrEmpty(appName))
        {
            Console.WriteLine("what chu doing bro?\n-------------");
            return;
        }

        if (appName.Equals("back", StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine();
            return;
        }

        bool found = Apps.Any(a => a.Equals(appName, StringComparison.OrdinalIgnoreCase));

        Console.WriteLine(found
            ? $"{appName} is in the apps list\n-------------"
            : $"{appName} is not in the apps list\n-------------");
    }

    void DeleteApp()
    {
        if (Apps.Count == 0)
        {
            Console.WriteLine("\nNo apps added yet\n-------------");
            return;
        }

        Console.WriteLine("\nType the name of the app you want to delete:\nTyping 'back' will send you back");
        string? raw = Console.ReadLine();
        string appName = raw?.Trim() ?? "";

        if (string.IsNullOrEmpty(appName))
        {
            Console.WriteLine("what chu doing bro?\n-------------");
            return;
        }

        if (appName.Equals("back", StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine();
            return;
        }

        string? match = Apps.FirstOrDefault(a => a.Equals(appName, StringComparison.OrdinalIgnoreCase));

        if (match != null)
        {
            Apps.Remove(match);
            SaveApps();
            Console.WriteLine($"{match} has been deleted from the apps list\n-------------");
        }
        else
        {
            Console.WriteLine($"{appName} is not in the apps list\n-------------");
        }
    }

    void EndProgram()
    {
        // Optional: Save again on exit just to be extra safe
        SaveApps();
        Console.WriteLine("\nYou've ended the program");
        programRunning = 0;
    }
}

void LoadApps()
{
    if (!File.Exists(FilePath))
        return;

    // Read, trim, drop empties, and dedupe case-insensitively
    var loaded = File.ReadLines(FilePath)
        .Select(line => line.Trim())
        .Where(line => !string.IsNullOrWhiteSpace(line))
        .Distinct(StringComparer.OrdinalIgnoreCase)
        .ToList();

    if (loaded.Count > 0)
    {
        Apps = loaded;
        Console.WriteLine($"Loaded {Apps.Count} apps from {FilePath}.");
    }
}

void SaveApps()
{
    // Simple write-all, one per line
    // If you want to be extra careful: write to a temp and replace the original
    var tmpPath = FilePath + ".tmp";
    File.WriteAllLines(tmpPath, Apps);
    if (File.Exists(FilePath)) File.Delete(FilePath);
    File.Move(tmpPath, FilePath);
}
