using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto2
{
    public class Analyzer
    {
        public List<Token> tokens;
        public string input;
        public string output;
        public Boolean done;
        public Analyzer(string input) { 
            this.input = input;
            this.done = false;
            this.output = "";
            this.tokens = new List<Token>();
            this.init();
            this.run();
        }

        public void run()
        {
            this.analyze(this.input);
            fileHelper.savInfo(this.output);
            this.done = true;
        }




        public void init()
        {
            tokens.Add(new Token("if", "palabra reservada"));
        }


        int getPos(string line, string reference) {

            return line.IndexOf(reference);
        }

        public void analyze(string line)
        {
            if (line.Length == 0) { this.done = true; return; }

            string aux = line;
            foreach(Token token in tokens)
            {
                string str = token.id;
                if (line.Contains(str))
                {
                    output += str + " - " + token.description + "  \n";
                    int pos = getPos(line, str);
                    if(pos != -1)
                    {
                        string result = aux.Remove(pos, str.Length);
                        aux = result;
                    }
                    break;
                    this.analyze(aux);
                }
            }
        }
    }
}
