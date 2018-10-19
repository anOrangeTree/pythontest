using IronPython.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pythonTest
{
    public enum PYTHON_SCRIPT_MODE
    {
        PSM_FILE = 0,
        PSM_SCRIPT = 1
    }
    public class PythonHelper
    {
        private dynamic _pythonScope = "";
    
        public PythonHelper(string pythonString, PYTHON_SCRIPT_MODE eMode = PYTHON_SCRIPT_MODE.PSM_FILE)
        {
            switch(eMode)
            {
                case PYTHON_SCRIPT_MODE.PSM_FILE:

                    var pythonEngin = Python.CreateEngine(); //(options);
                    /*
                    var pyText = Convert.ToBase64String(File.ReadAllBytes(new FileInfo(pythonFile).ToString()));
                    var codestring = Encoding.UTF8.GetString(Convert.FromBase64String(pyText));

                    // read file
                    var script = pythonEngin.CreateScriptSourceFromString(codestring);
                    */

                    // also import file directory
                    var script = pythonEngin.CreateScriptSourceFromFile(pythonString);

                    var code = script.Compile();
                    var scope = pythonEngin.CreateScope();
                    var excuteResult = code.Execute(scope);
                    _pythonScope = scope;
                    break;
                case PYTHON_SCRIPT_MODE.PSM_SCRIPT:
                    var pythonEngin2 = Python.CreateEngine(); //(options);

                    // read from script string
                    var script2 = pythonEngin2.CreateScriptSourceFromString(pythonString);

                    var code2 = script2.Compile();
                    
                    var scope2 = pythonEngin2.CreateScope();
                    var excuteResult2 = code2.Execute(scope2);
                    _pythonScope = scope2;
                    break;
                default:
                    break;
            }
                

        }

        public dynamic CallFun(string funName, object[] args) 
        {
            var _func = _pythonScope.GetVariable(funName);
            var retData = _func(args);
            return retData; 
        }

        public dynamic CallFun(string funName, int arg1, int arg2)
        {
            var _func = _pythonScope.GetVariable(funName);
            var retData = _func(arg1,arg2);
            return retData;
        }

        public void CallFun(string funName)
        {
            var _func = _pythonScope.GetVariable(funName);
            var retData = _func();
            return;
        }




    }
}
