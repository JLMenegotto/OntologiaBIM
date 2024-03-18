
## Arquivos OWL com as ontologias em sintaxe Manchester

O aluno pode abrir o arquivo OWL num editor de texto ou no Editor Protégé e fazer a leitura do conteúdo que está em sintaxe Manchester.

# Exemplo de filtro SPARQL que pode ser aplicado

 SELECT ?x ?y ?p ?q
 WHERE { 
            ?x abnt:código-n1 "20" .
            ?x abnt:código-n2 "10" .
            ?x abnt:código-n1 ?y .
            ?x abnt:código-n2 ?p .
            ?x abnt:descrição ?q .
       }
//Retorna uma lista de materiais n1 = 20 
//                               n2 = 10 
// ordenada com as colunas n1, n2, descrição do material
