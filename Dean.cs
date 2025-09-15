using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

public class Dean : Employee
{
    public Dean(string name, string email): base(name, email)
    {

    }
    public void HireEmployee(ResearchAssociate employee)
    {
        throw new System.NotImplementedException("Not implemented");
    }
    public void FireEmployee(ResearchAssociate employee)
    {
        throw new System.NotImplementedException("Not implemented");
    }
}
