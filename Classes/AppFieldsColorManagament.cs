// Created by Norbert Lubaszka
// Contact: norbert.lubaszka@gmail.com
// All rights reserved ©
// If you want to use the source code contact me
                                                                        // References
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace _2048.Classes
{
    class AppFieldsColorManagament
    {
        public AppFieldsColorManagament()                               // Constructor, empty
        {

        }
        public Color getColorForValue(int value)                        // This method is used to return color for given value
        {
            if(value == 0)                                              // If value is 0
            {
                return Color.FromArgb(255, 255, 255);                   // White
            }
            else if(value == 2)                                         // If value is 2
            {
                return Color.FromArgb(244, 188, 66);                    // Orange
            }
            else if (value == 4)                                        // If value is 2
            {
                return Color.FromArgb(227, 171, 49);                    // Orange
            }
            else if (value == 8)                                        // If value is 8
            {
                return Color.FromArgb(210, 154, 32);                    // Orange                
            }
            else if (value == 16)                                       // If value is 16
            {
                return Color.FromArgb(193, 137, 31);                    // Orange               
            }
            else if (value == 32)                                       // If value is 32
            {
                return Color.FromArgb(176, 120, 14);                    // Orange                
            }
            else if (value == 64)                                       // If value is 64
            {
                return Color.FromArgb(175, 103, 253);                   // Purple                
            }
            else if (value == 128)                                      // If value is 128
            {
                return Color.FromArgb(158, 86, 236);                    // Purple   
            }
            else if (value == 256)                                      // If value is 256
            {
                return Color.FromArgb(141, 69, 219);                    // Purple   
            }
            else if (value == 512)                                      // If value is 512
            {
                return Color.FromArgb(124, 52, 202);                    // Purple   
            }
            else if (value == 1024)                                     // If value is 1024
            {
                return Color.FromArgb(107, 35, 185);                    // Purple   
            }
            else if (value == 2048)                                     // If value is 2048
            {
                return Color.FromArgb(90, 18, 168);                     // Purple   
            }
            else if (value == 4096)                                     // If value is 4096
            {
                return Color.FromArgb(73, 1, 151);                      // Purple                  
            }
            else if (value == 8192)                                     // If value is 8192
            {
                return Color.FromArgb(56, 240, 134);                    // Green
            }
            else if (value == 16384)                                    // If value is 16384
            {
                return Color.FromArgb(39, 239, 117);                    // Green
            }
            else if (value == 32768)                                    // If value is 32768
            {
                return Color.FromArgb(22, 222, 100);                    // Green
            }
            else if (value == 65536)                                    // If value is 65536
            {
                return Color.FromArgb(5, 205, 83);                      // Green
            }
            else                                                        // Else
            {
                return Color.FromArgb(255, 255, 255);                   // White
            }
        }
    }
}
