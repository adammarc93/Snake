[1mdiff --git a/Piont.cs b/Piont.cs[m
[1mdeleted file mode 100644[m
[1mindex e45b1c1..0000000[m
[1m--- a/Piont.cs[m
[1m+++ /dev/null[m
[36m@@ -1,22 +0,0 @@[m
[31m-﻿using System;[m
[31m-using System.Collections.Generic;[m
[31m-using System.Linq;[m
[31m-using System.Text;[m
[31m-using System.Threading.Tasks;[m
[31m-[m
[31m-namespace Snake[m
[31m-{[m
[31m-    public class Piont[m
[31m-    {[m
[31m-        public int X { get; set; }[m
[31m-        public int Y { get; set; }[m
[31m-[m
[31m-        public Piont() { }[m
[31m-[m
[31m-        public Piont(int x, int y)[m
[31m-        {[m
[31m-            X = x;[m
[31m-            Y = y;[m
[31m-        }[m
[31m-    }[m
[31m-}[m
\ No newline at end of file[m
[1mdiff --git a/Snake.csproj b/Snake.csproj[m
[1mindex 97a7dec..b804954 100644[m
[1m--- a/Snake.csproj[m
[1m+++ b/Snake.csproj[m
[36m@@ -43,8 +43,10 @@[m
   </ItemGroup>[m
   <ItemGroup>[m
     <Compile Include="Board.cs" />[m
[32m+[m[32m    <Compile Include="Direction.cs" />[m
     <Compile Include="Game.cs" />[m
     <Compile Include="Menu.cs" />[m
[32m+[m[32m    <Compile Include="Point.cs" />[m
     <Compile Include="Program.cs" />[m
     <Compile Include="Properties\AssemblyInfo.cs" />[m
   </ItemGroup>[m
[1mdiff --git a/bin/Debug/Snake.exe b/bin/Debug/Snake.exe[m
[1mindex ece35b1..8223ea5 100644[m
Binary files a/bin/Debug/Snake.exe and b/bin/Debug/Snake.exe differ
[1mdiff --git a/bin/Debug/Snake.pdb b/bin/Debug/Snake.pdb[m
[1mindex 081539e..69c4af2 100644[m
Binary files a/bin/Debug/Snake.pdb and b/bin/Debug/Snake.pdb differ
[1mdiff --git a/obj/Debug/Snake.csproj.CoreCompileInputs.cache b/obj/Debug/Snake.csproj.CoreCompileInputs.cache[m
[1mindex f24544c..beecb1c 100644[m
[1m--- a/obj/Debug/Snake.csproj.CoreCompileInputs.cache[m
[1m+++ b/obj/Debug/Snake.csproj.CoreCompileInputs.cache[m
[36m@@ -1 +1 @@[m
[31m-351b62f8f8732b822ab89cc54a9c2c8c89f86e21[m
[32m+[m[32m736cd2c95792b833db6a1672a4d495ede1fe0c0b[m
[1mdiff --git a/obj/Debug/Snake.exe b/obj/Debug/Snake.exe[m
[1mindex ece35b1..8223ea5 100644[m
Binary files a/obj/Debug/Snake.exe and b/obj/Debug/Snake.exe differ
[1mdiff --git a/obj/Debug/Snake.pdb b/obj/Debug/Snake.pdb[m
[1mindex 081539e..69c4af2 100644[m
Binary files a/obj/Debug/Snake.pdb and b/obj/Debug/Snake.pdb differ
