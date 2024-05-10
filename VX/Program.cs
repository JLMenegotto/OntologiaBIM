// See https://aka.ms/new-console-template for more information

using VDS.RDF;
using VDS.RDF.Ontology;
using VDS.RDF.Parsing;
using VDS.RDF.Query.Inference;

namespace OntoBIM
{
    public class OBIM
    {
        public static void Main(String[] args)
        {
            Mensagem ( "\nEsta é uma aplicação que usa ontologias ttl. Aguarde 2 segundos..." , 2000 ); 

			string pastap  = "C:\\ABNT_Normas\\ABNT\\Onto_Projeto_Arquitetura\\";
            string arquttl = pastap + "Arquitetura.ttl";
            string meuuri  = "https://jlmenegotto.wixsite.com/jlmenegotto-bim#Elementos.Arquitetura";
            //bool   nodo  = false;

            string prefixos = "\n------------------\nPREFIXOS        \n------------------\n";
            string classes  = "\n------------------\nCLASSES         \n------------------\n";
            string objeprop = "\n------------------\nPROP. DE OBJETOS\n------------------\n";
            string dataprop = "\n------------------\nPROP. DE DADOS  \n------------------\n";
            string nodosont = "\n------------------\nNODOS           \n------------------\n";
            string tripleso = "\n------------------\nTRIPLES         \n------------------\n";

            OntologyGraph o     = new OntologyGraph(); FileLoader.Load(o, arquttl);
            IGraph        g     = new Graph();         g.LoadFromFile (arquttl, new TurtleParser());
            INode         Inodo = o.GetUriNode ( new Uri ( meuuri ));
            //nodo                = o.IsEmpty;

            IEnumerable<string>           pref = o.NamespaceMap.Prefixes;
            IEnumerable <OntologyClass>   clas = o.OwlClasses;
            IEnumerable<OntologyProperty> prop = o.OwlObjectProperties;
            IEnumerable<OntologyProperty> data = o.OwlDatatypeProperties;
            IEnumerable<INode>            nodo = o.AllNodes;
            IEnumerable<Triple>           trip = o.Triples;

            foreach (string pre in pref)          { prefixos += pref          + "\n"; }
            foreach (OntologyClass    cl in clas) { classes  += cl.ToString() + "\n"; }
            foreach (OntologyProperty op in prop) { objeprop += op.ToString() + "\n"; }
            foreach (OntologyProperty dp in data) { dataprop += dp.ToString() + "\n"; }

            foreach (INode nd in nodo) 
            {         
                     nodosont += "\n-----------" + 
                                 "\nNodo =     " + nd.ToString() + 
                                 "\nTipo =     " + nd.NodeType.ToString(); 
            }                                   
            foreach (Triple tr in trip)         
            {        tripleso += "\n-----------" +
                                 "\nSujeito  = " + tr.Subject.ToString() +
                                 "\nPredica  = " + tr.Predicate.ToString() +
                                 "\nObjeto   = " + tr.Object.ToString();
            }

            Mensagem ( classes  , 2000 ); 
            Mensagem ( objeprop , 2000 ); 
            Mensagem ( dataprop , 2000 ); 
            Mensagem ( nodosont , 2000 );
            Mensagem ( tripleso , 2000 ); 
            //-----------------------------------------------------------------------------------
            // Teste simple do reasoner
            //-----------------------------------------------------------------------------------
            string dir = "C:\\JLMenegotto\\Projetos\\OBIM\\";
            string esq = dir + "Esquemas.ttl";
            string fat = dir + "Fatos.ttl";

			Razonador ( "1" , esq , fat , ":Vehicle");
			Razonador ( "2" , esq , fat , ":Car");
			Razonador ( "3" , esq , fat , ":SportsCar");
		}

        public static void Razonador (string num, string arquesq, string arqufat, string classe)
        {
			   Mensagem  ("\nINICIA RAZONADOR: " + num + "   Aguarde 2 segundos.", 2000);  

		  	   StaticRdfsReasoner razonador = new StaticRdfsReasoner();
               string inferido = "\n";
               string separado = "\n-----------------";

               Graph    fatos   = new Graph();  FileLoader.Load(fatos   , arqufat );
               Graph    esquema = new Graph();  FileLoader.Load(esquema , arquesq );
               
               IUriNode clas = esquema.CreateUriNode( classe );
               IUriNode tipo = esquema.CreateUriNode( new Uri(RdfSpecsHelper.RdfType));

               razonador.Initialise( esquema );
               razonador.Apply     ( fatos   );

               foreach (Triple spo in fatos.GetTriplesWithPredicateObject ( tipo , clas ))
               {
                        inferido += separado +
									(spo.IsGroundTriple ? "\nO que segue é Verdadeiro" : "\nFalso") +
                                    "\nSujeito: " + spo.Subject.ToSafeString()   + 
                                    "\nPredica: " + spo.Predicate.ToSafeString() + 
                                    "\nObjeto:  " + spo.Object.ToSafeString();            
               }
			   Mensagem ("\nRESULTADO RAZONADOR: " + num + inferido , 2000 ); 
        }

        public static void SelecionarArquivo ()
        {
               DirectoryInfo Dir = new DirectoryInfo("C:/JLMenegotto/Projetos/OBIM");
               int i  = 0;
			   foreach (FileInfo f in Dir.GetFiles())
               {
			            Mensagem ( "\n" + i.ToString() + "- " + f.Name , 500);
                        i++;
               }

			            Mensagem ("\nNúmero do arquivo: " , 3000 );

               if (Int32.TryParse(Console.ReadLine(), out i))
               {
                        FileInfo f = Dir.GetFiles()[i];
				        Mensagem ("\nArquivo selecionado = " + f.Name , 500);
               }          
        }
        public static void Mensagem ( string txt , int tempo)
        {
			   Console.WriteLine ( txt   );
  			   Thread.Sleep      ( tempo );
		}


	}
}
