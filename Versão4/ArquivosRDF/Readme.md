# Construtor de Ontologias BIM GIS. Versão 4.0 
<sub> **_Prof. José Luis Menegotto._**</sub> 
+ <sub> **_DEG/POLI/UFRJ. Escola Politécnica da UFRJ._**</sub>
+ <sub> _PEU Programa de Pós-graduação em Engenharia Urbana_</sub>
+ <sub> _PPE Programa de Pós-graduação em Estruturas_</sub>

## Observações 

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

![Vista_INC](https://github.com/user-attachments/assets/24b8b37b-f52d-43e7-bbe8-805db847c105)

![ARQ_Mobiliários](https://github.com/user-attachments/assets/859a65e4-01ba-44e3-b07d-7be2207c8ed2)

![Vista_01](https://github.com/user-attachments/assets/10623359-40ab-4ae5-b43f-349f434f230e)

