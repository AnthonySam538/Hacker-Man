#!/bin/bash
#In the official documemtation the line above always has to be the first line of any script file.

# Author: Anthony Sam
# Program Name: Hacker Man

#This is a bash shell script to be used for compiling, linking, and executing the C sharp files of this assignment.
#Execute this file by navigating the terminal window to the folder where this file resides, and then enter either of the commands below:
#  sh run.sh OR ./build.sh

echo "First, remove any potentially outdated .dll or .exe files using the keyword rm"
rm *.dll
rm *.exe

echo "Display the list of the remaining source files in the terminal using the keyword ls"
ls -l

echo "Compile HackerManForm.cs to create the file: HackerManForm.dll"
mcs -target:library -read:System.Windows.Forms.dll -out:DysfunctionalForm.dll DysfunctionalForm.cs

echo "Compile HackerManMain.cs and link the previously created dll file(s) to create an executable (.exe) file."
mcs -read:System.Windows.Forms.dll -read:HackerManForm.dll -out:HackerMan.exe HackerManMain.cs

echo "Display the updated list of files in the folder, now including the newly created .dll and .exe files"
ls -l

echo "Run the Assignment 1 program."
./HackerMan.exe

echo "The script has terminated."