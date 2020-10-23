using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using wonder1;
using wonder2;
using wonder3;
using wonder4;
using wonder5;
using wonder6;
using wonder7;

namespace L_2_wonders_task_10
{
    /// <summary>
    /// Сlasses interact through a namespace wonder 1, 2, 3, 4, 5, 6, 7
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            egipt eg = new egipt();
            eg.egypt_showed();
            gardens gar = new gardens();
            gar.gardens_showed();
            statue_Zeus st_z = new statue_Zeus();
            st_z.statue_Zeus_showed();
            temple_Artemis t_art = new temple_Artemis();
            t_art.temple_Artemis_showed();
            Mausoleum_Halicarnassus m_hal = new Mausoleum_Halicarnassus();
            m_hal.Mausoleum_Halicarnassus_showed();
            colossus_Rhodes col_rh = new colossus_Rhodes();
            lighthouse_Alexandria l_alex = new lighthouse_Alexandria();
            l_alex.lighthouse_Alexandria_showd();
        }
    }
}
