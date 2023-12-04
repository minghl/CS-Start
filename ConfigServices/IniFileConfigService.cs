using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.IO;
namespace ConfigServices
{
	public class IniFileConfigService: IConfigService
	{
        public string FilePath { get; set; }

        public string GetValue(string name)
        {
            var kv = File.ReadAllLines(FilePath).Select(s => s.Split('=')).Select(srts => new { Name = srts[0], Value = srts[1] })
                .SingleOrDefault(kv => kv.Name == name);
            if (kv != null)
            {
                return kv.Value;
            }
            else
            {
                return null;
            }
        }
    }
}

