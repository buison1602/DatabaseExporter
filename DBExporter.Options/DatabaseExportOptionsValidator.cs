using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBExporter.Options
{
    public class SourceOptionsValidator: IDatabaseExportOptionsValidator
    {
        public void Validate(DatabaseExportOptions options) { 
            // Trả ra ngoại lệ nếu options == null 
            ArgumentNullException.ThrowIfNull(options, nameof(options));

            // Toán tử XOR (Exclusive OR) có nghĩa là "hoặc cái này hoặc cái kia, nhưng không phải cả hai"
            // toán tử ^ trả về true nếu 2 giá trị được so sánh khác nhau 
            //                  false _________________________ giống nhau 
            // VD: true ^ true = false
            //     true ^ false = true
            //     false ^ true = true
            //     false ^ false = false

            // Kiểm tra xem có viết lệnh Query không
            // if !(false ^ false) hoặc if !(true ^ true) đều ok 
            if ( !(string.IsNullOrWhiteSpace(options.DatabaseOptions.SelectQuery) ^ string.IsNullOrWhiteSpace(options.DatabaseOptions.TableNames)) )
            {
                throw new ArgumentException("Only SelectQuery or TableNames can be set");
            }
        }

        public static readonly SourceOptionsValidator Instance = new(); // normally we only need exactly 1 instance
    }
}
