# PCF-Dotnet2.0-ConsoleApp

This is a sample Console app that which could potentially be a replacement for Windoes Service. This app does a infiniate loop and prints the couter every 3 mins to console. 

## Create new  : dotnet new console
## Restore : dotnet restore 
## Publish : 
  mkdir PUBLISH 
  dotnet publish -f netcoreapp2.0 -r ubuntu.14.04-x64 -o PUBLISH
## Run on PCF 
cf push consoleapp -p PUBLISH -b https://github.com/cloudfoundry/dotnet-core-buildpack.git

## OutPut from the PCF Logs 

2018-02-05T20:55:06.301-05:00 [CELL/0] [OUT] Successfully created container
2018-02-05T20:55:08.642-05:00 [APP/PROC/WEB/0] [OUT] Started Console app
2018-02-05T20:55:08.644-05:00 [APP/PROC/WEB/0] [OUT] Loop # 1
2018-02-05T21:00:08.644-05:00 [APP/PROC/WEB/0] [OUT] Loop # 2

## Code 

using System;

namespace DOTNETCORE2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Started Console app");
	          int i;
	          i = 1;
            while (true)
 		        {
                Console.WriteLine("Loop # {0}", i);
		            System.Threading.Thread.Sleep(300000);
                i++;
            }

        }

    }
}
