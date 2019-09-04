// Author: Anthony Sam
// Program Name: Hacker Man

// Name of this file: HackerManMain.cs
// Purpose of this file: Launch the form
// Purpose of this entire program: Create a loading bar that gives way to a message when complete

// Source files in this program: HackerManForm.cs HackerManMain.cs

using System;
using System.Windows.Forms;

public class HackerManMain
{
  public static void Main()
  {
    System.Console.WriteLine("The hacker man program will begin now.");
    HackerManForm HackerMan_App = new HackerManForm();
    Application.Run(HackerMan_App);
    System.Console.WriteLine("The hacker man program will end now.")
  }
}