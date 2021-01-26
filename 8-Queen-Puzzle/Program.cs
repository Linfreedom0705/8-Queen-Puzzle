using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Queen_Puzzle
{
    class Program
    {
        static void Main(string[] args)
        {
            int intX, intY;
            List<int[]> liQueenCandidate = new List<int[]>();
            List<int[]> liQueen = new List<int[]>();
            for (int i = 0; i < 8; i++)
                for (int j = 0; j < 8; j++)
                    liQueenCandidate.Add(new int[] { i, j });

            Random rnd = new Random();
            string[,] strarrTemp = new string[8, 8];
            //for (int i = 0; i < 8; i++)
            //    for (int j = 0; j < 8; j++)
            //        strarrTemp[i, j] = "Q";
            while (liQueenCandidate.Count > 0)
            {
                int intPosition = rnd.Next(liQueenCandidate.Count);
                int[] intarrTmp = liQueenCandidate[intPosition];


                //strarrTemp[liQueenCandidate[intPosition][0], liQueenCandidate[intPosition][1]] = ".";
                liQueenCandidate.RemoveAt(intPosition);

                liQueen.Add(intarrTmp);

                for (int i = 0; i < 8; i++)
                    for (int j = liQueenCandidate.Count - 1; j >= 0; j--)
                        if (liQueenCandidate[j][0] == intarrTmp[0] && liQueenCandidate[j][1] == i)
                        {
                            //strarrTemp[liQueenCandidate[j][0], liQueenCandidate[j][1]] = ".";
                            liQueenCandidate.RemoveAt(j);
                        }

                //for (int i = 0; i < 8; i++)
                //{
                //    string strTemp = "";
                //    for (int j = 0; j < 8; j++)
                //        strTemp += strarrTemp[i, j] + " ";

                //    Console.WriteLine(strTemp);
                //}
                //Console.WriteLine();


                for (int i = 0; i < 8; i++)
                    for (int j = liQueenCandidate.Count - 1; j >= 0; j--)
                        if (liQueenCandidate[j][0] == i && liQueenCandidate[j][1] == intarrTmp[1])
                        {
                            //strarrTemp[liQueenCandidate[j][0], liQueenCandidate[j][1]] = ".";
                            liQueenCandidate.RemoveAt(j);
                        }

                //for (int i = 0; i < 8; i++)
                //{
                //    string strTemp = "";
                //    for (int j = 0; j < 8; j++)
                //        strTemp += strarrTemp[i, j] + " ";

                //    Console.WriteLine(strTemp);
                //}
                //Console.WriteLine();

                intX = intarrTmp[0];
                intY = intarrTmp[1];
                while (true)
                {
                    for (int i = liQueenCandidate.Count - 1; i >= 0; i--)
                        if (liQueenCandidate[i][0] == intX && liQueenCandidate[i][1] == intY)
                        {
                            //strarrTemp[liQueenCandidate[i][0], liQueenCandidate[i][1]] = ".";
                            liQueenCandidate.RemoveAt(i);
                        }
                    intX--;
                    intY--;

                    if (intX < 0 || intY < 0)
                        break;
                }
                //for (int i = 0; i < 8; i++)
                //{
                //    string strTemp = "";
                //    for (int j = 0; j < 8; j++)
                //        strTemp += strarrTemp[i, j] + " ";

                //    Console.WriteLine(strTemp);
                //}
                //Console.WriteLine();
                intX = intarrTmp[0];
                intY = intarrTmp[1];
                while (true)
                {
                    for (int i = liQueenCandidate.Count - 1; i >= 0; i--)
                        if (liQueenCandidate[i][0] == intX && liQueenCandidate[i][1] == intY)
                        {
                            //strarrTemp[liQueenCandidate[i][0], liQueenCandidate[i][1]] = ".";
                            liQueenCandidate.RemoveAt(i);
                        }
                    intX++;
                    intY++;
                    if (intX > 7 || intY > 7)
                        break;
                }
                //for (int i = 0; i < 8; i++)
                //{
                //    string strTemp = "";
                //    for (int j = 0; j < 8; j++)
                //        strTemp += strarrTemp[i, j] + " ";

                //    Console.WriteLine(strTemp);
                //}
                //Console.WriteLine();
                intX = intarrTmp[0];
                intY = intarrTmp[1];
                while (true)
                {
                    for (int i = liQueenCandidate.Count - 1; i >= 0; i--)
                        if (liQueenCandidate[i][0] == intX && liQueenCandidate[i][1] == intY)
                        {
                            //strarrTemp[liQueenCandidate[i][0], liQueenCandidate[i][1]] = ".";
                            liQueenCandidate.RemoveAt(i);
                        }
                    intX++;
                    intY--;
                    if (intX > 7 || intY < 0)
                        break;
                }
                //for (int i = 0; i < 8; i++)
                //{
                //    string strTemp = "";
                //    for (int j = 0; j < 8; j++)
                //        strTemp += strarrTemp[i, j] + " ";

                //    Console.WriteLine(strTemp);
                //}
                //Console.WriteLine();
                intX = intarrTmp[0];
                intY = intarrTmp[1];
                while (true)
                {
                    for (int i = liQueenCandidate.Count - 1; i >= 0; i--)
                        if (liQueenCandidate[i][0] == intX && liQueenCandidate[i][1] == intY)
                        {
                            //strarrTemp[liQueenCandidate[i][0], liQueenCandidate[i][1]] = ".";
                            liQueenCandidate.RemoveAt(i);
                        }

                    //for (int i = 0; i < 8; i++)
                    //{
                    //    string strTemp = "";
                    //    for (int j = 0; j < 8; j++)
                    //        strTemp += strarrTemp[i, j] + " ";

                    //    Console.WriteLine(strTemp);
                    //}
                    //Console.WriteLine();

                    intX--;
                    intY++;
                    if (intX < 0 || intY > 7)
                        break;
                }


                //for(int i = 0; i < liQueenCandidate.Count; i++)
                //{
                //    strarrTemp[liQueenCandidate[i][0], liQueenCandidate[i][1]] = ".";
                //}


                //for(int i = 0; i < 8;i++)
                //{
                //    string strTemp = "";
                //    for (int j = 0; j < 8; j++)
                //        strTemp += strarrTemp[i, j] + " ";

                //    Console.WriteLine(strTemp);
                //}
                //Console.WriteLine();

                if (liQueenCandidate.Count == 0 && liQueen.Count != 8)
                {
                    liQueenCandidate = new List<int[]>();
                    liQueen = new List<int[]>();
                    for (int i = 0; i < 8; i++)
                        for (int j = 0; j < 8; j++)
                            liQueenCandidate.Add(new int[] { i, j });
                }


            }



            for (int i = 0; i < 8; i++)
                for (int j = 0; j < 8; j++)
                    strarrTemp[i, j] = ".";

            for (int i = 0; i < liQueen.Count; i++)
                strarrTemp[liQueen[i][0], liQueen[i][1]] = "Q";

            for (int i = 0; i < 8; i++)
            {
                string strTemp = "";
                for (int j = 0; j < 8; j++)
                    strTemp += strarrTemp[i, j] + " ";

                Console.WriteLine(strTemp);
            }
            Console.WriteLine();
            Console.Read();
        }
    }
}
