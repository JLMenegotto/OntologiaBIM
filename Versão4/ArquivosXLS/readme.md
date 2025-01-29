# Construtor de Ontologias BIM GIS. Versão 4.0 
<sub> **_Prof. José Luis Menegotto._**</sub> 
+ <sub> **_DEG/POLI/UFRJ. Escola Politécnica da UFRJ._**</sub>
+ <sub> _PEU Programa de Pós-graduação em Engenharia Urbana_</sub>
+ <sub> _PPE Programa de Pós-graduação em Estruturas_</sub>

## Observações 
#### Os arquivos com nome Ontologia_IFC4_3_Axiomas.xlsx e Ontologia_IFC4_3_Projeto.xlsx incorporam a tradução em español e estão sendo testados para substituir Ontologia_IFC4x3_Axiomas.xlsx e Ontologia_IFC4x3_Projeto.xlsx. Repare a diferença no nome: IFC4_3  IFC4x3

#### Na versão 4, que é a mais recente do construtor, foi modificada a forma de leitura do arquivo Excel para permitir estruturar de modo menos homogêneo a planilha de axiomas de Classes.

#### Para as Classes IFC que não tenham uma categoria correlativa direta em Revit é sugerida uma ou várias categorias. Foi preparada uma anotação rdfs:label específica informada no RDF.

	  Class: bim:IfcSolarDevice
		SubClassOf: bim:Gerador_Solar
		Annotations: bim:Disciplina "Energética"@pt
		Annotations: bim:Tradução "Dispositivo captação solar"@pt
		Annotations: bim:Interoperabilidade "OST_ElectricalEquipmentt"@pt
		Annotations: bim:Natureza "Projeto"@pt
		Annotations: bim:Espécie "Insumos_Geração"@pt
		Annotations: bim:Tema "Gerador Solar"@pt

#### Arquivos OWL e TTL resultado do processo. Podem ser importados no Protégé para verificação.
#### As Classes IFC e Categorias de Revit (OST_) foram ordenadas de modo a ter os conceitos comuns (colunas B C D E).
#### Pode acontecer que algum conceito esteja presente num dos modelos de informação apenas. 
#### Na planilha de axiomas foram incorporadas colunas que definem Anotações sobre a Classe 

	 * Annotations: bim:Disciplina "Energética"@pt
 	 * Annotations: bim:Tradução "Dispositivo captação solar"@pt
	 * Annotations: bim:Interoperabilidade "OST_ElectricalEquipmentt"@pt
  	 * Annotations: bim:Natureza "Projeto"@pt
  	 * Annotations: bim:Espécie "Insumos_Geração"@pt
  	 * Annotations: bim:Tema "Gerador Solar"@pt

#### O trabalho está em processo de desenvolvimento portanto, os arquivos no repositório são continuamente atualizados e as mudanças podem ser de diversos graus.

##### Visualizações das classes em Protégé com OWLVIZ. 
##### As classes em amarelo são as definidas, as que figuram em laranja são as relações de equivalência entre classes. 
##### O texto "is-a" nas setas deve ser interpretado como uma relação entre as classes.

![Arq_Aud_01](https://github.com/user-attachments/assets/54222801-41bd-41df-941d-e6b416abb65d)

![Arq_Ene_01](https://github.com/user-attachments/assets/ddf61c29-f7cc-437c-bb45-9caf930d5199)


![Arq_Ilu_01](https://github.com/user-attachments/assets/43b7dfc4-64d6-4eaf-a1f0-1c70b0fbb470)

![Classes_Lampada](https://github.com/user-attachments/assets/c716a964-2318-4b8d-8ab1-c046234cf6bd)

