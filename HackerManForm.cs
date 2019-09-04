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
  
  // Create Rectangles
  private Rectangle blueRectangle;
  private Rectangle blackRectangle;

  // Create timer (It simulates loading)
  private static System.Timers.Timer myTimer = new System.Timers.Timer(50); //that should be 20 times a second

  public HackerManForm()
  {
    // Set up the form
    Text = "Password Unencryptor v1.14.2";
    Size = new Size(formWidth, formHeight);
    BackColor = Color.Black;

    // Set up the text on the screen
    text.Text = "Unencrypting data";
    text.Size = new Size(formWidth * 5/6, formHeight/6);
    text.Location = new Point(formWidth/12, formHeight/3 - 5); //center of the bottom of the top half
    
    // Add the controls to the form
    Controls.Add(text);
    
    // Set up the rectangles
    blueRectangle = new Rectangle(text.Left, text.Bottom + 5, text.Size.Width, text.Size.Height);
    blackRectangle = new Rectangle(blueRectangle.Left + 3, blueRectangle.Top + 3, blueRectangle.Width - 6, blueRectangle.Height - 6);
    
    // Tell the event which method to call (method is defined later)
    myTimer.Elapsed += new ElapsedEventHandler(fillLoadingBar);

    // Start the clock
    myTimer.Enabled = true;
  }

  protected override void OnPaint(PaintEventArgs e)
  {
    Graphics graphics = e.Graphics; //this is used to draw objects on screen

    graphics.FillRectangle(Brushes.DodgerBlue, blueRectangle); //center of the top of the bottom half
    graphics.FillRectangle(Brushes.BackColor, blackRectangle); //in the center of the middle of the DodgerBlue rectangle
  }
}
