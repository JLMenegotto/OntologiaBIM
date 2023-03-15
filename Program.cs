using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


using VDS.RDF;
using VDS.RDF.Ontology;
using VDS.RDF.Parsing;
using VDS.RDF.Writing;
using VDS.RDF.Query.Inference;

namespace OntoBIM
{
    public class OBIM
    {
        public static void Main(String[] args)
        {
            MessageBox.Show("Bom dia 1");
            string prefixos = "Prefixos\n";
            string dataprop = "Propriedades de dados\n";
            string objeprop = "Propriedades de objetos\n";
            string classes  = "Classes\n";
            bool nodo       = false;

            OntologyGraph     g = new OntologyGraph();

            FileLoader.Load ( g , "C://JLMenegotto//Projetos//OntoBIM//OntoBIM_ambientes_001.ttl");
            INode someClass = g.GetUriNode(new Uri("https://jlmenegotto.wixsite.com/jlmenegotto-bim#ao_interior"));

            IEnumerable<OntologyClass>    clas = g.OwlClasses;
            IEnumerable<OntologyProperty> prop = g.OwlDatatypeProperties;
            IEnumerable<OntologyProperty> data = g.OwlDatatypeProperties;
            IEnumerable<string>           pref = g.NamespaceMap.Prefixes;
                                          nodo = g.IsEmpty;
            foreach (string s in pref)
            {
                 prefixos += "\n"+s;
            }
            foreach (OntologyClass c in clas)
            {
                classes += "\n" + c.ToString();
            }

            foreach (OntologyProperty p in prop)
            {
                objeprop += "\n" + p.ToString();
            }

            foreach (OntologyProperty p in data)
            {
                dataprop += "\n" + p.ToString();
            }

            MessageBox.Show( nodo ? "VAZIO":"CHEIO");

            MessageBox.Show(prefixos);
            MessageBox.Show(classes );
            MessageBox.Show(objeprop);
            MessageBox.Show(dataprop);

        }
    }
}

