using System;

namespace Projeto_perfis
{
    public class Perfil
    {
        public int Pontuação { get; set; }

        public void Incremento(int escolha)
        {
            switch (escolha)
            {
                case 0:
                    Pontuação += 0;
                    break;

                case 1:
                    Pontuação += 1;
                    break;

                case 2:
                    Pontuação += 2;
                    break;

                case 3:
                    Pontuação += 3;
                    break;

                case 4:
                    Pontuação += 4;
                    break;

                default:
                    Console.WriteLine("Escolha não permitida tente novamente!");
                    break;
            }
        }

        public void Resultado(
            int realista,
            int investigador,
            int artistico,
            int social,
            int empreendedor,
            int convencional
        )
        {
            int[] pontuação =
            {
                realista,
                investigador,
                artistico,
                social,
                empreendedor,
                convencional,
            };
            string[] perfis =
            {
                "Realista",
                "Investigador",
                "Artistico",
                "Social",
                "Empreendedor",
                "Convencional",
            };

            int maior = 0;
            string perfil = "";

            for (int i = 0; i < pontuação.Length; i++)
            {
                if (maior < pontuação[i])
                {
                    maior = pontuação[i];
                    perfil = perfis[i];
                }
            }

            for (int i = 0; i < pontuação.Length; i++)
            {
                if (maior == pontuação[i])
                {
                    perfil = perfis[i];
                    Console.WriteLine("");
                    Console.WriteLine($"Você se encaixa no(s) perfil(s): {perfis[i]} com {maior} pontos.");
                    

                    if (perfil == "Realista")
                    {
                        Console.WriteLine(
                            "Com base no seu perfil os seus cursos podem ser: Mecânica, Automação, Usinagem, Eletricidade, Plastico, Costura."
                        );
                    }
                    else if (perfil == "Investigador")
                    {
                        Console.WriteLine(
                            "Com base no seu perfil os seus cursos podem ser: Tecnologia da Informação, Eletroeletrônica, Manutenção, Plastico. "
                        );
                    }
                    else if (perfil == "Artistico")
                    {
                        Console.WriteLine(
                            "Com base no seu perfil os seus cursos podem ser: Design de Produto, Impressão 3D, Comunicação Visual, Costura."
                        );
                    }
                    else if (perfil == "Social")
                    {
                        Console.WriteLine(
                            "Com base no seu perfil os seus cursos podem ser: Segurança do Trabalho, Educação, Saúde Ocupacional."
                        );
                    }
                    else if (perfil == "Empreendedor")
                    {
                        Console.WriteLine(
                            "Com base no seu perfil os seus cursos podem ser: Gestão, Vendas Técnicas, Logística."
                        );
                    }
                    else if (perfil == "Convencional")
                    {
                        Console.WriteLine(
                            "Com base no seu perfil os seus cursos podem ser: Administração, Controle de Qualidade, Planejamento."
                        );
                    }
                }
            }

            Console.WriteLine();

            Console.WriteLine("Seus pontos nos perfis foi:");
            for (int i = 0; i < pontuação.Length; i++)
            {
                Console.WriteLine($"Perfil: {perfis[i]} - Pontuação = {pontuação[i]}");
            }
        }
    }
}