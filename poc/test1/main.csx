#!/usr/bin/env dotnet-script
#load "proc.csx"
Console.WriteLine("Hello world!");
Args.ToList()
    .ForEach(x => Console.WriteLine(x));
GoCode();

