/*
MIT License

Copyright (c) 2020 Marcos Vinícius

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
*/

namespace SocketAppServer.ServerObjects
{
    public class RequestParameter
    {
        public string Name { get; set; }
        public object Value { get; set; }

        internal RequestParameter(string name, object value)
        {
            Name = name;
            Value = value;
        }

        internal bool IsComplexType()
        {
            return Name.Contains(".");
        }

        public override string ToString()
        {
            return Name;
        }

        internal string GetAliasName()
        {
            int pIndex = Name.IndexOf('.');
            int ptIndex = pIndex + 1;
            string aliasName = Name.Substring(0, pIndex);
            return aliasName;
        }

        internal string GetParameterProperyName()
        {
            int pIndex = Name.IndexOf('.');
            int ptIndex = pIndex + 1;
            string propertyName = Name.Substring(ptIndex, Name.Length - ptIndex);
            return propertyName;
        }

        public RequestParameter()
        {

        }
    }
}