using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml;

namespace Proyecto2
{
    public class Analyzer
    {
        public List<Token> tokens;
        public string input;
        public string output;
        public Boolean done;
        public Analyzer(string input)
        {
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
            tokens.Add(new Token("printf", "palabra reservada"));
            tokens.Add(new Token("for", "palabra reservada"));
            tokens.Add(new Token("cout", "palabra reservada"));
            tokens.Add(new Token("switch", "palabra reservada"));
            tokens.Add(new Token("try", "palabra reservada"));
            tokens.Add(new Token("catch", "palabra reservada"));
            tokens.Add(new Token("else", "palabra reservada"));
            tokens.Add(new Token("case", "palabra reservada"));
            tokens.Add(new Token("int", "palabra reservada"));
            tokens.Add(new Token("float", "palabra reservada"));
            tokens.Add(new Token("double", "palabra reservada"));
            tokens.Add(new Token("bool", "palabra reservada"));
            tokens.Add(new Token("long", "palabra reservada"));
            tokens.Add(new Token("string", "palabra reservada"));
            tokens.Add(new Token("void", "palabra reservada"));
            tokens.Add(new Token("char", "palabra reservada"));
            tokens.Add(new Token("using", "palabra reservada"));
            tokens.Add(new Token("namespace", "palabra reservada"));
            tokens.Add(new Token("std", "palabra reservada"));
            tokens.Add(new Token("endl", "palabra reservada"));
            tokens.Add(new Token("(", "prioridad_op"));
            tokens.Add(new Token(")", "prioridad_op"));
            tokens.Add(new Token("<", "operador_op"));
            tokens.Add(new Token(">", "operador_op"));
            tokens.Add(new Token("/", "operador_op"));
            tokens.Add(new Token("*", "operador_op"));
            tokens.Add(new Token("+", "operador_op"));
            tokens.Add(new Token("-", "operador_op"));
            tokens.Add(new Token(",", "separacion_op"));
            tokens.Add(new Token(";", "punto_y_coma"));
            tokens.Add(new Token("#", "numeral"));
        }


        int getPos(string line, string reference)
        {
            return line.IndexOf(reference);
        }


        public void analyze(string line)
        {
            //output += line + "\n";
            if (line.Length == 0) { this.done = true; return; }
            string aux = line;


            for(int i = 0; i < line.Length; i++)
            {
                if (line[i] == '\"')
                {
                    output += "<candena de usuario> \n";
                    int posx = line.Substring(i + 1).IndexOf('\"');
                    string b_s = "";
                    for(int j = 0; j < line.Length; j++)
                    {
                        if (line[j] > i || i > posx)
                        {
                            b_s += line[j];
                        }
                    }
                    line = b_s;
                    break;
                }
            }


            if (line.Contains("{") || line.Contains("}"))
            {
                if (line.Contains("{"))
                {

                    int pos = getPos(line, "{");
                    if (pos != -1)
                    {
                        output += "{ -  inicio_ins_op \n";
                        string result = aux.Remove(pos, 1);
                        aux = result;
                        this.analyze(aux);
                        return;
                    }
                }
                else
                {
                    int pos = getPos(line, "}");
                    if (pos != -1)
                    {
                        output += "} -  fin_ins_op \n";
                        string result = aux.Remove(pos, 1);
                        aux = result;
                        this.analyze(aux);
                        return;
                    }
                }
            }
            

            foreach (Token token in tokens)
            {
                string str = token.id;
                if (line.Contains(str))
                {
                    output += str + " - " + token.description + "  \n";
                    int pos = getPos(line, str);
                    if (pos != -1)
                    {
                        string result = aux.Remove(pos, str.Length);
                        aux = result;
                    }

                    this.analyze(aux);
                    break;
                }
            }
            string n = "";
            string abc = "abcdefghigklmnopqrstuvwxyz";
            for(int i = 0; i < line.Length; i++)
            {
                n += line[i];
                if (abc.Contains(line[i]))
                {
                    output += line[i] + " - " + " <id1>  \n";
                    break;
                }
            }
        }
    }
}
