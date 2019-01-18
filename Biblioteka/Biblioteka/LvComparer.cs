using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Biblioteka
{
    class LvComparer : IComparer
    {
        private int colIndex = 0;

        public LvComparer(int col)
        {
            this.colIndex = col;
        }

        public int Compare(object x, object y)
        {
            int valX = Int32.Parse(((ListViewItem)x).SubItems[colIndex].Text);
            int valY = Int32.Parse(((ListViewItem)y).SubItems[colIndex].Text);
            return -valX.CompareTo(valY);
        }
    }
}
