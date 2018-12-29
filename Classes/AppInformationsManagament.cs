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

namespace _2048.Classes
{
    class AppInformationsManagament
    {
        public AppInformationsManagament()                              // Constructor, empty
        {

        }
        public string authorInformation()                               // This method is used to get author information
        {
            return "Created by: Norbert Lubaszka \n" +                  // Return info about creator
                   "Contact: norbert.lubaszka@gmail.com \n" +           // Return info about creator
                   "\n" +                                               // Return info about creator
                   "Game made on '2048' themes," +                      // Return info about creator
                   "game from android, google store";                   // Return info about creator
        }
        public string gameInstruction()                                 // This method is used to get game instruction
        {
            return "Play by using arrows, your quest is to \n" +        // Return game instruction
                   "move fields up, down, right and left and \n" +      // Return game instruction
                   "match two same fields. Each matched field \n" +     // Return game instruction
                   "double value of the fild. Get as much points \n" +  // Return game instruction
                   "as you can ! Good luck player";                     // Return game instruction
        }
    }
}
