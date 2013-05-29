using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Display
{
    // <field>
    private double width;
    private double height;
    private int numbersOfColors;

    //<constructor>
    public Display()
    {
        this.height = 0;
        this.width = 0;
        this.numbersOfColors = 255;
    }
    // <properties>

    public double Width
    {
        get { return this.width; }
        set {
            // <Ensure all fields hold correct data at any given time.>
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("The price must be bigger than 0h");
            }
            this.width = value;
        }
    }
    public double Height
    {
        get { return this.height; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("The price must be bigger than 0h");
            }
            this.height = value;
        }
    }
    public int NumbersOfColors
    {
        get { return this.numbersOfColors; }
        set
        {
            if (value < 0 || value > 255)
            {
                throw new ArgumentOutOfRangeException("The price must be in interval [0-255]");
            }
            this.numbersOfColors = value;
        }
    }
}

