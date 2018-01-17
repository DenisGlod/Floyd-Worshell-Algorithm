using System;
using System.Data;

namespace Floyd_Worshell_Algorithm
{
    [Serializable]
    class ProjectFile
    {
        public string VertexName { get; set; }
        public DataTable DtWeight { get; set; }
        public DataTable DtPath { get; set; }
        public string RtbWeight { get; set; }
        public string RtbPath { get; set; }
        public string Start { get; set; }
        public string End { get; set; }
        public string TbResult { get; set; }
    }
}
