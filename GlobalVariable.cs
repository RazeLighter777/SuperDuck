
using System;
using SolidWorks.Interop.sldworks;

namespace SuperDuck
{

    class GlobalVariable
    {
        private ModelDoc2 model;

        private int Refresh()
        {
            EquationMgr mgr = model.GetEquationMgr();
            return mgr.EvaluateAll();
        }
        public GlobalVariable(ModelDoc2 m, String name, int ind, double val)
        {
            model = m; VarName = name; Index = ind; this.Val = val;
        }

        public int Index;

        public double Val {
            get
            {
                return Val;
            }
            set
            {
                EquationMgr mgr = model.GetEquationMgr();
                mgr.Equation[Index] = this.ToString();
                Refresh();
            }
        }

        public string VarName;

        override
        public String ToString()
        {
            return "\"" + VarName + "\"" + " = " + Val;
        }
    }
}
