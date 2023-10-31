# Ontologias BIM GIS 
  * **Escola Politécnica da UFRJ**
  *  **Programa de Pós-graduação em Engenharia Urbana**
  *  **Programa de Pós-graduação em Estruturas**

No projeto Ontologia BIM, atualmente ampliado para Ontologias GIS, foi implementado um construtor de ontologias para a criação de módulos ontológicos em formato OWL. 
Pensados para serem integrados em sistemas de dados abertos e conectados, que trabalhem com contextos de informação da construção ou geográficos. Os módulos procuram descrever conceitualmente os elementos de projetos arquitetônicos e urbanos. Podem ser aproveitados para ordenar e direcionar dados em sistemas CAD BIM GIS durante a concepção, assim como para organizar a informação durante as etapas construtivas e de gerenciamento após a construção. Procura-se integrar as categorias e enumerações de esquemas de dados diferentes como IFC e Revit. Atualmente o sistema está sendo ampliado para incorporar modelos de informação GIS como o CityGML, KML, OSM, etc. 

A implementação do construtor parte da hipótese de que a tecnologia digital de projeto em BIM poderá evoluir melhor se o conhecimento projetual que vai sendo acumulado com o decorrer do tempo for expresso e ordenado em redes de dados abertos e vinculados, segundo conceitualizou Tim Berners-Lee, configurando aos poucos bases de conhecimentos compartilhadas. Se Normas Técnicas expressam o conhecimento industrial acumulado, por que não o estruturar em ontologias de domínio específico e colocá-las a disposição de modo irrestrito, para que a comunidade técnica possa usufruir? Não se beneficiaria a indústria como um todo orgânico? Não seria esse um retorno do conhecimento às suas fontes?

Parece lógico defender que ontologias OWL devam ser desenvolvidas e publicadas abertamente e de modo irrestrito pelas organizações normativas, como a Associação Brasileira de Normas Técnicas (ABNT). Ontologias de produtos publicadas pelos fabricantes, que conhecem melhor os seus produtos e processos, complementariam as tradicionais bibliotecas de componentes. Códigos de edificações das Prefeituras e do Corpo de Bombeiros poderiam fornecer ontologias de requisitos em formato OWL, transformando fluxos de verificação e validação de projetos num processo aberto que aconteceria sistematicamente de modo contínuo e em paralelo ao projeto.

Os arquivos OWL, escritos em notação Manchester, são criados modularmente a partir de planilhas Excel gerenciadas por uma macro programada especialmente e a medida em Designscript. As ontologias podem ser abertas no editor Protégé para visualizar, gerenciar ou depurar a sua estruturação. Os módulos desenvolvidos tem prefixo fofu: (significando forma e função) e estão divididos em domínios específicos (ambiente, esquadria, SUS, normas, etc). As determinações ontológicas procuram fazer o alinhamento dos módulos para que possam ser importados evitando-se ou minimizando as sobreposições e ambiguidades conceituais. Ontologias direcionadas ao GIS poderão ter prefixos como urba:  rede: h2o: que permitam caracterizar o Namespace do domínio modelado.

 * **Fontes
                https://github.com/JLMenegotto/OntologiaBIM/tree/main/Dynamo

 * **Grafos
                https://github.com/JLMenegotto/OntologiaBIM/tree/main/OWL
      

* Versão 2.00 Para Revit 2024
![OntoBIM_Manchester_2024](https://github.com/JLMenegotto/OntologiaBIM/assets/9437020/945e437f-32db-44be-b04e-ec7d19a2a3c3)


![Tela_Inicial](https://user-images.githubusercontent.com/9437020/226172682-0c1a09aa-7069-428d-a8b8-fe8abb9ea39c.PNG)
