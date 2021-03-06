﻿using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace UltimixOS.Drivers
{
    public class Hypervisor
    {

        public Hypervisor()
        {



        }

        public void ConsoleOut(string text)
        {

            Console.Write(text);

        }

        public void ConsoleOutLine(string text)
        {

            Console.WriteLine(text);

        }

        public string ConsoleIn()
        {

            return Console.ReadLine();

        }

        public void Shutdown()
        {

            Cosmos.System.Power.Shutdown();

        }

        public void Reboot()
        {

            Cosmos.System.Power.Reboot();

        }



        public string readFileText(string path)
        {

            string output = "";

            if (File.Exists(path))
            {

                output = File.ReadAllText(path);

            } else
            {

                ConsoleOutLine("Hypervisor: File not found.");

            }
            return output;

        }

        public string[] readFileLns(string path)
        {


            if (File.Exists(path))
            {

                return File.ReadAllLines(path);

            }
            else
            {

                ConsoleOutLine("Hypervisor: File not found.");
                string[] outpt = {""};
                return outpt;

            }

        }

        public void fileWriteText(string path, string text)
        {

            File.WriteAllText(path, text.Replace("\\n","\n"));

        }

        public string[] getDirFiles(string path)
        {

            string[] output = { };

            if(Directory.Exists(path))
            {

                output = Directory.GetFiles(path);

            }

            return output;

        }

        public string[] dirGetDirs(string path)
        {

            string[] output = { };

            if(Directory.Exists(path))
            {

                output = Directory.GetDirectories(path);

            }

            return output;

        }

        public void removeFile(string path)
        {

            if (File.Exists(path))
            {

                File.Delete(path);

            }
            else
            {

                ConsoleOutLine("Hypervisor: File not found.");

            }

        }

        public void removeDir(string path)
        {

            if(Directory.Exists(path))
            {

                if(Directory.GetFiles(path).Length == 0 && Directory.GetDirectories(path).Length == 0)
                {

                    Directory.Delete(path);

                } else
                {

                    ConsoleOutLine("Hypervisor: Directory not empty.");

                }
                
            } else
            {

                ConsoleOutLine("Hypervisor: Directory not found.");

            }

        }

    }
}
