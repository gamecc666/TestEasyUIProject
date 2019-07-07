using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EasyUIProject.Models
{
    [Serializable]
    public class EasyTreeData
    {
        public string id { get; set; }
        public string text { get; set; }
        public string state { get; set; }
        public string iconCls { get; set; }
        public List<EasyTreeData> children { get; set; }
        public EasyTreeData()
        {
            this.children = new List<EasyTreeData>();
            this.state = "closed";
        }
        public EasyTreeData(string id,string text,string state="closed"):this()
        {
            this.id = id;
            this.text = text;
            this.state = state;
        }
        public EasyTreeData(int id, string text, string state = "open", List<EasyTreeData> children = null): this()
        {
            this.id = id.ToString();
            this.text = text;
            this.state = state;
            this.children = children;

        }
    }
}
