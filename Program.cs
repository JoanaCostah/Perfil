using Projeto_SENAI_10._12;

Perfil perfil = new Perfil();
Perfil realista = new Perfil(); //OK
Perfil investigador = new Perfil();
Perfil artistico = new Perfil();
Perfil social = new Perfil();
Perfil empreendedor = new Perfil();
Perfil convencional = new Perfil();
ApresentarOpcao apresentar = new ApresentarOpcao();

Console.WriteLine("Olá!");
Console.WriteLine("Este programa é uma pesquisa de quais cursos combinam com você.");
Console.WriteLine("");
Console.WriteLine(
    "Com base nas suas respostas analizaremos o seu perfil e definimos cursos que combina com ele!"
);
Console.WriteLine("");
Console.WriteLine(
    "Possiveis perfis: Realista, Investigador, Artistico, Social, Empreendedor e Convencional."
);
Console.WriteLine("");

Console.WriteLine("Vamos iniciar");
Console.WriteLine("");
Console.WriteLine("Vamos para a primeira Pergunta");
Console.WriteLine("");

//Realista
Console.WriteLine("1. Gosto de trabalhar com ferramentas, máquinas ou objetos.");
Console.WriteLine();
apresentar.Apresentar();

Console.Write("Escolha:");
int escolhaR1 = int.Parse(Console.ReadLine());
Console.WriteLine("");

realista.Incremento(escolhaR1);

Console.WriteLine("Proxima pergunta...");
Console.WriteLine("2. Prefiro atividades práticas a discussões teóricas.");
Console.WriteLine();
apresentar.Apresentar();

Console.Write("Escolha:");
int escolhaR2 = int.Parse(Console.ReadLine());
Console.WriteLine("");

realista.Incremento(escolhaR2);

Console.WriteLine("Proxima pergunta...");
Console.WriteLine("3. Gosto de consertar, montar ou construir coisas.");
Console.WriteLine();
apresentar.Apresentar();

Console.Write("Escolha:");
int escolhaR3 = int.Parse(Console.ReadLine());
Console.WriteLine("");

realista.Incremento(escolhaR3);

Console.WriteLine("Proxima pergunta...");
Console.WriteLine("4. Prefiro ambientes organizados e tarefas manuais.");
Console.WriteLine();
apresentar.Apresentar();

Console.Write("Escolha:");
int escolhaR4 = int.Parse(Console.ReadLine());
Console.WriteLine("");

realista.Incremento(escolhaR4);

//Investigativo
Console.WriteLine("Proxima pergunta...");
Console.WriteLine("5. Gosto de resolver problemas complexos.");
Console.WriteLine();
apresentar.Apresentar();

Console.Write("Escolha:");
int escolhaI1 = int.Parse(Console.ReadLine());
Console.WriteLine("");

investigador.Incremento(escolhaI1);

Console.WriteLine("Proxima pergunta...");
Console.WriteLine("6. Tenho interesse em ciência, pesquisa ou experimentos.");
Console.WriteLine();
apresentar.Apresentar();

Console.Write("Escolha:");
int escolhaI2 = int.Parse(Console.ReadLine());
Console.WriteLine("");

investigador.Incremento(escolhaI2);

Console.WriteLine("Proxima pergunta...");
Console.WriteLine("7. Gosto de analisar informações e entender como as coisas funcionam.");
Console.WriteLine();
apresentar.Apresentar();

Console.Write("Escolha:");
int escolhaI3 = int.Parse(Console.ReadLine());
Console.WriteLine("");

investigador.Incremento(escolhaI3);

Console.WriteLine("Proxima pergunta...");
Console.WriteLine("8. Prefiro atividades que envolvam reflexão e lógica.");
Console.WriteLine();
apresentar.Apresentar();

Console.Write("Escolha:");
int escolhaI4 = int.Parse(Console.ReadLine());
Console.WriteLine("");

investigador.Incremento(escolhaI4);

//Artistico
Console.WriteLine("Proxima pergunta...");
Console.WriteLine("9. Gosto de criar, desenhar, inventar ou expressar ideias.");
Console.WriteLine();
apresentar.Apresentar();

Console.Write("Escolha:");
int escolhaA1 = int.Parse(Console.ReadLine());
Console.WriteLine("");

artistico.Incremento(escolhaA1);

Console.WriteLine("Proxima pergunta...");
Console.WriteLine("10. Prefiro atividades com liberdade e sem regras rígidas.");
Console.WriteLine();
apresentar.Apresentar();

Console.Write("Escolha:");
int escolhaA2 = int.Parse(Console.ReadLine());
Console.WriteLine("");

artistico.Incremento(escolhaA2);

Console.WriteLine("Proxima pergunta...");
Console.WriteLine("11. Gosto de música, artes visuais, escrita ou atuação.");
Console.WriteLine();
apresentar.Apresentar();

Console.Write("Escolha:");
int escolhaA3 = int.Parse(Console.ReadLine());
Console.WriteLine("");

artistico.Incremento(escolhaA3);

Console.WriteLine("Proxima pergunta...");
Console.WriteLine("12. Sou imaginativo(a) e busco formas diferentes de fazer as coisas.");
Console.WriteLine();
apresentar.Apresentar();

