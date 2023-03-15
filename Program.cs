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
            string pastap   = "C:\\JLMenegotto\\Projetos\\OntoBIM\\";
            string pastaa   = "C:\\JLMenegotto\\Aplicativos_BIM\\OntoBIM\\";
            string meuuri   = "https://jlmenegotto.wixsite.com/jlmenegotto-bim#ambientes";
            string prefixos = "Prefixos     \n";
            string dataprop = "Prop dados   \n";
            string objeprop = "Prop objetos \n";
            string classes  = "Classes      \n";
            bool nodo       = false;

            OntologyGraph o     = new OntologyGraph();  FileLoader.Load ( o , pastap +  "OntoBIM_ambientes_001.ttl");
            INode         Inodo = o.GetUriNode (new Uri ( meuuri ));
            
            IEnumerable<OntologyClass>    clas = o.OwlClasses;
            IEnumerable<OntologyProperty> prop = o.OwlDatatypeProperties;
            IEnumerable<OntologyProperty> data = o.OwlDatatypeProperties;
            IEnumerable<string>           pref = o.NamespaceMap.Prefixes;
                                          nodo = o.IsEmpty;

            foreach (string           s in pref) { prefixos += "\n" + s;            }
            foreach (OntologyClass    c in clas) { classes  += "\n" + c.ToString(); }
            foreach (OntologyProperty p in prop) { objeprop += "\n" + p.ToString() + p.Domains.ToString(); }
            foreach (OntologyProperty p in data) { dataprop += "\n" + p.ToString() + p.Domains.ToString(); }

            MessageBox.Show( nodo ? "VAZIO" : "CHEIO"            + "\n" +
                             Inodo.ToString()                    + "\n" + 
                             Inodo.NodeType.ToString()           + "\n" +  
                             Inodo.GraphUri.Authority.ToString() + "\n" +
                             Inodo.Graph.ToString()
                           );

            //MessageBox.Show(prefixos);
            //MessageBox.Show(classes );
              MessageBox.Show(objeprop);
            //MessageBox.Show(dataprop);
            //---------------------------------------------------------------------------------------
            //Exemplo de inferência de subclasses  Exemplo 1
            //---------------------------------------------------------------------------------------
            string   resultadoInfe = "\n";
            string   classe        = "ex:Car";
            Graph    dados1        = new Graph(); FileLoader.Load( dados1 , pastaa + "Os_individuos.ttl");
            Graph    esque1        = new Graph(); FileLoader.Load( esque1 , pastaa + "Os_esquemas.ttl" );
            IUriNode clase1        = dados1.CreateUriNode( classe );
            IUriNode tipos1        = dados1.CreateUriNode(new Uri(RdfSpecsHelper.RdfType));
            StaticRdfsReasoner razona1 = new StaticRdfsReasoner();
            razona1.Initialise( esque1 );
            razona1.Apply     ( dados1 );
            foreach (Triple t in dados1.GetTriplesWithPredicateObject( tipos1 , clase1))
            {
                     resultadoInfe += t.Subject.ToString() + "\n";  
            }
            MessageBox.Show( "\nCom Inferência 1: " + resultadoInfe );
            //---------------------------------------------------------------------------------------
            //Exemplo de inferência de subclasses  Exemplo 2 com ambientes fofu:
            //---------------------------------------------------------------------------------------
            resultadoInfe = "\n";
            classe        = "fofu:CorpoEdificado";

            Graph              dados2  = new Graph(); FileLoader.Load(dados2 , pastap + "OntoBIM_ambientes_Individuos.ttl");
            Graph              esque2  = new Graph(); FileLoader.Load(esque2 , pastap + "OntoBIM_ambientes_Esquema.ttl");
            IUriNode           clase2  = dados2.CreateUriNode ( classe );
            IUriNode           tipos2  = dados2.CreateUriNode (new Uri(RdfSpecsHelper.RdfType));
            StaticRdfsReasoner razona2 = new StaticRdfsReasoner();

            razona2.Initialise(esque2);
            razona2.Apply     (dados2);

            foreach (Triple t in dados2.GetTriplesWithPredicateObject(tipos2, clase2))
            {
                      resultadoInfe += 
                                       "Sujeito: "   + t.Subject.ToString()   + "\n" +
                                       "Objeto: "    + t.Object.ToString()    + "\n" +
                                       "Predicado: " + t.Predicate.ToString() + "\n" +
                                                      (t.IsGroundTriple ? "Verdadeiro":"Falso") + "\n";
            }
            MessageBox.Show( "\nCom Inferência 2: " + resultadoInfe   );
        }
    }
}

