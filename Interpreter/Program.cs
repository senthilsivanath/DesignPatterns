using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter
{
    class Program
    {
        public AbstractExpression getMaleExpression(String data)
        {
            return new TerminalExpression(data);
        }

        public AbstractExpression getAndExpression(AbstractExpression expr1, AbstractExpression expr2)
        {
            AndExpression andExpression = new AndExpression(expr1, expr2);
            return andExpression;
        }

        public AbstractExpression getOrExpression(AbstractExpression expr1, AbstractExpression expr2)
        {
            OrExpression andExpression = new OrExpression(expr1, expr2);
            return andExpression;
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            AbstractExpression maleExpresion = p.getMaleExpression("Ram");
            Boolean validateResult = maleExpresion.validate("Am i Ram ?");
            Console.WriteLine("Validate male expression{0}",validateResult);
            AbstractExpression shamExpression = p.getMaleExpression("Sham");
            AbstractExpression andExpression = p.getAndExpression(maleExpresion, shamExpression);
            Boolean validateAndExpression = andExpression.validate("Did SRm and Sham go to walking together ?");
            Console.WriteLine("Validate and expression{0}", validateAndExpression);
        }
    }
}
