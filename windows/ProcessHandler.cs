﻿/**
 * Author(s): Takahiro Tow
 * Last updated: July 6, 2017
 **/

using System;
using System.Collections.Generic;

namespace Networking
{
    public static class ProcessHandler
    {
        /**
         * Attribute List
        **/ 
        private static IDictionary<int,ProcessInterface> processDict;
        private static List<string> processListNames;
        private static ProcessInterface currentProcess; //Process in focus
        
        /**
         * Constructor
         * initializes processList and currentProcess
         * @return: all Processes in List format
        **/
        static ProcessHandler()
        {
            //processList = new List<ProcessInterface>();
            processDict = new Dictionary<int, ProcessInterface>();
            processListNames = new List<string>();
            updateProcessListNames();
            currentProcess = null;
        }

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern IntPtr GetForegroundWindow();

        [System.Runtime.InteropServices.DllImport("user32.dll", SetLastError = true)]
        static extern uint GetWindowThreadProcessId(IntPtr hWnd, IntPtr Processid);

        /**
         * determines the foreground window on computer
         **/
        private static void determineForegroundWindow()
        {
            IntPtr currentForeground = GetForegroundWindow();
            if (processDict.Keys.Contains(currentForeground.ToInt32()))
            {
                currentProcess = processDict[currentForeground.ToInt32()];
            }
        }

        /**
         * updates the list of process names 
         **/
        public static void updateProcessListNames()
        {
            processListNames.Clear();
            foreach(int key in processDict.Keys)
            {
                processListNames.Add(processDict[key].getTitle());
            }

        }

        public static void addProcess(int key, ProcessInterface pInt)
        {
            processDict.Add(key, pInt);
            //send phone update on process
        }

        public static void removeProcess(int key)
        {
            processDict.Remove(key);
        }

        /**
         * FOR TESTING PURPOSES ONLY
         * calls killProcess method of process specified by user
         **/
        public static void killProcess(int key)
        {
            if (processDict[key].killApp())
            {
                determineForegroundWindow();
            }
        }

        public static void openProgram(int key)
        {
            if (processDict[key].setForegroundApp())
            {
                currentProcess = processDict[key];
            }
        }
        /**
         * main method to be called upon recieving instructions
         * will direct instruction to the appropriate process object
         **/
        public static void performAction()
        {

        }

        private static void setForeGroundApp(int key)
        {
            currentProcess = processDict[key];
            currentProcess.setForegroundApp();
        }

        /**
         * Displays to console list of currently running processes in processList variable
        **/ 
        public static void printProcessList()
        {
            //Console.WriteLine("Current Processes on {0}", System.Environment.MachineName);
            foreach (int key in processDict.Keys)
            {
                processDict[key].printProcessInfo();
            }
            Console.WriteLine("###########################################\n\n");
        }

        public static IDictionary<int, ProcessInterface> getProcessDict()
        {
            return processDict;
        }
    }
}
