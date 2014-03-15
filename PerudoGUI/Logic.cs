using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerudoGUI
{
    class Logic
    {

        int[] Dices1;
        int[] Dices2;
        int[] Dices3;
        int[] Dices4;
        int[] Dices5;
        int[] Dices6;

        int dicesLeftp1 = 5;
        int dicesLeftp2 = 5;
        int dicesLeftp3 = 5;
        int dicesLeftp4 = 5;
        int dicesLeftp5 = 5;
        int dicesLeftp6 = 5;


        AdminForm af;

        public Logic(AdminForm a) {
            af = a;
        }

        public void rollDices() {
            Dices1 = new int[dicesLeftp1];
            Dices2 = new int[dicesLeftp2];
            Dices3 = new int[dicesLeftp3];
            Dices4 = new int[dicesLeftp4];
            Dices5 = new int[dicesLeftp5];
            Dices6 = new int[dicesLeftp6];

            Random rand = new Random();

            for (int a = 0; a < dicesLeftp1; a++)
            {
                int n = rand.Next(6) + 1;
                Dices1[a] = n;
            }
            for (int a = 0; a < dicesLeftp2; a++)
            {
                int n = rand.Next(6) + 1;
                Dices2[a] = n;
            }
            for (int a = 0; a < dicesLeftp3; a++)
            {
                int n = rand.Next(6) + 1;
                Dices3[a] = n;
            }
            for (int a = 0; a < dicesLeftp4; a++)
            {
                int n = rand.Next(6) + 1;
                Dices4[a] = n;
            }
            for (int a = 0; a < dicesLeftp5; a++)
            {
                int n = rand.Next(6) + 1;
                Dices5[a] = n;
            }
            for (int a = 0; a < dicesLeftp6; a++)
            {
                int n = rand.Next(6) + 1;
                Dices6[a] = n;
            }

            af.showPictures(Dices1, Dices2, Dices3, Dices4, Dices5, Dices6);

        }
    }
}
