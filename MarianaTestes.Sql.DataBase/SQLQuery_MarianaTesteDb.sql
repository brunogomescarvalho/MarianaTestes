USE GeradorTesteOrm

DELETE FROM TBTESTE_TBQUESTAO
DELETE FROM TBTESTE
DELETE FROM TBALTERNATIVA
DELETE FROM TBQUESTAO
DELETE FROM TBMATERIA
DELETE FROM TBDISCIPLINA

DBCC CHECKIDENT(TBTESTE, RESEED, 0)
DBCC CHECKIDENT(TBALTERNATIVA, RESEED, 0)
DBCC CHECKIDENT(TBQUESTAO, RESEED, 0)
DBCC CHECKIDENT(TBMATERIA, RESEED, 0)
DBCC CHECKIDENT(TBDISCIPLINA, RESEED, 0)

                             
INSERT INTO TBDISCIPLINA VALUES ('MATEMÁTICA')    
INSERT INTO TBDISCIPLINA VALUES ('PORTUGUÊS')                
INSERT INTO TBDISCIPLINA VALUES ('ARTES')    
INSERT INTO TBDISCIPLINA VALUES ('CIÊNCIAS')

INSERT INTO TBMATERIA (nome, serie, DisciplinaId) VALUES ('Números e operações', 1,1)    
INSERT INTO TBMATERIA  (nome, serie, DisciplinaId) VALUES ('Formas Geométricas', 2,1)     
INSERT INTO TBMATERIA  (nome, serie, DisciplinaId)VALUES ('Vogais e consoantes', 1,2)                       
INSERT INTO TBMATERIA  (nome, serie, DisciplinaId)VALUES ('Cores primárias', 1,3)                                    
INSERT INTO TBMATERIA  (nome, serie, DisciplinaId)VALUES ('Animais', 1,4)  
INSERT INTO TBMATERIA  (nome, serie, DisciplinaId)VALUES ('Plantas', 1,4)  
                
INSERT INTO TBQUESTAO VALUES ('Qual é o resultado da adição de 3 + 2?',1,0)
INSERT INTO TBALTERNATIVA (Texto, EhCorreta, QuestaoId)VALUES ('4',0,1)
INSERT INTO TBALTERNATIVA (Texto, EhCorreta, QuestaoId)VALUES ('5',1,1)
INSERT INTO TBALTERNATIVA(Texto, EhCorreta, QuestaoId) VALUES ('6',0,1)
INSERT INTO TBALTERNATIVA (Texto, EhCorreta, QuestaoId)VALUES ('7',0,1)


INSERT INTO TBQUESTAO VALUES ('Quanto é 10 - 4?',1,0)
INSERT INTO TBALTERNATIVA (Texto, EhCorreta, QuestaoId) VALUES ('3',0,2)
INSERT INTO TBALTERNATIVA (Texto, EhCorreta, QuestaoId)VALUES ('4',0,2)
INSERT INTO TBALTERNATIVA(Texto, EhCorreta, QuestaoId) VALUES ('5',0,2)
INSERT INTO TBALTERNATIVA(Texto, EhCorreta, QuestaoId) VALUES ('6',1,2)


INSERT INTO TBQUESTAO VALUES ('Complete a sequência numérica: 2, 4, 6, __, 10',1,0)
INSERT INTO TBALTERNATIVA(Texto, EhCorreta, QuestaoId) VALUES ('8',1,3)
INSERT INTO TBALTERNATIVA (Texto, EhCorreta, QuestaoId)VALUES ('9',0,3)
INSERT INTO TBALTERNATIVA (Texto, EhCorreta, QuestaoId)VALUES ('10',0,3)
INSERT INTO TBALTERNATIVA (Texto, EhCorreta, QuestaoId)VALUES ('11',0,3)


INSERT INTO TBQUESTAO VALUES ('Qual é o resultado da multiplicação de 5 por 3?',1,0)
INSERT INTO TBALTERNATIVA (Texto, EhCorreta, QuestaoId)VALUES  ('8',0,4)
INSERT INTO TBALTERNATIVA (Texto, EhCorreta, QuestaoId)VALUES ('12',0,4)
INSERT INTO TBALTERNATIVA (Texto, EhCorreta, QuestaoId)VALUES ('15',1,4)
INSERT INTO TBALTERNATIVA(Texto, EhCorreta, QuestaoId) VALUES ('18',0,4)


