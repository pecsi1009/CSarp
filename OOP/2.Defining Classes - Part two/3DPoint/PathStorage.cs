﻿/*
4.1. Create a static class PathStorage with static methods to save and load paths from a text file. Use a file format of your choice.   
*/

using System;
using System.Linq;
using System.IO;

namespace Point3DMain
{
    static class PathStorage
    {
        public static void SavePath(Path temp)
        {

            using (StreamWriter writer = new StreamWriter(@"../../savedPaths.txt")) //create a file
            {
                foreach (var p in temp.Paths)
                {
                    writer.WriteLine(String.Format("({0},{1},{2})", p.X, p.Y, p.Z));
                    writer.Flush();
                }
            }
        }

        internal static Path LoadPath()
        {
            Path loadPath = new Path();
            try
            {
                using (StreamReader reader = new StreamReader(@"../../savedPaths.txt"))
                {
                    while (reader.Peek() >= 0)
                    {
                        String line = reader.ReadLine();
                        String[] splittedLine = line.Split(new char[] { '(', ',', ')' }, StringSplitOptions.RemoveEmptyEntries);
                        loadPath.AddPoint(new Point3D(int.Parse(splittedLine[0]), int.Parse(splittedLine[1]), int.Parse(splittedLine[2])));
                    }
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found, try adding a new file");
            }
            catch (IOException io)
            {
                Console.WriteLine(io.Message);
            }
            catch (OutOfMemoryException ome)
            {
                Console.WriteLine(ome.Message);
            }
            finally { }
            return loadPath;
        }
    }
}
