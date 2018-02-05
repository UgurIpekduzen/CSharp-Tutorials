using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Params
{
    class Program
    {
        static void Main(string[] args)
        {
            //Rect r1 = new Rect(3,4);
            //r1.Show();

            //r1.Enlarge(2); 
            /*
              fonksiyon içinde yeni bir nesne ataması gerçekleştirdiği için
              r1 nesnesine yeni bilgileri gönderemez mutlaka yeni bir adrese yollanmalıdır!!!!!!!
            */

            //Rect r2 = r1.Enlarge(2); 

            //r2.Show();

            /*Boş bir nesne dolaylı yoldan nesne ataması*/
            Rect R = new Rect();

            Rect R1 = R.Factory(3,4);

            R1.Show();
        }
    }

    class Rect
    {
        int width;
        int height;

        /*
        public Rect(int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        public Rect Enlarge(int Factor)
        {
            Rect R = new Rect(this.width * Factor, this.height * Factor);
            return R;
        }
        */
        public Rect Factory(int width, int height)
        {
            Rect R = new Rect();
            R.width = width;
            R.height = height;
            return R;
        }
        public void Show()
        {
            Console.WriteLine("Rect W:{0} H:{1}", this.width, this.height);
        }
    }
}
