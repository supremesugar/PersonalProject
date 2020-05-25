using System;
using System.Collections.Generic;
using System.Text;

namespace Tarkov_randomItems
{
    class Ammo_data
    {
        //Gun_data gd = new Gun_data();

        string[] ammo_type = new string[14] { "5.56x45mm NATO", "7.62x39mm", "5.45x39mm", "12.7x55mm STs-130", "7.62x51mm NATO", ".366 TKM", "9x39mm", "9x19mm Parabellum", "4.6x30mm HK", "5.7x28mm FN", "9x18mm Makarov", "12x70mm", "20x70mm", "7.62x54mmR" };

        string[][] smg_cartridges = new string[][] {
            new string [3] { "PP-91 \"Klin\"", "PP-91 \"Kedr\"", "PP-91-01 \"Kedr-B\"" },      //9x18mm Makarov
            new string [7] { "MP5", "MP5K-N", "MPX", "PP-19-01 Vityaz-SN", "Saiga-9", "MP9", "MP9-N" },     //9x19mm Parabellum
            new string [2] { "MP7A1", "MP7A2" },        //4.6x30mm HK
            new string [1] {"P90"},       // 5.7x28mm FN
            new string [1] {"PPSH-41"}      //7.62x25mm Tokarev
        };

        string[][] rifle_cartridges = new string[][]
        {
            new string[10] { "AK-105", "AK-74", "AK-74M", "AK-74N", "AKS-74", "AKS-74N", "AKS-74U", "AKS-74UB", "AKS-74UN", "RPK-16" },   // 5.45x39mm
            new string[7] { "ADAR 2-15", "AK-101", "AK-102", "DT MDR 5.56x45", "HK 416A5", "M4A1", "TX-15 DML" },   // 5.56x45mm NATO
            new string[9] { "OP-SKS", "SKS", "AK-103", "AK-104", "AKM", "AKMN", "AKMS", "AKMSN", "Vepr KM/VPO-136" },    // 7.62x39mm
            new string[9] { "Vepr Hunter/VPO-101", "SA-58", "DT MDR .308", "M1A", "RSASS", "SR-25", "DVL-10", "M700", "T-5000" },   // 7.62x51mm NATO
            new string[4] { "SVDS", "Mosin", "Mosin Inf.", "SV-98" },    // 7.62x54mmR
            new string[2] { "AS VAL", "VSS Vintorez" },  // 9x39mm
            new string[2] { "Vepr AKM/VPO-209", "VPO-215" }, // .366 TKM
            new string[1] {"ASh-12"} // 12.7x55mm STs-130

        };


        string[] shotgun = new string[] { "M870", "MP-133", "MP-153", "Saiga-12" };  // 12x70mm
        string toz = "toz"; // 20x70mm
        public void ammo_types(string gkind)
        {
            int i = 0;
            int j = 0;

            for (j = 0; j < smg_cartridges.Length; j++)
            {
                for (i = 0; i < smg_cartridges[j].Length; i++)
                {
                    if (j == 0 && gkind == smg_cartridges[j][i])
                    {
                        Console.WriteLine("9x18mm Makarov");
                    }
                    else if (j == 1 && gkind == smg_cartridges[j][i])
                    {
                        Console.WriteLine("9x19mm Parabellum");
                    }
                    else if (j == 2 && gkind == smg_cartridges[j][i])
                    {
                        Console.WriteLine("9x19mm Parabellum");
                    }
                    else if (j == 3 && gkind == smg_cartridges[j][0])
                    {
                        Console.WriteLine("5.7x28mm FN");
                    }
                    else if (j == 4 && gkind == smg_cartridges[j][0])
                    {
                        Console.WriteLine("7.62x25mm Tokarev");
                    }
                }
            }

            for (j = 0; j < rifle_cartridges.Length; j++)
            {
                for (i = 0; i < rifle_cartridges[j].Length; i++)
                {
                    if (j == 0 && gkind == rifle_cartridges[j][i])
                    {
                        Console.WriteLine("5.45x39mm");
                    }
                    else if (j == 1 && gkind == rifle_cartridges[j][i])
                    {
                        Console.WriteLine("5.56x45mm NATO");
                    }
                    else if (j == 2 && gkind == rifle_cartridges[j][i])
                    {
                        Console.WriteLine("7.62x39mm");
                    }
                    else if (j == 3 && gkind == rifle_cartridges[j][i])
                    {
                        Console.WriteLine("7.62x51mm NATO");
                    }
                    else if (j == 4 && gkind == rifle_cartridges[j][i])
                    {
                        Console.WriteLine("7.62x54mmR");
                    }
                    else if (j == 5 && gkind == rifle_cartridges[j][i])
                    {
                        Console.WriteLine("9x39mm");
                    }
                    else if (j == 6 && gkind == rifle_cartridges[j][i])
                    {
                        Console.WriteLine(".366 TKM");
                    }
                    else if (j == 7 && gkind == rifle_cartridges[j][i])
                    {
                        Console.WriteLine("12.7x55mm STs-130");
                    }
                }
            }

            for (i = 0; i < shotgun.Length; i++)
            {
                if(gkind == shotgun[i])
                {
                    Console.WriteLine("12x70mm");
                }
            }

            if(gkind == toz)
            {
                Console.WriteLine("20x70mm");
            }
        }
    }
}

