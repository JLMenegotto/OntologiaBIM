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
            MessageBox.Show("Inicia Leitura");
            
            string prefixos = "Prefixos\n";
            string dataprop = "Propriedades de dados\n";
            string objeprop = "Propriedades de objetos\n";
            string classes  = "Classes\n";
            bool nodo       = false;

            OntologyGraph     g = new OntologyGraph();

            FileLoader.Load ( g , "C://JLMenegotto//Projetos//OntoBIM//OntoBIM_ambientes_001.ttl");
            INode Inodo = g.GetUriNode(new Uri("https://jlmenegotto.wixsite.com/jlmenegotto-bim#ambientes"));
            
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

            MessageBox.Show(
                            Inodo.ToString()                    + "\n" + 
                            Inodo.NodeType.ToString()           + "\n" +  
                            Inodo.GraphUri.Authority.ToString() + "\n" +
                            Inodo.Graph.ToString()
                           );

            MessageBox.Show(prefixos);
            MessageBox.Show(classes );
            MessageBox.Show(objeprop);
            MessageBox.Show(dataprop);

            //Carregar dados e esquemas 
            Graph dados    = new Graph(); FileLoader.Load(dados , "C:\\JLMenegotto\\Aplicativos_BIM\\OntoBIM\\Os_individuos.ttl");
            Graph esque    = new Graph(); FileLoader.Load(esque , "C:\\JLMenegotto\\Aplicativos_BIM\\OntoBIM\\Os_esquemas.ttl");

            IUriNode clase = dados.CreateUriNode("ex:Car");
            IUriNode tipos = dados.CreateUriNode(new Uri(RdfSpecsHelper.RdfType));

            string carrosSemi = "\n";
            string carrosInfe = "\n";

            //Resultaso sim fazer inferência
            foreach (Triple t in dados.GetTriplesWithPredicateObject( tipos , clase))
            {
                     carrosSemi += t.Subject.ToString() + "\n";
            }

            //Faz a inferência e retorna as subclasses de carros
            StaticRdfsReasoner razona = new StaticRdfsReasoner();
            razona.Initialise( esque );
            razona.Apply     ( dados );

            //Resultados com inferência
            foreach (Triple t in dados.GetTriplesWithPredicateObject( tipos , clase))
            {
                      carrosInfe += t.Subject.ToString() + "\n";  
            }

            MessageBox.Show(
                               "\nSem Inferência: " + carrosSemi + "\n" +
                               "\nCom Inferência: " + carrosInfe
                           );
        }
    }






}