INSERT INTO TBQUESTAO VALUES ('Qual é o número que vem antes do 9?',1,0)
INSERT INTO TBALTERNATIVA(Texto, EhCorreta, QuestaoId) VALUES  ('7',0,5)
INSERT INTO TBALTERNATIVA (Texto, EhCorreta, QuestaoId)VALUES  ('8',1,5)
INSERT INTO TBALTERNATIVA(Texto, EhCorreta, QuestaoId) VALUES  ('9',0,5)
INSERT INTO TBALTERNATIVA(Texto, EhCorreta, QuestaoId) VALUES ('10',0,5)


INSERT INTO TBQUESTAO VALUES ('Qual das seguintes letras é uma vogal?',3,0)
INSERT INTO TBALTERNATIVA (Texto, EhCorreta, QuestaoId)VALUES ('B',0,6)
INSERT INTO TBALTERNATIVA (Texto, EhCorreta, QuestaoId)VALUES ('C',0,6)
INSERT INTO TBALTERNATIVA(Texto, EhCorreta, QuestaoId) VALUES ('D',0,6)
INSERT INTO TBALTERNATIVA(Texto, EhCorreta, QuestaoId)VALUES ('E',1,6)


INSERT INTO TBQUESTAO VALUES ( 'Qual das seguintes letras não é uma vogal?',3,0)
INSERT INTO TBALTERNATIVA (Texto, EhCorreta, QuestaoId)VALUES  ('E',0,7)
INSERT INTO TBALTERNATIVA (Texto, EhCorreta, QuestaoId)VALUES ('I' ,0,7)
INSERT INTO TBALTERNATIVA(Texto, EhCorreta, QuestaoId) VALUES ('F' ,1,7)
INSERT INTO TBALTERNATIVA(Texto, EhCorreta, QuestaoId) VALUES ('O' ,0,7)


INSERT INTO TBQUESTAO VALUES ('Quantas consoantes existem na palavra "Amigo"?',3,0)
INSERT INTO TBALTERNATIVA(Texto, EhCorreta, QuestaoId) VALUES ('1',0,8)
INSERT INTO TBALTERNATIVA(Texto, EhCorreta, QuestaoId) VALUES ('2',1,8)
INSERT INTO TBALTERNATIVA(Texto, EhCorreta, QuestaoId) VALUES ('3',0,8)
INSERT INTO TBALTERNATIVA(Texto, EhCorreta, QuestaoId) VALUES ('4',0,8)


INSERT INTO TBQUESTAO VALUES ('Complete a palavra: "B_l_".',3,0)
INSERT INTO TBALTERNATIVA(Texto, EhCorreta, QuestaoId) VALUES  ('Pato',   0,9)
INSERT INTO TBALTERNATIVA(Texto, EhCorreta, QuestaoId) VALUES ('Bola',    1,9)
INSERT INTO TBALTERNATIVA(Texto, EhCorreta, QuestaoId) VALUES ('Cachorro',0,9)
INSERT INTO TBALTERNATIVA (Texto, EhCorreta, QuestaoId)VALUES ('Gato',    0,9)


INSERT INTO TBQUESTAO VALUES ('Qual é a primeira letra do alfabeto?',3,0)
INSERT INTO TBALTERNATIVA (Texto, EhCorreta, QuestaoId)VALUES  ('A',1,10)
INSERT INTO TBALTERNATIVA(Texto, EhCorreta, QuestaoId) VALUES  ('B',0,10)
INSERT INTO TBALTERNATIVA(Texto, EhCorreta, QuestaoId) VALUES  ('C',0,10)
INSERT INTO TBALTERNATIVA (Texto, EhCorreta, QuestaoId)VALUES ( 'D',0,10)


