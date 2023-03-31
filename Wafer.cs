using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chipset_Wafer_Simulator
{
    public class Wafer
    {
        public string Company
        {
            get;//가져오기
            set;//설정하기
            //private set; //외부에서 설정하기를 막고자 할 때
        }
        public string Name
        {
            get;
            set;
        }
        public WDirection WDir
        {
            get;
            set;
        }
        public double Radius
        {
            get;
            set;
        }
        public bool PType
        {
            get;
            set;
        }
        public Wafer(string company, string name,
            WDirection wdir, double radius, bool ptype)
        {
            Company = company;
            Name = name;
            WDir = wdir;
            Radius = radius;
            PType = ptype;
        }
    }
    public enum WDirection
    {
        WD_111, WD_100, WD_110
    }



 
}