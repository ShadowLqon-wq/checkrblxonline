using System;
using System.Diagnostics;
using System.IO;
using System.Net;

Console.WriteLine("Rblx Online Checker");
string id = Console.ReadLine();
while (true)
{//
    string timeNow = DateTime.Now.ToString("HH:mm:ss tt");
    string url = $"https://api.roblox.com//users/{id}/friends";
    string time = new WebClient().DownloadString(url);
    

    using (StreamWriter sw = File.AppendText("time.txt"))
    {
        using (StreamReader sr = File.OpenText("offline.txt")) // 13 + 14
        {


            string[] responsearry = time.Split('"');
            string[] offlinearry = sr.ReadLine().Split('"');
            //Console.WriteLine(timeNow + " << " + offlinearry[14]);

            if (responsearry[14].Contains(":true}]") || responsearry[14].Contains(":true},{"))
            {
                Console.WriteLine(timeNow + " << Online <");
                sw.WriteLine(timeNow + "<< Online");
            }else
            {
                Console.WriteLine(timeNow + "<< Offline");
                sw.WriteLine(timeNow + "<< Offline");
            }



        }
        //sw.WriteLine(time + " " + timeNow);
        //Console.WriteLine(time + " " + timeNow);
        //Task.Delay(10000).Wait();




        





    }

}