INSERT INTO TBQUESTAO VALUES ('Quais são as cores primárias?',4,0)
INSERT INTO TBALTERNATIVA(Texto, EhCorreta, QuestaoId) VALUES ('Vermelho, verde e azul',0,11)
INSERT INTO TBALTERNATIVA(Texto, EhCorreta, QuestaoId) VALUES ('Vermelho, amarelo e azul',1,11)
INSERT INTO TBALTERNATIVA(Texto, EhCorreta, QuestaoId) VALUES ('Vermelho, amarelo e verde',0,11)
INSERT INTO TBALTERNATIVA (Texto, EhCorreta, QuestaoId)VALUES ('Laranja, verde e roxo',0,11)


INSERT INTO TBQUESTAO VALUES ('Misturando as cores amarelo e azul, qual cor é obtida?',4,0)
INSERT INTO TBALTERNATIVA (Texto, EhCorreta, QuestaoId)VALUES  ('Vermelho',0,12)
INSERT INTO TBALTERNATIVA (Texto, EhCorreta, QuestaoId)VALUES ('Verde' ,1,12)
INSERT INTO TBALTERNATIVA (Texto, EhCorreta, QuestaoId)VALUES ('Laranja' ,0,12)
INSERT INTO TBALTERNATIVA (Texto, EhCorreta, QuestaoId)VALUES ('Roxo' ,0,12)


INSERT INTO TBQUESTAO VALUES ('Quais são as cores secundárias?',4,0)
INSERT INTO TBALTERNATIVA (Texto, EhCorreta, QuestaoId)VALUES ('Vermelho, verde e azul',0,13)
INSERT INTO TBALTERNATIVA (Texto, EhCorreta, QuestaoId)VALUES ('Vermelho, amarelo e azul',0,13)
INSERT INTO TBALTERNATIVA (Texto, EhCorreta, QuestaoId)VALUES ('Vermelho, amarelo e verde',0,13)
INSERT INTO TBALTERNATIVA (Texto, EhCorreta, QuestaoId)VALUES ('Laranja, verde e roxo',1,13)

INSERT INTO TBQUESTAO VALUES ('Qual é a cor resultante da mistura das cores primárias?',4,0)
INSERT INTO TBALTERNATIVA(Texto, EhCorreta, QuestaoId) VALUES  ('Preto',0,14)
INSERT INTO TBALTERNATIVA(Texto, EhCorreta, QuestaoId) VALUES ('Branco',0,14)
INSERT INTO TBALTERNATIVA(Texto, EhCorreta, QuestaoId) VALUES ('Cinza',0,14)
INSERT INTO TBALTERNATIVA(Texto, EhCorreta, QuestaoId) VALUES ('Marrom',1,14)


INSERT INTO TBQUESTAO VALUES ('Qual é a cor complementar do amarelo?',4,0)
INSERT INTO TBALTERNATIVA(Texto, EhCorreta, QuestaoId) VALUES ( 'Roxo',1,15)
INSERT INTO TBALTERNATIVA(Texto, EhCorreta, QuestaoId) VALUES  ('Azul',0,15)
INSERT INTO TBALTERNATIVA(Texto, EhCorreta, QuestaoId) VALUES  ('Verde',0,15)
INSERT INTO TBALTERNATIVA(Texto, EhCorreta, QuestaoId) VALUES  ('Vermelho',0,15)


INSERT INTO TBQUESTAO VALUES ('Qual dos seguintes animais é um mamífero?',5,0)
INSERT INTO TBALTERNATIVA(Texto, EhCorreta, QuestaoId) VALUES ('Galinha',0,16)
INSERT INTO TBALTERNATIVA(Texto, EhCorreta, QuestaoId) VALUES ('Peixe',0,16)
INSERT INTO TBALTERNATIVA(Texto, EhCorreta, QuestaoId) VALUES ('Girafa',1,16)
INSERT INTO TBALTERNATIVA(Texto, EhCorreta, QuestaoId) VALUES ('Tartaura',0,16)


INSERT INTO TBQUESTAO VALUES ('Qual é o maior animal terrestre?',5,0)
INSERT INTO TBALTERNATIVA(Texto, EhCorreta, QuestaoId) VALUES  ('Elefante',1,17)
INSERT INTO TBALTERNATIVA(Texto, EhCorreta, QuestaoId) VALUES ('Leão',0,17)
INSERT INTO TBALTERNATIVA(Texto, EhCorreta, QuestaoId) VALUES ('Hipopótamo' ,0,17)
INSERT INTO TBALTERNATIVA(Texto, EhCorreta, QuestaoId) VALUES ('Girafa',0,17)


