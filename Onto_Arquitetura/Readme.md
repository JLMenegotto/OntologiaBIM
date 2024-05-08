## Ontologia de projeto Arquitetônico - Prefixo arq:

Os arquivos Excel de esta pasta contêm o campo ontológico de conceitos para projeto Arquitetônico para serem utilizados em projetos BIM. 
Antes de executar filtros SPARQL em Protégé deve-se inicializar um Reasoner como HermiT.

Consulte em: https://www.w3.org/TR/sparql11-query/

### Arquivos
    1. Ontologia_V1_Projeto_Arquitetura.dyn   (Função em Designscript para Revit 2024 que gera o arquivo OWL)
    2. Ontologia_V1_Projeto_Arquitetura.owl   (Ontologia owl escrita em sintaxe Manchester)
    3. Ontologia_V1_Projeto_Arquitetura.xlsx  (Campo ontológico de Instâncias de teste)
    4. Ontologia_V1_Projeto_Arquitetura_Classes_Propriedades.xlsx (Campo ontológico com Classes e Propriedades e disjunções) 

### Observações

As instâncias da ontologia (Individual) têm a finalidade de testar a consistência das classes e propriedades. 
Os indivíduos e os fatos associados devem ser criados a partir da leitura de um modelo BIM.

### Grafos de exemplo
![Grafo_01](https://github.com/JLMenegotto/OntologiaBIM/assets/9437020/595c3427-4820-4f10-b329-6dc09a8cf39b)


### Filtro SPARQL1
        Prefix arq: <https://jlmenegotto.wixsite.com/jlmenegotto-bim#>    
        # Encontrar descrições que contenham "Wall" e "Door"
    
        Select ?ob1 ?ob2 ?p1 ?p2 
        Where
        {
               ?ob1 arq:descrição ?p1 .
               ?ob2 arq:descrição ?p2 .
               filter (contains (str (?p1), "Wall")) 
               filter (contains (str (?p2), "Door")) 
        }

http://localhost:7200/sparql?name=Paredes%20e%20Portas&query=PREFIX%20arq%3A%20%3Chttps%3A%2F%2Fjlmenegotto.wixsite.com%2Fjlmenegotto-bim%23%3E%0ASelect%20%3Fparedes%20%3Fportas%20%3Fdpar%20%3Fdpor%20%0AWhere%0A%7B%0A%20%20%20%20%20%20%20%20%20%20%20%20%20%20%20%3Fparedes%20arq%3Adescri%C3%A7%C3%A3o%20%3Fdpar%20.%0A%20%20%20%20%20%20%20%20%20%20%20%20%20%20%20%3Fportas%20arq%3Adescri%C3%A7%C3%A3o%20%3Fdpor%20.%0A%20%20%20%20%20%20%20%20%20%20%20%20%20%20%20filter%20(contains%20(str%20(%3Fdpar)%2C%20%22Wall%22))%20%0A%20%20%20%20%20%20%20%20%20%20%20%20%20%20%20filter%20(contains%20(str%20(%3Fdpor)%2C%20%22Door%22))%20%0A%7D%0A&infer=true&sameAs=true

### Filtro SPARQL2
        Prefix arq: <https://jlmenegotto.wixsite.com/jlmenegotto-bim#>
        # Encontrar tipos que contenham "Vidro"   
        Select ?r1 ?o1 ?t1 
        Where
        {
               ?r1  arq:descrição ?o1 ;
                    arq:tipo ?t1 .
               filter (contains (str (?t1), "Vidro")) 
        }

### Filtro SPARQL3
         Prefix arq: <https://jlmenegotto.wixsite.com/jlmenegotto-bim#>
         # Encontrar as classes 
         
          Select distinct  ?classe
          where
          {
                ?recurso  a  ?classe .
          }
        
