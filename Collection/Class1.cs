using System;

namespace MyNamespace
{
    public class Common<T> where T : Living
    {
        public string GetUpperName(T p)
        {
            return p.GetName().ToUpper();
        }
    } 
}