INSERT INTO TBQUESTAO VALUES ('Qual é o órgão responsável pela respiração nos seres humanos?',5,0)
INSERT INTO TBALTERNATIVA(Texto, EhCorreta, QuestaoId) VALUES ('Coração',0,18)
INSERT INTO TBALTERNATIVA(Texto, EhCorreta, QuestaoId) VALUES ('Estômago',0,18)
INSERT INTO TBALTERNATIVA(Texto, EhCorreta, QuestaoId) VALUES ('Fígado',0,18)
INSERT INTO TBALTERNATIVA(Texto, EhCorreta, QuestaoId) VALUES ('Pulmão',1,18)



INSERT INTO TBQUESTAO VALUES ('Quais são as partes principais de um inseto?',5,0)
INSERT INTO TBALTERNATIVA(Texto, EhCorreta, QuestaoId) VALUES ('Cabeça, tronco e membros',0,19)
INSERT INTO TBALTERNATIVA(Texto, EhCorreta, QuestaoId) VALUES ('Cabeça, pescoço e pernas',0,19)
INSERT INTO TBALTERNATIVA(Texto, EhCorreta, QuestaoId) VALUES ('Cabeça, tórax e abdômen',1,19)
INSERT INTO TBALTERNATIVA(Texto, EhCorreta, QuestaoId) VALUES ('Cabeça, peito e barriga',0,19)


INSERT INTO TBQUESTAO VALUES ('Qual é o processo pelo qual as plantas produzem seu próprio alimento?',6,0)
INSERT INTO TBALTERNATIVA(Texto, EhCorreta, QuestaoId) VALUES ('Fotossíntese',1,20)
INSERT INTO TBALTERNATIVA(Texto, EhCorreta, QuestaoId) VALUES  ('Respiração',0,20)
INSERT INTO TBALTERNATIVA(Texto, EhCorreta, QuestaoId) VALUES  ('Digestão',0,20)
INSERT INTO TBALTERNATIVA(Texto, EhCorreta, QuestaoId) VALUES  ('Circulação',0,20)






-- 


INSERT INTO TBQUESTAO VALUES ('Qual é a forma geométrica que tem três lados?',2,0)
INSERT INTO TBALTERNATIVA(Texto, EhCorreta, QuestaoId) VALUES ('Quadrado',0,21)
INSERT INTO TBALTERNATIVA(Texto, EhCorreta, QuestaoId) VALUES  ('Círculo',0,21)
INSERT INTO TBALTERNATIVA(Texto, EhCorreta, QuestaoId) VALUES  ('Triângulo',1,21)
INSERT INTO TBALTERNATIVA(Texto, EhCorreta, QuestaoId) VALUES  ('Retângulo',0,21)


INSERT INTO TBQUESTAO VALUES ('Quantos lados tem um retângulo?',2,0)
INSERT INTO TBALTERNATIVA(Texto, EhCorreta, QuestaoId) VALUES ('2',0,22)
INSERT INTO TBALTERNATIVA(Texto, EhCorreta, QuestaoId) VALUES  ('3',0,22)
INSERT INTO TBALTERNATIVA(Texto, EhCorreta, QuestaoId) VALUES  ('4',1,22)
INSERT INTO TBALTERNATIVA(Texto, EhCorreta, QuestaoId) VALUES  ('5',0,22)


INSERT INTO TBQUESTAO VALUES ('Qual é a forma geométrica que tem quatro lados iguais?',2,0)
INSERT INTO TBALTERNATIVA (Texto, EhCorreta, QuestaoId)VALUES ('Quadrado',1,   23)
INSERT INTO TBALTERNATIVA (Texto, EhCorreta, QuestaoId)VALUES  ('Círculo',0,   23)
INSERT INTO TBALTERNATIVA (Texto, EhCorreta, QuestaoId)VALUES  ('Triângulo',0, 23)
INSERT INTO TBALTERNATIVA (Texto, EhCorreta, QuestaoId)VALUES  ('Retângulo',0, 23)


