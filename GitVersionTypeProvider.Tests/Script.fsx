﻿#r @"..\GitVersionTypeProvider\bin\Debug\GitVersionTypeProvider.dll"

open System.Reflection

[<assembly: AssemblyFileVersion(Git.Version.Value)>]
do ()
