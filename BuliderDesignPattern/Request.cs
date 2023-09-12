using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuliderDesignPattern
{
    public class Request
    {
        public string? Url { get; set; }
        public object? Form { get; set; }
        public object? Body { get; set; }
        public Dictionary<string,string>? QueryString { get; set; }
        public override string ToString()
        {
            return $"{Url}?{string.Join("&", QueryString.Select(q => $"{q.Key}:{q.Value}"))}";
        }
    }
}
