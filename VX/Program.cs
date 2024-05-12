// See https://aka.ms/new-console-template for more information

using System;
using VDS.RDF;
using VDS.RDF.Ontology;
using VDS.RDF.Parsing;
using VDS.RDF.Query;
using VDS.RDF.Query.Inference;
using VDS.RDF.Writing;
using VDS.RDF.Writing.Formatting;

namespace OntoBIM
{
    public class OBIM
    {
        public static void Main(String[] args)
        {
               Mensagem ( "\nEsta é uma aplicação que usa ontologias ttl. Aguarde 1 segundo..." , 1000 );

  			   string dir1 = "C:\\JLMenegotto\\Projetos\\OBIM\\";
			   string dir2 = "C:\\ABNT_Normas\\ABNT\\Onto_Projeto_Arquitetura\\";

			   string esq      = dir1 + "Esquemas.ttl";
			   string fat      = dir1 + "Fatos.ttl";
               string arquttl  = dir2 + "Arquitetura.ttl";
               string meuuri   = "https://jlmenegotto.wixsite.com/jlmenegotto-bim#Elementos.Arquitetura";

               TurtleParser  tute  = new TurtleParser ( );
			   OntologyGraph onto  = new OntologyGraph( ); FileLoader.Load   ( onto , arquttl );
               IGraph        graf  = new Graph();          graf.LoadFromFile ( arquttl , tute );
               INode         Inodo = onto.GetUriNode ( new Uri ( meuuri ));

               IEnumerable<string> pref = onto.NamespaceMap.Prefixes;
                         
               Novos_Nodos  ( dir1 , "Exemplo");
			   Ver_Conteudo ( dir2 , "Arquitetura.ttl");

			   Razonador    ( "1" , esq , fat , ":Vehicle");
			   Razonador    ( "2" , esq , fat , ":Car");
			   Razonador    ( "3" , esq , fat , ":SportsCar");
		}

		public static List<ILiteralNode> Novos_Nodos ( string dir , string arq) 
        {
                      Graph              grafo  = new Graph();
			          IUriNode           RDF    = grafo.CreateUriNode ( UriFactory.Create ( "http://www.dotnetrdf.org" ));
                      IUriNode           dito   = grafo.CreateUriNode ( UriFactory.Create ( "https://jlmenegotto.wixsite.com/jlmenegotto-bim/obim"));
                      //IUriNode         dito   = grafo.CreateUriNode ( UriFactory.Create ( "http://example.org/obim"  ));
                      List<ILiteralNode> Lnodos = new List<ILiteralNode> { };
                      List<string>       Ltexto = new List<string> { "Nodo.A ", "Nodo.B ", "Nodo.C ", "Nodo.D ", "Nodo.E ", "Nodo.F ", "Nodo.G ", "Nodo.H " };
                      foreach (string txt in Ltexto)
                      {
		                        ILiteralNode litnod = grafo.CreateLiteralNode( txt , "pt" );
				                grafo.Assert ( new Triple ( RDF , dito , litnod ) );
			          }
                  	  foreach (Triple tri in grafo.Triples)
			          {
				            	Mensagem(tri.ToString() , 5 );
				      }
			          RdfXmlWriter   EscreveXML = new RdfXmlWriter   ( );
			          NTriplesWriter EscreveNT3 = new NTriplesWriter ( );
			          EscreveXML.Save ( grafo , dir + arq + ".rdf");
			          EscreveNT3.Save ( grafo , dir + arq + ".owl");
		       return Lnodos;
		}
		public static void Ver_Conteudo ( string dir , string arq ) 
		{
			          OntologyGraph onto = new OntologyGraph();
			          FileLoader.Load   (onto, dir + arq);
                      string texto = "";
                      //------------------------------------------------------------------------------------------
			          List<OntologyClass>    clase = onto.OwlClasses.ToList( );
                      List<OntologyProperty> propi = onto.OwlObjectProperties.ToList( );
                      List<OntologyProperty> dados = onto.OwlDatatypeProperties.ToList( );
			          List<INode>            nodos = onto.AllNodes.ToList( );
		              List<Triple>           tripl = onto.Triples.ToList ( );

			//------------------------------------------------------------------------------------------
			foreach (OntologyClass    cla in clase) { texto += "\nClasse:  " + cla.ToString(); }
            foreach (OntologyProperty pro in propi) { texto += "\nObjeto:  " + pro.ToString(); }
			foreach (OntologyProperty dad in dados) { texto += "\nDado:    " + dad.ToString(); }
			foreach (INode            nod in nodos) { texto += "\nNodo:    " + nod.ToString(); 
		                                              texto += "\nTipo:    " + nod.NodeType.ToString();
			}
			foreach (Triple           tri in tripl) { texto += "\nSujeito: " + tri.Subject.ToString();
	                                                  texto += "\nPredica: " + tri.Predicate.ToString();
				                                      texto += "\nObjeto:  " + tri.Object.ToString();
			}
            Mensagem (texto , 1000);
		}
		public static void Razonador    ( string num , string arquesq, string arqufat, string classe)
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
        public static void Selecionar   ( string dir              ) 
        {
               DirectoryInfo Dir = new DirectoryInfo( dir );
               int           i   = 1;
			   foreach (FileInfo f in Dir.GetFiles())
               {
			            Mensagem ( "\n" + i.ToString() + "- " + f.Name , 500);
                        i++;
               }

			   Mensagem ("\nSelecione Número do arquivo (Aguarda 5 seg): " , 5000 );

               if (Int32.TryParse(Console.ReadLine(), out i))
               {
                        FileInfo f = Dir.GetFiles()[i-1];
				        Mensagem ("\nArquivo selecionado = " + f.Name , 500);
               }          
        }
        public static void Mensagem     ( string txt , int tempo  ) 
        {
			   Console.WriteLine ( txt   );
  			   Thread.Sleep      ( tempo );
		}
	}
}
