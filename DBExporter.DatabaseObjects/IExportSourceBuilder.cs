using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBExporter.DatabaseObjects
{
    // Trường hợp có nhiều kiểu database như postgresql, sqlServer, oracle, ... thì mỗi DatabaseBuilder 
    // tương ứng sẽ phải thực thi interface này 
    public interface IExportSourceBuilder
    {
        ExportSource Build(string selectQuery);
    }
}
