using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;

namespace _01.Most_Frequent_Number
{
    class MostFrequentNumber
    {
        static void Main()
        {
            string[] file = File.ReadAllLines("1.MostFrequentNumber.txt");

            for (int l = 0; l < file.Length; l++)
            {
                var currLine = file[l]
                    .Split(' ')
                    .Select(int.Parse)
                    .ToArray();;

                int currNumber = 0;
                int count = 0;
                int maxCount = 0;
                int mostFreqNum = 0;
                int num = 0;
                var resultFile = "MostFrequentNum_resultFile.txt";
                File.WriteAllText(resultFile, String.Empty);
                
                for (int i = 0; i < currLine.Length - 1; i++)
                {
                    currNumber = currLine[i];
                    for (int j = 0; j < currLine.Length - 1; j++)
                    {
                        if (currNumber == currLine[j])
                        {
                            count++;
                            if (maxCount < count)
                            {
                                maxCount = count;
                            }
                            if (num < count)
                            {
                                mostFreqNum = currNumber;
                                num = count;
                            }
                        }
                        else
                        {
                            count = 0;
                        }
                        
                    }
                    
                    //File.AppendAllText("MostFrequentNum_resultFile.txt", Environment.NewLine);
                }
                Console.WriteLine(mostFreqNum);
                File.AppendAllText(resultFile, $"{mostFreqNum}");


                //var result = File.Create("C:\\Users\\Freeware Sys\\Desktop\\MostFrequentNum-result.txt");
                //var arrResult = new List<string>();
                //arrResult.Add(mostFreqNum.ToString());
                //File.AppendAllLines($"C:\\Users\\Freeware Sys\\Desktop\\C# - Programming Fundamentals\\Programming-Fundamentals\\Exercise8\\Files,Dir\\FilesDirectoriesAndExceptions\\01.MostFrequentNumber\\bin\\Debug\\MostFrequentNum-result.txt", arrResult);
            }   
        }
    }
}