Console.Write("Escolha:");
int escolhaA4 = int.Parse(Console.ReadLine());
Console.WriteLine("");

artistico.Incremento(escolhaA4);

//Social
Console.WriteLine("Proxima pergunta...");
Console.WriteLine("13. Gosto de ajudar, orientar ou cuidar de pessoas.");
Console.WriteLine();
apresentar.Apresentar();

Console.Write("Escolha:");
int escolhaS1 = int.Parse(Console.ReadLine());
Console.WriteLine("");

social.Incremento(escolhaS1);

Console.WriteLine("Proxima pergunta...");
Console.WriteLine("14. Tenho facilidade para ouvir e compreender os outros.");
Console.WriteLine();
apresentar.Apresentar();

Console.Write("Escolha:");
int escolhaS2 = int.Parse(Console.ReadLine());
Console.WriteLine("");

social.Incremento(escolhaS2);

Console.WriteLine("Proxima pergunta...");
Console.WriteLine("15. Prefiro atividades que envolvem ensinar ou apoiar alguém.");
Console.WriteLine();
apresentar.Apresentar();

Console.Write("Escolha:");
int escolhaS3 = int.Parse(Console.ReadLine());
Console.WriteLine("");

social.Incremento(escolhaS3);

Console.WriteLine("Proxima pergunta...");
Console.WriteLine("16. Gosto de trabalhar em equipe e apoiar o bem-estar coletivo.");
Console.WriteLine();
apresentar.Apresentar();

Console.Write("Escolha:");
int escolhaS4 = int.Parse(Console.ReadLine());
Console.WriteLine("");

social.Incremento(escolhaS4);

//Empreendedor
Console.WriteLine("Proxima pergunta...");
Console.WriteLine("17. Gosto de liderar, convencer ou motivar pessoas.");
Console.WriteLine();
apresentar.Apresentar();

Console.Write("Escolha:");
int escolhaE1 = int.Parse(Console.ReadLine());
Console.WriteLine("");

empreendedor.Incremento(escolhaE1);

Console.WriteLine("Proxima pergunta...");
Console.WriteLine("18. Tenho iniciativa e gosto de tomar decisões.");
Console.WriteLine();
apresentar.Apresentar();

Console.Write("Escolha:");
int escolhaE2 = int.Parse(Console.ReadLine());
Console.WriteLine("");

empreendedor.Incremento(escolhaE2);

Console.WriteLine("Proxima pergunta...");
Console.WriteLine("19. Prefiro desafios que envolvam resultados e metas.");
Console.WriteLine();
apresentar.Apresentar();

Console.Write("Escolha:");
int escolhaE3 = int.Parse(Console.ReadLine());
Console.WriteLine("");

empreendedor.Incremento(escolhaE3);

Console.WriteLine("Proxima pergunta...");
Console.WriteLine("20. Gosto de criar projetos e colocar ideias em prática.");
Console.WriteLine();
apresentar.Apresentar();

Console.Write("Escolha:");
int escolhaE4 = int.Parse(Console.ReadLine());
Console.WriteLine("");

empreendedor.Incremento(escolhaE4);

//Convencional
Console.WriteLine("Proxima pergunta...");
Console.WriteLine("21. Gosto de organizar, planejar e manter tudo em ordem.");
Console.WriteLine();
apresentar.Apresentar();

Console.Write("Escolha:");
int escolhaC1 = int.Parse(Console.ReadLine());
Console.WriteLine("");

convencional.Incremento(escolhaC1);

Console.WriteLine("Proxima pergunta...");
Console.WriteLine("22. Prefiro atividades com regras claras e rotina.");
Console.WriteLine();
apresentar.Apresentar();

Console.Write("Escolha:");
int escolhaC2 = int.Parse(Console.ReadLine());
Console.WriteLine("");

convencional.Incremento(escolhaC2);

Console.WriteLine("Proxima pergunta...");
Console.WriteLine("23. Gosto de trabalhar com documentos, tabelas ou registros.");
Console.WriteLine();
apresentar.Apresentar();

Console.Write("Escolha:");
int escolhaC3 = int.Parse(Console.ReadLine());
Console.WriteLine("");

convencional.Incremento(escolhaC3);

Console.WriteLine("Proxima pergunta...");
Console.WriteLine("24. Sou detalhista e cuidadoso(a) com informações.");
Console.WriteLine();
apresentar.Apresentar();

Console.Write("Escolha:");
int escolhaC4 = int.Parse(Console.ReadLine());
Console.WriteLine("");

convencional.Incremento(escolhaC4);

int eRealista = realista.Pontuação;
int eInvestigador = investigador.Pontuação;
int eArtistico = artistico.Pontuação;
int eSocial = social.Pontuação;
int eEmpreendedor = empreendedor.Pontuação;
int eConvencional = convencional.Pontuação;

Console.WriteLine("Finalizamos as perguntas...");
Console.WriteLine();
perfil.Resultado(eRealista, eInvestigador, eArtistico, eSocial, eEmpreendedor, eConvencional);
Console.WriteLine();
Console.WriteLine("Obrigada por participar!");
