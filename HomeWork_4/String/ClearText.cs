using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace String
{
    class ClearText
    {     
        public static string a;
        public void GetClearString(string patch)
        {
            Repository repository = new Repository();
            repository.LoadString(patch);

            StringBuilder sb = new StringBuilder(Repository.line);
            a = sb
              .Replace("----", "").Replace("--", "-").Replace("....",".").Replace('"',' ').Replace("\n\n", "\n").Replace("\n\n\n", "\n").Replace("\n\n\n\n", "\n")
              .Replace("(", "").Replace(")", "").Replace("[", "").Replace("]", "").Replace("{", "").Replace("}", "").Replace("_", "").Replace("  ", "")
              .Replace("=","").Replace("+", "").Replace("|", "").Replace(":", " ").Replace(";", " ").Replace("\n\n\n\n\n", "\n").Replace("#","")
              .Replace("<","").Replace(">","").Replace("=-", "").Replace("*","").Replace(" '"," ").Replace("' ", " ").ToString();
        // Чистку можно было сделать более подробную, также через регулярку было бы проще но я здесь отразил работу замены в строке...
        }

    }
}
