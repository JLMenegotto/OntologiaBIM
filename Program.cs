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

            foreach (string           s in pref) { prefixos += "\n" + s;            }
            foreach (OntologyClass    c in clas) { classes  += "\n" + c.ToString(); }
            foreach (OntologyProperty p in prop) { objeprop += "\n" + p.ToString(); }
            foreach (OntologyProperty p in data) { dataprop += "\n" + p.ToString(); }

            MessageBox.Show( nodo ? "VAZIO" : "CHEIO"            + "\n" +
                             Inodo.ToString()                    + "\n" + 
                             Inodo.NodeType.ToString()           + "\n" +  
                             Inodo.GraphUri.Authority.ToString() + "\n" +
                             Inodo.Graph.ToString()
                           );

            //MessageBox.Show(prefixos);
            //MessageBox.Show(classes );
            //MessageBox.Show(objeprop);
            //MessageBox.Show(dataprop);
            //---------------------------------------------------------------------------------------
            //Exemplo de inferência de subclasses  Exemplo 1
            //---------------------------------------------------------------------------------------
            string pasta1 = "C:\\JLMenegotto\\Aplicativos_BIM\\OntoBIM\\";
            string resultadoSemi = "\n";
            string resultadoInfe = "\n";

            //Carregar dados e esquemas 
            Graph dados1 = new Graph(); FileLoader.Load(dados1 , pasta1 + "Os_individuos.ttl");
            Graph esque1 = new Graph(); FileLoader.Load(esque1 , pasta1 + "Os_esquemas.ttl" );

            IUriNode clase1 = dados1.CreateUriNode("ex:Car");
            IUriNode tipos1 = dados1.CreateUriNode(new Uri(RdfSpecsHelper.RdfType));
            foreach (Triple t in dados1.GetTriplesWithPredicateObject( tipos1 , clase1))
            {
                   resultadoSemi += t.Subject.ToString() + "\n";
            }
            MessageBox.Show( "\nSem Inferência 1: " + resultadoSemi + "\n" );

            //Faz a inferência e retorna as subclasses de carros
            StaticRdfsReasoner razona = new StaticRdfsReasoner();
            razona.Initialise( esque1 );
            razona.Apply     ( dados1 );
            foreach (Triple t in dados1.GetTriplesWithPredicateObject( tipos1 , clase1))
            {
                     resultadoInfe += t.Subject.ToString() + "\n";  
            }

            MessageBox.Show(
                               "\nSem Inferência 1: " + resultadoSemi + "\n" +
                               "\nCom Inferência 1: " + resultadoInfe
                           );


            //---------------------------------------------------------------------------------------
            //Exemplo de inferência de subclasses  Exemplo 2 com ambientes fofu:
            //---------------------------------------------------------------------------------------
            resultadoSemi   = "\n";
            resultadoInfe   = "\n";
            string   pasta2 = "C:\\JLMenegotto\\Projetos\\OntoBIM\\";
            Graph    dados2 = new Graph(); FileLoader.Load(dados2, pasta2 + "OntoBIM_ambientes_Individuos.ttl");
            Graph    esque2 = new Graph(); FileLoader.Load(esque2, pasta2 + "OntoBIM_ambientes_Esquema.ttl");
            IUriNode clase2 = dados2.CreateUriNode("fofu:Ambiente");
            IUriNode tipos2 = dados2.CreateUriNode(new Uri(RdfSpecsHelper.RdfType));

            //Resultaso sim fazer inferência
            foreach (Triple t in dados2.GetTriplesWithPredicateObject(tipos2, clase2))
            {
                     resultadoSemi += t.Subject.ToString() + "\n";
            }

            MessageBox.Show("\nSem Inferência 2: " + resultadoSemi + "\n");

            //Faz a inferência e retorna as subclasses de carros
            StaticRdfsReasoner razona2 = new StaticRdfsReasoner();
            razona2.Initialise(esque2);
            razona2.Apply     (dados2);

            //Resultados com inferência
            foreach (Triple t in dados2.GetTriplesWithPredicateObject(tipos2, clase2))
            {
                resultadoInfe += t.Subject.ToString() + "\n";
            }
            MessageBox.Show(
                               "\nSem Inferência 2: " + resultadoSemi + "\n" +
                               "\nCom Inferência 2: " + resultadoInfe
                           );

        }
    }
}

