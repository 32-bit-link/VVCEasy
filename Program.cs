using System;
using System.Threading;

namespace VVCEasy
{
    public class Program
    {
        public static void Main()
        {
            bool exit = false;
            Console.Title = "Martin Eesmaa / VVCEasy";
            Console.WriteLine("MARTIN EESMAA / VVCEasy");
            Console.WriteLine("Welcome to VVCEasy. (.NET Console Beta Version, v.0.5.0)");
            Console.ReadLine();
            do
            {
                Console.Clear();
                Console.WriteLine("VVCEasy (.NET Console Beta Version, v.0.5.0)");
                Console.WriteLine("Note: C# is not ready yet, malfunction mode");
                Console.WriteLine("");
                Console.Title = "Martin Eesmaa / VVCEasy";
                Console.WriteLine("What would you like to do for encode/decode of VVC?\n1. Encode\n2. Decode\n3. Help\n4. Exit\n5. Test path environment\n6. Install VLC Media Player (o266player, Windows x64)\n7. Install quickly through Anaconda for ffmpeg (Windows)\n8. Install VVdec Web Player\n9. Decompress WindowsVVC.7z (Before you use new VVCEasy version!!!)");

                string input = Console.ReadLine();

                if (input == "1")
                {
                encodestart:
                    Console.Clear();
                    Console.Title = "Encode to VVC";
                    Console.WriteLine("Welcome to VVC encoder.\nWhat do you like encode to VVC?\nBefore we move to settings quality, is your video lossy or lossless?\n1. Lossy (example YouTube videos, Web videos, lossy compressed videos, and other webs)\n2. Lossless (example XIPH Media, Camera uncompressed (MOV/MP4/AVI), Apple ProRes and others uncompressed files)\n3. Go back to menu");

                    string input2 = Console.ReadLine();
                    if (input2 == "1")
                    {
                        Console.Clear();
                        Console.Title = "Lossy settings with Lossy compressed (VVC Encoder)";
                        Console.WriteLine("Do you have YUV?\nIf you have YUV already, move your YUV file into C:/Program Files/VVCEasy/\nIf you do not have YUV, your instruction will go to next...\n1. I have YUV already (I am ready)\n2. No, I am not ready yet (go back to previous)\nIf you don't have Y4M already... you need transcode file from your lossy video file to YUV.\nExample: ffmpeg -i yourfile.mp4 -strict 1 yourfinal.yuv\n");

                        string input3 = Console.ReadLine();

                        if (input3 == "1")
                        {
                            Console.Clear();
                            Console.Title = "VVC ENCODER (YUV LOSSY)";
                            Console.WriteLine("Before we start encode from your YUV file to VVC file, I'm afraid I cannot do automatically for you.\nYou have to manually encode to VVC, the batchfile won't work.\nHere is code: vvencapp --qp 38 -i yourinput.yuv -s 854x480 -r 30 -o youroutputlossy.266\nYOU HAVE TO REPLACE VIDEO SIZE AND FRAME RATE. -s is video size and -r is frame rate.\nYou can also add for --tier high or/and 10-bit video -c yuv420_10, if necessary.");
                            Console.ReadLine();
                        }
                        else if (input3 == "2")
                        {
                            goto encodestart;
                        }
                    }
                }
                else if (input == "2")
                {
                    Console.Clear();
                    Console.Title = "Decode from VVC to YUV/Y4M";
                    Console.WriteLine("Do you want to transcode back from VVC to YUV or Y4M? Which did you choose settings?\nChoosing settings will transcode back.\nYou need copy from your VVC file to C:/Program Files/VVCEasy/WindowsVVC/.\nWindows Explorer will open automatically.\nAfter copying your VVC file into VVCEasy folder, you need rename to VVC.vvc.\nIt will transcode from your VVC file to YUV/Y4M.\nAfter transcoding, your transcoded file should be: C:/Program Files/VVCEasy/transcodedback\nNote, if you are using portable, like you git cloned VVCEasy or downloaded source files, go to your Downloads folder and select VVCEasy.\nPortable won't work, you need move from your Downloads folder/VVCEasy into Program Files/VVCEasy.\n1. YUV (lossy video VVC)\n2. Y4M (lossless video VVC)");

                    string decodestart1 = Console.ReadLine();

                    if (decodestart1 == "1")
                    {
                        Console.Clear();
                        Console.Title = "STARTING TRANSCODING BACK FROM VVC TO YUV...";
                        Console.Beep();
                        Console.WriteLine("Sorry, this is currently maintenance of C#");
                        Console.ReadLine();
                    }
                    else if (decodestart1 == "2")
                    {
                        Console.Clear();
                        Console.Title = "STARTING TRANSCODING BACK FROM VVC TO Y4M...";
                        Console.Beep();
                        Console.WriteLine("Sorry, this is currently maintenance of C#");
                        Console.ReadLine();
                    }
                }
                else if (input == "3")
                {
                    helpingvvc:
                    Console.Clear();
                    Console.WriteLine("Welcome to VVCEasy help instructions!\nHere is tutorial about... How to use VVCEasy?");
                    Console.ReadLine();
                    Console.WriteLine("Step 1: Run on VVCEasy.bat. When you see the screen of Welcome to VVCEasy. You can press any key continue to main menu.\nStep 2: Here are the list of main menus, that you need type any number will go to direction like (goto) command.\nStep 3: Follow the command instructions and that is easy.");
                    Console.ReadLine();
                    Console.WriteLine("If you have any problems that you do not understand of VVCEasy. Please contact to Martin Eesmaa by creating issues for questions or/and problems.\nDo you want to start over help instructions? If yes, then it will go back from beginning. If No, going to back menu. Y/N?");

                    string helper = Console.ReadLine();

                    if (helper == "Y" + "y")
                    {
                        goto helpingvvc;
                    }
                }
                else if (input == "4")
                {
                    Console.Clear();
                    Console.Title = "Have a wonderful day!";
                    Console.WriteLine("Have a wonderful day! Thank you for using VVCEasy. :)");
                    Console.WriteLine("    _   _                 _                      \n    | | | |               | |                     \n    | |_| |__   __ _ _ __ | | ___   _  ___  _   _ \n    | __| '_ / / _` | '_ /| |/ / | | |/ _ /| | | |\n    | |_| | | | (_| | | | |   <| |_| | (_) | |_| |\n     /__|_| |_|/__,_|_| |_|_|/_\\__, |/___/ /__,_|\n                                 __/ |            \n                                |___/\n\n\n    __      ____      _______ ______                \n    / /    / // /    / / ____|  ____|               \n      / // /    / // /| |    |  __| / _` / __| | | |\n       /  /      /  / | |____| |___| (_| /__ / |_| |\n        //        //   /_____|______/__,_|___//__, |\n                                               __/ |\n                                              |___/ \n\n\n     __  __            _   _         ______                                \n    |  //  |          | | (_)       |  ____|                               \n    | /  / | __ _ _ __| |_ _ _ __   | |__   ___  ___ _ __ ___   __ _  __ _ \n    | |//| |/ _` | '__| __| | '_ /  |  __| / _ // __| '_ ` _ / / _` |/ _` |\n    | |  | | (_| | |  | |_| | | | | | |___|  __//__ / | | | | | (_| | (_| |\n    |_|  |_|/__,_|_|   /__|_|_| |_| |______/___||___/_| |_| |_|/__,_|/__,_|\nCopyright 2022 Martin Eesmaa\n\nExiting program...");
                    Thread.Sleep(3000);
                    exit = true;
                }
                else if (input == "5")
                {
                testpathenvironment:
                    Console.Clear();
                    Console.Title = "TEST PATH ENVIRONMENT";
                    Console.WriteLine("Martin Eesmaa is testing your paths, that you installed programs in PATH. Not sure, what is path?\nYou can go here for link: https://stackoverflow.com/questions/4910721/python-on-cmd-path\nYou can also search What is PATH in Windows? in DuckDuckGo or SearX.\nAre you ready to test? (Y/N)");

                    string readytestbefore = Console.ReadLine();

                    if (readytestbefore == "Y" + "y")
                    {
                        Console.Title = "Testing time...";
                        Console.WriteLine("Sorry, it's malfunction mode in C#...");
                        Console.ReadLine();
                    }
                }
                else if (input == "6")
                {
                    Console.Clear();
                    Console.Title = "VLC Media PLayer (custom build of o266player)";
                    Console.WriteLine("Hello, would you like to install VLC Media Player (v3.0.11.1 Vetinari, custom build of o266player) on your computer?\nBefore you install...\nThe VLC Media Player (custom build of o266player) works only on Windows 7 / Windows Server 2012 or earlier versions.\nWindows Vista and older versions will not work, including Windows 8.0 won't work too, because it could be terminal error or/and cannot decode VVC format.\nYou need 64-bit / x64 to run VLC custom build. On 32-bit / x86, it will not work to run.\nNote: Some operating system work VLC custom build on Virtualbox and VMware. Real machines can all almost run Windows versions, like Windows Server 2016.\nReminder: I'm not kinda sure about this, I hope should you're running on real machine, that means it needs to be working to load VVC video format.\nInstall? Y/N?");

                    string vlcinstall = Console.ReadLine();

                    if (vlcinstall == "Y" + "y")
                    {

                    }
                }
                else if (input == "7")
                {
                    Console.Clear();
                    Console.Title = "ANACONDA";
                    Console.WriteLine("Welcome to Anaconda Quick Install. This will only one task for ffmpeg. Would you like to install? Y/N?");

                    string anacondaman = Console.ReadLine();

                    if (anacondaman == "Y" + "y")
                    {
                        Console.WriteLine("SUCCESS, going to back menu...");
                        Console.ReadLine();
                    }
                }
                else if (input == "8")
                {
                    Console.Clear();
                    Console.Title = "VVdec Web Player.";
                    Console.WriteLine("By installing, you will have to agree to download VVDec Web Player from Fraunhoferhhi GitHub.\nSee the code of VVDEC Web Player: https://github.com/fraunhoferhhi/vvdecWebPlayer\nWhen you agree to install, it will clone of VVDec Web Player repository using git. After git, we will copy from VVDECWEBINSTALL files into vvdecWebPlayer/bin folder.\nAfter all of that, we will run Python to start web server of your localhost port 8000.\nWould you like to install of VVDEC Web Player?");

                    string okletsdoit = Console.ReadLine();

                    if (okletsdoit == "Y" + "y")
                    {
                        Console.Clear();
                        Console.Title = "INSTALLING VVDEC WEB PLAYER...";
                        Console.WriteLine("Sorry, the command is not ready yet...");
                        Console.ReadLine();
                    }
                }
                else if (input == "9")
                {
                    Console.Clear();
                    Console.Title = "WindowsVVC.7z (decompressing)";
                    Console.WriteLine("Decompressing...\nSorry, the command is not ready yet...");
                    Console.ReadLine();
                }
            }
            while (exit == false);
        }
    }
}
