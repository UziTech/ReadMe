using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Runtime.InteropServices;


public class ToolTipListBox : System.Windows.Forms.ListBox
{
    [StructLayout(LayoutKind.Sequential)]
    public struct SIZE
    {
        public int cx;
        public int cy;
    }
    [DllImport("gdi32.dll")]
    public static extern int GetTextExtentPoint32(IntPtr hdc,
        String str, int len, ref SIZE size);

    [DllImport("user32.dll")]
    public static extern IntPtr GetDC(IntPtr hWnd);

    [DllImport("user32.dll")]
    public static extern int ReleaseDC(IntPtr hWnd, IntPtr hdc);


    public ToolTipListBox()
    {
        tp.InitialDelay = 500;
        tp.ReshowDelay = 500;
        tp.AutoPopDelay = 3000;
        tp.Active = true;
    }


    protected override void OnMouseMove(System.Windows.Forms.MouseEventArgs e)
    {
        // Get the index of the mouse-hovered item
        int index = base.IndexFromPoint(e.X, e.Y);

        // Ensure that there is an item
        if (index != ListBox.NoMatches)
        {
            // Check if the mouse has moved enough distance for a new index
            if (LastIndex != index)
            {
                string s = Items[index].ToString();
                Size textSize = TextRenderer.MeasureText(s, base.Font);

                Rectangle r = base.GetItemRectangle(index);
                if (r.Width < textSize.Width)
                    // Display the TT over the LB item
                    tp.Show(s, this, r.X + 1, r.Y + 2);
                else
                    tp.Hide(this);

                LastIndex = index;
            }
        }
        else
        {
            LastIndex = -1;
            tp.Hide(this);
        }
    }

    private ToolTip tp = new ToolTip();
    private int LastIndex = -1;

}