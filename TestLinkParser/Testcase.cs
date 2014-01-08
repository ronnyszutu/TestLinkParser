using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace TestLinkParser
{
    class Testcase
    {
        public XmlNode node_order, externalid, version, summary, preconditions, execution_type, importance;
        public List<Keyword> keywordList = new List<Keyword>();
        public List<StepAction> stepActionList = new List<StepAction>();
    }
}