INSERT INTO TBQUESTAO VALUES ('Quantos lados tem um pentágono?',2,0)
INSERT INTO TBALTERNATIVA (Texto, EhCorreta, QuestaoId)VALUES  ('2',0,24)
INSERT INTO TBALTERNATIVA (Texto, EhCorreta, QuestaoId)VALUES   ('3',0,24)
INSERT INTO TBALTERNATIVA (Texto, EhCorreta, QuestaoId)VALUES   ('4',0,24)
INSERT INTO TBALTERNATIVA (Texto, EhCorreta, QuestaoId)VALUES   ('5',1,24)


INSERT INTO TBQUESTAO VALUES ('Qual é a forma geométrica que não possui lados?',2,0)
INSERT INTO TBALTERNATIVA (Texto, EhCorreta, QuestaoId)VALUES ('Quadrado',0,   25)
INSERT INTO TBALTERNATIVA (Texto, EhCorreta, QuestaoId)VALUES  ('Círculo',1,   25)
INSERT INTO TBALTERNATIVA (Texto, EhCorreta, QuestaoId)VALUES  ('Triângulo',0, 25)
INSERT INTO TBALTERNATIVA (Texto, EhCorreta, QuestaoId) VALUES  ('Retângulo',0, 25)


--

INSERT INTO TBQUESTAO VALUES ('Qual é a parte da planta responsável pela absorção de água e nutrientes do solo?',6,0)
INSERT INTO TBALTERNATIVA (Texto, EhCorreta, QuestaoId)VALUES  ('Folhas',0,   26)
INSERT INTO TBALTERNATIVA (Texto, EhCorreta, QuestaoId)VALUES  ('Caule',0,   26)
INSERT INTO TBALTERNATIVA (Texto, EhCorreta, QuestaoId)VALUES  ('Raiz',1,   26)
INSERT INTO TBALTERNATIVA (Texto, EhCorreta, QuestaoId)VALUES  ('Flor',0,   26)


INSERT INTO TBQUESTAO VALUES ('Quais são os produtos finais da fotossíntese?',6,0)
INSERT INTO TBALTERNATIVA(Texto, EhCorreta, QuestaoId) VALUES  ('Oxigênio e glicose',1,   27)
INSERT INTO TBALTERNATIVA(Texto, EhCorreta, QuestaoId) VALUES  ('Água e glicose',0,   27)
INSERT INTO TBALTERNATIVA(Texto, EhCorreta, QuestaoId) VALUES  ('Dióxido de carbono e água',0,   27)
INSERT INTO TBALTERNATIVA(Texto, EhCorreta, QuestaoId) VALUES  ('Oxigênio e dióxido de carbono',0,   27)


INSERT INTO TBQUESTAO VALUES ('Quais são os principais fatores necessários para o crescimento saudável das plantas?',6,0)
INSERT INTO TBALTERNATIVA(Texto, EhCorreta, QuestaoId) VALUES  ('Luz solar, água e solo fértil',1,   28)
INSERT INTO TBALTERNATIVA(Texto, EhCorreta, QuestaoId) VALUES  ('Ventos fortes, luz solar e água salgada',0,   28)
INSERT INTO TBALTERNATIVA(Texto, EhCorreta, QuestaoId) VALUES  ('Sombras, solo seco e ventilação',0,   28)
INSERT INTO TBALTERNATIVA(Texto, EhCorreta, QuestaoId) VALUES  ('Fogo, chuva ácida e solo pedregoso',0,   28)



INSERT INTO TBQUESTAO VALUES ('Como as plantas se reproduzem?',6,0)

INSERT INTO TBALTERNATIVA (Texto, EhCorreta, QuestaoId)VALUES  ('Através de sementes',0,   29)
INSERT INTO TBALTERNATIVA (Texto, EhCorreta, QuestaoId)VALUES  ('Através de ovos',0,       29)
INSERT INTO TBALTERNATIVA (Texto, EhCorreta, QuestaoId)VALUES  ('Através de esporos',1,    29)
INSERT INTO TBALTERNATIVA (Texto, EhCorreta, QuestaoId)VALUES  ('Através de filhotes',0,   29)

               

