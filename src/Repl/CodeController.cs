using System;
using System.Web.Http;
using ScriptSharp.ScriptEngine;

namespace ScriptSharp.Repl
{
    public class CodeController : ApiController
    {
        // POST api/code 
        public void Post([FromBody]string code)
        {
            Console.WriteLine(CSharpScriptEngine.Execute(code));
        }
    }
}