using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_DuongVanKhiem_2054052026
{
    class Trasua
    {
        private string name;
        private int price;
        private int soluong;

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public int Price
        {
            get
            {
                return price;
            }

            set
            {
                price = value;
            }
        }

        public int Soluong(int soluong)
        {
            return soluong;
        }

    }
}
