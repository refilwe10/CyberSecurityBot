# CyberSecurityBot
using System;
using System.Media;
using System.Threading;

public class CyberSecuritybot
{
    static void Main()

    {

        Console.Title = "Cybersecurity Awareness Bot";
        Console.ForegroundColor = ConsoleColor.DarkCyan;


        // play Audio
        new playNow() { };

        // Display ASCII logo
        DisplayAsciiArt();

        // Start chatbot interaction
        StartChatbot();
    }



    static void DisplayAsciiArt()
    {
        Console.WriteLine(@"                                           
                                                                                                                  
                               `@@@@@@@@@@@@@@@@@@@@@Z@@f :@@@@@@@@@@[                              
                              Q@@'                 w@@@p| t )       h@@                             
                           ,@@@ o@@@@@@@@@@@@@@@@@@@ @X@v ~@@@@@@@@@@ @@@]                          
                         t@$r n@@l   _|ttttfB@@@@@r@r@I!b@*)^)/{""   $@# tw@Q                        
                        [@$(#@@/  i@@h_lllI}@@@ @@@@@@IIl!lIIl<J@@t  ;@@@]C@0                       
                        @@]@{  ^b@@b r/ttttx@QB @n@f@@Yttttttttx;}@@@+   @@z@                       
                       :@i@@  n@@^ @@W-lllI}@@ r}<B@m,  Illlll<0@@> k@*  1@ @z                      
                       Z@ @~ ,@pr@@*.       C*`)O^   t@@m        z@@al@z  @a@@                      
                       @oW@  M@ @r         @@+         I@@         :@*@@  w@ @i                     
                      ,@.@m  @J@@         @@ -         > @@         0@ @- >@ @O                     
                      |@ @_ )@ @r        t@ dO_@@@@@@@]$p @Q        ,@~@$  @Z@@                     
                      W@[@; *@i@`    ^@@@@@@ @O@@@@@@@O@ @@@@@@:     @@@@  @@o@                     
                    ""@@C<@@[@@p@    _@@: Ip@n@#,  .  I$@0@W+ '*@/    a@/@  @@c@                     
                    Q@n:+>@B@@@@    @@/W@@@@(@@@CjM0|@@@)@@@@@Jb@@@@@@@}@  @@x@                     
                    0@j{,/@$@@@@  1@@_)@@;    /@O~ :]@@      !@C:     Q@@  @@Q@                     
                    .@@>` /b@O@@  @@ _<I@h    @@J@M@@(@      tW   Ia@@iI@@@@Z@@                     
                      +@n}! !#@h  @@Y !Z@p    @@""@x@@@@      @@r [@@ W@wl I~ @C                     
                       @@Z@@@$ @@@@b ,o@@     .@*@(@ @(      @z(/.0@ @}@*{ [^v@,                    
                       h@""@~ c@@w  .!@m        @@@C@;@       @@|vZ@nY@.@!@n_)j@h                    
                       I@]@@ r@w@@@@@ @X       @M@z@ @""      n@}@@[^@<@*B@ a'w@h                    
                        B@ @0 @@!@n @@:@h      @@@ @$@<     0@/@@ I@#O@'r@ Qn@@I                    
                         @@(@} @@)@Y @@ @@!    d@@#@@@    I@@ @@.~@@]@| @@}@$.                      
                         ~@00@}.@@I@$ @@;Q@@i           l@@p.@@ r@wt@c @@ @0                        
                          {@YY@n @@ @@:|@@ J@@a^     'b@@0 @@X @@:#@{ @@ @k                         
                           1@Ml@B @@j_@@ z@@. J@@@@@@@O  @@m W@b @@ v@w<@O                          
                            >@@ @@!>@@'1@@_;@@a       b@@) @@w @@Q @@ #@r                           
                              @@r+@@ |@@> @@@'i@@@@@@@t @@@] @@b M@Z @@:                            
                               /@@.x@@ t@@b ;B@@@   O@@@] |@@p @@# @@Q                              
                                 O@@.)@@a @@@d :/z@a(} Y@@@l{@@C @@$                                
                                   k@@{ W@@w @@@@] IX@@@ }@@@+'@@@                                  
                                     t@@*  b@@@{ Y@# ^@@@*_ n@@w                                    
                                        h@@0  ]B@@@@@@f  {@@@:                                      
                                           X@@@)     i@@@d""                                         
                                              <*@@@@@@)                                                                                      

                                 CyberSecurity Awareness Chat Bot
                                 CYBER SERVER - SECURE YOUR WORLD

        ");
    }

    static void StartChatbot()
    {
        Console.Write("Hello Welcome to Cyber Security Awereness Bot");
          Console.Write(" Please enter your name: ");


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
            case "phishing":
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
