// Author: Anthony Sam
// Program Name: Hacker Man

// Name of this file: HackerManForm.cs
// Purpose of this file: Define the form
// Purpose of this entire program: Create a loading bar that gives way to a message when complete

// Source files in this program: HackerManForm.cs HackerManMain.cs

using System;
using System.Drawing;
using System.Windows.Forms;
using System.Timers;

public class HackerManForm : Form
{
  // Set the size of the window
  private const int formWidth = 360;
  private const int formHeight = formWidth * 2/3;

  // Create Controls
  private Label text = new Label();

  // Create timer (It helps simulate loading)
  private static System.Timers.Timer myTimer = new System.Timers.Timer(50); //that should be 20 times a second

  public HackerManForm()
  {
    // Set up the form
    Text = "Password Unencryptor v1.14.2";
    Size = new Size(formWidth, formHeight);
    BackColor = Color.Black;

    // Set up the text on the screen
    text.Text = "Unencrypting data";
    text.Size = new Size(formWidth * 8/10, formHeight/6);
    text.Location = new Point(0, 0);
    
    // Add the controls to the form
    Controls.Add(text);

    // Start the clock
    myTimer.Enabled = true;
  }

  protected override void OnPaint(PaintEventArgs e)
  {
    Graphics graphics = e.Graphics;

    graphics.FillRectangle(Brushes.DodgerBlue); //in the center of the bottom half
    graphics.FillRectangle(Brushes.Black); //in the center of the bottom
  }
}