using System;
using FervorLibrary;
using ObsidianFunctions;
using System.Collections.Generic; 

namespace CodeCompile
{
    class Program
    {
        static void Main(string[] args)
        {
            string channel = args[0];
            string rnick = args[1];
            string rmsg = args[2];
            try
			{
			ObsidianFunctions.Functions ObsidFunc = new ObsidianFunctions.Functions();
                            if (ObsidFunc.isOperator == true)
                            {
                                string query = rmsg.Remove(0, 11);
                                bool nickisuser = ObsidFunc.isActiveUser(rnick);
                                if (nickisuser == true)
                                {
                                    Console.WriteLine("MODE " + channel + " -o " + query);
                                }
                                else
                                {
                                    Console.WriteLine("PRIVMSG " + channel + " :Insufficient permissions!");
                                }
                            }
			}
			catch (Exception ex)
			{
				Console.WriteLine("PRIVMSG " + channel + " :" + ex.ToString()); 
			}
        }
    }
}