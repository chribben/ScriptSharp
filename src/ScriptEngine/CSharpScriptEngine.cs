using System;
using Microsoft.CodeAnalysis.Scripting;
using Microsoft.CodeAnalysis.Scripting.CSharp;

namespace ScriptSharp.ScriptEngine
{
    public class CSharpScriptEngine
    {
        private static Script _previousInput;
        private static Lazy<object> _nextInputState = new Lazy<object>();
        public static object Execute(string code)
        {
            var script = CSharpScript.Create(code, ScriptOptions.Default).WithPrevious(_previousInput);
            var endState = script.Run(_nextInputState.Value);
            _previousInput = endState.Script;
            _nextInputState = new Lazy<object>(() => endState);
            return endState.ReturnValue;
        }
    }
}
