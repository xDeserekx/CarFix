using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarFix.Interfaces
{
    public interface ICarExporter
    {
        void ExportToPdf(DataGridView dgv, string fileName);
    }
}
