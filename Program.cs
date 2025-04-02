
using System;
using System.Media;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

public class CyberSecuritybot
{
    static void Main()

    {

        Console.Title = "Cybersecurity Awareness Bot";
        Console.ForegroundColor = ConsoleColor.DarkCyan;

        new playNow() { };



        // Display ASCII banner
        DisplayAsciiArt();

        // Start chatbot interaction
        StartChatbot();
    }



    static void DisplayAsciiArt()
    {

        Console.WriteLine(@"
         **************************************
        |    CYBERSECURITY AWARENESS BOT       |
         **************************************
        ");
    }

    static void StartChatbot()
    {
        Console.Write("Hello Welcome to Cyber Security Awereness Bot Please enter your name: ");
        Console.ForegroundColor = ConsoleColor.Magenta;
        string? name = Console.ReadLine()?.Trim();
        Console.ResetColor();

        name = string.IsNullOrWhiteSpace(name) ? "User" : name;

        string welcomeMessage = $"Welcome, {name}! How can I help you with cybersecurity today?";
        TypeText(welcomeMessage, ConsoleColor.DarkCyan);
        Thread.Sleep(500);

        ChatLoop(name);
    }

    static void ChatLoop(string name)
    {
        string? userInput;
        do
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write($"\n{name}: ");
            userInput = Console.ReadLine()?.Trim().ToLower();
            Console.ResetColor();

            if (string.IsNullOrEmpty(userInput))
            {
                TypeText("I didn't quite understand that. Could you rephrase?", ConsoleColor.DarkCyan);
                continue;
            }

            string botResponse = GetChatbotResponse(userInput, name);
            TypeText($"Bot: {botResponse}", ConsoleColor.DarkCyan);
            Thread.Sleep(500);

        } while (userInput != "exit");

        TypeText($"Goodbye, {name}! Stay safe online.", ConsoleColor.DarkCyan);
    }

    static string GetChatbotResponse(string input, string name)
    {
        switch (input)
        {
            case "hello":
                return $"Hello {name}! How can I assist you with cybersecurity today?";
            case "how are you":
                return "I'm a bot, so I don't have feelings, but I'm here to help!";
            case "what's your purpose":
                return "I provide cybersecurity tips and answer your questions about online safety.";
            case "what can i ask you about":
                return "You can ask me about phishing, password safety, and safe browsing.";
            case " phishing":
                return "Phishing is a scam where attackers trick you into revealing sensitive information.";
            case "password tips":
                return "Use strong passwords with at least 12 characters, a mix of letters, numbers, and symbols.";
            case "safe browsing":
                return "Always verify website URLs, avoid clicking suspicious links, and use updated security software.";
            case "exit":
                return $"Goodbye, {name}!";
            default:
                return $"I'm not sure about that, {name}. Try asking about phishing, password tips, or safe browsing!";
        }
    }

    static void TypeText(string text, ConsoleColor color)
    {
        Console.ForegroundColor = color;
        foreach (char c in text)
        {
            Console.Write(c);
            Thread.Sleep(25);
        }
        Console.WriteLine();
        Console.ResetColor();
    }
}